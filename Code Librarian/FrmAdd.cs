/**
 * This file is part of Code Librarian <https://github.com/StevenJDH/Code-Librarian>.
 * Copyright (C) 2019 Steven Jenkins De Haro.
 *
 * Code Librarian is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Code Librarian is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Code Librarian.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Librarian.Classes;
using Code_Librarian.Extensions;
using Code_Librarian.Models;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmAdd : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FrmAdd(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _unitOfWork.WorkCompleted += UnitOfWork_Completed;
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            ReloadAuthors();
            ReloadLanguages();

            this.MdiParent.Text = $"{Application.ProductName} - [New Snippet Record]";
            txtDateCreated.Text = DateTime.Now.ToShortDateString();
            txtDateUpdated.Text = txtDateCreated.Text;
            txtVersion.Text = "1.0.0";
        }

        /// <summary>
        /// Reloads the available authors for the snippet record.
        /// </summary>
        private void ReloadAuthors()
        {
            cmbAuthor.Items.Clear();

            _unitOfWork.Authors.GetAll()
                .Select(a => a.Name)
                .ToList()
                .ForEach(a => cmbAuthor.Items.Add(a));
        }

        /// <summary>
        /// Reloads the available language categories for the snippet record.
        /// </summary>
        private void ReloadLanguages()
        {
            cmbLanguage.Items.Clear();

            _unitOfWork.Languages.GetAll()
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguage.Items.Add(l));
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            this.MdiParent.Text = String.IsNullOrWhiteSpace(txtTitle.Text) ? 
                $"{Application.ProductName} - [New Snippet Record]" : 
                $"{Application.ProductName} - [{txtTitle.Text.RemoveExcessWhiteSpace()}]";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Version.TryParse(txtVersion.Text.Trim(), out var versionNumber) == false)
            {
                MessageBox.Show($"The version number '{txtVersion.Text.Trim()}' is not using '#.#.#' as the format.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to add this snippet to the library?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            var newSnippet = new Snippet()
            {
                AuthorId = _unitOfWork.Authors
                               .FirstOrDefault(a => a.Name == cmbAuthor.Text)?
                               .AuthorId ?? -1,
                Title = txtTitle.Text.RemoveExcessWhiteSpace(),
                DateCreated = DateTime.Parse(txtDateCreated.Text, cultureInfo),
                DateUpdated = DateTime.Parse(txtDateUpdated.Text, cultureInfo),
                Version = versionNumber.ToString(),
                LanguageId = _unitOfWork.Languages
                                .FirstOrDefault(l => l.Name == cmbLanguage.Text)?
                                .LanguageId ?? -1,
                Purpose = txtPurpose.Text.Trim(),
                Keywords = txtKeywords.Text.RemoveExcessWhiteSpace(),
                CodeSnippet = txtCode.Text.Trim()
            };

            _unitOfWork.Snippets.Add(newSnippet);

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The snippet record has been added successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (DbUpdateException)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show("Error: Could not apply changes due to a constraint rule violation.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EntityValidationException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the entered information?", 
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cmbAuthor.SelectedIndex = -1;
            txtTitle.Text = "";
            txtDateCreated.Text = DateTime.Now.ToShortDateString();
            txtDateUpdated.Text = txtDateCreated.Text;
            txtVersion.Text = "1.0.0";
            cmbLanguage.SelectedIndex = -1;
            txtPurpose.Text = "";
            txtKeywords.Text = "";
            txtCode.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthor.Text == "")
            {
                txtPhoneEmail.Text = "";
                return;
            }

            txtPhoneEmail.Text = _unitOfWork.Authors
                .FirstOrDefault(a => a.Name == cmbAuthor.Text)
                .ContactInfo;
        }

        private void TxtPhoneEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPhoneEmail.Text))
            {
                lblPhoneEmail.Text = "Phone Number/Email";
                return;
            }

            lblPhoneEmail.Text = txtPhoneEmail.Text.Contains('@') ? "Email" : "Phone Number";
        }

        private void TxtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void UnitOfWork_Completed(object sender, WorkCompletedEventArgs e)
        {
            if (e.EntitiesChanged.Contains(Entity.Author))
            {
                var bookmark = cmbAuthor.Text;

                ReloadAuthors();

                if (cmbAuthor.Items.Contains(bookmark))
                {
                    cmbAuthor.Text = bookmark;
                }
            }

            if (e.EntitiesChanged.Contains(Entity.Language))
            {
                var bookmark = cmbLanguage.Text;

                ReloadLanguages();

                if (cmbLanguage.Items.Contains(bookmark))
                {
                    cmbLanguage.Text = bookmark;
                }
            }
        }

        private void FrmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork.WorkCompleted -= UnitOfWork_Completed;
            this.MdiParent.Text = Application.ProductName;
        }
    }
}

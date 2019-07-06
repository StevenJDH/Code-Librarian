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
    public partial class FrmEdit : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _selectedTitle;
        private readonly string _selectedLanguage;
        private Snippet _snippetRecord;

        public FrmEdit(IUnitOfWork unitOfWork, string snippetTitle, string language)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _selectedTitle = snippetTitle;
            _selectedLanguage = language;
            _snippetRecord = null;
            _unitOfWork.WorkCompleted += UnitOfWork_Completed;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            ReloadAuthors();
            ReloadLanguages();
            LoadSnippetRecord();
            this.MdiParent.Text = $"{Application.ProductName} - [{_selectedTitle }]";
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

        /// <summary>
        /// Loads the snippet record from the database into view.
        /// </summary>
        private void LoadSnippetRecord()
        {
            _snippetRecord = _unitOfWork.Snippets.GetSnippetsWithAll()
                .FirstOrDefault(s => s.Title == _selectedTitle && s.Language.Name == _selectedLanguage);

            if (_snippetRecord == null)
            {
                MessageBox.Show($"Error: The snippet record '{_selectedTitle}' was not found.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Has to be closed like this to avoid a handle not created yet error in form's load event.
                this.BeginInvoke(new MethodInvoker(Close));
            }

            cmbAuthor.Text = _snippetRecord.Author.Name;
            txtTitle.Text = _snippetRecord.Title;
            txtDateCreated.Text = _snippetRecord.DateCreated.ToShortDateString();
            txtDateUpdated.Text = _snippetRecord.DateUpdated.ToShortDateString();
            txtVersion.Text = _snippetRecord.Version;
            cmbLanguage.Text = _snippetRecord.Language.Name;
            txtPurpose.Text = _snippetRecord.Purpose;
            txtKeywords.Text = _snippetRecord.Keywords;
            txtCode.Text = _snippetRecord.CodeSnippet;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Version.TryParse(txtVersion.Text.Trim(), out var versionNumber) == false)
            {
                MessageBox.Show($"The version number '{txtVersion.Text.Trim()}' is not using '#.#.#' as the format.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this record in the library?", 
                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _snippetRecord.AuthorId = _unitOfWork.Authors
                                          .FirstOrDefault(a => a.Name == cmbAuthor.Text)?
                                          .AuthorId ?? -1;
            _snippetRecord.Title = txtTitle.Text.RemoveExcessWhiteSpace();
            _snippetRecord.DateUpdated = DateTime.Parse(txtDateUpdated.Text, Thread.CurrentThread.CurrentCulture);
            _snippetRecord.Version = versionNumber.ToString();
            _snippetRecord.LanguageId = _unitOfWork.Languages
                                            .FirstOrDefault(l => l.Name == cmbLanguage.Text)?
                                            .LanguageId ?? -1;
            _snippetRecord.Purpose = txtPurpose.Text.Trim();
            _snippetRecord.Keywords = txtKeywords.Text.RemoveExcessWhiteSpace();
            _snippetRecord.CodeSnippet = txtCode.Text.Trim();

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The record has been updated successfully.",
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

        private void BtnRevert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to undo all changes?.",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            LoadSnippetRecord();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthor.Text == "")
            {
                txtPhone.Text = "";
                return;
            }

            txtPhone.Text = _unitOfWork.Authors
                .FirstOrDefault(a => a.Name == cmbAuthor.Text)
                .PhoneNumber;
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

        private void FrmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork.WorkCompleted -= UnitOfWork_Completed;
            this.MdiParent.Text = Application.ProductName;
        }
    }
}

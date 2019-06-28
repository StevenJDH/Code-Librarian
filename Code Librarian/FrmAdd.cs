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
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            _unitOfWork.Authors.GetAll()
                .Select(a => a.Name)
                .ToList()
                .ForEach(a => cmbAuthor.Items.Add(a));

            _unitOfWork.Languages.GetAll()
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguage.Items.Add(l));

            txtDateCreated.Text = DateTime.Now.ToShortDateString();
            txtDateUpdated.Text = txtDateCreated.Text;
            txtVersion.Text = "1.0.0";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            var newSnippet = new Snippet()
            {
                AuthorId = _unitOfWork.Authors
                    .FirstOrDefault(a => a.Name == cmbAuthor.Text)?
                    .AuthorId ?? -1,
                Title = txtTitle.Text.Trim(),
                DateCreated = DateTime.Parse(txtDateCreated.Text, cultureInfo),
                DateUpdated = DateTime.Parse(txtDateUpdated.Text, cultureInfo),
                Version = txtVersion.Text.Trim(),
                LanguageId = _unitOfWork.Languages
                    .FirstOrDefault(l => l.Name == cmbLanguage.Text)?
                    .LanguageId ?? -1,
                Purpose = txtPurpose.Text.Trim(),
                Keywords = txtKeywords.Text.Trim(),
                CodeSnippet = txtCode.Text.Trim()
            };

            _unitOfWork.Snippets.Add(newSnippet);

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The record has been added successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Trigger a refresh on the parent form with an event maybe.
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
            txtPhone.Text = "";
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

        private void CmbAuthor_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbAuthor.Text == "")
            {
                return;
            }

            txtPhone.Text = _unitOfWork.Authors
                .FirstOrDefault(a => a.Name == cmbAuthor.Text)
                .PhoneNumber;
        }

        private void CmbAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            // Prevents mouse scrolling via mouse wheel and arrow keys.
            e.Handled = true;
        }
    }
}

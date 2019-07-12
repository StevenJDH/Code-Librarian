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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Librarian.Classes;
using Code_Librarian.Extensions;
using Code_Librarian.Models;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmManageAuthors : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FrmManageAuthors(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        private void FrmManageAuthors_Load(object sender, EventArgs e)
        {
             _unitOfWork.Authors.GetAll()
                .ToList()
                .ForEach(a => lstViewAuthors.Items.Add(new ListViewItem(new[] { a.Name, a.ContactInfo })));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtPhoneEmail.Text.Contains('@') && IsEmailAddressValid(txtPhoneEmail.Text) == false)
            {
                MessageBox.Show("The author's email address is invalid.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (MessageBox.Show("Are you sure you want to add this author?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var author = new Author()
            {
                Name = txtName.Text.RemoveExcessWhiteSpace(),
                ContactInfo = txtPhoneEmail.Text.RemoveExcessWhiteSpace()
            };

            _unitOfWork.Authors.Add(author);

            try
            {
                _unitOfWork.Complete();
                var newEntry = lstViewAuthors.Items.Add(new ListViewItem(new[] {author.Name, author.ContactInfo}));
                newEntry.Selected = true;

                MessageBox.Show("The author has been added successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show("Error: Could not apply changes due to a constraint rule violation.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPhoneEmail.Text.Contains('@') && IsEmailAddressValid(txtPhoneEmail.Text) == false)
            {
                MessageBox.Show("The author's email address is invalid.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (MessageBox.Show("Are you sure you want to update this author?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var name = lstViewAuthors.SelectedItems[0].SubItems[clmName.Index];
            var author = _unitOfWork.Authors.FirstOrDefault(a => a.Name == name.Text);

            author.Name = txtName.Text.RemoveExcessWhiteSpace();
            author.ContactInfo = txtPhoneEmail.Text.RemoveExcessWhiteSpace();

            try
            {
                _unitOfWork.Complete();
                lstViewAuthors.SelectedItems[0].Remove();
                var newEntry = lstViewAuthors.Items.Add(new ListViewItem(new[] { author.Name, author.ContactInfo }));
                newEntry.Selected = true;

                MessageBox.Show("The author has been updated successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show("Error: Could not apply changes due to a constraint rule violation.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var name = lstViewAuthors.SelectedItems[0].SubItems[clmName.Index];
            var author = _unitOfWork.Authors.FirstOrDefault(a => a.Name == name.Text);
            var useCount = author.Snippets.Count;

            if (useCount > 0)
            {
                MessageBox.Show($"This author has {useCount} {(useCount == 1 ? "record" : "records")} assigned to it and cannot be deleted. Try renaming it instead.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this author? Don't worry, there are no records assigned to it.",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _unitOfWork.Authors.Remove(author);

            try
            {
                _unitOfWork.Complete();
                lstViewAuthors.SelectedItems[0].Remove();
                txtName.Text = "";
                txtPhoneEmail.Text = "";

                MessageBox.Show("The author has been deleted successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show("Error: Could not apply changes due to a constraint rule violation.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstViewAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewAuthors.SelectedItems.Count == 0)
            {
                return;
            }

            txtName.Text = lstViewAuthors.SelectedItems[0].SubItems[clmName.Index].Text;
            txtPhoneEmail.Text = lstViewAuthors.SelectedItems[0].SubItems[clmPhoneEmail.Index].Text;
            ValidateControls();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void TxtPhoneEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void ValidateControls()
        {
            bool state = (String.IsNullOrWhiteSpace(txtName.Text) == false &&
                          String.IsNullOrWhiteSpace(txtPhoneEmail.Text) == false);

            btnAdd.Enabled = 
                (state && 
                 lstViewAuthors.Items.ContainsEx(txtName.Text.RemoveExcessWhiteSpace()) == false);
            btnUpdate.Enabled = 
                (state && 
                 lstViewAuthors.SelectedItems.Count > 0 && 
                 lstViewAuthors.Items.ContainsEx(txtName.Text.RemoveExcessWhiteSpace()) == false ||
                 lstViewAuthors.SelectedItems[0].SubItems[clmPhoneEmail.Index].Text != 
                    txtPhoneEmail.Text.RemoveExcessWhiteSpace());
            btnDelete.Enabled = (lstViewAuthors.SelectedItems.Count > 0);
        }

        /// <summary>
        /// Validates an email address to ensure it is in the correct format as best as possible.
        /// </summary>
        /// <remarks>
        /// Both the MailAddress class and the EmailAddressAttribute class do not properly validate,
        /// so Regex is needed with a pattern that approximates to RFC correctness.
        /// </remarks>
        /// <param name="email">Email address to validate.</param>
        /// <returns>True if email address is valid, or false if not.</returns>
        private bool IsEmailAddressValid(string email)
        {
            const string pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

            return Regex.IsMatch(email, pattern, 
                RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
        }
    }
}

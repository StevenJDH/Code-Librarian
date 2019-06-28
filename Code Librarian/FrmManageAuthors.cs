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
using System.Threading.Tasks;
using System.Windows.Forms;
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
                .ForEach(a => lstViewAuthors.Items.Add(new ListViewItem(new[] { a.Name, a.PhoneNumber })));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                return;
            }

            if (lstViewAuthors.Items.ContainsEx(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Author already exists, and therefore, cannot be added again.",
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
                Name = txtName.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim()
            };

            _unitOfWork.Authors.Add(author);

            try
            {
                _unitOfWork.Complete();
                var newEntry = lstViewAuthors.Items.Add(new ListViewItem(new[] {author.Name, author.PhoneNumber}));
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
            if (lstViewAuthors.SelectedItems.Count == 0 || txtName.Text == "" || txtPhone.Text == "")
            {
                return;
            }

            if (lstViewAuthors.Items.ContainsEx(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Author already exists, and therefore, cannot be updated to this.",
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

            author.Name = txtName.Text.Trim();
            author.PhoneNumber = txtPhone.Text.Trim();

            try
            {
                _unitOfWork.Complete();
                lstViewAuthors.SelectedItems[0].Remove();
                var newEntry = lstViewAuthors.Items.Add(new ListViewItem(new[] { author.Name, author.PhoneNumber }));
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
            if (lstViewAuthors.SelectedItems.Count == 0)
            {
                return;
            }

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
                txtPhone.Text = "";

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
            // TODO: Trigger a refresh on the parent form with an event maybe by raising from closing.
            this.Close();
        }

        private void LstViewAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewAuthors.SelectedItems.Count == 0)
            {
                return;
            }

            txtName.Text = lstViewAuthors.SelectedItems[0].SubItems[clmName.Index].Text;
            txtPhone.Text = lstViewAuthors.SelectedItems[0].SubItems[clmPhone.Index].Text;
        }
    }
}

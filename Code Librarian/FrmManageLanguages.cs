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
    public partial class FrmManageLanguages : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private const string ReservedWordSelectLanguage = "--- Select Language ---";

        public FrmManageLanguages(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        private void FrmManageLanguages_Load(object sender, EventArgs e)
        {
            _unitOfWork.Languages.GetAll()
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => lstLanguages.Items.Add(l));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text == "")
            {
                return;
            }

            if (txtLanguage.Text.Trim().ToUpper() == ReservedWordSelectLanguage.ToUpper())
            {
                MessageBox.Show("You cannot add this since it is a reserved lebel for filtering.", 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lstLanguages.Items.ContainsEx(txtLanguage.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Language already exists, and therefore, cannot be added again.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to add this language?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var language = new Language()
            {
                Name = txtLanguage.Text.Trim()
            };

            _unitOfWork.Languages.Add(language);

            try
            {
                _unitOfWork.Complete();
                lstLanguages.Items.Add(language.Name);
                lstLanguages.Text = language.Name;

                MessageBox.Show("The language has been added successfully.",
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
            if (lstLanguages.Text == "" || txtLanguage.Text == "")
            {
                return;
            }

            if (txtLanguage.Text.Trim().ToUpper() == ReservedWordSelectLanguage.ToUpper())
            {
                MessageBox.Show("You cannot update with this since it is a reserved label for filtering.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lstLanguages.Items.ContainsEx(txtLanguage.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Language already exists, and therefore, cannot be updated to this.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this language?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var language = _unitOfWork.Languages
                .FirstOrDefault(l => l.Name == lstLanguages.Text);

            language.Name = txtLanguage.Text.Trim();

            try
            {
                _unitOfWork.Complete();
                lstLanguages.Items.Remove(lstLanguages.Text.Trim());
                lstLanguages.Items.Add(language.Name);
                lstLanguages.Text = language.Name;

                MessageBox.Show("The language has been updated successfully.",
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
            if (lstLanguages.Text == "")
            {
                return;
            }

            var language = _unitOfWork.Languages
                .FirstOrDefault(l => l.Name == lstLanguages.Text);
            var useCount = language.Snippets.Count;

            if (useCount > 0)
            {
                MessageBox.Show($"This language has {useCount} {(useCount == 1 ? "record" : "records")} assigned to it and cannot be deleted. Try renaming it instead.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;   
            }

            if (MessageBox.Show("Are you sure you want to delete this language? Don't worry, there are no records assigned to it.",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _unitOfWork.Languages.Remove(language);

            try
            {
                _unitOfWork.Complete();
                lstLanguages.Items.Remove(lstLanguages.Text);
                txtLanguage.Text = "";

                MessageBox.Show("The language has been deleted successfully.",
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

        private void LstLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLanguage.Text = lstLanguages.Text;
            ValidateControls();
        }

        private void TxtLanguage_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void ValidateControls()
        {
            bool state = (String.IsNullOrWhiteSpace(txtLanguage.Text) == false && 
                          lstLanguages.Items.ContainsEx(txtLanguage.Text.Trim()) == false);

            btnAdd.Enabled = state;
            btnUpdate.Enabled = (state && lstLanguages.Text != "");
            btnDelete.Enabled = (lstLanguages.Text != "");
        }
    }
}

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

        private void FrmEditLang_Load(object sender, EventArgs e)
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

            if (lstLanguages.Items.ContainsEx(txtLanguage.Text, StringComparison.OrdinalIgnoreCase))
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
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}",
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
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstLanguages.Text == "")
            {
                return;
            }

            var useCount = _unitOfWork.Snippets
                .GetSnippetsWithAll()
                .Count(s => s.Language.Name == lstLanguages.Text);

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

            var language = _unitOfWork.Languages
                .FirstOrDefault(l => l.Name == lstLanguages.Text);

            _unitOfWork.Languages.Remove(language);

            try
            {
                _unitOfWork.Complete();
                lstLanguages.Items.Remove(lstLanguages.Text);
                txtLanguage.Text = "";

                MessageBox.Show("The language has been deleted successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}", 
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
        }
    }
}

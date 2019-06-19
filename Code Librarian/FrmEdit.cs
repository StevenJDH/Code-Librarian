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
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            LoadSnippetRecord();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRevert_Click(object sender, EventArgs e)
        {
            cmbAuthor.Items.Clear();
            cmbLanguage.Items.Clear();
            LoadSnippetRecord();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this record in the library?", 
                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _snippetRecord.AuthorId = _unitOfWork.Authors
                .FirstOrDefault(a => a.Name == cmbAuthor.Text)
                .AuthorId;
            _snippetRecord.Title = txtTitle.Text.Trim();
            _snippetRecord.DateUpdated = DateTime.Parse(txtDateUpdated.Text, Thread.CurrentThread.CurrentCulture);
            _snippetRecord.Version = txtVersion.Text.Trim();
            _snippetRecord.LanguageId = _unitOfWork.Languages
                .FirstOrDefault(l => l.Name == cmbLanguage.Text)
                .LanguageId;
            _snippetRecord.Purpose = txtPurpose.Text.Trim();
            _snippetRecord.Keywords = txtKeywords.Text.Trim();
            _snippetRecord.CodeSnippet = txtCode.Text.Trim();

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The record has been updated successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Trigger a refresh on the parent form with an event maybe.
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSnippetRecord()
        {
            _snippetRecord = _unitOfWork.Snippets.GetSnippetsWithAll()
                .FirstOrDefault(s => s.Title == _selectedTitle && s.Language.Name == _selectedLanguage);

            if (_snippetRecord == null)
            {
                throw new InvalidOperationException($"The snippet record '{_selectedTitle}' was not found.");
            }

            _unitOfWork.Authors.GetAll()
                .Select(a => a.Name)
                .ToList()
                .ForEach(a => cmbAuthor.Items.Add(a));
            cmbAuthor.Text = _snippetRecord.Author.Name;
            txtPhone.Text = _snippetRecord.Author.PhoneNumber;
            txtTitle.Text = _snippetRecord.Title;
            txtDateCreated.Text = _snippetRecord.DateCreated.ToShortDateString();
            txtDateUpdated.Text = _snippetRecord.DateUpdated.ToShortDateString();
            txtVersion.Text = _snippetRecord.Version;
            _unitOfWork.Languages.GetAll()
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguage.Items.Add(l));
            cmbLanguage.Text = _snippetRecord.Language.Name;
            txtPurpose.Text = _snippetRecord.Purpose;
            txtKeywords.Text = _snippetRecord.Keywords;
            txtCode.Text = _snippetRecord.CodeSnippet;
        }

        private void CmbAuthor_DropDownClosed(object sender, EventArgs e)
        {
            // Using the DropDownClosed event to avoid form's Load event raising the SelectedIndexChanged
            // event when setting cmbAuthor's index.

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

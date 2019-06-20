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
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}",
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

            var row = lstViewAuthors.SelectedIndices[0];
            var name = lstViewAuthors.SelectedItems[row].SubItems[clmName.Index];
            var author = _unitOfWork.Authors.FirstOrDefault(a => a.Name == name.Text);

            author.Name = txtName.Text.Trim();
            author.PhoneNumber = txtPhone.Text.Trim();

            try
            {
                _unitOfWork.Complete();
                lstViewAuthors.SelectedItems[row].Remove();
                var newEntry = lstViewAuthors.Items.Add(new ListViewItem(new[] { author.Name, author.PhoneNumber }));
                newEntry.Selected = true;

                MessageBox.Show("The author has been updated successfully.",
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
            if (lstViewAuthors.SelectedItems.Count == 0)
            {
                return;
            }

            var row = lstViewAuthors.SelectedIndices[0];
            var name = lstViewAuthors.SelectedItems[row].SubItems[clmName.Index];
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
                lstViewAuthors.SelectedItems[row].Remove();
                txtName.Text = "";
                txtPhone.Text = "";

                MessageBox.Show("The author has been deleted successfully.",
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

        private void LstViewAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewAuthors.SelectedItems.Count == 0)
            {
                return;
            }

            var row = lstViewAuthors.SelectedIndices[0];

            txtName.Text = lstViewAuthors.SelectedItems[row].SubItems[clmName.Index].Text;
            txtPhone.Text = lstViewAuthors.SelectedItems[row].SubItems[clmPhone.Index].Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Librarian.Models;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmMain : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private const int WS_EX_COMPOSITED = 0x02000000;

        public FrmMain()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new AppDbContext());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Alpha_Background;
            TmrDateTime_Tick(this, EventArgs.Empty);
            int count = _unitOfWork.Snippets.GetAll().Count();
            toolStripInfo.Text = $"There are currently {count} snippet {(count == 1 ? "record" : "records")} in the database.";

            cmbLanguageFilter.Items.Add("--- Select Language ---");

            _unitOfWork.Languages.GetAll()
                .OrderBy(l => l.Name)
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguageFilter.Items.Add(l));

            // Triggers the CmbLanguageFilter_SelectedIndexChanged event to load the list.
            cmbLanguageFilter.SelectedIndex = 0;
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            toolStripTime.Text = DateTime.Now.ToLongTimeString();
            toolStripDate.Text = DateTime.Now.ToShortDateString();
        }

        private void CmbLanguageFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        /// <summary>
        /// Filters the snippet list based on the selected language chosen.
        /// </summary>
        private void FilterList()
        {
            lstSnippets.Items.Clear();

            if (cmbLanguageFilter.Text == "--- Select Language ---")
            {
                return;
            }

            _unitOfWork.Snippets.GetSnippetsWithAll()
                .Where(s => s.Language.Name == cmbLanguageFilter.Text)
                .Select(s => s.Title)
                .ToList()
                .ForEach(t => lstSnippets.Items.Add(t));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            ShowChildWindow(new FrmView(_unitOfWork, lstSnippets.Text, cmbLanguageFilter.Text));
        }

        private void ShowChildWindow(Form mdiChild)
        {
            mdiChild.MdiParent = this;
            mdiChild.Dock = DockStyle.Fill;
            mdiChild.Show();
        }

        /// <summary>
        /// Fixes MDI child flickering when a form is displayed. This method essentially
        /// sets DoubledBuffered at the form level rather than at the control level.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;

                return cp;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork?.Dispose();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            ShowChildWindow(new FrmEdit(_unitOfWork, lstSnippets.Text, cmbLanguageFilter.Text));
        }

        private void MnuDeleteRecord_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected record from the library?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var snippetRecord = _unitOfWork.Snippets
                .FirstOrDefault(s => s.Title == lstSnippets.Text && 
                                     s.Language.Name == cmbLanguageFilter.Text);
            _unitOfWork.Snippets.Remove(snippetRecord);

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The record has been deleted successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstSnippets.Items.Remove(lstSnippets.Text);
            }
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}", 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripDeleteRecord_Click(object sender, EventArgs e)
        {
            MnuDeleteRecord_Click(this, EventArgs.Empty);
        }

        private void MnuAddNewRecord_Click(object sender, EventArgs e)
        {
            ShowChildWindow(new FrmAdd(_unitOfWork));
        }

        private void ToolStripAddNewRecord_Click(object sender, EventArgs e)
        {
            MnuAddNewRecord_Click(this, EventArgs.Empty);
        }

        private void LstSnippets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnView_Click(this, EventArgs.Empty);
            }
        }

        private void MnuDonate_Click(object sender, EventArgs e)
        {
            try
            {
                // Sends URL to the operating system for opening.
                Process.Start("https://www.paypal.me/stevenjdh/5");
            }
            catch (Exception)
            {
                // Consuming exceptions
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripAbout_Click(object sender, EventArgs e)
        {
            MnuAbout_Click(this, EventArgs.Empty);
        }
    }
}

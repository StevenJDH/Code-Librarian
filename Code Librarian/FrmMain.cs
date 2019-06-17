using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            cmbLanguageFilter.Items.Add("All Languages");

            var languages = _unitOfWork.Languages.GetAll()
                .OrderBy(l => l.Name)
                .Select(l => l.Name)
                .ToList();
            foreach (var language in languages)
            {
                cmbLanguageFilter.Items.Add(language);
            }

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

            if (cmbLanguageFilter.Text == "All Languages")
            {
                _unitOfWork.Snippets.GetAll()
                    .Select(s => s.Title)
                    .ToList()
                    .ForEach(t => lstSnippets.Items.Add(t));
            }
            else
            {
                _unitOfWork.Snippets.GetSnippetsWithAll()
                    .Where(s => s.Language.Name == cmbLanguageFilter.Text)
                    .Select(s => s.Title)
                    .ToList()
                    .ForEach(t => lstSnippets.Items.Add(t));
            }
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

            ShowChildWindow(new FrmView());
        }

        private void ShowChildWindow(Form mdiChild)
        {
            mdiChild.MdiParent = this;
            mdiChild.Dock = DockStyle.Fill;
            mdiChild.Show();
        }
    }
}

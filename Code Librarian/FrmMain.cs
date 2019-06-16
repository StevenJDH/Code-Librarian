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
    }
}

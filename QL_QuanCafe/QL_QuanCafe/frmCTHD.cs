using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCafe
{
    public partial class frmCTHD : Form
    {
        frmDanhSachBan ds = new frmDanhSachBan();
        string ma;
        public frmCTHD(string ma)
        {
            this.ma = ma;
            InitializeComponent();
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            txtMaCTHD.Text = ma;
        }
    }
}

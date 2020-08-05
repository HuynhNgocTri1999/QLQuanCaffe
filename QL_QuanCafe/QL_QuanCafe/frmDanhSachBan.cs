using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace QL_QuanCafe
{
    public partial class frmDanhSachBan : Form
    {
        Ban b = new Ban();
        public frmDanhSachBan()
        {
            InitializeComponent();
        }
        private void frmDanhSachBan_Load(object sender, EventArgs e)
        {
            LoadDanhMucBan();
        }
        private void LoadDanhMucBan()
        {
            int width = 130;
            int height = 100;
            foreach(var item in b.getDSBan())
            {
                Button btnDM = new Button();
                btnDM.Width = width;
                btnDM.Height = height;
                btnDM.Text = item.TENBAN;
                btnDM.Cursor = Cursors.Hand;
                btnDM.Dock = DockStyle.Top;
                btnDM.TextAlign = ContentAlignment.BottomCenter;
                btnDM.BackgroundImage = Properties.Resources.table_64px;
                btnDM.BackgroundImageLayout = ImageLayout.Center;
                btnDM.Tag = item;

                pnlDMBan.Controls.Add(btnDM);
                if (item.TRANGTHAI == "TRỐNG")
                {
                    btnDM.BackColor = Color.LightSlateGray;
                }
                else
                {
                    btnDM.BackColor = Color.Red;
                }
                btnDM.Click +=btnDM_Click;

            }
        }
        public void ShowBill(string id)
        {
        }
        private void btnDM_Click(object sender, EventArgs e)
        {
            Button btnDM = sender as Button;
            string tableID = ((sender as Button).Tag as BAN).MABAN;
            ShowBill(tableID);
            string ma = "abc";
            frmCTHD frm = new frmCTHD(tableID);
            frm.Show();
            //LoadDanhMucBan(Convert.ToInt32(btnDM.Tag));
        }
    }
}

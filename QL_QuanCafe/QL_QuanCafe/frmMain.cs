using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_QuanCafe
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form KiemTraTonTai(Type ptype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ptype)
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDanhSachBan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachBan f = new frmDanhSachBan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
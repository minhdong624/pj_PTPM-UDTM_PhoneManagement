using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace PhoneManagement
{
    public partial class frmDangKiKhachHang : Form
    {
        QuanLiKhachHang_BUS ql = new QuanLiKhachHang_BUS();
        frmMain f;
        public frmDangKiKhachHang(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void panelControl1_SizeChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32((this.ClientSize.Width / 2) - (groupNhapThongTin.Width / 2));
            int y = Convert.ToInt32((this.ClientSize.Height / 2) - (groupNhapThongTin.Height / 2));
            groupNhapThongTin.Location = new Point(x, y);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            var a = ql.ThemKhachHang(txtTenKhachHang.Text, txtSoDienThoai.Text, txtEmail.Text, txtDiaChi.Text, txtCMND.Text);
            XtraMessageBox.Show(a);
        }
    }
}

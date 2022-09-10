using DevExpress.XtraEditors;
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

namespace PhoneManagement
{
    public partial class frmLogin : Form
    {
        DangNhap_BUS dn = new DangNhap_BUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");//Set skin mặc định Devexpress
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain f = new frmMain();
            f.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                if (dn.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
                {
                    this.Close();
                    frmMain.Show();
                }
                else
                {
                    XtraMessageBox.Show("Đăng nhập thất bại vui lòng kiểm tra tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng không bỏ trống!");
            }
        }
    }
}

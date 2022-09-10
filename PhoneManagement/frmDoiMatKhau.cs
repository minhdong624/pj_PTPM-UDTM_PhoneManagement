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
    public partial class frmDoiMatKhau : Form
    {
        frmMain f;
        DoiMatKhau_BUS dmk = new DoiMatKhau_BUS();
        public frmDoiMatKhau(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_SizeChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32((this.ClientSize.Width / 2) - (groupNhapThongTin.Width / 2));
            int y = Convert.ToInt32((this.ClientSize.Height / 2) - (groupNhapThongTin.Height / 2));
            groupNhapThongTin.Location = new Point(x, y);
        }

        private void groupNhapThongTin_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
                if (txtMatKhauCu.Text != "" && txtMatKhauMoi.Text != "" && txtNhapLaiMatkhau.Text != "")
                {
                    if ((txtMatKhauMoi.Text).Equals(txtNhapLaiMatkhau.Text))
                    {
                        if (dmk.KiemTraMatKhau(Convert.ToInt32(SessionLogin_BUS.idUser), txtMatKhauCu.Text) == true)
                        {
                            dmk.DoiMatKhau(Convert.ToInt32(SessionLogin_BUS.idUser), txtMatKhauMoi.Text);
                            XtraMessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Mật khẩu cũ không đúng");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu mới không trùng với mật khẩu nhập lại.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được bỏ trống");
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace PhoneManagement
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");//Set skin mặc định Devexpress

            if (SessionLogin_BUS.idUser == null)
            {
                headerTTDangNhap.Caption = "Bạn chưa đăng nhập?";
                headerRoleName.Caption = "";
                NoLogin();
            }
            else
            {
                headerTTDangNhap.Caption = "Chào mừng: " + SessionLogin_BUS.taiKhoan;
                headerRoleName.Caption = "Quyền: " + SessionLogin_BUS.roleName;
                if (SessionLogin_BUS.idRoles == 1)
                {
                    LoginedQuyenQuanLi();
                }
                else
                {
                    LoginedQuyenNhanVien();
                }
            }
        }
        private bool existForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void btnQuanLiNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiNguoiDung(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        public void LoginedQuyenQuanLi()
        {
            btnDangNhap.Enabled = false;
            btnThoat.Enabled = true;
            btnQuanLiNguoiDung.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            btnBanDienThoai.Enabled = true;
            btnQuanLiSanPham.Enabled = true;
            btnQuanLiKhachHang.Enabled = true;
            btnLoaiDienThoai.Enabled = true;
            btnHangDienThoai.Enabled = true;
            btnQuanLiHoaDon.Enabled = true;
            btnBaoCaoTonKho.Enabled = true;
            btnDangKiKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
        }
        public void LoginedQuyenNhanVien()
        {
            btnDangNhap.Enabled = false;
            btnBanDienThoai.Enabled = true;
            btnDangXuat.Enabled = true;
            btnThoat.Enabled = true;
            btnQuanLiSanPham.Enabled = false;
            btnQuanLiKhachHang.Enabled = false;
            btnLoaiDienThoai.Enabled = false;
            btnHangDienThoai.Enabled = false;
            btnQuanLiHoaDon.Enabled = false;
            btnQuanLiNguoiDung.Enabled = false;
            btnBaoCaoTonKho.Enabled = false;
            btnDangKiKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = false;
        }
        public void NoLogin()
        {
            btnDangNhap.Enabled = true;
            btnThoat.Enabled = true;
            btnQuanLiNguoiDung.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
            btnBanDienThoai.Enabled = false;
            btnQuanLiSanPham.Enabled = false;
            btnQuanLiKhachHang.Enabled = false;
            btnLoaiDienThoai.Enabled = false;
            btnHangDienThoai.Enabled = false;
            btnQuanLiHoaDon.Enabled = false;
            btnBaoCaoTonKho.Enabled = false;
            btnDangKiKhachHang.Enabled = false;
            btnThongKeDoanhThu.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                SessionLogin_BUS.idUser = null;
                SessionLogin_BUS.idRoles = null;
                SessionLogin_BUS.roleName = null;
                SessionLogin_BUS.taiKhoan = null;
                frmLogin f = new frmLogin();
                f.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmDoiMatKhau(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnBanDienThoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmBanDienThoai(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnQuanLiKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiKhachHang(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnLoaiDienThoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiLoaiDienThoai(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnHangDienThoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiHangDienThoai(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnQuanLiSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiDienThoai(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnQuanLiHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQuanLiHoaDon(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnBaoCaoTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmBaoCaoTonKho(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnDangKiKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmDangKiKhachHang(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnThongKeDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmThongKeDoanhThu(this);
            if (existForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
    }
}

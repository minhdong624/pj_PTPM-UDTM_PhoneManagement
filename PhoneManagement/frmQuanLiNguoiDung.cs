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
    public partial class frmQuanLiNguoiDung : Form
    {
        frmMain f;
        QuanLiNguoiDung_BUS ql = new QuanLiNguoiDung_BUS();
        public frmQuanLiNguoiDung(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void frmQuanLiNguoiDung_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");//Set skin mặc định Devexpress
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvQuanLiNguoiDung.DataSource = ql.XemThongTinNguoiDung();
        }
      
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cmbGioiTinh.Properties.DataSource = null;
            cmbGioiTinh.Properties.ValueMember = null;
            cmbGioiTinh.Properties.DisplayMember = null;
            cmbChucVu.Properties.DataSource = null;
            cmbChucVu.Properties.ValueMember = null;
            cmbChucVu.Properties.DisplayMember = null;
            txtTenNhanVien.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "tenNhanVien");
            txtDiaChi.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "diaChi");
            txtEmail.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "email");
            txtTaiKhoan.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "taiKhoan");
            txtMatKhau.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "matKhau");
            txtSoDienThoai.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "SDT");
            txtLuong.EditValue = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "luong");
            cmbGioiTinh.Properties.NullText = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "gioiTinh").ToString();
            cmbChucVu.Properties.NullText = gvQuanLiNguoiDung.GetRowCellValue(e.FocusedRowHandle, "tenRole").ToString();

        }


        private void btnShowGioiTinh_Click(object sender, EventArgs e)
        {
            cmbGioiTinh.Properties.DataSource = ql.GioiTinh();
            cmbGioiTinh.Properties.ValueMember = "maGT";
            cmbGioiTinh.Properties.DisplayMember = "tenGT";
        }

        private void btnChonChucVu_Click(object sender, EventArgs e)
        {
            cmbChucVu.Properties.DataSource = ql.Role();
            cmbChucVu.Properties.ValueMember = "ID_Role";
            cmbChucVu.Properties.DisplayMember = "tenRole";
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbChucVu.EditValue) != "")
            {
                if (Convert.ToString(cmbGioiTinh.EditValue) != "")
                {
                    var a = ql.ThemNguoiDung(txtTenNhanVien.Text, txtEmail.Text, txtDiaChi.Text,
                    txtSoDienThoai.Text, txtTaiKhoan.Text, txtMatKhau.Text,
                    txtLuong.Text, Convert.ToInt32(cmbChucVu.EditValue),
                    Convert.ToBoolean(cmbGioiTinh.EditValue));
                    XtraMessageBox.Show(a.ToString());
                    DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn làm mới dữ liệu người dùng","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        dgvQuanLiNguoiDung.DataSource = ql.XemThongTinNguoiDung();
                    }
                    else
                    {            
                        XtraMessageBox.Show("Cảm ơn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn giới tính");
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn chức vụ");
            }
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            //XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            //args.Caption = "Thông báo!";
            //args.Text = a;
            //args.Buttons = new DialogResult[] { DialogResult.OK };
            //args.Showing += Args_Showing;
            //XtraMessageBox.Show(args).ToString();
            //dgvQuanLiNguoiDung.DataSource = ql.XemThongTinNguoiDung();
            //XtraMessageBox.Show(Convert.ToString(cmbChucVu.EditValue));
            //bold message caption 
            e.Form.Appearance.FontStyleDelta = FontStyle.Bold;
            //increased button height and font size 
            MessageButtonCollection buttons = e.Buttons as MessageButtonCollection;
            SimpleButton btn = buttons[System.Windows.Forms.DialogResult.OK] as SimpleButton;
            if (btn != null)
            {
                btn.Appearance.FontSizeDelta = 4;
                btn.Height += 10;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa người dùng này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var a = ql.XoaNguoiDung(Convert.ToInt32(gvQuanLiNguoiDung.GetRowCellValue(gvQuanLiNguoiDung.FocusedRowHandle, "ID_User")));
                dgvQuanLiNguoiDung.DataSource = ql.XemThongTinNguoiDung();
                XtraMessageBox.Show(a);
            }
            else
            {
                XtraMessageBox.Show("Bạn đã không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            cmbGioiTinh.Text = "";
            cmbChucVu.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát?", 
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Bạn không thoát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbChucVu.EditValue) != "")
            {
                if (Convert.ToString(cmbGioiTinh.EditValue) != "")
                {
                    var a = ql.SuaNguoiDung(Convert.ToInt32(gvQuanLiNguoiDung.GetRowCellValue(gvQuanLiNguoiDung.FocusedRowHandle, "ID_User")), txtTenNhanVien.Text, txtEmail.Text, txtDiaChi.Text,
                    txtSoDienThoai.Text, txtMatKhau.Text,
                    txtLuong.Text, Convert.ToInt32(cmbChucVu.EditValue),
                    Convert.ToBoolean(cmbGioiTinh.EditValue));
                    XtraMessageBox.Show(a.ToString());
                    dgvQuanLiNguoiDung.DataSource = ql.XemThongTinNguoiDung();
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn giới tính");
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn chức vụ");
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

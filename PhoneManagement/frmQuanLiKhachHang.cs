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
    public partial class frmQuanLiKhachHang : Form
    {
        QuanLiKhachHang_BUS ql = new QuanLiKhachHang_BUS();
        frmMain f;
        public frmQuanLiKhachHang(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvQuanLiKhachHang.DataSource = ql.XemKhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemKhachHang.Text == "")
            {
                dgvQuanLiKhachHang.DataSource = ql.XemKhachHang();
            }
            else
            {
                dgvQuanLiKhachHang.DataSource = ql.search(txtTimKiemKhachHang.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var a = ql.ThemKhachHang(txtTenKhachHang.Text, txtSoDienThoai.Text, txtEmail.Text, txtDiaChi.Text, txtCMND.Text);
            XtraMessageBox.Show(a);
            dgvQuanLiKhachHang.DataSource = ql.XemKhachHang();
        }

        private void gvQuanLiKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtTenKhachHang.EditValue = gvQuanLiKhachHang.GetRowCellValue(e.FocusedRowHandle, "tenKhachHang");
            txtDiaChi.EditValue = gvQuanLiKhachHang.GetRowCellValue(e.FocusedRowHandle, "diaChi");
            txtEmail.EditValue = gvQuanLiKhachHang.GetRowCellValue(e.FocusedRowHandle, "email");
            txtSoDienThoai.EditValue = gvQuanLiKhachHang.GetRowCellValue(e.FocusedRowHandle, "SDT");
            txtCMND.EditValue = gvQuanLiKhachHang.GetRowCellValue(e.FocusedRowHandle, "SCMND");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvQuanLiKhachHang.RowCount > 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa khách hàng này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var a = ql.XoaKhachHang(Convert.ToInt32(gvQuanLiKhachHang.GetRowCellValue(gvQuanLiKhachHang.FocusedRowHandle, "ID_KhachHang")));
                    dgvQuanLiKhachHang.DataSource = ql.XemKhachHang();
                    XtraMessageBox.Show(a);
                }
                else
                {
                    XtraMessageBox.Show("Bạn đã không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvQuanLiKhachHang.RowCount > 0)
            {
                var a = ql.SuaKhachHang(Convert.ToInt32(gvQuanLiKhachHang.GetRowCellValue(gvQuanLiKhachHang.FocusedRowHandle, "ID_KhachHang")), txtTenKhachHang.Text, txtSoDienThoai.Text, txtEmail.Text, txtDiaChi.Text, txtCMND.Text);
                XtraMessageBox.Show(a);
                dgvQuanLiKhachHang.DataSource = ql.XemKhachHang();
            }
            else
            {
                XtraMessageBox.Show("Không có dữ liệu để sửa");
            }
        }

        private void txtTimKiemKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

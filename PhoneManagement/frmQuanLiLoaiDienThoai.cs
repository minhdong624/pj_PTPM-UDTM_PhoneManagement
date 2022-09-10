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
    public partial class frmQuanLiLoaiDienThoai : Form
    {
        QuanLiLoaiDienThoai_BUS ql = new QuanLiLoaiDienThoai_BUS();
        frmMain f;
        public frmQuanLiLoaiDienThoai(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        
        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvLoaiDT.DataSource = ql.XemLoaiDienThoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoaiSanPham.Text != "")
            {
                ql.ThemLoaiDienThoai(txtLoaiSanPham.Text, rtxtMoTa.Text);
                dgvLoaiDT.DataSource = ql.XemLoaiDienThoai();
                XtraMessageBox.Show("Thêm thành công");
            }
            else
            {
                XtraMessageBox.Show("Tên loại không được bỏ trống");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoaiSanPham.Text = "";
            rtxtMoTa.Text = "";
        }

        private void gvLoaiDT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtLoaiSanPham.EditValue = gvLoaiDT.GetRowCellValue(e.FocusedRowHandle, "tenLoaiDT");
            rtxtMoTa.Text = gvLoaiDT.GetRowCellValue(e.FocusedRowHandle, "moTa").ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvLoaiDT.RowCount > 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa loại này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ql.XoaLoaiDienThoai(Convert.ToInt32(gvLoaiDT.GetRowCellValue(gvLoaiDT.FocusedRowHandle, "ID_LoaiDT")));
                    dgvLoaiDT.DataSource = ql.XemLoaiDienThoai();
                    XtraMessageBox.Show("Đã xóa");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtLoaiSanPham.Text != "")
            {
                ql.SuaLoaiDienThoai(Convert.ToInt32(gvLoaiDT.GetRowCellValue(gvLoaiDT.FocusedRowHandle, "ID_LoaiDT")), txtLoaiSanPham.Text, rtxtMoTa.Text);
                dgvLoaiDT.DataSource = ql.XemLoaiDienThoai();
                XtraMessageBox.Show("Sửa thành công");
            }
            else
            {
                XtraMessageBox.Show("Tên loại không được bỏ trống");
            }
        }
    }
}

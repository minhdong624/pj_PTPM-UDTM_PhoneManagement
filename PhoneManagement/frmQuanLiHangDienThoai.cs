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
    public partial class frmQuanLiHangDienThoai : Form
    {
        QuanLiHangDienThoai_BUS ql = new QuanLiHangDienThoai_BUS();
        frmMain f;
        public frmQuanLiHangDienThoai(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHangSanPham.Text != "")
            {
                ql.ThemHangDienThoai(txtHangSanPham.Text, rtxtMoTa.Text,rtxtGhiChu.Text);
                dgvHangDT.DataSource = ql.XemHangDienThoai(); 
                XtraMessageBox.Show("Thêm thành công");
            }
            else
            {
                XtraMessageBox.Show("Tên hãng không được bỏ trống");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvHangDT.RowCount > 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa hãng điện thoại này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ql.XoaHangDienThoai(Convert.ToInt32(gvHangDT.GetRowCellValue(gvHangDT.FocusedRowHandle, "ID_HangDT")));
                    dgvHangDT.DataSource = ql.XemHangDienThoai();
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
            if (txtHangSanPham.Text != "")
            {
                ql.SuaHangDienThoai(Convert.ToInt32(gvHangDT.GetRowCellValue(gvHangDT.FocusedRowHandle, "ID_HangDT")), txtHangSanPham.Text, rtxtMoTa.Text,rtxtGhiChu.Text);
                dgvHangDT.DataSource = ql.XemHangDienThoai();
                XtraMessageBox.Show("Sửa thành công");
            }
            else
            {
                XtraMessageBox.Show("Tên loại không được bỏ trống");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvHangDT.DataSource = ql.XemHangDienThoai();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHangSanPham.Text = "";
            rtxtGhiChu.Text = "";
            rtxtMoTa.Text = "";
        }

        private void gvHangDT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtHangSanPham.EditValue = gvHangDT.GetRowCellValue(e.FocusedRowHandle, "tenHang");
            rtxtMoTa.Text = gvHangDT.GetRowCellValue(e.FocusedRowHandle, "moTa").ToString();
            rtxtGhiChu.Text = gvHangDT.GetRowCellValue(e.FocusedRowHandle, "ghiChu").ToString();
        }
    }
}

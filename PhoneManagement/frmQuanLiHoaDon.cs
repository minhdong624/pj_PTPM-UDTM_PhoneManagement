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
    public partial class frmQuanLiHoaDon : Form
    {
        QuanLiHoaDon_BUS ql = new QuanLiHoaDon_BUS();
        frmMain f;
        public frmQuanLiHoaDon(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLiHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ql.XemHoaDon();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = ql.XemChiTietHoaDon(Convert.ToInt32(gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ID_HoaDon")));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa hóa đơn này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var a = ql.XoaHoaDon(Convert.ToInt32(gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ID_HoaDon")));
                dgvHoaDon.DataSource = ql.XemHoaDon();
                XtraMessageBox.Show(a);
            }
            else
            {
                XtraMessageBox.Show("Bạn đã không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaToanBoCTHD_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa toàn bộ chi tiết hóa đơn này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var a = ql.XoaToanBoCTHD(Convert.ToInt32(gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ID_HoaDon")));
                dgvChiTietHoaDon.DataSource = ql.XemChiTietHoaDon(Convert.ToInt32(gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ID_HoaDon")));
                XtraMessageBox.Show(a);
            }
            else
            {
                XtraMessageBox.Show("Bạn đã không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchHoaDon_TextChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ql.TimKiemHoaDon(searchHoaDon.Text);
        }

        
    }
}

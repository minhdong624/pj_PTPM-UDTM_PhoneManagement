using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace PhoneManagement
{
    public partial class frmQuanLiDienThoai : Form
    {
        QuanLiDienThoai_BUS ql = new QuanLiDienThoai_BUS();
        string imgName = "";
        Image image;
        frmMain f;
        public frmQuanLiDienThoai(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDienThoai.DataSource = ql.XemDienThoai();
        }

        private void frmQuanLiDienThoai_Load(object sender, EventArgs e)
        {

        }

        private void btnChonHangDienThoai_Click(object sender, EventArgs e)
        {
            cmbHangDienThoai.Properties.DataSource = ql.XemHangDienThoai();
            cmbHangDienThoai.Properties.ValueMember = "ID_HangDT";
            cmbHangDienThoai.Properties.DisplayMember = "tenHang";
        }

        private void btnChonLoaiDienThoai_Click(object sender, EventArgs e)
        {
            cmbLoaiDienThoai.Properties.DataSource = ql.XemLoaiDienThoai();
            cmbLoaiDienThoai.Properties.ValueMember = "ID_LoaiDT";
            cmbLoaiDienThoai.Properties.DisplayMember = "tenLoaiDT";
        }

        private void gvDienThoai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDienThoai.RowCount > 0)
            {
                cmbLoaiDienThoai.Properties.DataSource = null;
                cmbLoaiDienThoai.Properties.ValueMember = null;
                cmbLoaiDienThoai.Properties.DisplayMember = null;
                cmbHangDienThoai.Properties.DataSource = null;
                cmbHangDienThoai.Properties.ValueMember = null;
                cmbHangDienThoai.Properties.DisplayMember = null;
                txtTenDienThoai.EditValue = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "tenDienThoai");
                txtDonGia.EditValue = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "donGia");
                txtSoLuongTon.EditValue = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "soLuongTon");
                dateHanBaoHanh.EditValue = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "hanBaoHanh");
                rtxtGhiChu.Text = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "ghiChu").ToString();
                rtxtMoTa.Text = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "moTa").ToString();
                rtxtThongSoKiThuat.Text = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "thongSoKyThuat").ToString();
                cmbHangDienThoai.Properties.NullText = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "tenHang").ToString();
                cmbLoaiDienThoai.Properties.NullText = gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "tenLoaiDT").ToString();
                if (gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "hinhAnh").ToString() != "")
                {
                    string filepath = Path.Combine(Application.StartupPath, @"Image\");
                    picDienThoai.Image = Image.FromFile(filepath + gvDienThoai.GetRowCellValue(e.FocusedRowHandle, "hinhAnh").ToString());
                }
            }
            else
            {
                picDienThoai.Image = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenDienThoai.Text = "";
            txtSoLuongTon.Text = "";
            txtDonGia.Text = "";
            dateHanBaoHanh.Text = "";
            rtxtGhiChu.Text = "";
            rtxtMoTa.Text = "";
            rtxtThongSoKiThuat.Text = "";
            picDienThoai.Image = null;
            cmbHangDienThoai.Properties.NullText = "";
            cmbLoaiDienThoai.Properties.NullText = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Sau khi xóa dữ liệu sẽ không được phục hồi", "Bạn có muốn xóa điện thoại này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var a = ql.XoaDienThoai(Convert.ToInt32(gvDienThoai.GetRowCellValue(gvDienThoai.FocusedRowHandle, "ID_dienThoai")));
                dgvDienThoai.DataSource = ql.XemDienThoai();
                XtraMessageBox.Show(a);
            }
            else
            {
                XtraMessageBox.Show("Bạn đã không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (imgName == "")
            {
                if (txtTenDienThoai.Text != "" && txtSoLuongTon.Text != "" && txtDonGia.Text != "")
                {
                    if (Convert.ToString(cmbHangDienThoai.EditValue) != "")
                    {
                        if (Convert.ToString(cmbLoaiDienThoai.EditValue) != "")
                        {
                            var a = ql.ThemDienThoai(txtTenDienThoai.Text, txtSoLuongTon.Text, txtDonGia.Text, Convert.ToDateTime(dateHanBaoHanh.Text), rtxtMoTa.Text, rtxtGhiChu.Text, rtxtThongSoKiThuat.Text, Convert.ToInt32(cmbHangDienThoai.EditValue), Convert.ToInt32(cmbLoaiDienThoai.EditValue), "");
                            XtraMessageBox.Show(a);
                            dgvDienThoai.DataSource = ql.XemDienThoai();
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa chọn loại điện thoại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn hãng điện thoại");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được bỏ trống tên điện thoại, đơn giá và số lượng tồn!");
                }
            }
            else
            {
                if (txtTenDienThoai.Text != "" && txtSoLuongTon.Text != "" && txtDonGia.Text != "")
                {
                    if(Convert.ToString(cmbHangDienThoai.EditValue) != "")
                    {
                        if(Convert.ToString(cmbLoaiDienThoai.EditValue) != "")
                        {
                            var a = ql.ThemDienThoai(txtTenDienThoai.Text, txtSoLuongTon.Text, txtDonGia.Text, Convert.ToDateTime(dateHanBaoHanh.Text), rtxtMoTa.Text, rtxtGhiChu.Text, rtxtThongSoKiThuat.Text, Convert.ToInt32(cmbHangDienThoai.EditValue), Convert.ToInt32(cmbLoaiDienThoai.EditValue), imgName);
                            XtraMessageBox.Show(a);
                            dgvDienThoai.DataSource = ql.XemDienThoai();
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa chọn loại điện thoại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn hãng điện thoại");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được bỏ trống tên điện thoại, đơn giá và số lượng tồn!");
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (imgName == "")
            {
                if (txtTenDienThoai.Text != "" && txtSoLuongTon.Text != "" && txtDonGia.Text != "")
                {
                    if (Convert.ToString(cmbHangDienThoai.EditValue) != "")
                    {
                        if (Convert.ToString(cmbLoaiDienThoai.EditValue) != "")
                        {
                            var a = ql.SuaDienThoai(Convert.ToInt32(gvDienThoai.GetRowCellValue(gvDienThoai.FocusedRowHandle, "ID_dienThoai")),txtTenDienThoai.Text, txtSoLuongTon.Text, txtDonGia.Text, Convert.ToDateTime(dateHanBaoHanh.Text), rtxtMoTa.Text, rtxtGhiChu.Text, rtxtThongSoKiThuat.Text, Convert.ToInt32(cmbHangDienThoai.EditValue), Convert.ToInt32(cmbLoaiDienThoai.EditValue), "");
                            XtraMessageBox.Show(a);
                            dgvDienThoai.DataSource = ql.XemDienThoai();
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa chọn loại điện thoại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn hãng điện thoại");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được bỏ trống tên điện thoại, đơn giá và số lượng tồn!");
                }
            }
            else
            {
                if (txtTenDienThoai.Text != "" && txtSoLuongTon.Text != "" && txtDonGia.Text != "")
                {
                    if (Convert.ToString(cmbHangDienThoai.EditValue) != "")
                    {
                        if (Convert.ToString(cmbLoaiDienThoai.EditValue) != "")
                        {
                            var a = ql.SuaDienThoai(Convert.ToInt32(gvDienThoai.GetRowCellValue(gvDienThoai.FocusedRowHandle, "ID_dienThoai")), txtTenDienThoai.Text, txtSoLuongTon.Text, txtDonGia.Text, Convert.ToDateTime(dateHanBaoHanh.Text), rtxtMoTa.Text, rtxtGhiChu.Text, rtxtThongSoKiThuat.Text, Convert.ToInt32(cmbHangDienThoai.EditValue), Convert.ToInt32(cmbLoaiDienThoai.EditValue), imgName);
                            XtraMessageBox.Show(a);
                            dgvDienThoai.DataSource = ql.XemDienThoai();
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa chọn loại điện thoại");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn hãng điện thoại");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không được bỏ trống tên điện thoại, đơn giá và số lượng tồn!");
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (f.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(f.FileName);
                picDienThoai.Image = image;
                //picDienThoai.Image = new Bitmap(f.FileName);
                //string imgpath = f.FileName;
                //imgName = Path.GetFileName(imgpath);
                //picDienThoai.Image.Save(imgpath);
                //File.Copy(f.FileName, Path.Combine(@"F:\PhoneManagement\PhoneManagement\bin\Debug\Image\", Path.GetFileName(imgName)), true);

            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = @"F:\PhoneManagement\PhoneManagement\bin\Debug\Image\";
            f.Filter = "Files|*.jpg;*.jpeg;*.png";
            f.FilterIndex = 2;
            f.RestoreDirectory = true;
            if (image != null)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    image.Save(f.FileName);
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn ảnh");
            }
        }

        private void btnChonAnhDeLuu_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Files|*.jpg;*.jpeg;*.png";
            f.InitialDirectory = @"F:\PhoneManagement\PhoneManagement\bin\Debug\Image\";
            f.Filter = "Files|*.jpg;*.jpeg;*.png";
            f.FilterIndex = 2;
            if (f.ShowDialog() == DialogResult.OK)
            {
                string imgpath = f.FileName;
                imgName = Path.GetFileName(imgpath);
            }
        }
    }
}

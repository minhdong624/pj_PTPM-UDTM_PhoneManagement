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
    public partial class frmBaoCaoTonKho : Form
    {
        BaoCaoTonKho_BUS bc = new BaoCaoTonKho_BUS();
        BindingSource bs = new BindingSource();
        rptBaoCaoTonKho rpt = new rptBaoCaoTonKho();
        frmMain f;
        public frmBaoCaoTonKho(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }
        
        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            rbtnNone.Checked = true;
            cmbLoaiDienThoai.Properties.DataSource = bc.ldts();
            cmbLoaiDienThoai.Properties.ValueMember = "ID_LoaiDT";
            cmbLoaiDienThoai.Properties.DisplayMember = "tenLoaiDT";
            cmbHangDienThoai.Properties.DataSource = bc.hdts();
            cmbHangDienThoai.Properties.ValueMember = "ID_HangDT";
            cmbHangDienThoai.Properties.DisplayMember = "tenHang";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (rbtnNone.Checked == true)
            {
                bs.DataSource = bc.BaoCao();
                rpt.SetDataSource(bs);
                rpt_View.ReportSource = rpt;
                rpt_View.RefreshReport();
            }

            if (rbtnHangLoai.Checked == true)
            {
                bs.DataSource = bc.BaoCaoTheoHangVaLoai(Convert.ToInt32(cmbLoaiDienThoai.EditValue), Convert.ToInt32(cmbHangDienThoai.EditValue));
                rpt.SetDataSource(bs);
                rpt_View.ReportSource = rpt;
                rpt_View.RefreshReport();
            }

            if (rbtnHang.Checked == true)
            {
                bs.DataSource = bc.BaoCaoTheoHang(Convert.ToInt32(cmbHangDienThoai.EditValue));
                rpt.SetDataSource(bs);
                rpt_View.ReportSource = rpt;
                rpt_View.RefreshReport();
            }

            if (rbtnLoai.Checked == true)
            {
                bs.DataSource = bc.BaoCaoTheoLoai(Convert.ToInt32(cmbLoaiDienThoai.EditValue));
                rpt.SetDataSource(bs);
                rpt_View.ReportSource = rpt;
                rpt_View.RefreshReport();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

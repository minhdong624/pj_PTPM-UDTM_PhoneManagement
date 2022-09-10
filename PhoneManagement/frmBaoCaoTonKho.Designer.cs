namespace PhoneManagement
{
    partial class frmBaoCaoTonKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTonKho));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnHangLoai = new System.Windows.Forms.RadioButton();
            this.rbtnHang = new System.Windows.Forms.RadioButton();
            this.rbtnNone = new System.Windows.Forms.RadioButton();
            this.rbtnLoai = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHangDienThoai = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbLoaiDienThoai = new DevExpress.XtraEditors.LookUpEdit();
            this.rpt_View = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHangDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiDienThoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1350, 156);
            this.panelControl1.TabIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnXem);
            this.groupControl3.Controls.Add(this.btnThoat);
            this.groupControl3.Location = new System.Drawing.Point(765, 14);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(326, 128);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(175, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(23, 40);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(131, 50);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtnLoai);
            this.groupControl2.Controls.Add(this.rbtnNone);
            this.groupControl2.Controls.Add(this.rbtnHang);
            this.groupControl2.Controls.Add(this.rbtnHangLoai);
            this.groupControl2.Location = new System.Drawing.Point(396, 14);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 128);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Điều kiện lọc";
            // 
            // rbtnHangLoai
            // 
            this.rbtnHangLoai.AutoSize = true;
            this.rbtnHangLoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHangLoai.Location = new System.Drawing.Point(189, 38);
            this.rbtnHangLoai.Name = "rbtnHangLoai";
            this.rbtnHangLoai.Size = new System.Drawing.Size(115, 23);
            this.rbtnHangLoai.TabIndex = 3;
            this.rbtnHangLoai.TabStop = true;
            this.rbtnHangLoai.Text = "Hãng và loại";
            this.rbtnHangLoai.UseVisualStyleBackColor = true;
            // 
            // rbtnHang
            // 
            this.rbtnHang.AutoSize = true;
            this.rbtnHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHang.Location = new System.Drawing.Point(35, 82);
            this.rbtnHang.Name = "rbtnHang";
            this.rbtnHang.Size = new System.Drawing.Size(64, 23);
            this.rbtnHang.TabIndex = 1;
            this.rbtnHang.TabStop = true;
            this.rbtnHang.Text = "Hãng";
            this.rbtnHang.UseVisualStyleBackColor = true;
            // 
            // rbtnNone
            // 
            this.rbtnNone.AutoSize = true;
            this.rbtnNone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNone.Location = new System.Drawing.Point(35, 38);
            this.rbtnNone.Name = "rbtnNone";
            this.rbtnNone.Size = new System.Drawing.Size(64, 23);
            this.rbtnNone.TabIndex = 2;
            this.rbtnNone.TabStop = true;
            this.rbtnNone.Text = "None";
            this.rbtnNone.UseVisualStyleBackColor = true;
            // 
            // rbtnLoai
            // 
            this.rbtnLoai.AutoSize = true;
            this.rbtnLoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLoai.Location = new System.Drawing.Point(189, 82);
            this.rbtnLoai.Name = "rbtnLoai";
            this.rbtnLoai.Size = new System.Drawing.Size(56, 23);
            this.rbtnLoai.TabIndex = 4;
            this.rbtnLoai.TabStop = true;
            this.rbtnLoai.Text = "Loại";
            this.rbtnLoai.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbLoaiDienThoai);
            this.groupControl1.Controls.Add(this.cmbHangDienThoai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 128);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Dữ liệu lọc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Loại điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hãng điện thoại";
            // 
            // cmbHangDienThoai
            // 
            this.cmbHangDienThoai.Location = new System.Drawing.Point(149, 35);
            this.cmbHangDienThoai.Name = "cmbHangDienThoai";
            this.cmbHangDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHangDienThoai.Properties.Appearance.Options.UseFont = true;
            this.cmbHangDienThoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHangDienThoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_HangDT", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenHang", "Hãng điện thoại")});
            this.cmbHangDienThoai.Properties.NullText = "";
            this.cmbHangDienThoai.Size = new System.Drawing.Size(161, 26);
            this.cmbHangDienThoai.TabIndex = 1;
            // 
            // cmbLoaiDienThoai
            // 
            this.cmbLoaiDienThoai.Location = new System.Drawing.Point(149, 83);
            this.cmbLoaiDienThoai.Name = "cmbLoaiDienThoai";
            this.cmbLoaiDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiDienThoai.Properties.Appearance.Options.UseFont = true;
            this.cmbLoaiDienThoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiDienThoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_LoaiDT", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenLoaiDT", "Loại điện thoại")});
            this.cmbLoaiDienThoai.Properties.NullText = "";
            this.cmbLoaiDienThoai.Size = new System.Drawing.Size(161, 26);
            this.cmbLoaiDienThoai.TabIndex = 0;
            // 
            // rpt_View
            // 
            this.rpt_View.ActiveViewIndex = -1;
            this.rpt_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_View.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_View.Location = new System.Drawing.Point(0, 156);
            this.rpt_View.Name = "rpt_View";
            this.rpt_View.Size = new System.Drawing.Size(1350, 371);
            this.rpt_View.TabIndex = 8;
            // 
            // frmBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 527);
            this.Controls.Add(this.rpt_View);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBaoCaoTonKho";
            this.Text = "BÁO CÁO TỒN KHO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHangDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiDienThoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbLoaiDienThoai;
        private DevExpress.XtraEditors.LookUpEdit cmbHangDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rbtnLoai;
        private System.Windows.Forms.RadioButton rbtnNone;
        private System.Windows.Forms.RadioButton rbtnHang;
        private System.Windows.Forms.RadioButton rbtnHangLoai;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_View;
    }
}
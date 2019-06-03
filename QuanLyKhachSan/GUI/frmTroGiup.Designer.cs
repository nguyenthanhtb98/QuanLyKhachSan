namespace QuanLyKhachSan.GUI
{
    partial class frmTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroGiup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnSau = new DevExpress.XtraEditors.SimpleButton();
            this.btnTruoc = new DevExpress.XtraEditors.SimpleButton();
            this.pnlTroGiup_SDDV = new System.Windows.Forms.Panel();
            this.pnlTroGiup_ThanhToan = new System.Windows.Forms.Panel();
            this.pnlTroGiup_ThuePhong = new System.Windows.Forms.Panel();
            this.lblTrang = new System.Windows.Forms.Label();
            this.lblThongTinTrang = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblThongTinTrang);
            this.panel1.Controls.Add(this.lblTrang);
            this.panel1.Controls.Add(this.btnTroVe);
            this.panel1.Controls.Add(this.btnSau);
            this.panel1.Controls.Add(this.btnTruoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 35);
            this.panel1.TabIndex = 4;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.ImageOptions.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(786, 3);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(86, 29);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnSau
            // 
            this.btnSau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSau.ImageOptions.Image")));
            this.btnSau.Location = new System.Drawing.Point(95, 3);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(86, 29);
            this.btnSau.TabIndex = 4;
            this.btnSau.Text = "Sau";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTruoc.ImageOptions.Image")));
            this.btnTruoc.Location = new System.Drawing.Point(3, 3);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(86, 29);
            this.btnTruoc.TabIndex = 3;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // pnlTroGiup_SDDV
            // 
            this.pnlTroGiup_SDDV.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.img_HDSDDV;
            this.pnlTroGiup_SDDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTroGiup_SDDV.Location = new System.Drawing.Point(502, 57);
            this.pnlTroGiup_SDDV.Name = "pnlTroGiup_SDDV";
            this.pnlTroGiup_SDDV.Size = new System.Drawing.Size(268, 154);
            this.pnlTroGiup_SDDV.TabIndex = 2;
            // 
            // pnlTroGiup_ThanhToan
            // 
            this.pnlTroGiup_ThanhToan.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.img_HDThanhToan;
            this.pnlTroGiup_ThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTroGiup_ThanhToan.Location = new System.Drawing.Point(240, 57);
            this.pnlTroGiup_ThanhToan.Name = "pnlTroGiup_ThanhToan";
            this.pnlTroGiup_ThanhToan.Size = new System.Drawing.Size(238, 154);
            this.pnlTroGiup_ThanhToan.TabIndex = 1;
            // 
            // pnlTroGiup_ThuePhong
            // 
            this.pnlTroGiup_ThuePhong.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.img_HDThuePhong;
            this.pnlTroGiup_ThuePhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTroGiup_ThuePhong.Location = new System.Drawing.Point(12, 57);
            this.pnlTroGiup_ThuePhong.Name = "pnlTroGiup_ThuePhong";
            this.pnlTroGiup_ThuePhong.Size = new System.Drawing.Size(210, 154);
            this.pnlTroGiup_ThuePhong.TabIndex = 0;
            // 
            // lblTrang
            // 
            this.lblTrang.AutoSize = true;
            this.lblTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrang.Location = new System.Drawing.Point(260, 10);
            this.lblTrang.Name = "lblTrang";
            this.lblTrang.Size = new System.Drawing.Size(44, 17);
            this.lblTrang.TabIndex = 6;
            this.lblTrang.Text = "Trang:";
            // 
            // lblThongTinTrang
            // 
            this.lblThongTinTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThongTinTrang.AutoSize = true;
            this.lblThongTinTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTrang.Location = new System.Drawing.Point(396, 10);
            this.lblThongTinTrang.Name = "lblThongTinTrang";
            this.lblThongTinTrang.Size = new System.Drawing.Size(98, 17);
            this.lblThongTinTrang.TabIndex = 7;
            this.lblThongTinTrang.Text = "Thông tin trang";
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTroGiup_SDDV);
            this.Controls.Add(this.pnlTroGiup_ThanhToan);
            this.Controls.Add(this.pnlTroGiup_ThuePhong);
            this.Name = "frmTroGiup";
            this.Text = "frmTroGiup";
            this.Load += new System.EventHandler(this.frmTroGiup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTroGiup_ThuePhong;
        private System.Windows.Forms.Panel pnlTroGiup_ThanhToan;
        private System.Windows.Forms.Panel pnlTroGiup_SDDV;
        private DevExpress.XtraEditors.SimpleButton btnTruoc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnSau;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Label lblThongTinTrang;
    }
}
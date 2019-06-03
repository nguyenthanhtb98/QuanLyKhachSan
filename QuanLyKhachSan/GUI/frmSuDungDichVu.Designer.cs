namespace QuanLyKhachSan.GUI
{
    partial class frmSuDungDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuDungDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDichVu = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDichVuDaSuDung = new System.Windows.Forms.DataGridView();
            this.SDDV_MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaDV = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTenDV = new System.Windows.Forms.DataGridView();
            this.cboLoaiDV = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenDV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDichVu
            // 
            this.pnlDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlDichVu.Controls.Add(this.label6);
            this.pnlDichVu.Controls.Add(this.label4);
            this.pnlDichVu.Controls.Add(this.dgvDichVuDaSuDung);
            this.pnlDichVu.Controls.Add(this.label2);
            this.pnlDichVu.Controls.Add(this.dgvTenDV);
            this.pnlDichVu.Controls.Add(this.cboLoaiDV);
            this.pnlDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDichVu.Location = new System.Drawing.Point(0, 0);
            this.pnlDichVu.Name = "pnlDichVu";
            this.pnlDichVu.Size = new System.Drawing.Size(1136, 544);
            this.pnlDichVu.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(374, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại Dịch Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(890, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Các dịch vụ đã sử dụng";
            // 
            // dgvDichVuDaSuDung
            // 
            this.dgvDichVuDaSuDung.AllowUserToAddRows = false;
            this.dgvDichVuDaSuDung.AllowUserToResizeColumns = false;
            this.dgvDichVuDaSuDung.AllowUserToResizeRows = false;
            this.dgvDichVuDaSuDung.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDichVuDaSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuDaSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SDDV_MaDV,
            this.TenDV2,
            this.Gia,
            this.SoLuong,
            this.XoaDV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVuDaSuDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVuDaSuDung.Location = new System.Drawing.Point(800, 86);
            this.dgvDichVuDaSuDung.Name = "dgvDichVuDaSuDung";
            this.dgvDichVuDaSuDung.ReadOnly = true;
            this.dgvDichVuDaSuDung.RowHeadersVisible = false;
            this.dgvDichVuDaSuDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVuDaSuDung.Size = new System.Drawing.Size(326, 296);
            this.dgvDichVuDaSuDung.TabIndex = 4;
            this.dgvDichVuDaSuDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVuDaSuDung_CellContentClick);
            // 
            // SDDV_MaDV
            // 
            this.SDDV_MaDV.DataPropertyName = "MaDV";
            this.SDDV_MaDV.HeaderText = "Mã Dịch Vụ";
            this.SDDV_MaDV.Name = "SDDV_MaDV";
            this.SDDV_MaDV.ReadOnly = true;
            this.SDDV_MaDV.Visible = false;
            // 
            // TenDV2
            // 
            this.TenDV2.DataPropertyName = "TenDV";
            this.TenDV2.FillWeight = 174.4374F;
            this.TenDV2.HeaderText = "Tên Dịch Vụ";
            this.TenDV2.Name = "TenDV2";
            this.TenDV2.ReadOnly = true;
            this.TenDV2.Width = 133;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GiaDV";
            this.Gia.FillWeight = 92.09903F;
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 70;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 114.2902F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 87;
            // 
            // XoaDV
            // 
            this.XoaDV.FillWeight = 68.41196F;
            this.XoaDV.HeaderText = "Xóa";
            this.XoaDV.Image = global::QuanLyKhachSan.Properties.Resources.remove;
            this.XoaDV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.XoaDV.Name = "XoaDV";
            this.XoaDV.ReadOnly = true;
            this.XoaDV.Width = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(537, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Các dịch vụ của khách sạn";
            // 
            // dgvTenDV
            // 
            this.dgvTenDV.AllowUserToAddRows = false;
            this.dgvTenDV.AllowUserToResizeColumns = false;
            this.dgvTenDV.AllowUserToResizeRows = false;
            this.dgvTenDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTenDV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTenDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV1,
            this.GiaDV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTenDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTenDV.Location = new System.Drawing.Point(480, 86);
            this.dgvTenDV.Name = "dgvTenDV";
            this.dgvTenDV.ReadOnly = true;
            this.dgvTenDV.RowHeadersVisible = false;
            this.dgvTenDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenDV.Size = new System.Drawing.Size(314, 296);
            this.dgvTenDV.TabIndex = 2;
            this.dgvTenDV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenDV_CellDoubleClick);
            // 
            // cboLoaiDV
            // 
            this.cboLoaiDV.BackColor = System.Drawing.Color.White;
            this.cboLoaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboLoaiDV.FormattingEnabled = true;
            this.cboLoaiDV.Location = new System.Drawing.Point(365, 86);
            this.cboLoaiDV.Name = "cboLoaiDV";
            this.cboLoaiDV.Size = new System.Drawing.Size(109, 21);
            this.cboLoaiDV.TabIndex = 1;
            this.cboLoaiDV.SelectedIndexChanged += new System.EventHandler(this.cboLoaiDV_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.btnTroVe);
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 544);
            this.panel3.TabIndex = 43;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Appearance.Options.UseFont = true;
            this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.ImageOptions.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(244, 22);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 38);
            this.btnTroVe.TabIndex = 28;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.MaKH,
            this.TenKH,
            this.GioiTinh,
            this.SDT,
            this.Email,
            this.CMND,
            this.NgayDen,
            this.NgayDi,
            this.HinhThucThue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 78);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(339, 304);
            this.dgvKhachHang.TabIndex = 10;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // MaPT
            // 
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.HeaderText = "Mã Phiếu Thuê";
            this.MaPT.Name = "MaPT";
            this.MaPT.ReadOnly = true;
            this.MaPT.Visible = false;
            this.MaPT.Width = 110;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Visible = false;
            this.MaKH.Width = 89;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 140;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 90;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 130;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.ReadOnly = true;
            this.NgayDen.Width = 130;
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.ReadOnly = true;
            this.NgayDi.Width = 130;
            // 
            // HinhThucThue
            // 
            this.HinhThucThue.DataPropertyName = "HinhThucThue";
            this.HinhThucThue.HeaderText = "Hình Thức Thuê";
            this.HinhThucThue.Name = "HinhThucThue";
            this.HinhThucThue.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30.45686F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QuanLyKhachSan.Properties.Resources.add;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 32;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.FillWeight = 109.4591F;
            this.MaDV.HeaderText = "Mã dịch vụ";
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            // 
            // TenDV1
            // 
            this.TenDV1.DataPropertyName = "TenDV";
            this.TenDV1.FillWeight = 160.084F;
            this.TenDV1.HeaderText = "Tên Dịch Vụ";
            this.TenDV1.Name = "TenDV1";
            this.TenDV1.ReadOnly = true;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Giá Dịch Vụ";
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.ReadOnly = true;
            // 
            // frmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDichVu);
            this.Name = "frmSuDungDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.SuDungDichVu_Load);
            this.pnlDichVu.ResumeLayout(false);
            this.pnlDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenDV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTenDV;
        private System.Windows.Forms.ComboBox cboLoaiDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDichVuDaSuDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDDV_MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewImageColumn XoaDV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucThue;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
    }
}
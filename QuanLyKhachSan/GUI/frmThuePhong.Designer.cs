namespace QuanLyKhachSan.GUI
{
    partial class frmThuePhong
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdiNu = new System.Windows.Forms.RadioButton();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.rdiNam = new System.Windows.Forms.RadioButton();
            this.btnXacNhanThue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHinhThucThue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dateNgayDi = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dateNgayDen = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.ChonThue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTheoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTheoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Thêm";
            this.dataGridViewImageColumn1.Image = global::QuanLyKhachSan.Properties.Resources.add;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.rdiNu);
            this.panel4.Controls.Add(this.btnQuayLai);
            this.panel4.Controls.Add(this.rdiNam);
            this.panel4.Controls.Add(this.btnXacNhanThue);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cboHinhThucThue);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.dateNgayDi);
            this.panel4.Controls.Add(this.txtCMND);
            this.panel4.Controls.Add(this.txtTenKH);
            this.panel4.Controls.Add(this.dateNgayDen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 508);
            this.panel4.TabIndex = 44;
            // 
            // rdiNu
            // 
            this.rdiNu.AutoSize = true;
            this.rdiNu.Location = new System.Drawing.Point(221, 91);
            this.rdiNu.Name = "rdiNu";
            this.rdiNu.Size = new System.Drawing.Size(39, 17);
            this.rdiNu.TabIndex = 63;
            this.rdiNu.Text = "Nữ";
            this.rdiNu.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuayLai.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(192, 450);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(143, 44);
            this.btnQuayLai.TabIndex = 62;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // rdiNam
            // 
            this.rdiNam.AutoSize = true;
            this.rdiNam.Checked = true;
            this.rdiNam.Location = new System.Drawing.Point(139, 91);
            this.rdiNam.Name = "rdiNam";
            this.rdiNam.Size = new System.Drawing.Size(47, 17);
            this.rdiNam.TabIndex = 62;
            this.rdiNam.TabStop = true;
            this.rdiNam.Text = "Nam";
            this.rdiNam.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanThue
            // 
            this.btnXacNhanThue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXacNhanThue.BackColor = System.Drawing.Color.YellowGreen;
            this.btnXacNhanThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThue.Location = new System.Drawing.Point(42, 450);
            this.btnXacNhanThue.Name = "btnXacNhanThue";
            this.btnXacNhanThue.Size = new System.Drawing.Size(144, 44);
            this.btnXacNhanThue.TabIndex = 61;
            this.btnXacNhanThue.Text = "Xác Nhận Thuê";
            this.btnXacNhanThue.UseVisualStyleBackColor = false;
            this.btnXacNhanThue.Click += new System.EventHandler(this.btnXacNhanThue_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Hình Thức Thuê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Số CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Giới Tính";
            // 
            // cboHinhThucThue
            // 
            this.cboHinhThucThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThucThue.FormattingEnabled = true;
            this.cboHinhThucThue.Items.AddRange(new object[] {
            "Theo Giờ",
            "Theo Ngày"});
            this.cboHinhThucThue.Location = new System.Drawing.Point(26, 412);
            this.cboHinhThucThue.Name = "cboHinhThucThue";
            this.cboHinhThucThue.Size = new System.Drawing.Size(152, 25);
            this.cboHinhThucThue.TabIndex = 60;
            this.cboHinhThucThue.Text = "Theo Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Ngày Đi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Tên Khách Hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(26, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 25);
            this.txtEmail.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Ngày Đến";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(26, 142);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(327, 25);
            this.txtSDT.TabIndex = 47;
            // 
            // dateNgayDi
            // 
            this.dateNgayDi.CustomFormat = "dd/MM/yy hh:mm tt";
            this.dateNgayDi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDi.Location = new System.Drawing.Point(26, 358);
            this.dateNgayDi.Name = "dateNgayDi";
            this.dateNgayDi.Size = new System.Drawing.Size(327, 25);
            this.dateNgayDi.TabIndex = 57;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(26, 250);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(327, 25);
            this.txtCMND.TabIndex = 49;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(26, 51);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(327, 25);
            this.txtTenKH.TabIndex = 40;
            // 
            // dateNgayDen
            // 
            this.dateNgayDen.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateNgayDen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDen.Location = new System.Drawing.Point(26, 304);
            this.dateNgayDen.Name = "dateNgayDen";
            this.dateNgayDen.Size = new System.Drawing.Size(327, 25);
            this.dateNgayDen.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dgvThuePhong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(412, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 508);
            this.panel5.TabIndex = 45;
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AllowUserToAddRows = false;
            this.dgvThuePhong.AllowUserToResizeColumns = false;
            this.dgvThuePhong.AllowUserToResizeRows = false;
            this.dgvThuePhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuePhong.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuePhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChonThue,
            this.MaPhong,
            this.TenPhong,
            this.TrangThai,
            this.GiaTheoGio,
            this.GiaTheoNgay,
            this.TenLoaiPhong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuePhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuePhong.Location = new System.Drawing.Point(31, 31);
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.RowHeadersVisible = false;
            this.dgvThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuePhong.Size = new System.Drawing.Size(605, 465);
            this.dgvThuePhong.TabIndex = 46;
            // 
            // ChonThue
            // 
            this.ChonThue.FillWeight = 60.9137F;
            this.ChonThue.HeaderText = "Chọn Thuê";
            this.ChonThue.Name = "ChonThue";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 107.8173F;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = false;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.FillWeight = 107.8173F;
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 107.8173F;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // GiaTheoGio
            // 
            this.GiaTheoGio.DataPropertyName = "GiaTheoGio";
            this.GiaTheoGio.HeaderText = "Giá Theo Giờ";
            this.GiaTheoGio.Name = "GiaTheoGio";
            // 
            // GiaTheoNgay
            // 
            this.GiaTheoNgay.DataPropertyName = "GiaTheoNgay";
            this.GiaTheoNgay.FillWeight = 107.8173F;
            this.GiaTheoNgay.HeaderText = "Giá Theo Ngày";
            this.GiaTheoNgay.Name = "GiaTheoNgay";
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLP";
            this.TenLoaiPhong.FillWeight = 107.8173F;
            this.TenLoaiPhong.HeaderText = "Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 508);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "frmThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHinhThucThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dateNgayDi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker dateNgayDen;
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhanThue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChonThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTheoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTheoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.RadioButton rdiNu;
        private System.Windows.Forms.RadioButton rdiNam;
    }
}
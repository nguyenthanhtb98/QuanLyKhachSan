namespace QuanLyKhachSan.GUI
{
    partial class frmTrangBiTheoPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhSachTrangBi = new System.Windows.Forms.DataGridView();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaTB = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTenTrangBi = new System.Windows.Forms.ComboBox();
            this.pnlThemTrangBiTheoPhong = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThem_TroVe = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlThemTrangBiTheoPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.dgvDanhSachTrangBi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTenPhong);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(294, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 469);
            this.panel1.TabIndex = 0;
            // 
            // dgvDanhSachTrangBi
            // 
            this.dgvDanhSachTrangBi.AllowUserToAddRows = false;
            this.dgvDanhSachTrangBi.AllowUserToResizeColumns = false;
            this.dgvDanhSachTrangBi.AllowUserToResizeRows = false;
            this.dgvDanhSachTrangBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTrangBi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachTrangBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTrangBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTB,
            this.TenTB,
            this.SoLuong,
            this.XoaTB});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachTrangBi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachTrangBi.Location = new System.Drawing.Point(25, 100);
            this.dgvDanhSachTrangBi.Name = "dgvDanhSachTrangBi";
            this.dgvDanhSachTrangBi.ReadOnly = true;
            this.dgvDanhSachTrangBi.RowHeadersVisible = false;
            this.dgvDanhSachTrangBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTrangBi.Size = new System.Drawing.Size(470, 306);
            this.dgvDanhSachTrangBi.TabIndex = 6;
            this.dgvDanhSachTrangBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTrangBi_CellClick);
            this.dgvDanhSachTrangBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTrangBi_CellContentClick);
            // 
            // MaTB
            // 
            this.MaTB.DataPropertyName = "MaTB";
            this.MaTB.FillWeight = 94.52784F;
            this.MaTB.HeaderText = "Mã Trang Bị";
            this.MaTB.Name = "MaTB";
            this.MaTB.ReadOnly = true;
            this.MaTB.Visible = false;
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.FillWeight = 206.8617F;
            this.TenTB.HeaderText = "Tên Trang Bị";
            this.TenTB.Name = "TenTB";
            this.TenTB.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 72.24995F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // XoaTB
            // 
            this.XoaTB.FillWeight = 26.36055F;
            this.XoaTB.HeaderText = "Xóa";
            this.XoaTB.Image = global::QuanLyKhachSan.Properties.Resources.remove;
            this.XoaTB.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.XoaTB.Name = "XoaTB";
            this.XoaTB.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bảng danh sách các trang bị của phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Phòng";
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTenPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(101, 19);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(121, 25);
            this.cboTenPhong.TabIndex = 0;
            this.cboTenPhong.SelectedIndexChanged += new System.EventHandler(this.cboTenPhong_SelectedIndexChanged);
            // 
            // txtSoLuongTB
            // 
            this.txtSoLuongTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTB.Location = new System.Drawing.Point(111, 58);
            this.txtSoLuongTB.Name = "txtSoLuongTB";
            this.txtSoLuongTB.Size = new System.Drawing.Size(173, 25);
            this.txtSoLuongTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Trang Bị:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 43);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(197, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(445, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "QUẢN LÝ CÁC TRANG BỊ PHÒNG KHÁCH SẠN";
            // 
            // cboTenTrangBi
            // 
            this.cboTenTrangBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenTrangBi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTenTrangBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenTrangBi.FormattingEnabled = true;
            this.cboTenTrangBi.Location = new System.Drawing.Point(111, 19);
            this.cboTenTrangBi.Name = "cboTenTrangBi";
            this.cboTenTrangBi.Size = new System.Drawing.Size(173, 25);
            this.cboTenTrangBi.TabIndex = 11;
            // 
            // pnlThemTrangBiTheoPhong
            // 
            this.pnlThemTrangBiTheoPhong.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnOK);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnThem_TroVe);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.cboTenTrangBi);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.txtSoLuongTB);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.label2);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.label3);
            this.pnlThemTrangBiTheoPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThemTrangBiTheoPhong.Location = new System.Drawing.Point(0, 43);
            this.pnlThemTrangBiTheoPhong.Name = "pnlThemTrangBiTheoPhong";
            this.pnlThemTrangBiTheoPhong.Size = new System.Drawing.Size(296, 416);
            this.pnlThemTrangBiTheoPhong.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(111, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 28);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnThem_TroVe
            // 
            this.btnThem_TroVe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_TroVe.Location = new System.Drawing.Point(208, 115);
            this.btnThem_TroVe.Name = "btnThem_TroVe";
            this.btnThem_TroVe.Size = new System.Drawing.Size(76, 28);
            this.btnThem_TroVe.TabIndex = 12;
            this.btnThem_TroVe.Text = "Trở Về";
            this.btnThem_TroVe.UseVisualStyleBackColor = true;
            this.btnThem_TroVe.Click += new System.EventHandler(this.btnThem_TroVe_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 23.2593F;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = global::QuanLyKhachSan.Properties.Resources.remove;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 36;
            // 
            // frmTrangBiTheoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.pnlThemTrangBiTheoPhong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangBiTheoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG BỊ TỪNG PHÒNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlThemTrangBiTheoPhong.ResumeLayout(false);
            this.pnlThemTrangBiTheoPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDanhSachTrangBi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongTB;
        private System.Windows.Forms.ComboBox cboTenTrangBi;
        private System.Windows.Forms.Panel pnlThemTrangBiTheoPhong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThem_TroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewImageColumn XoaTB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
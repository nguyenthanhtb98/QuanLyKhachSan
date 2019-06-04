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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangBiTheoPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhSachTrangBi = new System.Windows.Forms.DataGridView();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenTrangBi = new System.Windows.Forms.ComboBox();
            this.pnlThemTrangBiTheoPhong = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).BeginInit();
            this.pnlThemTrangBiTheoPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.dgvDanhSachTrangBi);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 437);
            this.panel1.TabIndex = 0;
            // 
            // dgvDanhSachTrangBi
            // 
            this.dgvDanhSachTrangBi.AllowUserToAddRows = false;
            this.dgvDanhSachTrangBi.AllowUserToResizeColumns = false;
            this.dgvDanhSachTrangBi.AllowUserToResizeRows = false;
            this.dgvDanhSachTrangBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachTrangBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTrangBi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachTrangBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTrangBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTB,
            this.TenTB,
            this.SoLuong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachTrangBi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachTrangBi.Location = new System.Drawing.Point(325, 40);
            this.dgvDanhSachTrangBi.Name = "dgvDanhSachTrangBi";
            this.dgvDanhSachTrangBi.ReadOnly = true;
            this.dgvDanhSachTrangBi.RowHeadersVisible = false;
            this.dgvDanhSachTrangBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTrangBi.Size = new System.Drawing.Size(660, 350);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Phòng:";
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTenPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(114, 168);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(169, 25);
            this.cboTenPhong.TabIndex = 0;
            this.cboTenPhong.SelectedIndexChanged += new System.EventHandler(this.cboTenPhong_SelectedIndexChanged);
            // 
            // txtSoLuongTB
            // 
            this.txtSoLuongTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTB.Location = new System.Drawing.Point(114, 252);
            this.txtSoLuongTB.Name = "txtSoLuongTB";
            this.txtSoLuongTB.Size = new System.Drawing.Size(169, 25);
            this.txtSoLuongTB.TabIndex = 10;
            this.txtSoLuongTB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Trang Bị:";
            // 
            // cboTenTrangBi
            // 
            this.cboTenTrangBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenTrangBi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTenTrangBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenTrangBi.FormattingEnabled = true;
            this.cboTenTrangBi.Location = new System.Drawing.Point(114, 210);
            this.cboTenTrangBi.Name = "cboTenTrangBi";
            this.cboTenTrangBi.Size = new System.Drawing.Size(169, 25);
            this.cboTenTrangBi.TabIndex = 11;
            // 
            // pnlThemTrangBiTheoPhong
            // 
            this.pnlThemTrangBiTheoPhong.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnThem);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnSua);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnTroVe);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.btnXoa);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.label4);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.cboTenPhong);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.cboTenTrangBi);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.txtSoLuongTB);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.label2);
            this.pnlThemTrangBiTheoPhong.Controls.Add(this.label3);
            this.pnlThemTrangBiTheoPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThemTrangBiTheoPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlThemTrangBiTheoPhong.Name = "pnlThemTrangBiTheoPhong";
            this.pnlThemTrangBiTheoPhong.Size = new System.Drawing.Size(296, 437);
            this.pnlThemTrangBiTheoPhong.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(28, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 38);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(151, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 38);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Appearance.Options.UseFont = true;
            this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.ImageOptions.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(151, 101);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 38);
            this.btnTroVe.TabIndex = 29;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click_2);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(28, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 38);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.ClientSize = new System.Drawing.Size(1015, 437);
            this.Controls.Add(this.pnlThemTrangBiTheoPhong);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangBiTheoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang bị từng phòng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).EndInit();
            this.pnlThemTrangBiTheoPhong.ResumeLayout(false);
            this.pnlThemTrangBiTheoPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDanhSachTrangBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuongTB;
        private System.Windows.Forms.ComboBox cboTenTrangBi;
        private System.Windows.Forms.Panel pnlThemTrangBiTheoPhong;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}
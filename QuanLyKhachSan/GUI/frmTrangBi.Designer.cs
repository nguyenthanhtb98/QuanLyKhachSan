namespace QuanLyKhachSan.GUI
{
    partial class frmTrangBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangBi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhSachTrangBi = new System.Windows.Forms.DataGridView();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTroVe);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txtTenTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 471);
            this.panel2.TabIndex = 1;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Appearance.Options.UseFont = true;
            this.btnTroVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(153, 97);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 38);
            this.btnTroVe.TabIndex = 19;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(30, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 38);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(30, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 38);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(153, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 38);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(30, 201);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(212, 20);
            this.txtTenTB.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.dgvDanhSachTrangBi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 471);
            this.panel3.TabIndex = 2;
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
            this.TenTB});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachTrangBi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachTrangBi.Location = new System.Drawing.Point(32, 36);
            this.dgvDanhSachTrangBi.Name = "dgvDanhSachTrangBi";
            this.dgvDanhSachTrangBi.ReadOnly = true;
            this.dgvDanhSachTrangBi.RowHeadersVisible = false;
            this.dgvDanhSachTrangBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTrangBi.Size = new System.Drawing.Size(713, 409);
            this.dgvDanhSachTrangBi.TabIndex = 7;
            this.dgvDanhSachTrangBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTrangBi_CellClick);
            // 
            // MaTB
            // 
            this.MaTB.DataPropertyName = "MaTB";
            this.MaTB.FillWeight = 94.52784F;
            this.MaTB.HeaderText = "Mã Trang Bị";
            this.MaTB.Name = "MaTB";
            this.MaTB.ReadOnly = true;
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.FillWeight = 206.8617F;
            this.TenTB.HeaderText = "Tên Trang Bị";
            this.TenTB.Name = "TenTB";
            this.TenTB.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên trang bị:";
            // 
            // frmTrangBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmTrangBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangBi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhSachTrangBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Label label1;
    }
}
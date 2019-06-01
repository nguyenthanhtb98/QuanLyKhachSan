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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.btnXoaTrangBi = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnSuaTrangBi = new System.Windows.Forms.Button();
            this.btnThemTrangBi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachTrangBi = new System.Windows.Forms.DataGridView();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 65);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(174, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "QUẢN LÝ CÁC TRANG BỊ KHÁCH SẠN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTenTB);
            this.panel2.Controls.Add(this.btnXoaTrangBi);
            this.panel2.Controls.Add(this.btnTroVe);
            this.panel2.Controls.Add(this.btnSuaTrangBi);
            this.panel2.Controls.Add(this.btnThemTrangBi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 368);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên Trang Bị";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(16, 155);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(201, 25);
            this.txtTenTB.TabIndex = 13;
            // 
            // btnXoaTrangBi
            // 
            this.btnXoaTrangBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTrangBi.Location = new System.Drawing.Point(116, 34);
            this.btnXoaTrangBi.Name = "btnXoaTrangBi";
            this.btnXoaTrangBi.Size = new System.Drawing.Size(89, 31);
            this.btnXoaTrangBi.TabIndex = 11;
            this.btnXoaTrangBi.Text = "Xóa";
            this.btnXoaTrangBi.UseVisualStyleBackColor = true;
            this.btnXoaTrangBi.Click += new System.EventHandler(this.btnXoaTrangBi_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(116, 71);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(89, 31);
            this.btnTroVe.TabIndex = 10;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnSuaTrangBi
            // 
            this.btnSuaTrangBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTrangBi.Location = new System.Drawing.Point(22, 71);
            this.btnSuaTrangBi.Name = "btnSuaTrangBi";
            this.btnSuaTrangBi.Size = new System.Drawing.Size(89, 31);
            this.btnSuaTrangBi.TabIndex = 9;
            this.btnSuaTrangBi.Text = "Sửa";
            this.btnSuaTrangBi.UseVisualStyleBackColor = true;
            this.btnSuaTrangBi.Click += new System.EventHandler(this.btnSuaTrangBi_Click);
            // 
            // btnThemTrangBi
            // 
            this.btnThemTrangBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTrangBi.Location = new System.Drawing.Point(22, 34);
            this.btnThemTrangBi.Name = "btnThemTrangBi";
            this.btnThemTrangBi.Size = new System.Drawing.Size(89, 31);
            this.btnThemTrangBi.TabIndex = 8;
            this.btnThemTrangBi.Text = "Thêm";
            this.btnThemTrangBi.UseVisualStyleBackColor = true;
            this.btnThemTrangBi.Click += new System.EventHandler(this.btnThemTrangBi_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgvDanhSachTrangBi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(228, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 368);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Các trang bị đang có của khách sạn";
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
            this.dgvDanhSachTrangBi.Location = new System.Drawing.Point(20, 47);
            this.dgvDanhSachTrangBi.Name = "dgvDanhSachTrangBi";
            this.dgvDanhSachTrangBi.ReadOnly = true;
            this.dgvDanhSachTrangBi.RowHeadersVisible = false;
            this.dgvDanhSachTrangBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTrangBi.Size = new System.Drawing.Size(429, 309);
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
            // frmTrangBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangBi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTrangBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaTrangBi;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnSuaTrangBi;
        private System.Windows.Forms.Button btnThemTrangBi;
        private System.Windows.Forms.DataGridView dgvDanhSachTrangBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
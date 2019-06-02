using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmTaiKhoan : Form
    {
        private DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
            dgvDanhSachTaiKhoan.DataSource = dal_TaiKhoan.ThongTinCacTaiKhoan();
            
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTK = txtTenTK.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            if(rdiAdmin.Checked == true)
            {
                tk.Quyen = "Admin";
            }
            else tk.Quyen = "Nhân Viên";
            int kq = dal_TaiKhoan.ThemTaiKhoan(tk);
            if(kq == 1)
            {
                dgvDanhSachTaiKhoan.DataSource = dal_TaiKhoan.ThongTinCacTaiKhoan();
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTK = txtTenTK.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            if (rdiAdmin.Checked == true)
            {
                tk.Quyen = "Admin";
            }
            else tk.Quyen = "Nhân Viên";
            dal_TaiKhoan.SuaTaiKhoan(tk);
            dgvDanhSachTaiKhoan.DataSource = dal_TaiKhoan.ThongTinCacTaiKhoan();
            MessageBox.Show("Sửa tài khoản thành công!");
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTK = txtTenTK.Text.Trim();
            dal_TaiKhoan.XoaTaiKhoan(tk);
            dgvDanhSachTaiKhoan.DataSource = dal_TaiKhoan.ThongTinCacTaiKhoan();
            MessageBox.Show("Xóa tài khoản thành công!");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhSachTaiKhoan.CurrentCell.RowIndex;
            txtTenTK.Text = dgvDanhSachTaiKhoan.Rows[i].Cells[0].Value.ToString().Trim();
            txtMatKhau.Text = dgvDanhSachTaiKhoan.Rows[i].Cells[1].Value.ToString().Trim();
            if (dgvDanhSachTaiKhoan.Rows[i].Cells[2].Value.ToString().Trim() == "Admin")
            {
                rdiAdmin.Checked = true;
            }
            else rdiNhanVien.Checked = true;
        }



    }
}

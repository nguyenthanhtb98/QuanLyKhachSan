using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        private DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {       
            try
            {
                if(conn.GetValue("Select * from TAIKHOAN where TenTK = '"+ txtTenDangNhap.Text + "'" + "and MatKhau = " + "'" + txtMatKhau.Text + "'") != "")
                {
                    this.Hide();
                    dal_TaiKhoan.LayQuyenTaiKhoan(txtTenDangNhap.Text);
                    Form frm = new frmMenu(txtTenDangNhap.Text.Trim(),dal_TaiKhoan.LayQuyenTaiKhoan(txtTenDangNhap.Text));
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;

            }
            else txtMatKhau.UseSystemPasswordChar = true;
        }


    }
}

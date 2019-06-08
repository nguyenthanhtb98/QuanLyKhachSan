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
using QuanLyKhachSan.GUI;
using QuanLyKhachSan.Values_Object;

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
                    
                    //tạo đối tượng tài khoản để lưu thông tin
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.TenTK = txtTenDangNhap.Text;
                    taikhoan.MatKhau = txtMatKhau.Text;
                    taikhoan.Quyen = dal_TaiKhoan.LayQuyenTaiKhoan(txtTenDangNhap.Text);

                    //truyền thông tin tài khoản về form menu
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.LayThongTinTaiKhoan(taikhoan);
                    frm.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu ");
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

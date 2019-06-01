using QuanLyKhachSan.GUI;
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

namespace QuanLyKhachSan
{
    public partial class frmMenu : Form
    {
        private string TenTK;
        private string Quyen;
        public frmMenu(string tentk, string quyen)
        {
            InitializeComponent();
            TenTK = tentk;
            Quyen = quyen;
            lblTenTK.Text = TenTK;
        }

        private void ptrThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptrThuePhong_Click(object sender, EventArgs e)
        {
            frmThuePhong frmThuePhong = new frmThuePhong();
            frmThuePhong.ShowDialog();
        }

        private void ptrPhong_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frmPhong frm = new frmPhong();
                frm.ShowDialog();
            }
            else MessageBox.Show("Tài khoản cần có quyền admin để truy cập mục này!");

        }

        private void ptrKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void ptrTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frmTaiKhoan frm = new frmTaiKhoan();
                frm.ShowDialog();
            }
            else MessageBox.Show("Tài khoản cần có quyền admin để truy cập mục này!");

        }

        private void ptrDichVu_Click(object sender, EventArgs e)
        {
            frmSuDungDichVu frmsddv = new frmSuDungDichVu();
            frmsddv.ShowDialog();
        }

        private void ptrQuanLyTrangBiTheoPhong_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frmTrangBiTheoPhong frm = new frmTrangBiTheoPhong();
                frm.ShowDialog();
            }
            else MessageBox.Show("Tài khoản cần có quyền admin để truy cập mục này!");
        }

        private void ptrTrangBi_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frmTrangBi frm = new frmTrangBi();
                frm.ShowDialog();
            }
            else MessageBox.Show("Tài khoản cần có quyền admin để truy cập mục này!");
        }

        private void ptrThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}

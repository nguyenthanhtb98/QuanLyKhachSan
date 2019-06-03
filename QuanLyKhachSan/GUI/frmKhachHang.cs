using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Values_Object;

namespace QuanLyKhachSan.GUI
{
    public partial class frmKhachHang : Form
    {
        private DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = dal_KhachHang.ThongTinCacKhachHang();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhachHang.CurrentCell.RowIndex;
            txtTenKH.Text = dgvKhachHang.Rows[index].Cells["TenKH"].Value.ToString();
            if (dgvKhachHang.Rows[index].Cells["GioiTinh"].Value.ToString() == "Nam") rdiNam.Checked = true; else rdiNu.Checked = true;
            txtSDT.Text = dgvKhachHang.Rows[index].Cells["SDT"].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[index].Cells["Email"].Value.ToString();
            txtCMND.Text = dgvKhachHang.Rows[index].Cells["CMND"].Value.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string strTuKhoa = txtTimKiem.Text.Trim();
            dgvKhachHang.DataSource = dal_KhachHang.TimKiem(strTuKhoa);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        KhachHang kh = new KhachHang();
        //        kh.TenKH = txtTenKH.Text.Trim();
        //        if (rdiNam.Checked == true)
        //        {
        //            kh.GioiTinh = "Nam";
        //        }
        //        else kh.GioiTinh = "Nữ";
        //        kh.SDT = txtSDT.Text.Trim();
        //        kh.Email = txtEmail.Text.Trim();
        //        kh.CMND = txtCMND.Text.Trim();
        //        dal_KhachHang.ThemKhachHang(kh);
        //        dgvKhachHang.DataSource = dal_KhachHang.ThongTinCacKhachHang();
        //        MessageBox.Show("Thêm khách hàng thành công!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error" + ex.Message);
        //    }

        //}

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvKhachHang.CurrentCell.RowIndex;
                string str_makh = dgvKhachHang.Rows[i].Cells["MaKH"].Value.ToString().Trim();
                KhachHang kh = new KhachHang();
                kh.MaKH = str_makh;
                kh.TenKH = txtTenKH.Text.Trim();
                if (rdiNam.Checked == true)
                {
                    kh.GioiTinh = "Nam";
                }
                else kh.GioiTinh = "Nữ";
                kh.SDT = txtSDT.Text.Trim();
                kh.Email = txtEmail.Text.Trim();
                kh.CMND = txtCMND.Text.Trim();
                dal_KhachHang.SuaKhachHang(kh);

                dgvKhachHang.DataSource = dal_KhachHang.ThongTinCacKhachHang();
                MessageBox.Show("Sửa thông tin khách hàng thành công!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int i = dgvKhachHang.CurrentCell.RowIndex;
        //        string str_makh = dgvKhachHang.Rows[i].Cells["MaKH"].Value.ToString().Trim();
        //        KhachHang kh = new KhachHang();
        //        kh.MaKH = str_makh;
        //        kh.TenKH = txtTenKH.Text.Trim();
        //        dal_KhachHang.XoaKhachHang(kh);

        //        dgvKhachHang.DataSource = dal_KhachHang.ThongTinCacKhachHang();
        //        MessageBox.Show("Đã xóa khách hàng có mã " + kh.MaKH.Trim() + " và tên " + kh.TenKH.Trim() + " thành công!");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}

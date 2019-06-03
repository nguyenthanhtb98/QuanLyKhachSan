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
    public partial class frmTrangBi : Form
    {
        private DAL_TrangBi dal_TrangBi = new DAL_TrangBi();
        public frmTrangBi()
        {
            InitializeComponent();
            dgvDanhSachTrangBi.DataSource = dal_TrangBi.ThongTinTrangBi();
        }


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachTrangBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhSachTrangBi.CurrentCell.RowIndex;           
            txtTenTB.Text = dgvDanhSachTrangBi.Rows[i].Cells[1].Value.ToString().Trim();
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangBi tb = new TrangBi();
            tb.TenTB = txtTenTB.Text.Trim();
            dal_TrangBi.ThemTrangBi(tb);
            //cập nhật
            dgvDanhSachTrangBi.DataSource = dal_TrangBi.ThongTinTrangBi();
            MessageBox.Show("Thêm trang bị thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TrangBi tb = new TrangBi();
            tb.MaTB = dgvDanhSachTrangBi.Rows[dgvDanhSachTrangBi.CurrentCell.RowIndex].Cells["MaTB"].Value.ToString().Trim();
            tb.TenTB = txtTenTB.Text.Trim();
            dal_TrangBi.XoaTrangBi(tb);
            //cập nhật
            dgvDanhSachTrangBi.DataSource = dal_TrangBi.ThongTinTrangBi();
            MessageBox.Show("Xóa trang bị thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangBi tb = new TrangBi();
            tb.MaTB = dgvDanhSachTrangBi.Rows[dgvDanhSachTrangBi.CurrentCell.RowIndex].Cells["MaTB"].Value.ToString().Trim();
            tb.TenTB = txtTenTB.Text.Trim();
            dal_TrangBi.SuaTrangBi(tb);
            //cập nhật
            dgvDanhSachTrangBi.DataSource = dal_TrangBi.ThongTinTrangBi();
            MessageBox.Show("Sửa trang bị thành công!");
        }


    }
}

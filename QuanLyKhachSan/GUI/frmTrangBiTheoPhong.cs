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
    public partial class frmTrangBiTheoPhong : Form
    {
        private DAL_TrangBiTheoPhong dal_TrangBiTheoPhong = new DAL_TrangBiTheoPhong();
        private DAL_TrangBi dal_trangbi = new DAL_TrangBi();
        private DAL_Phong dal_phong = new DAL_Phong();
        public frmTrangBiTheoPhong()
        {
            InitializeComponent();
            //lấy thông tin cho combobox Tên Phòng và dgv Trang bị theo phòng
            cboTenPhong.DataSource = dal_phong.ThongTinCacPhong();
            cboTenPhong.DisplayMember = "TenPhong";
            cboTenPhong.ValueMember = "MaPhong";
            dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
           
            //lấy thông tin trang bị
            cboTenTrangBi.DataSource = dal_trangbi.ThongTinTrangBi();
            cboTenTrangBi.DisplayMember = "TenTB";
            cboTenTrangBi.ValueMember = "MaTB";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
        }

        private void dgvDanhSachTrangBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhSachTrangBi.CurrentCell.RowIndex;
        }


        private void btnThem_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvDanhSachTrangBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTroVe_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTrangBi.RowCount > 0)
            {
                int i = dgvDanhSachTrangBi.CurrentCell.RowIndex;
                TrangBiTheoPhong tb = new TrangBiTheoPhong();
                tb.MaPhong = cboTenPhong.SelectedValue.ToString().Trim();
                tb.MaTB = dgvDanhSachTrangBi.Rows[i].Cells["MaTB"].Value.ToString().Trim();
                //lưu tên trang bị xóa
                string strTenTB = dgvDanhSachTrangBi.Rows[i].Cells["TenTB"].Value.ToString().Trim();
                dal_TrangBiTheoPhong.XoaTrangBiChoPhong(tb);

                //cập nhật lại bảng danh sách

                dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
                MessageBox.Show("Xóa trang bị "+strTenTB+" của phòng thành công!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangBiTheoPhong tb = new TrangBiTheoPhong();
            tb.MaPhong = cboTenPhong.SelectedValue.ToString().Trim();
            tb.MaTB = cboTenTrangBi.SelectedValue.ToString().Trim();
            try
            {
                tb.SoLuong = Convert.ToInt32(txtSoLuongTB.Text);
            }
            catch (Exception)
            {

                tb.SoLuong = 1;
            }
            int ketqua = dal_TrangBiTheoPhong.ThemTrangBiChoPhong(tb);
            if (ketqua == 1)
            {
                dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
                MessageBox.Show("Thêm trang bị thành công!");
            }
            else
            {
                MessageBox.Show("Thêm trang bị thất bại! Trang bị này đã tồn tại");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachTrangBi.RowCount>0)
            {
                TrangBiTheoPhong tb = new TrangBiTheoPhong();
                tb.MaPhong = cboTenPhong.SelectedValue.ToString().Trim();
                tb.MaTB = cboTenTrangBi.SelectedValue.ToString().Trim();
                try
                {
                    tb.SoLuong = Convert.ToInt32(txtSoLuongTB.Text);
                }
                catch (Exception)
                {
                    tb.SoLuong = 0;
                }
                int ketqua = dal_TrangBiTheoPhong.SuaSoLuongTrangBiChoPhong(tb);
                if (ketqua == 1)
                {
                    dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
                    MessageBox.Show("Sửa số lượng trang bị thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa số lượng trang bị thất bại! ");
                }
            }


        }
    }


}

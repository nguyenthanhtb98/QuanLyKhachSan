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
            int i = dgvDanhSachTrangBi.CurrentCell.RowIndex;
            TrangBiTheoPhong tb = new TrangBiTheoPhong();
            tb.MaPhong = cboTenPhong.SelectedValue.ToString().Trim();
            tb.MaTB = dgvDanhSachTrangBi.Rows[i].Cells[1].Value.ToString().Trim();
            dal_TrangBiTheoPhong.XoaDichVuChoPhong(tb);

            //cập nhật lại bảng danh sách
            dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TrangBiTheoPhong tb = new TrangBiTheoPhong();
            tb.MaPhong = cboTenPhong.SelectedValue.ToString().Trim();
            tb.MaTB = cboTenTrangBi.SelectedValue.ToString().Trim();
            tb.SoLuong = Convert.ToInt32(txtSoLuongTB.Text);
            //tạo 1 biến kết quả kiểm tra có thêm được trang bị cho phòng hay không, nếu trả về 0 nghĩa là đã tồn tại, cần tiến hành sửa thay vì thêm
            int ketqua = dal_TrangBiTheoPhong.ThemTrangBiChoPhong(tb);
            if (ketqua == 1) MessageBox.Show("Thêm Trang Bị Thành Công!");
            if (ketqua == 0)
            {
                dal_TrangBiTheoPhong.SuaDichVuChoPhong(tb);
                MessageBox.Show("Sửa Số Lượng Trang Bị Thành Công!");
            }
            //cập nhật lại bảng danh sách trang bị
            dgvDanhSachTrangBi.DataSource = dal_TrangBiTheoPhong.ThongTinCacTrangBiTheoMaPhong(cboTenPhong.SelectedValue.ToString().Trim());
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}

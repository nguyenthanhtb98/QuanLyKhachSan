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
    public partial class frmSuDungDichVu : Form
    {
        private DAL_DichVu dal_DichVu = new DAL_DichVu();
        private DAL_LoaiDV dal_LoaiDV = new DAL_LoaiDV();
        private DAL_SuDungDichVu dal_SDDV = new DAL_SuDungDichVu();
        private DAL_ThanhToan dal_ThanhToan = new DAL_ThanhToan();
        private DAL_PhieuThue dal_PhieuThue = new DAL_PhieuThue();
        public static int SDDV_SoLuong = 0; // tạo biến static để lấy dữ liệu từ form khác
        public frmSuDungDichVu()
        {          
            InitializeComponent();
            dgvKhachHang.DataSource = dal_ThanhToan.ThongTinCacKhachHangThuePhong();
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            if(dgvKhachHang.RowCount>0)
            {
                int i = dgvKhachHang.CurrentCell.RowIndex;
                string str_mapt = dgvKhachHang.Rows[i].Cells["MaPT"].Value.ToString().Trim();

                dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt);
            }
            //lấy tên các dịch vụ vào combo box
            cboLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu();
            cboLoaiDV.DisplayMember = "TenLDV";
            cboLoaiDV.ValueMember = "MaLDV";
            dgvTenDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
        }

        private void cboLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTenDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
        }
        // Thêm dịch vụ vào csdl bảng suwe dụng dịch vụ với thuộc tính mã phiếu thuê, mã dịch vụ, số lượng
        private void dgvTenDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvKhachHang.RowCount>0)
            {
                string str_mapt = dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells["MaPT"].Value.ToString().Trim();
                int i = dgvTenDV.CurrentCell.RowIndex;
                frmSDDV_SoLuong frmSDDV_SoLuong = new frmSDDV_SoLuong();
                frmSDDV_SoLuong.ShowDialog();
                //Nếu số lượng dịch vụ khác 0 thì thêm vào
                if (SDDV_SoLuong != 0)
                {
                    SuDungDichVu sddv = new SuDungDichVu();
                    sddv.MaPT = str_mapt;
                    sddv.MaDV = dgvTenDV.Rows[i].Cells[0].Value.ToString();
                    sddv.SoLuong = SDDV_SoLuong;

                    int ketqua = dal_SDDV.ThemSuDungDichVu(sddv); // thêm dịch vụ
                    if (ketqua == 0) dal_SDDV.SuaSuDungDichVu(sddv); // nếu có rồi thì sửa lại

                    // cập nhật lại dgv bảng các dịch vụ đã sử dụng
                    dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt);
                }

            }

        }

        private void btnSDDV_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Xóa dịch vụ đã dùng
        private void dgvDichVuDaSuDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str_mapt = dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells["MaPT"].Value.ToString().Trim();
            int i = dgvDichVuDaSuDung.CurrentCell.RowIndex; //lấy chỉ số hàng đang chọn
            SuDungDichVu sddv = new SuDungDichVu();
            sddv.MaDV = dgvDichVuDaSuDung.Rows[i].Cells[1].Value.ToString().Trim();
            sddv.MaPT = str_mapt;
            DialogResult result = MessageBox.Show("Bạn xác nhận xóa dịch vụ này chứ?", "Thông Báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                dal_SDDV.XoaSuDungDichVu(sddv);
                dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt);
            }
        }



        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentCell.RowIndex;
            string str_mapt = dgvKhachHang.Rows[i].Cells["MaPT"].Value.ToString().Trim();
            dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

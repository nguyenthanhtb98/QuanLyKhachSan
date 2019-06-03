using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Values_Object;

namespace QuanLyKhachSan.GUI
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        private DAL_DichVu dal_DichVu = new DAL_DichVu();
        private DAL_LoaiDV dal_LoaiDV = new DAL_LoaiDV();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvDV.Columns["GiaDV"].DefaultCellStyle.Format = "#,#";
            //lấy tên các dịch vụ vào combo box
            cboLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu();
            cboLoaiDV.DisplayMember = "TenLDV";
            cboLoaiDV.ValueMember = "MaLDV";
            //bắt lỗi không có loại dịch vụ nào
            try
            {
                dgvDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
            }
            catch (Exception)
            {
                dgvDV.DataSource = null;
            }

            if (dgvDV.RowCount>0)
            {            
                int i = dgvDV.CurrentCell.RowIndex;
                txtTenDV.Text = dgvDV.Rows[i].Cells["TenDV"].Value.ToString().Trim();
                txtGiaDV.Text = dgvDV.Rows[i].Cells["GiaDV"].Value.ToString().Trim();
            }

        }

        private void cboLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cboLoaiDV.SelectedValue.ToString()!= null) // tránh lối combo box trống
            {
                DichVu DV = new DichVu();
                DV.TenDV = txtTenDV.Text.Trim();
                try
                {
                    DV.GiaDV = Convert.ToInt32(txtGiaDV.Text.Trim());
                }
                catch (Exception)
                {

                    DV.GiaDV = 0;
                }
                
                DV.MaLDV = cboLoaiDV.SelectedValue.ToString().Trim();
                dal_DichVu.ThemDV(DV);
                //cập nhật
                dgvDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
                MessageBox.Show("Thêm loại dịch vụ thành công!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDV.RowCount>0)
            {
                DichVu DV = new DichVu();
                DV.MaDV = dgvDV.Rows[dgvDV.CurrentCell.RowIndex].Cells["MaDV"].Value.ToString().Trim();
                DV.TenDV = txtTenDV.Text.Trim();
                DV.GiaDV = Convert.ToInt32(txtGiaDV.Text.Trim());
                dal_DichVu.SuaDV(DV);
                //cập nhật
                dgvDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
                MessageBox.Show("Sửa  dịch vụ thành công!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDV.RowCount>0)
            {
                DichVu DV = new DichVu();
                DV.MaDV = dgvDV.Rows[dgvDV.CurrentCell.RowIndex].Cells["MaDV"].Value.ToString().Trim();

                int ketqua = dal_DichVu.XoaDV(DV);
                //cập nhật
                if (ketqua == 1)
                {
                    dgvDV.DataSource = dal_DichVu.ThongTinCacDichVuTheoMaLoaiDichVu(cboLoaiDV.SelectedValue.ToString().Trim());
                    MessageBox.Show("Xóa dịch vụ thành công!");
                }
                else MessageBox.Show("Xóa dịch vụ thất bại! Đang có khách hàng dùng dịch vụ này!");

            }


        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDV.CurrentCell.RowIndex;
            txtTenDV.Text = dgvDV.Rows[i].Cells["TenDV"].Value.ToString().Trim();
            txtGiaDV.Text = dgvDV.Rows[i].Cells["GiaDV"].Value.ToString().Trim();
        }
    }
}
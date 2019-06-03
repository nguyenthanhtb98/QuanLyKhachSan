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
using QuanLyKhachSan.Values_Object;
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan.GUI
{
    public partial class frmLoaiDV : DevExpress.XtraEditors.XtraForm
    {
        private DAL_LoaiDV dal_LoaiDV = new DAL_LoaiDV();
        public frmLoaiDV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiDV LDV = new LoaiDV();
            LDV.TenLoaiDV = txtTenLoaiDV.Text.Trim();
            dal_LoaiDV.ThemLoaiDV(LDV);
            //cập nhật
            dgvLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu();
            MessageBox.Show("Thêm loại dịch vụ thành công!");
        }

        private void frmLoaiDV_Load(object sender, EventArgs e)
        {
            dgvLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu();
            if(dgvLoaiDV.RowCount>0)
            {
                int i = dgvLoaiDV.CurrentCell.RowIndex;
                txtTenLoaiDV.Text = dgvLoaiDV.Rows[i].Cells[1].Value.ToString().Trim();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvLoaiDV.RowCount>0)
            {
                LoaiDV LDV = new LoaiDV();
                LDV.MaLoaiDV = dgvLoaiDV.Rows[dgvLoaiDV.CurrentCell.RowIndex].Cells["MaLDV"].Value.ToString().Trim();
                LDV.TenLoaiDV = txtTenLoaiDV.Text.Trim();
                dal_LoaiDV.SuaLoaiDV(LDV);
                //cập nhật
                dgvLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu();
                MessageBox.Show("Sửa loại dịch vụ thành công!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvLoaiDV.RowCount>0)
            {
                LoaiDV LDV = new LoaiDV();
                LDV.MaLoaiDV = dgvLoaiDV.Rows[dgvLoaiDV.CurrentCell.RowIndex].Cells["MaLDV"].Value.ToString().Trim();

                int ketqua = dal_LoaiDV.XoaLoaiDV(LDV);
                //cập nhật
                if (ketqua == 1)
                {
                    dgvLoaiDV.DataSource = dal_LoaiDV.ThongTinCacLoaiDichVu(); ;
                    MessageBox.Show("Xóa loại dịch vụ thành công!");
                }
                else MessageBox.Show("Xóa loại dịch vụ thất bại! Cần xóa tất cả các dịch vụ thuộc loại này trước");


            }

        }

        private void dgvLoaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoaiDV.CurrentCell.RowIndex;
            txtTenLoaiDV.Text = dgvLoaiDV.Rows[i].Cells[1].Value.ToString().Trim();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class frmPhong : Form
    {
        private DataTable dt = new DataTable();
        private DAL_Phong dal_phong = new DAL_Phong();
        private DAL_LoaiPhong dal_loaiphong = new DAL_LoaiPhong();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = dal_phong.ThongTinCacPhong();
            dgvPhong.Columns["GiaTheoGio"].DefaultCellStyle.Format = "#,#";
            dgvPhong.Columns["GiaTheoNgay"].DefaultCellStyle.Format = "#,#";
            cboLoaiPhong.DataSource = dal_loaiphong.ThongTinCacLoaiPhong();
            cboLoaiPhong.DisplayMember = "TenLP";
            cboLoaiPhong.ValueMember = "MaLP";
            if(dgvPhong.RowCount>0) //lấy thông tin dòng đầu
            {
                int index = dgvPhong.CurrentCell.RowIndex;
                txtTenPhong.Text = dgvPhong.Rows[index].Cells[1].Value.ToString();
                cboTrangThaiPhong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
                txtGiaTheoGio.Text = dgvPhong.Rows[index].Cells[3].Value.ToString();
                txtGiaTheoNgay.Text = dgvPhong.Rows[index].Cells[4].Value.ToString();
                cboLoaiPhong.Text = dgvPhong.Rows[index].Cells[5].Value.ToString();
            }

        }


        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhong.CurrentCell.RowIndex;
            txtTenPhong.Text = dgvPhong.Rows[index].Cells[1].Value.ToString();
            cboTrangThaiPhong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
            txtGiaTheoGio.Text = dgvPhong.Rows[index].Cells[3].Value.ToString();
            txtGiaTheoNgay.Text = dgvPhong.Rows[index].Cells[4].Value.ToString(); 
            cboLoaiPhong.Text = dgvPhong.Rows[index].Cells[5].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Phong Phong = new Phong();
                Phong.GiaTheoGio = Convert.ToInt32(txtGiaTheoGio.Text);
                Phong.GiaTheoNgay = Convert.ToInt32(txtGiaTheoNgay.Text);
                Phong.TenPhong = txtTenPhong.Text;
                Phong.MaLP = cboLoaiPhong.SelectedValue.ToString();
                dal_phong.ThemPhong(Phong);
                dgvPhong.DataSource = dal_phong.ThongTinCacPhong();
                MessageBox.Show("Đã Thêm Thành Công!");

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvPhong.CurrentCell.RowIndex;
                Phong p = new Phong();
                p.MaPhong = dgvPhong.Rows[i].Cells["MaPhong"].Value.ToString();
                p.TenPhong = txtTenPhong.Text;
                p.TrangThai = cboTrangThaiPhong.Text;
                p.GiaTheoGio = Convert.ToInt32(txtGiaTheoGio.Text);
                p.GiaTheoNgay = Convert.ToInt32(txtGiaTheoNgay.Text);
                p.MaLP = cboLoaiPhong.SelectedValue.ToString();
                dal_phong.SuaPhong(p);
                dgvPhong.DataSource = dal_phong.ThongTinCacPhong();
                MessageBox.Show("Sửa thông tin phòng thành công!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvPhong.CurrentCell.RowIndex;
                if(dgvPhong.Rows[i].Cells["MaPT"].Value.ToString() == "")
                {
                    Phong p = new Phong();
                    p.MaPhong = dgvPhong.Rows[i].Cells["MaPhong"].Value.ToString();
                    dal_phong.XoaPhong(p);
                    dgvPhong.DataSource = dal_phong.ThongTinCacPhong();
                    MessageBox.Show("Xóa phòng có mã " + p.MaPhong.Trim() + " thành công");
                }
                else
                {
                    MessageBox.Show("Phòng này có người thuê nên không thể xóa !!!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strTuKhoa = txtTimKiem.Text.Trim();
            dgvPhong.DataSource = dal_phong.TimKiem(strTuKhoa);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }
    }
}

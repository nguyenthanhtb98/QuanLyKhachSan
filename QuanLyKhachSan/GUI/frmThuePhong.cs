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
    public partial class frmThuePhong : Form
    {
        private DAL_Phong dal_phong = new DAL_Phong();
        private DAL_LoaiPhong dal_loaiphong = new DAL_LoaiPhong();
        private DAL_KhachHang dal_khachhang = new DAL_KhachHang();
        private DAL_PhieuThue dal_phieuthue = new DAL_PhieuThue();
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            dgvThuePhong.DataSource = dal_phong.ThongTinCacPhongConTrong();
        }


        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanThue_Click_1(object sender, EventArgs e)
        {
            int dem = 0; // số phòng mà khách chọn
            foreach (DataGridViewRow row in dgvThuePhong.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if ((Boolean)row.Cells[0].Value == true)
                    {
                        dem++;
                    }
                }
            }
            if(dem>0)
            {
                //Thêm khách hàng mới
                KhachHang kh = new KhachHang();
                kh.TenKH = txtTenKH.Text;
                if (rdiNam.Checked == true)
                {
                    kh.GioiTinh = "Nam";
                }
                else kh.GioiTinh = "Nữ";
                kh.SDT = txtSDT.Text;
                kh.Email = txtEmail.Text;
                kh.CMND = txtCMND.Text;
                dal_khachhang.ThemKhachHang(kh);
                string str_MaKHVuaThem = dal_khachhang.LayMaKHVuaThem();
                //Thêm vào bảng Phiếu thuê mã khách hàng, ngày đén ngày đi, hình thức thuê
                PhieuThue PT = new PhieuThue();
                PT.MaKH = str_MaKHVuaThem;
                PT.NgayDen = dateNgayDen.Value;
                PT.NgayDi = dateNgayDi.Value;
                PT.HinhThucThue = cboHinhThucThue.Text;
                dal_phieuthue.ThemPhieuThue(PT);
                string str_MaPTVuaThem = dal_phieuthue.LayMaPTVuaThem();
                //Update bảng phòng
                foreach (DataGridViewRow row in dgvThuePhong.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if ((Boolean)row.Cells[0].Value == true)
                        {
                            Phong P = new Phong();
                            P.MaPhong = row.Cells[1].Value.ToString().Trim();
                            P.TrangThai = "Đã bị thuê";
                            P.MaPT = str_MaPTVuaThem;
                            dal_phong.SuaPhongSauKhiThue(P);
                        }
                    }
                }
                MessageBox.Show("Thuê phòng thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn phòng");
            }

        }
    }
}

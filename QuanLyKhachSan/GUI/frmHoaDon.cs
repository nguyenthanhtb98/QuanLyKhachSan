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
    public partial class frmHoaDon : Form
    {
        private DAL_ThanhToan dal_ThanhToan = new DAL_ThanhToan();
        private DAL_Phong dal_Phong = new DAL_Phong();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void ThongTinHoaDon(HoaDon hd)
        {
            lblTenKH.Text = hd.TenKH;
            lblGioiTinh.Text = hd.GioiTinh;
            lblSDT.Text = hd.SDT;
            lblEmail.Text = hd.Email;
            lblCMND.Text = hd.CMND;
            lblTienDV.Text = hd.TienDV.ToString();
            lblTienPhong.Text = hd.TienPhong.ToString();
            lblTongTienTT.Text = hd.TongTienTT.ToString();

            lblNgayTT.Text = DateTime.Now.ToString();
        }
        private string MaPT; //tạo biến lưu mã phiếu thuê từ form Thanh toán
        
        public void LayMaPT(string str)
        {
            MaPT = str;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //các nội dung cần thay đổi khi thanh toán: Thông tin về trạng thái của phòng
            //Thay đổi thông tin phiếu thuê
            //chèn dữ liệu vào bảng thanh toán: thông tin gồm: Mã phiếu thanh toán, Mã phiếu thuê, tổng tiền thanh toán, ngày thanh toán
      
            //thêm thông tin vào bảng phiếu thanh toán
            PhieuThanhToan ptt = new PhieuThanhToan();
            ptt.TongTienTT = Convert.ToInt32(lblTienPhong.Text) + Convert.ToInt32(lblTienDV.Text);
            ptt.NgayTT = Convert.ToDateTime(lblNgayTT.Text);
            ptt.MaPT = MaPT;
            dal_ThanhToan.ThemPhieuThanhToan(ptt); 

            //sửa lại thông tin các phòng sau khi thanh toán, đặt trạng thái phòng về còn trống và đặt mã phiếu thuê về null
            dal_Phong.SuaCacPhongSauThanhToan(MaPT);

            MessageBox.Show("Thanh toán cho khách hàng này thành công!");
            this.Close();
        }

    }
}

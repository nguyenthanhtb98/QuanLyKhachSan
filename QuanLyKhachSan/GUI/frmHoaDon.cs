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
        private DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        private DAL_PhieuThue dal_PhieuThue = new DAL_PhieuThue();
        private DAL_SuDungDichVu dal_SDDV = new DAL_SuDungDichVu();
        private HoaDon HD = new HoaDon();

        public void LayDuLieuTuFormThanhToanVaoFormHoaDon(HoaDon _HD)
        {
            HD.MaPT = _HD.MaPT;
            HD.MaKH = _HD.MaKH;
            HD.TenKH = _HD.TenKH;
            HD.GioiTinh = _HD.GioiTinh;
            HD.Email = _HD.Email;
            HD.SDT = _HD.SDT;
            HD.CMND = _HD.CMND;
            HD.TienDV = _HD.TienDV;
            HD.TienPhong = _HD.TienPhong;
            HD.TongTienTT = _HD.TongTienTT;
            HD.NgayTT = _HD.NgayTT;
        }
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void HienThiThongTinHoaDon()
        {
            lblTenKH.Text = HD.TenKH;
            lblGioiTinh.Text = HD.GioiTinh;
            lblSDT.Text = HD.SDT;
            lblEmail.Text = HD.Email;
            lblCMND.Text = HD.CMND;
            lblTienDV.Text = HD.TienDV.ToString();
            lblTienPhong.Text = HD.TienPhong.ToString();
            lblTongTienTT.Text = HD.TongTienTT.ToString();
            lblNgayTT.Text = HD.NgayTT.ToString();
        }
        //private string MaPT; //tạo biến lưu mã phiếu thuê từ form Thanh toán
        
        //public void LayMaPT(string str)
        //{
        //    MaPT = str;
        //}
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //các nội dung cần thay đổi khi thanh toán: Thông tin về trạng thái của phòng
            //Xóa thông tin khách hàng trong bảng khách hàng,sử dụng dịch vụ trong bảng SDDV, xóa thông tin phiếu thuê trong bảng phiếu thuê
            //chèn dữ liệu vào bảng thanh toán: thông tin gồm: tên khách hàng, giới tính, ngày thanh toán, sđt, tổng tiền
      
            //thêm thông tin vào bảng phiếu thanh toán
            PhieuThanhToan ptt = new PhieuThanhToan();
            ptt.TenKH = HD.TenKH;
            ptt.GioiTinh = HD.GioiTinh;
            ptt.NgayTT = HD.NgayTT;
            ptt.SDT = HD.SDT;
            ptt.TongTienTT = HD.TongTienTT;

            dal_ThanhToan.ThemPhieuThanhToan(ptt); 

            //sửa lại thông tin các phòng sau khi thanh toán, đặt trạng thái phòng về còn trống và đặt mã phiếu thuê về null
            dal_Phong.SuaCacPhongSauThanhToan(HD.MaPT);
            //xóa thông tin sử dụng dịch vụ
            SuDungDichVu SDDV = new SuDungDichVu();
            SDDV.MaPT = HD.MaPT;
            dal_SDDV.XoaSuDungDichVuTheoMaPT(SDDV);

            //xóa thông tin phiếu thuê trong CSDL
            PhieuThue PT = new PhieuThue();
            PT.MaPT = HD.MaPT;
            dal_PhieuThue.XoaPhieuThue(PT);
            //xóa thông tin khách hàng đã lưu trong CSDL
            KhachHang kh = new KhachHang();
            kh.MaKH = HD.MaKH;
            dal_KhachHang.XoaKhachHang(kh);

            MessageBox.Show("Thanh toán cho khách hàng này thành công!");
            this.Close();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiThongTinHoaDon();
        }
    }
}

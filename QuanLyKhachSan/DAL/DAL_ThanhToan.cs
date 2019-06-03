using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_ThanhToan
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinCacKhachHangThuePhong()
        {
            return conn.GetDataTable("select distinct PHIEUTHUE.MaPT, PHIEUTHUE.MaKH, TenKH, GioiTinh, Email, SDT, CMND, NgayDen, NgayDi, HinhThucThue from KHACHHANG,PHIEUTHUE,PHONG where KHACHHANG.MaKH = PHIEUTHUE.MaKH and PHIEUTHUE.MaPT = PHONG.MaPT");
        }

        public DataTable ThongTinCacPhongThueTheoMaPT(string str)
        {
            return conn.GetDataTable("select PHONG.MaPhong, PHONG.TenPhong, PHONG.GiaTheoGio, PHONG.GiaTheoNgay from PHONG, PHIEUTHUE where PHONG.MaPT = PHIEUTHUE.MaPT and PHIEUTHUE.MaPT = '"+str+"'");
        }

        public int ThemPhieuThanhToan(PhieuThanhToan ptt)
        {
            return conn.ThucHienLenh("ThemPhieuThanhToan N'" + ptt.TenKH + "',N'" + ptt.GioiTinh + "','" + ptt.SDT + "','"+ptt.NgayTT+"','"+ptt.TongTienTT+"'");
        }
        /// <summary>
        /// Hàm lấy tổng tiền dịch vụ theo mã phiếu thuê
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int TinhTienDichVu(string str_mapt)
        {
            string str = "select dbo.TinhTienDVTheoMaPT('"+str_mapt+"')";
            return conn.LayGiaTriCuaHamTraVeKieuInt(str);
        }
        public int TinhTienPhong(string str_mapt)
        {
            string str = "select dbo.TinhTienPhongTheoMaPT('" + str_mapt + "')";
            return conn.LayGiaTriCuaHamTraVeKieuInt(str);
        }

    }
}

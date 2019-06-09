using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_KhachHang
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        /// <summary>
        /// Trả về datatable chứa dữ liệu các khách hàng
        /// </summary>
        /// <returns></returns>
        public DataTable ThongTinCacKhachHang()
        {
            return conn.GetDataTable("select MaKH, TenKH, GioiTinh, SDT, CMND, Email, SoNguoi from KHACHHANG");
        }

        /// <summary>
        /// hàm này sử dụng khi thuê phòng
        /// </summary>
        public string LayMaKHVuaThem()
        {
            return conn.GetValue("select Max(MaKH) from KHACHHANG");
        }
        public int ThemKhachHang(KhachHang kh)
        {
            return conn.ThucHienLenh("execute ThemKhachHang N'" + kh.TenKH + "',N'" +kh.GioiTinh+ "','" + kh.SDT + "','" + kh.CMND +"','" +kh.Email+ "','"+kh.SoNguoi+"'");
            //return conn.ThucHienLenh("Insert into KHACHHANG(TenKH, GioiTinh, SDT, CMND, Email) values(N'" + kh.TenKH + "',N'" +kh.GioiTinh+ "','" + kh.SDT + "','" + kh.CMND +"','" +kh.Email+ "')");
        }

        public int SuaKhachHang(KhachHang kh)
        {
            return conn.ThucHienLenh("Update KHACHHANG set TenKH = N'" + kh.TenKH + "',GioiTinh = N'" + kh.GioiTinh + "',SDT = '" + kh.SDT + "',CMND = '" + kh.CMND + "',Email = '" + kh.Email + "', SoNguoi = '"+kh.SoNguoi+"' where MaKH = '" +kh.MaKH+ "'");
        }

        public int XoaKhachHang(KhachHang kh)
        {
            return conn.ThucHienLenh("Delete from KHACHHANG where MaKH = '" + kh.MaKH + "'");
        }

        public DataTable TimKiem(string strTuKhoa)
        {
            if(strTuKhoa == "")
            {
                return conn.GetDataTable("select MaKH, TenKH, GioiTinh, SDT, CMND, Email, SoNguoi from KHACHHANG");
            }
            return conn.GetDataTable("select MaKH, TenKH, GioiTinh, SDT, CMND, Email,SoNguoi from KHACHHANG where TenKH like N'%"+strTuKhoa+"%'");
        }

    }
}

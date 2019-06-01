using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_Phong
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinCacPhong()
        {
            return conn.GetDataTable("select PHONG.MaPhong,TenPhong,TrangThai,GiaTheoGio, GiaTheoNgay,TenLP from PHONG,LOAIPHONG where PHONG.MaLP=LOAIPHONG.MaLP order by PHONG.MaPhong");
        }
        public DataTable ThongTinCacPhongConTrong()
        {
            return conn.GetDataTable("select PHONG.MaPhong,TenPhong,TrangThai,GiaTheoGio, GiaTheoNgay,TenLP from PHONG,LOAIPHONG where PHONG.MaLP=LOAIPHONG.MaLP and TrangThai = N'Còn trống' order by PHONG.MaPhong");
        }
        public  int ThemPhong(Phong p)
        {
            return conn.ThucHienLenh("execute ThemPhong N'" + p.TenPhong + "',N'Còn Trống','" + p.GiaTheoGio + "','" + p.GiaTheoNgay + "','" + p.MaLP + "'");
            //return conn.ThucHienLenh("Insert into PHONG(MaPhong, TenPhong, TrangThai, GiaTheoGio, GiaTheoNgay, MaLP) values('" + p.MaPhong + "',N'" + p.TenPhong + "',N'Còn Trống','"+p.GiaTheoGio+"','" + p.GiaTheoNgay + "','" + p.MaLP + "')");
        }

        public int SuaPhong(Phong p)
        {
            return conn.ThucHienLenh("Update PHONG set TenPhong = N'"+p.TenPhong+"',TrangThai = N'"+ p.TrangThai+ "',GiaTheoGio = '"+ p.GiaTheoGio+"', GiaTheoNgay = '"+p.GiaTheoNgay+"', MaLP = '"+p.MaLP+"' where MaPhong = '"+p.MaPhong+"'");
        }

        public int SuaPhongSauKhiThue(Phong p)
        {
            return conn.ThucHienLenh("Update PHONG set TrangThai = N'" + p.TrangThai +  "',MaPT = '"+p.MaPT+"' where MaPhong = '" + p.MaPhong + "'");
        }
        /// <summary>
        /// sửa lại thông tin các phòng theo mã phiếu thuê sau khi thanh toán
        /// </summary>
        /// <param name="str_mapt"></param>
        /// <returns></returns>
        public int SuaCacPhongSauThanhToan(string str_mapt)
        {
            return conn.ThucHienLenh("Update PHONG set TrangThai = N'Còn trống', MaPT = NULL where MaPT = '" + str_mapt + "'");
        }

        public int XoaPhong(Phong p)
        {
            return conn.ThucHienLenh("Delete from PHONG where MaPhong = '"+p.MaPhong+"'");
        }

    }
}

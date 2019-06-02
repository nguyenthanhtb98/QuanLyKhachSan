using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_TrangBiTheoPhong
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinCacTrangBiTheoMaPhong(string str)
        {
            return conn.GetDataTable("select TRANGBI.MaTB, TenTB, SoLuong from TRANGBI,TRANGBITHEOPHONG where TRANGBI.MaTB =TRANGBITHEOPHONG.MaTB and MaPhong= '" + str + "'");
        }

        public int ThemTrangBiChoPhong(TrangBiTheoPhong tb)
        {
            return conn.ThucHienLenh("Insert into TRANGBITHEOPHONG(MaTB, MaPhong, SoLuong) values('" + tb.MaTB + "','" + tb.MaPhong + "','" + tb.SoLuong + "')");
        }

        public int SuaDichVuChoPhong(TrangBiTheoPhong tb)
        {
            return conn.ThucHienLenh("Update TRANGBITHEOPHONG set SoLuong = '" + tb.SoLuong + "' where MaPhong = '" + tb.MaPhong + "' and MaTB = '" + tb.MaTB + "'");
        }
        public int XoaDichVuChoPhong(TrangBiTheoPhong tb)
        {
            return conn.ThucHienLenh("Delete from TRANGBITHEOPHONG where MaPhong = '" + tb.MaPhong + "' and MaTB = '" + tb.MaTB + "'");
        }
    }
}

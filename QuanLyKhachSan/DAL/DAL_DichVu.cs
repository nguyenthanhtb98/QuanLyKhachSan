using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_DichVu
    {
        KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinCacDichVuTheoMaLoaiDichVu(string str)
        {
            return conn.GetDataTable("select MaDV, TenDV, GiaDV from DICHVU,LOAIDICHVU where DICHVU.MaLDV = LOAIDICHVU.MaLDV and DICHVU.MaLDV = '"+ str+"'");
        }

        public int ThemDV(DichVu DV)
        {
            return conn.ThucHienLenh("execute ThemDV N'" + DV.TenDV+ "','"+DV.GiaDV+"','"+DV.MaLDV+"'");
        }

        public int SuaDV(DichVu DV)
        {
            return conn.ThucHienLenh("Update DICHVU set TenDV = N'" + DV.TenDV + "', GiaDV = '"+DV.GiaDV+"' where MaDV = '" + DV.MaDV + "'");
        }

        public int XoaDV(DichVu DV)
        {
            return conn.ThucHienLenh("Delete from DICHVU where MaDV = '" + DV.MaDV + "'");
        }
    }
}

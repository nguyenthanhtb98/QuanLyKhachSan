using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_PhieuThue
    {
        KetNoiCSDL conn = new KetNoiCSDL();

        public DataTable ThongTinCacPhieuThue()
        {
            return conn.GetDataTable("Select * from PHIEUTHUE");
        }
        public int ThemPhieuThue(PhieuThue PT)
        {
            return conn.ThucHienLenh("execute ThemPhieuThue '" + PT.NgayDen + "','" + PT.NgayDi + "','" + PT.MaKH + "',N'" + PT.HinhThucThue + "'");
            //return conn.ThucHienLenh("Insert into PHIEUTHUE(NgayDen, NgayDi, MaKH, HinhThucThue) values('" +PT.NgayDen + "','"+ PT.NgayDi+"','" + PT.MaKH + "',N'" + PT.HinhThucThue + "')");
        }
        public string LayMaPTVuaThem()
        {
            return conn.GetValue("select Max(MaPT) from PHIEUTHUE");
        }
        public int SuaPhieuThue(PhieuThue PT)
        {
            return conn.ThucHienLenh("Update PHIEUTHUE Set NgayDi = '" + PT.NgayDi + "' where MaPT = '"+PT.MaPT+"'");
        }

        public int XoaPhieuThue(PhieuThue PT)
        {
            return conn.ThucHienLenh("Delete PHIEUTHUE where MaPT = '" + PT.MaPT + "'");
        }
    }
}

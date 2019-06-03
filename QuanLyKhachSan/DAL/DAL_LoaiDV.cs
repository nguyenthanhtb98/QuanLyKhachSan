using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_LoaiDV
    {
        KetNoiCSDL conn = new KetNoiCSDL();

        public DataTable ThongTinCacLoaiDichVu()
        {
            return conn.GetDataTable("select * from LOAIDICHVU");
        }

        public int ThemLoaiDV(LoaiDV LoaiDV)
        {
            return conn.ThucHienLenh("execute ThemLoaiDV N'"+LoaiDV.TenLoaiDV+"'");
        }

        public int SuaLoaiDV(LoaiDV LoaiDV)
        {
            return conn.ThucHienLenh("Update LOAIDICHVU set TenLDV = N'" + LoaiDV.TenLoaiDV + "' where MaLDV = '" + LoaiDV.MaLoaiDV + "'");
        }

        public int XoaLoaiDV(LoaiDV LoaiDV)
        {
            return conn.ThucHienLenh("Delete from LOAIDICHVU where MaLDV = '" + LoaiDV.MaLoaiDV + "'");
        }
    }
}

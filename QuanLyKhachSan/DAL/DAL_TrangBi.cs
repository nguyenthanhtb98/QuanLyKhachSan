
using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_TrangBi
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinTrangBi()
        {
            return conn.GetDataTable("select * from TRANGBI");
        }

        public int ThemTrangBi(TrangBi tb)
        {
            return conn.ThucHienLenh("execute ThemTrangBi N'" + tb.TenTB + "'");
            //return conn.ThucHienLenh("Insert into TRANGBI(MaTB, TenTB) values('" + tb.MaTB + "',N'" +tb.TenTB + "')");
        }

        public int SuaTrangBi(TrangBi tb)
        {
            return conn.ThucHienLenh("Update TRANGBI set TenTB = N'"+tb.TenTB+"' where MaTB = '"+tb.MaTB+"'");
        }

        public int XoaTrangBi(TrangBi tb)
        {
            return conn.ThucHienLenh("Delete from TRANGBI where MaTB = '"+tb.MaTB+"'");
        }
    }
}

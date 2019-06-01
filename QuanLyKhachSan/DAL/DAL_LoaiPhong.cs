using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_LoaiPhong
    {
        KetNoiCSDL conn = new KetNoiCSDL();

        
        public DataTable ThongTinCacLoaiPhong()
        {
            return conn.GetDataTable("select * from LOAIPHONG");
        }
        
    }
}

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
        
    }
}

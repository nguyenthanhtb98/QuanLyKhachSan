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
            return conn.GetDataTable("select MaDV, TenDV from DICHVU,LOAIDICHVU where DICHVU.MaLDV = LOAIDICHVU.MaLDV and DICHVU.MaLDV = '"+ str+"'");
        }
    }
}

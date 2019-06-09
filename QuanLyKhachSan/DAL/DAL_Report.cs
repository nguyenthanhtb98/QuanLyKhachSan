using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    // lớp này thực hiện những xử lý thống kê
    class DAL_Report
    {
        KetNoiCSDL conn = new KetNoiCSDL();

        public int TongTienDV()
        {
            string strTongTien= conn.GetValue("select SUM(TienDV) from PHIEUTHANHTOAN");
            int TongTien = 0;
            try
            {
                TongTien = Convert.ToInt32(strTongTien);
            }
            catch (Exception)
            {
                TongTien = 0;
                throw;
            }
            return TongTien;
        }

        public int TongTienPhong()
        {
            string strTongTien = conn.GetValue("select SUM(TienPhong) from PHIEUTHANHTOAN");
            int TongTien = 0;
            try
            {
                TongTien = Convert.ToInt32(strTongTien);
            }
            catch (Exception)
            {
                TongTien = 0;
                throw;
            }
            return TongTien;
        }

    }
}

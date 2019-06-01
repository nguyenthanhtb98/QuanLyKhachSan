using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class DAL_TaiKhoan
    {
        private KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinCacTaiKhoan()
        {
            return conn.GetDataTable("select * from TAIKHOAN");
        }
        public int ThemTaiKhoan(TaiKhoan tk)
        {
            return conn.ThucHienLenh("Insert into TAIKHOAN(TenTK, MatKhau, Quyen) values('" + tk.TenTK + "','" + tk.MatKhau + "','" + tk.Quyen + "')");
        }

        public int SuaTaiKhoan(TaiKhoan tk)
        {
            return conn.ThucHienLenh("Update TAIKHOAN set MatKhau = '" + tk.MatKhau + "', Quyen = '"+ tk.Quyen + "' where TenTK = '" + tk.TenTK + "'");
        }

        public int XoaTaiKhoan(TaiKhoan tk)
        {
            return conn.ThucHienLenh("Delete from TAIKHOAN where TenTK = '" + tk.TenTK + "'");
        }

        public string LayQuyenTaiKhoan(string str_tentk)
        {
            return conn.GetValue("select Quyen from TAIKHOAN where TenTK = '" + str_tentk + "'");
        }

    }
}

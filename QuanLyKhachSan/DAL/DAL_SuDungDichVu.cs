using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Values_Object;

namespace QuanLyKhachSan.DAL
{
    class DAL_SuDungDichVu
    {
        KetNoiCSDL conn = new KetNoiCSDL();
        public DataTable ThongTinSuDungDichVuTheoMaPhieuThue(string str)
        {
            return conn.GetDataTable("select DICHVU.MaDV, TenDV, GiaDV, SoLuong from SUDUNGDV, DICHVU where SUDUNGDV.MaDV = DICHVU.MaDV and SUDUNGDV.MaPT = '" + str + "'");
        }

        public int ThemSuDungDichVu(SuDungDichVu sddv)
        {
            return conn.ThucHienLenh("Insert SUDUNGDV(MaPT, MaDV, SoLuong) values('"+sddv.MaPT+"','"+sddv.MaDV+"','"+sddv.SoLuong+"')");
        }

        public int SuaSuDungDichVu(SuDungDichVu sddv)
        {
            return conn.ThucHienLenh("Update SUDUNGDV SET SoLuong='"+sddv.SoLuong+"'where MaPT='"+sddv.MaPT+"' and MaDV = '"+sddv.MaDV+"'");
        }

        public int XoaSuDungDichVu(SuDungDichVu sddv)
        {
            return conn.ThucHienLenh("Delete from SUDUNGDV where MaPT= '"+sddv.MaPT+"' and MaDV = '" + sddv.MaDV + "'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class PhieuThanhToan
    {
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }

        private string _GioiTinh;

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        //private string _CMND;

        //public string CMND
        //{
        //    get { return _CMND; }
        //    set { _CMND = value; }
        //}

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        //private string _Email;

        //public string Email
        //{
        //    get { return _Email; }
        //    set { _Email = value; }
        //}

        private int _TienPhong;

        public int TienPhong
        {
            get { return _TienPhong; }
            set { _TienPhong = value; }
        }

        private int _TienDV;

        public int TienDV
        {
            get { return _TienDV; }
            set { _TienDV = value; }
        }

        private DateTime _NgayTT;

        public DateTime NgayTT
        {
            get { return _NgayTT; }
            set { _NgayTT = value; }
        }

        private int _TongTienTT;

        public int TongTienTT
        {
            get { return _TongTienTT; }
            set { _TongTienTT = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class KhachHang
    {
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

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

        private string _CMND;

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private int _SoNguoi;

        public int SoNguoi
        {
            get { return _SoNguoi; }
            set { _SoNguoi = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class TaiKhoan
    {
        private string _TenTK;

        public string TenTK
        {
            get { return _TenTK; }
            set { _TenTK = value; }
        }

        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private string _Quyen;

        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class TrangBiTheoPhong
    {
        private string _MaTB;

        public string MaTB
        {
            get { return _MaTB; }
            set { _MaTB = value; }
        }

        private string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        
    }
}

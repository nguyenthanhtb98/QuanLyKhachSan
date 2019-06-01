using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class Phong
    {
        private string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }

        private string _TenPhong;

        public string TenPhong
        {
            get { return _TenPhong; }
            set { _TenPhong = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        private int _GiaTheoGio;

        public int GiaTheoGio
        {
            get { return _GiaTheoGio; }
            set { _GiaTheoGio = value; }
        }
        
        private int _GiaTheoNgay;

        public int GiaTheoNgay
        {
            get { return _GiaTheoNgay; }
            set { _GiaTheoNgay = value; }
        }

        private string _MaLP;

        public string MaLP
        {
            get { return _MaLP; }
            set { _MaLP = value; }
        }

        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class PhieuThanhToan
    {
        private string _MaPTT;

        public string MaPTT
        {
            get { return _MaPTT; }
            set { _MaPTT = value; }
        }

        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }

        private int _TongTienTT;

        public int TongTienTT
        {
            get { return _TongTienTT; }
            set { _TongTienTT = value; }
        }

        private DateTime _NgayTT;

        public DateTime NgayTT
        {
            get { return _NgayTT; }
            set { _NgayTT = value; }
        }
        
        
        
    }
}

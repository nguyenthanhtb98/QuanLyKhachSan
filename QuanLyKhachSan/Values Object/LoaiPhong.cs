using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class LoaiPhong
    {
        private string _MaLP;

        public string MaLP
        {
            get { return _MaLP; }
            set { _MaLP = value; }
        }

        private string _TenLP;

        public string TenLP
        {
            get { return _TenLP; }
            set { _TenLP = value; }
        }
    }
}

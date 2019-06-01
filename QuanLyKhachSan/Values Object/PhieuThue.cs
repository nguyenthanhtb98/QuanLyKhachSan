using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class PhieuThue
    {
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }

        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private DateTime _NgayDen;

        public DateTime NgayDen
        {
            get { return _NgayDen; }
            set { _NgayDen = value; }
        }

        private DateTime _NgayDi;

        public DateTime NgayDi
        {
            get { return _NgayDi; }
            set { _NgayDi = value; }
        }

        private string _HinhThucThue;

        public string HinhThucThue
        {
            get { return _HinhThucThue; }
            set { _HinhThucThue = value; }
        }
        
        
    }
}

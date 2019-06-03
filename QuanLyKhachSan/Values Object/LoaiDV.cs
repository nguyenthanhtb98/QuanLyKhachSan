using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class LoaiDV
    {
        private string _MaLoaiDV;

        public string MaLoaiDV
        {
            get { return _MaLoaiDV; }
            set { _MaLoaiDV = value; }
        }

        private string _TenLoaiDV;

        public string TenLoaiDV
        {
            get { return _TenLoaiDV; }
            set { _TenLoaiDV = value; }
        }

    }
}

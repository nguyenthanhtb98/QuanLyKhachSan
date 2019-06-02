using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Values_Object
{
    class LoaiDichVu
    {
        private string _MaLDV;

        public string MaLDV
        {   
            get { return _MaLDV; }
            set { _MaLDV = value; }
        }

        private string _TenLDV;

        public string TenLDV
        {
            get { return _TenLDV; }
            set { _TenLDV = value; }
        }
        
        
    }
}

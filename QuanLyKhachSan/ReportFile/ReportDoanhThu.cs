using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan.ReportFile
{
    public partial class ReportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDoanhThu()
        {
            InitializeComponent();
        }

        public void KhoiTao(string strTiLeDoanhThuDV, string strTiLeDoanhThuPhong)
        {
            pTiLeDoanhThuDV.Value = strTiLeDoanhThuDV;
            pTiLeDoanhThuPhong.Value = strTiLeDoanhThuPhong; 
        }
    }
}

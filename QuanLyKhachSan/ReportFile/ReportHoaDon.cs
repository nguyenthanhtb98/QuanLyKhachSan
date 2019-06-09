using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan.ReportFile
{
    public partial class ReportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }

        public void KhoiTaoDuLieu(string strMaPT, int TienDV, int TienPhong, int TongTien)
        {
            pMaPT.Value = strMaPT;
            pTienDV.Value = TienDV;
            pTienPhong.Value = TienPhong;
            pTongTien.Value = TongTien;
            pNgayTT.Value = DateTime.Now;
        }
    }
}

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

        public void KhoiTaoDuLieu(string strTenKH, string strGT, string strEmail, string strSDT, string strCMND, int TienDV, int TienPhong, int TongTien)
        {
            pTenKH.Value = strTenKH;
            pGioiTinh.Value = strGT;
            pSDT.Value = strSDT;
            pEmail.Value = strEmail;
            pCMND.Value = strCMND;
            pTienDV.Value = TienDV;
            pTienPhong.Value = TienPhong;
            pTongTien.Value = TongTien;
            pNgayTT.Value = DateTime.Now;
        }
    }
}

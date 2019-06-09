using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.ReportFile;
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan.GUI
{
   
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        private DAL_Report dal_report = new DAL_Report();
        public frmPrint()
        {
            InitializeComponent();

        }


        private void frmPrint_Load(object sender, EventArgs e)
        {

        }

        public void ThongKeDoanhThu()
        {
            ReportDoanhThu report = new ReportDoanhThu();
            //tính tỷ lệ tiền dịch vụ, phòng, // có hàm percentage trong report của devexpress, nhưng chưa biết dùng nên dùng tạm cách này
            int TongTienDV = dal_report.TongTienDV();
            int TongTienPhong = dal_report.TongTienPhong();
            float TiLeDoanhThuDV = (float)TongTienDV*100 / (TongTienDV + TongTienPhong);
            string strTLDV = string.Format("{0:0.00} %", TiLeDoanhThuDV);
            float TiLeDoanhThuPhong = 100 - TiLeDoanhThuDV;
            string strTLPhong = string.Format("{0:0.00} %", TiLeDoanhThuPhong);
            report.KhoiTao(strTLDV, strTLPhong);
            foreach (var item in report.Parameters)
            {
                item.Visible = false;
            }
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void ThongKePhong()
        {
            ReportPhong report = new ReportPhong();

            foreach (var item in report.Parameters)
            {
                item.Visible = false;
            }
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void InHoaDon(string strMaPT, int TienDV, int TienPhong, int TongTien)
        {
            ReportHoaDon report = new ReportHoaDon();
            report.KhoiTaoDuLieu(strMaPT,TienDV,TienPhong,TongTien); // truyền dữ liệu vào parameter trong printdocument hóa đơn
            foreach (var item in report.Parameters)
            {
                item.Visible = false;
            }
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
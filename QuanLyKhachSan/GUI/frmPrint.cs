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

namespace QuanLyKhachSan.GUI
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
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
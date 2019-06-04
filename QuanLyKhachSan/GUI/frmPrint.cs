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

        public void InTaiLieu()
        {
            ReportDoanhThu report = new ReportDoanhThu();

            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

        }

        public void InDSKHDaThanhToan()
        {
            ReportDoanhThu report = new ReportDoanhThu();
            foreach (var item in report.Parameters)
            {
                item.Visible = false;
            }
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
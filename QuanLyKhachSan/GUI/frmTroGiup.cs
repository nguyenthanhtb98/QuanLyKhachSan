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

namespace QuanLyKhachSan.GUI
{
    public partial class frmTroGiup : DevExpress.XtraEditors.XtraForm
    {
        static int sttPanel = 1;
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            AnToanBoPanel();
            HienThiPanel(1);
            
            
        }

        public void AnToanBoPanel()
        {
            pnlTroGiup_ThuePhong.Visible = false;
            pnlTroGiup_SDDV.Visible = false;
            pnlTroGiup_ThanhToan.Visible = false;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            AnToanBoPanel();
            if (sttPanel == 1)
            {
                sttPanel = 3;
            }
            else sttPanel--;
            HienThiPanel(sttPanel);
        }

        //hàm hiển thị panel có số thứ tự là ?
        public void HienThiPanel(int stt)
        {
            if(stt==1)
            {
                lblThongTinTrang.Text = "Hướng dẫn thuê phòng";
                pnlTroGiup_ThuePhong.Dock = DockStyle.Fill;
                pnlTroGiup_ThuePhong.Visible = true;
                
            }
            else if(stt==2)
            {
                lblThongTinTrang.Text = "Hướng dẫn thanh toán";
                pnlTroGiup_ThanhToan.Dock = DockStyle.Fill;
                pnlTroGiup_ThanhToan.Visible = true;
            }
            else if(stt==3)
            {
                lblThongTinTrang.Text = "Hướng dẫn đăng ký sử dụng dịch vụ cho khách hàng";
                pnlTroGiup_SDDV.Dock = DockStyle.Fill;
                pnlTroGiup_SDDV.Visible = true;
            }
            //hiển thị trang:
            lblTrang.Text = "Trang: "+stt+" / 3";
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            AnToanBoPanel();
            if (sttPanel == 3)
            {
                sttPanel = 1;
            }
            else sttPanel++;
            HienThiPanel(sttPanel);
        }
    }
}
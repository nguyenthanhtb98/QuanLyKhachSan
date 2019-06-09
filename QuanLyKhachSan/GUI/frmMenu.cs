using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyKhachSan.Values_Object;

namespace QuanLyKhachSan.GUI
{
    public partial class frmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TaiKhoan TK = new TaiKhoan();
        public frmMenu()
        {
            InitializeComponent();
        }

        public void LayThongTinTaiKhoan(TaiKhoan taikhoan)
        {
            TK.TenTK = taikhoan.TenTK;
            TK.MatKhau = taikhoan.MatKhau;
            TK.Quyen = taikhoan.Quyen;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnTrangBi_ItemClick(object sender, ItemClickEventArgs e)
        {           
            frmTrangBi frm = new frmTrangBi();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// kiểm tra xem form con có đang mở hay không
        /// </summary>
        /// <returns></returns>
        private bool FormConChuaMo(Form frm)
        {
            foreach (var item in MdiChildren)
            {
                if(item.Name == frm.Name)
                {
                    item.Activate();
                    return false;
                }
            }
            return true;
        }

        private void DongHetCacFormConKhac()
        {
            foreach (var item in MdiChildren)
            {
                item.Close();
            }
        }
        private void btnPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhong frm = new frmPhong();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnTrangBiTheoPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTrangBiTheoPhong frm = new frmTrangBiTheoPhong();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThuePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThuePhong frm = new frmThuePhong();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSDDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSuDungDichVu frm = new frmSuDungDichVu();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }


        private void frmMenu2_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Caption = "XIN CHÀO "+ TK.TenTK;
            if(TK.Quyen != "Admin")
            {
                rbbQuanLy.Visible = false;
            }
            else
            {
                rbbQuanLy.Visible = true;
            }
        }

        private void btnTroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLoaiDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoaiDV frm = new frmLoaiDV();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDichVu frm = new frmDichVu();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDSKHDaThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPrint frm = new frmPrint();
            frm.ThongKeDoanhThu();
            frm.ShowDialog();   
        }

        private void btnThongKePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPrint frm = new frmPrint();
            frm.ThongKePhong();
            frm.ShowDialog();
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            DongHetCacFormConKhac();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongTinUngDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongHetCacFormConKhac();
            MessageBox.Show("Design by:   NGUYỄN VĂN CÔNG - CNTT15 - MTA","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
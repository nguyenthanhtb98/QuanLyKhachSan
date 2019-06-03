using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Values_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmThanhToan : Form
    {
        private DAL_DichVu dal_DichVu = new DAL_DichVu();
        private DAL_LoaiDV dal_LoaiDV = new DAL_LoaiDV();
        private DAL_ThanhToan dal_ThanhToan = new DAL_ThanhToan();
        private DAL_SuDungDichVu dal_SDDV = new DAL_SuDungDichVu();
        private DAL_PhieuThue dal_PhieuThue = new DAL_PhieuThue();
        private DAL_Phong dal_Phong = new DAL_Phong();
        public frmThanhToan()
        {
            InitializeComponent();
            //Danh sách các khách hàng thuê phòng
            dgvPhieuThanhToan.DataSource = dal_ThanhToan.ThongTinCacKhachHangThuePhong();

            //lấy dữ liệu của phiếu thuê đầu tiên
            string str_mapt = dgvPhieuThanhToan.Rows[0].Cells[0].Value.ToString().Trim();
            lblTenKH.Text = dgvPhieuThanhToan.Rows[0].Cells[2].Value.ToString().Trim();
            dgvPhong.DataSource = dal_ThanhToan.ThongTinCacPhongThueTheoMaPT(str_mapt.Trim());
            dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt.Trim());
            lblTongTienDV.Text = string.Format("{0:0,0}", dal_ThanhToan.TinhTienDichVu(str_mapt.Trim()));
            lblTienPhong.Text =  string.Format("{0:0,0}", dal_ThanhToan.TinhTienPhong(str_mapt.Trim()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // mỗi lần click trên datagridview sẽ lấy thông tin theo mã phiếu thuê
            int i = dgvPhieuThanhToan.CurrentCell.RowIndex;
            string str_mapt = dgvPhieuThanhToan.Rows[i].Cells[0].Value.ToString().Trim();

            lblTenKH.Text = dgvPhieuThanhToan.Rows[i].Cells[2].Value.ToString().Trim();
            dgvPhong.DataSource = dal_ThanhToan.ThongTinCacPhongThueTheoMaPT(str_mapt.Trim());
            dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt.Trim());
            lblTongTienDV.Text = string.Format("{0:0,0}", dal_ThanhToan.TinhTienDichVu(str_mapt.Trim()));
            lblTienPhong.Text = string.Format("{0:0,0}", dal_ThanhToan.TinhTienPhong(str_mapt.Trim()));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
      
            //lấy thông tin của khách hàng thuê phòng cho vào form hóa đơn
            int i = dgvPhieuThanhToan.CurrentCell.RowIndex; //lấy chỉ số hàng
            string str_mapt = dgvPhieuThanhToan.Rows[i].Cells[0].Value.ToString().Trim(); //lấy mã phiếu thuê
            //tạo đối tượng hóa đơn lưu thông tin truyền qua form hóa đơn
            HoaDon hd = new HoaDon();
            hd.MaPT = dgvPhieuThanhToan.Rows[i].Cells[0].Value.ToString().Trim();
            hd.MaKH = dgvPhieuThanhToan.Rows[i].Cells[1].Value.ToString().Trim();
            hd.TenKH = dgvPhieuThanhToan.Rows[i].Cells[2].Value.ToString().Trim();
            hd.GioiTinh = dgvPhieuThanhToan.Rows[i].Cells[3].Value.ToString().Trim();
            hd.SDT = dgvPhieuThanhToan.Rows[i].Cells[4].Value.ToString().Trim();
            hd.Email = dgvPhieuThanhToan.Rows[i].Cells[5].Value.ToString().Trim();
            hd.CMND = dgvPhieuThanhToan.Rows[i].Cells[6].Value.ToString().Trim();
            hd.TienPhong = dal_ThanhToan.TinhTienPhong(str_mapt.Trim());
            hd.TienDV = dal_ThanhToan.TinhTienDichVu(str_mapt.Trim());
            hd.TongTienTT = hd.TienPhong + hd.TienDV;

            frmHoaDon frm = new frmHoaDon();
            frm.LayDuLieuTuFormThanhToanVaoFormHoaDon(hd);
            frm.ShowDialog();
         
            //cập nhật lại thông tin danh sách người đang thuê phòng và các thông tin phòng dịch vụ
            dgvPhieuThanhToan.DataSource = dal_ThanhToan.ThongTinCacKhachHangThuePhong();
            i = dgvPhieuThanhToan.CurrentCell.RowIndex;
            str_mapt = dgvPhieuThanhToan.Rows[i].Cells[0].Value.ToString().Trim();
            lblTenKH.Text = dgvPhieuThanhToan.Rows[i].Cells[2].Value.ToString().Trim();
            dgvPhong.DataSource = dal_ThanhToan.ThongTinCacPhongThueTheoMaPT(str_mapt.Trim());
            dgvDichVuDaSuDung.DataSource = dal_SDDV.ThongTinSuDungDichVuTheoMaPhieuThue(str_mapt.Trim());
            lblTongTienDV.Text = string.Format("{0:0,0}", dal_ThanhToan.TinhTienDichVu(str_mapt.Trim()));
            lblTienPhong.Text = string.Format("{0:0,0}", dal_ThanhToan.TinhTienPhong(str_mapt.Trim()));
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn đồng ý lấy ngày giờ này chứ?", "Thông Báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                // lấy thông tin
                int i = dgvPhieuThanhToan.CurrentCell.RowIndex;

                PhieuThue pt = new PhieuThue();
                pt.MaPT = dgvPhieuThanhToan.Rows[i].Cells[0].Value.ToString().Trim();
                pt.NgayDi = dateNgayDi.Value;
                dal_PhieuThue.SuaPhieuThue(pt);

                //cập nhật lại dgvPhieuthanhtoan
                dgvPhieuThanhToan.DataSource = dal_ThanhToan.ThongTinCacKhachHangThuePhong();
                //cập nhật lại tiền phòng
                lblTienPhong.Text = dal_ThanhToan.TinhTienPhong(pt.MaPT).ToString();
                MessageBox.Show("Cập nhật ngày đi cho khách hàng thành công!");
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        /// <summary>
        /// xem hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             //lấy thông tin của khách hàng thuê phòng cho vào form hóa đơn
            int i = dgvPhieuThanhToan.CurrentCell.RowIndex; //lấy chỉ số hàng
            string str_mapt = dgvPhieuThanhToan.Rows[i].Cells["MaPT"].Value.ToString().Trim(); //lấy mã phiếu thuê
            string str_TenKH = dgvPhieuThanhToan.Rows[i].Cells["TenKH"].Value.ToString().Trim();
            string str_GioiTinh = dgvPhieuThanhToan.Rows[i].Cells["GioiTinh"].Value.ToString().Trim();
            string str_SDT = dgvPhieuThanhToan.Rows[i].Cells["SDT"].Value.ToString().Trim();
            string str_Email = dgvPhieuThanhToan.Rows[i].Cells["Email"].Value.ToString().Trim();
            string str_CMND = dgvPhieuThanhToan.Rows[i].Cells["CMND"].Value.ToString().Trim();
            int int_TienPhong = dal_ThanhToan.TinhTienPhong(str_mapt.Trim());
            int int_TienDV = dal_ThanhToan.TinhTienDichVu(str_mapt.Trim());
            int int_TongTienTT = int_TienPhong + int_TienDV;
            //xem hóa đơn
            int x = 200; int y = 320; // tọa độ tên khách hàng
            int d = 50; // khoảng cách giữa 2 dòng
            Bitmap bmp = Properties.Resources.logoKhachSan;
            Image img = bmp;
            e.Graphics.DrawImage(img, 100, 20, 700, 200);
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 27, FontStyle.Underline), Brushes.Red, new Point(340, 220));
            e.Graphics.DrawString("Tên khách hàng: " + str_TenKH, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y));
            e.Graphics.DrawString("Giới tính: " + str_GioiTinh, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+d));
            e.Graphics.DrawString("Số điện thoại: " + str_SDT, new Font("Segoe UI", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+2*d));
            e.Graphics.DrawString("Email: " + str_Email, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+3*d));
            e.Graphics.DrawString("Số CMND: " + str_CMND, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+4*d));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y + 5 * d));
            e.Graphics.DrawString("Tiền phòng:   " + string.Format("{0:0,0}",int_TienPhong)+" đồng", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+6*d));
            e.Graphics.DrawString("Tiền dịch vụ: " + string.Format("{0:0,0}", int_TienDV) + " đồng", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+7*d));
            e.Graphics.DrawString("------------------------------------------------------",new Font("Arial", 18, FontStyle.Regular), Brushes.Black,new Point(x,y+8*d));
            e.Graphics.DrawString("Tổng tiền:    " + string.Format("{0:0,0}", int_TongTienTT) + " đồng", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y+9*d));
            e.Graphics.DrawString("Ngày thanh toán:   " + DateTime.Now.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(x, y + 12*d));

        }


    }
}

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
    public partial class frmSDDV_SoLuong : Form
    {
        public frmSDDV_SoLuong()
        {
            InitializeComponent();
        }

	
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuDungDichVu.SDDV_SoLuong = Convert.ToInt32(txtSoLuongDV.Text);
            }
            catch (Exception)
            {

                frmSuDungDichVu.SDDV_SoLuong = 1;
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

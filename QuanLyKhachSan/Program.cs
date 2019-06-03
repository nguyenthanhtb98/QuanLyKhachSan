using QuanLyKhachSan.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMenu2());
            //frmMenu2 frmMenu2 = new frmMenu2();
            //Application.Run(frmDangNhap);
            //if( frmDangNhap.isLoggedIn == true)
            //{
            //    Application.Run(frmMenu2);
            //}
            Application.Run(new frmDangNhap());
        }
    }
}

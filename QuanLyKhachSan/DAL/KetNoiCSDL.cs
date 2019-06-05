using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan.DAL
{
    class KetNoiCSDL
    {
        private SqlConnection conn;
        private string strConn = @"Data Source=(local);Initial Catalog=QLKHACHSAN;Integrated Security=True";
        public void MoKetNoi()
        {
            if(conn==null)
            {
                conn = new SqlConnection(strConn);
            }
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void DongKetNoi()
        {
            if(conn!=null)
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public int ThucHienLenh(string str)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                DongKetNoi();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }          
        }
        public DataTable GetDataTable(string str)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(str, conn);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
                return null;
            }
        }
        public string GetValue(string str)
        {
            try
            {
                MoKetNoi();
                string temp="";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    temp = reader.GetValue(0).ToString().Trim();
                }
                reader.Close();
                DongKetNoi();
                return temp;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public int LayGiaTriCuaHamTraVeKieuInt(string str)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(str, conn);
                int i = (int)cmd.ExecuteScalar();
                DongKetNoi();
                return i;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

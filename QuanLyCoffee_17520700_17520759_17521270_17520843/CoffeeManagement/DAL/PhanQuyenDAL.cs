using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhanQuyenDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public PhanQuyenDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select * from phanquyen";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối" + e.Message);
            }
            return k;
        }
    }
}

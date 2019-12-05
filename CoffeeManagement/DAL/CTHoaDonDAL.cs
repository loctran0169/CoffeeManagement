using DTO;
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
    public class CTHoaDonDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public CTHoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(CTHoaDonDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO cthoadon(mahd,masp,soluong,thanhtien) VALUES (@mahd,@masp,@soluong,@thanhtien)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mahd", bn.MaHD1);
                    cmd.Parameters.AddWithValue("@masp", bn.MaSP1);
                    cmd.Parameters.AddWithValue("@soluong", bn.SoLuong1);
                    cmd.Parameters.AddWithValue("@thanhtien", bn.ThanhTien1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public bool xoa(CTHoaDonDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM cthoadon WHERE mahd = @mahd";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mahd", bn.MaHD1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public DataTable loadDuLieuChiTietHoaHon(string mahd)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "SELECT s.tensp,dv.tendv,ct.soluong,s.dongia, (ct.soluong*s.dongia) as 'thanhtien'";
                query += "from sanpham s,cthoadon ct, donvi dv ";
                query += "where s.masp = ct.masp and s.madv = dv.madv and ct.mahd=@mahd";             
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mahd", mahd);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }
    }
}

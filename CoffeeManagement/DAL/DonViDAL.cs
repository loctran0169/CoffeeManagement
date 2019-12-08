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
    public class DonViDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DonViDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(DonViDTO dv)
        {

            string query = string.Empty;
            query += "INSERT INTO donvi (tendv,ghichu) VALUES (@tendv,@ghichu)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tendv", dv.TenDV1);
                    cmd.Parameters.AddWithValue("@ghichu", dv.GhiChu1);
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

        public bool sua(DonViDTO dv)
        {
            string query = string.Empty;
            query += "UPDATE donvi SET madv = @madv, tendv = @tendv, ghichu=@ghichu WHERE madv = @madv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madv", dv.MaDV1);
                    cmd.Parameters.AddWithValue("@tendv", dv.TenDV1);
                    cmd.Parameters.AddWithValue("@ghichu", dv.GhiChu1);
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

        public bool xoa(DonViDTO dv)
        {
            string query = string.Empty;
            query += "DELETE FROM donvi WHERE madv = @madv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madv", dv.MaDV1);
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

        public List<DonViDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM donvi";

            List<DonViDTO> listdonvi = new List<DonViDTO>();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DonViDTO dv = new DonViDTO();
                                dv.MaDV1 = reader["MaDV"].ToString();
                                dv.TenDV1 = reader["TenDV"].ToString(); ;
                                listdonvi.Add(dv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }

                }
            }
            return listdonvi;
        }


        public List<DonViDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM donvi";
            query += " WHERE (madv LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (tendv LIKE CONCAT('%',@sKeyword,'%'))";

            List<DonViDTO> listdonvi = new List<DonViDTO>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DonViDTO dv = new DonViDTO();
                                dv.MaDV1 = reader["MaDV"].ToString();
                                dv.TenDV1 = reader["TenDV"].ToString(); ;
                                listdonvi.Add(dv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listdonvi;
        }

        public DataTable loadDuLieuDonViTinh()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from donvi";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
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

        public DataTable selectByKeyWordDV(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM donvi";
            query += " WHERE (upper(madv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%'))";
            query += " OR (upper(tendv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%'))";

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(query, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {
                return new DataTable();
                MessageBox.Show(e.Message);
            }
            return k;
        }
    }
}

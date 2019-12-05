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
    public class HoaDonDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public HoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(HoaDonDTO bn)
        {

            string query = string.Empty;
            query += "INSERT INTO hoadon(mahd,manv,ngaylap,tongtien) VALUES (@mahd,@manv,@ngaylap,@tongtien)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mahd", bn.MaHD1);
                    cmd.Parameters.AddWithValue("@manv", bn.MaNV1);
                    cmd.Parameters.AddWithValue("@ngaylap", bn.NgayLap1);
                    cmd.Parameters.AddWithValue("@tongtien", bn.TongTien1);
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

        public bool sua(HoaDonDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE hoadon SET mahd = @mahd,manv=@manv,ngaylap = @ngaylap,tongtien = @tongtien  WHERE mahd = @mahd";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mahd", bn.MaHD1);
                    cmd.Parameters.AddWithValue("@manv", bn.MaNV1);
                    cmd.Parameters.AddWithValue("@ngaylap", bn.NgayLap1);
                    cmd.Parameters.AddWithValue("@tongtien", bn.TongTien1);

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

        public bool xoa(HoaDonDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM hoadon WHERE mahd = @mahd";
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

        public List<HoaDonDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM hoadon";

            List<HoaDonDTO> listthuoc = new List<HoaDonDTO>();

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
                                HoaDonDTO bn = new HoaDonDTO();
                                bn.MaHD1 = reader["MaNL"].ToString();
                                bn.MaNV1 = reader["TenNL"].ToString();
                                bn.NgayLap1 = DateTime.Parse(reader["MaDV"].ToString());
                                bn.TongTien1 = float.Parse(reader["SoLuongTon"].ToString());
                                listthuoc.Add(bn);
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
            return listthuoc;
        }

        public DataTable selectByKeyWord(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM hoadon";
            query += " WHERE (mahd LIKE CONCAT('%','"+sKeyword.ToUpper()+"','%'))";
            query += " OR (manv LIKE CONCAT('%','"+sKeyword.ToUpper()+"','%'))";

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
                MessageBox.Show(e.Message);
            }
            return k;
        }

        public DataTable loadToDataTable(DateTime a, DateTime b)
        {
            DataTable k = new DataTable();
            string sql = "select distinct a.mahd,a.tennv,a.ngaylap,a.tongtien " +
                         "from (select hd.mahd, nv.tennv, hd.ngaylap, hd.tongtien from hoadon hd, nhanvien nv " +
                         "where hd.manv = nv.manv and hd.ngaylap <= @right) a " +
                         "Inner Join " +
                         "(select hd.mahd, nv.tennv, hd.ngaylap, hd.tongtien " +
                         "from hoadon hd, nhanvien nv " +
                         "where hd.manv = nv.manv and hd.ngaylap >= @left) b " +
                         "where a.mahd = b.mahd ";
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = kn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@right", MySqlDbType.Date).Value = b.Date;
                    cmd.Parameters.Add("@left", MySqlDbType.Date).Value = a.Date;
                    try
                    {
                        kn.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        k.Load(reader);//đổ dữ liệu từ DataBase sang bảng
                        kn.Close();
                        reader.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        kn.Close();
                        return null;
                    }
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }

        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select mahd, tennv, ngaylap, tongtien from hoadon hd, nhanvien nv where hd.manv = nv.manv";
                //string sql = "select * from hoadon";
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

    }
}

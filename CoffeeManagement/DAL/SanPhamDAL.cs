using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public SanPhamDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(SanPhamDTO bn)
        {

            string query = string.Empty;
            query += "INSERT INTO sanpham(MaSP,TenSP,HinhAnh,MaDV,DonGia) VALUES (@MaSP,@TenSP,@HinhAnh,@MaDV,@DonGia)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSP", bn.MaSP1);
                    cmd.Parameters.AddWithValue("@TenSP", bn.TenSP1);
                    cmd.Parameters.AddWithValue("@HinhAnh", bn.HinhAnh1);
                    cmd.Parameters.AddWithValue("@MaDV", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@DonGia", bn.DonGia1);
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

        public bool sua(SanPhamDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE sanpham SET masp = @masp,tensp=@tensp, hinhanh = @hinhanh, madv = @madv,dongia = @dongia  WHERE masp = @masp";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@masp", bn.MaSP1);
                    cmd.Parameters.AddWithValue("@tensp", bn.TenSP1);
                    cmd.Parameters.AddWithValue("@hinhanh", bn.HinhAnh1);
                    cmd.Parameters.AddWithValue("@madv", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@dongia", bn.DonGia1);

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

        public bool xoa(SanPhamDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM sanpham WHERE masp = @masp";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@masp", bn.MaSP1);
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

        public List<SanPhamDTO> select()
        {
            string query = string.Empty;
            query += "SELECT masp,tensp ";
            query += "FROM sanpham";

            List<SanPhamDTO> listthuoc = new List<SanPhamDTO>();

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
                                SanPhamDTO bn = new SanPhamDTO();
                                bn.MaSP1 = reader["MaSP"].ToString();
                                bn.TenSP1 = reader["TenSP"].ToString();
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

        public List<SanPhamDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM sanpham";
            query += " WHERE (masp LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (tensp LIKE CONCAT('%',@sKeyword,'%'))";

            List<SanPhamDTO> listthuoc = new List<SanPhamDTO>();
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
                                SanPhamDTO bn = new SanPhamDTO();
                                bn.MaSP1 = reader["MaSp"].ToString();
                                bn.MaDV1 = reader["MaDV"].ToString();
                                bn.TenSP1 = reader["TenSP"].ToString();
                                bn.HinhAnh1 = reader["HinhAnh"].ToString();
                                bn.DonGia1 = float.Parse(reader["DonGia"].ToString());
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

        public DataTable loadDuLieuDonViTinh()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaDV, tendv from donvi";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
            }
            return k;
        }

        public DataTable loadDuLieuSanPham()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select masp,tensp,t.madv,hinhanh,dongia from donvi dv join sanpham t on dv.Madv = t.MaDV";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                return new DataTable();
            }
            return k;
        }

        public DataTable loadToCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select masp,tensp from sanpham";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                return new DataTable();
            }
            return k;
        }
    }
}

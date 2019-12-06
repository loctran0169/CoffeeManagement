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
    public class TaiKhoanDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public TaiKhoanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(TaiKhoanDTO us)
        {
            string query = string.Empty;
            query += "INSERT INTO taikhoan (matk,taikhoan,matkhau,mapq,ghichu) VALUES (@matk,@taikhoan,@matkhau,@mapq,@ghichu)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@matk", us.MaTK1);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MaTK1);
                    cmd.Parameters.AddWithValue("@mapq", us.MaPQ1);
                    cmd.Parameters.AddWithValue("@ghichu", us.GhiChu1);
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

        public bool sua(TaiKhoanDTO us)
        {
            string query = string.Empty;
            query += "UPDATE taikhoan SET  taikhoan = @taikhoan, matkhau = @matkhau,mapq=@mapq,ghichu=@ghichu WHERE matk = @matk";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@matk", us.MaTK1);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
                    cmd.Parameters.AddWithValue("@mapq", us.MaPQ1);
                    cmd.Parameters.AddWithValue("@ghichu", us.GhiChu1);
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

        public bool suamk(TaiKhoanDTO us)
        {
            string query = string.Empty;
            query += "UPDATE taikhoan SET  matkhau = @matkhau WHERE matk = @matk";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaTK1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
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

        public bool xoa(TaiKhoanDTO us)
        {
            string query = string.Empty;
            query += "DELETE FROM taikhoan WHERE matk = @matk";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaTK1);
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

        public DataTable loadDuLieuUsers()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from taikhoan";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }

        public DataTable dangNhap(TaiKhoanDTO us)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select * from taikhoan where taikhoan=@taikhoan and matkhau=@matkhau";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {

            }
            return k;
        }
    }
}

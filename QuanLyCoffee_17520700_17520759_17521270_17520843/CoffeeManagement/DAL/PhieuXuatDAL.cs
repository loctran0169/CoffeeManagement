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
    public class PhieuXuatDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public PhieuXuatDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(PhieuXuatDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO phieuxuat (manv,ngaylap,ngayxuat,diachi,tongtien,tinhtrang) VALUES (@manv,@ngaylap,@ngayxuat,@diachi,@tongtien,@tinhtrang)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", bn.MaNV1);
                    cmd.Parameters.AddWithValue("@ngaylap", bn.NgayLap1);
                    cmd.Parameters.AddWithValue("@ngayxuat", bn.NgayXuat1);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi1);
                    cmd.Parameters.AddWithValue("@tongtien", bn.TongTien1);
                    cmd.Parameters.AddWithValue("@tinhtrang", bn.TinhTrang1);
                    try
                    {
                        con.Open();
                        //cmd.ExecuteNonQuery();
                        int modified = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show(modified.ToString());
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public bool sua(PhieuXuatDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE phieuxuat SET ngayxuat=@ngayxuat,diachi = @diachi, tinhtrang=@tinhtrang,tongtien = @tongtien  WHERE mapx = @mapx";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapx", bn.MaPX1);
                    cmd.Parameters.AddWithValue("@ngayxuat", bn.NgayXuat1);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi1);
                    cmd.Parameters.AddWithValue("@tinhtrang", bn.TinhTrang1);
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

        public bool xoa(PhieuXuatDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM phieuxuat WHERE mapx = @mapx";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapx", bn.MaPX1);
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

        public DataTable loadMaPX(DateTime date)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                string query = null;
                //query += "select * from phieuxuat where ngaylap='"+date.ToString("yyyy-MM-dd HH:mm:ss")+"'";
                query = "SELECT mapx FROM phieuxuat ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                kn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(k);
                kn.Close();
                adapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
            return k;
        }

        public DataTable selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT px.mapx, nv.tennv,px.ngaylap, px.ngayxuat, px.tongtien,px.tinhtrang";
            query += " FROM phieuxuat px, nhanvien nv";
            query += " WHERE ((upper(px.mapx) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and px.manv=nv.manv)";
            query += " OR ((upper(nv.tennv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and px.manv=nv.manv)";

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

        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select mapx, tennv,ngaylap, ngayxuat, tongtien, tinhtrang from phieuxuat px, nhanvien nv where px.manv = nv.manv";
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

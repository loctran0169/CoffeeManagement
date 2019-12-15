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
    public class PhieuNhapDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public PhieuNhapDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(PhieuNhapDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO phieunhap (manv,ngaylap,ngaynhap,diachi,tongtien,tinhtrang) VALUES (@manv,@ngaylap,@ngaynhap,@diachi,@tongtien,@tinhtrang)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", bn.MaNV1);
                    cmd.Parameters.AddWithValue("@ngaylap", bn.NgayLap1);
                    cmd.Parameters.AddWithValue("@ngaynhap", bn.NgayNhap1);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi1);
                    cmd.Parameters.AddWithValue("@tongtien", bn.TongTien1);
                    cmd.Parameters.AddWithValue("@tinhtrang", bn.TinhTrang1);
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
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public bool sua(PhieuNhapDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE phieunhap SET ngaynhap=@ngaynhap,diachi = @diachi, tinhtrang=@tinhtrang,tongtien = @tongtien  WHERE mapn = @mapn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapn", bn.MaPN1);
                    cmd.Parameters.AddWithValue("@ngaynhap", bn.NgayNhap1);
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

        public bool xoa(PhieuNhapDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM phieunhap WHERE mapn = @mapn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapn", bn.MaPN1);
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
                query = "SELECT mapn FROM phieunhap ORDER BY id DESC LIMIT 1";
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
            query += " SELECT pn.mapn, nv.tennv, pn.ngaynhap, pn.tongtien,pn.tinhtrang";
            query += " FROM phieunhap pn, nhanvien nv";
            query += " WHERE ((upper(pn.mapx) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and pn.manv=nv.manv)";
            query += " OR ((upper(nv.tennv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and pn.manv=nv.manv)";

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
                string sql = "select mapn, tennv,ngaylap, ngaynhap, tongtien, tinhtrang from phieunhap pn, nhanvien nv where pn.manv = nv.manv";
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

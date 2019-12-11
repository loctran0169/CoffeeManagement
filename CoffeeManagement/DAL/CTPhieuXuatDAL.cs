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
    public class CTPhieuXuatDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public CTPhieuXuatDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(CTPhieuXuatDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO ctphieuxuat(mapx,manl,soluong,dongia) VALUES (@mapx,@manl,@soluong,@dongia)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapx", bn.MaPX1);
                    cmd.Parameters.AddWithValue("@manl", bn.MaNL1);
                    cmd.Parameters.AddWithValue("@soluong", bn.SoLuong1);
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

        public bool xoa(string bn)
        {
            string query = string.Empty;
            query += "DELETE FROM ctphieuxuat WHERE mapx = @mapx";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapx", bn);
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

        public DataTable loadDuLieuChiTietPhieuXuat(string mapx)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select ct.manl,nl.tennl,dv.tendv,ct.SoLuong,ct.dongia,(ct.SoLuong*ct.dongia) as thanhtien ";
                query += "from ctphieuxuat ct, nguyenlieu nl , donvi dv ";
                query += "where ct.manl=nl.manl and dv.madv=nl.madv and ct.mapx=@mapx";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapx", mapx);
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

        public DataTable loadInfo(string mapx)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select px.mapx, nv.tennv, px.ngayxuat, px.diachi, px.tongtien, px.tinhtrang ";
                query += "from phieuxuat px, nhanvien nv ";
                query += "where px.manv=nv.manv and px.mapx=@mapx";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapx", mapx);
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

        //load by dataset
        public DataSet loadCTPhieuXuat(string mapx)
        {
            DataSet k = new DataSet();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select * ";
                query += "from ctphieuxuat ";
                query += "where mapx=@mapx";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapx", mapx);
                kn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(k,"ctphieuxuat");
                kn.Close();
                adapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }

        public bool updateData(DataTable ds)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("select * from ctphieuxuat",con))
                {
                    using (MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter))
                        try
                        {
                            con.Open();
                            adapter.Update(ds);
                            con.Close();
                            con.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            con.Close();
                            return false;
                        }
                }
            }
            return true;
        }
    }
}

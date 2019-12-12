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
    public class CTPhieuNhapDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public CTPhieuNhapDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(CTPhieuNhapDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO ctphieunhap(mapn,manl,soluong,dongia) VALUES (@mapn,@manl,@soluong,@dongia)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapn", bn.MaPN1);
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
            query += "DELETE FROM ctphieunhap WHERE mapn = @mapn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapn", bn);
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

        public DataTable loadDuLieuChiTietPhieuNhap(string mapn)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select ct.manl,nl.tennl,dv.tendv,ct.SoLuong,ct.dongia,(ct.SoLuong*ct.dongia) as thanhtien ";
                query += "from ctphieunhap ct, nguyenlieu nl , donvi dv ";
                query += "where ct.manl=nl.manl and dv.madv=nl.madv and ct.mapn=@mapn";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapn", mapn);
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

        public DataTable loadInfo(string mapn)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select pn.mapn, nv.tennv, pn.ngaynhap, pn.diachi, pn.tongtien, pn.tinhtrang ";
                query += "from phieunhap pn, nhanvien nv ";
                query += "where pn.manv=nv.manv and pn.mapn=@mapn";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapn", mapn);
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
        public DataSet loadctphieunhap(string mapn)
        {
            DataSet k = new DataSet();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "select * ";
                query += "from ctphieunhap ";
                query += "where mapn=@mapn";
                MySqlCommand cmd = new MySqlCommand(query, kn);
                cmd.Parameters.AddWithValue("@mapn", mapn);
                kn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(k, "ctphieunhap");
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
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("select * from ctphieunhap", con))
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
                            MessageBox.Show("dal ct " + ex.Message);
                            con.Close();
                            return false;
                        }
                }
            }
            return true;
        }
    }
}

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
    public class BaoCaoDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public BaoCaoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(BaoCaoDTO dv)
        {

            string query = string.Empty;
            query += "INSERT INTO baocao (manv,loai,thoigian) VALUES (@manv,@loai,@thoigian)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", dv.MaNV1);
                    cmd.Parameters.AddWithValue("@loai", dv.Loai1);
                    cmd.Parameters.Add("@thoigian", MySqlDbType.Datetime).Value = dv.ThoiGian1;
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
                        MessageBox.Show("Thêm báo cáo thất bại "+ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public DataTable loadDuLieuDoanhThu(int month, int year)
        {

            var k = new DataTable();
            k.Columns.Add("Ngay", typeof(DateTime));
            k.Columns.Add("SoLuongKhach", typeof(int));
            k.Columns.Add("DoanhThu", typeof(string));
            k.Columns.Add("TyLe", typeof(float));
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {

                string sql = "SELECT date(NgayLap) as Ngay,COUNT(*) as   'SoLuongKhach', sum(tongtien) as 'DoanhThu',sum(tongtien)*100/(SELECT sum(tongtien) " +
                    "FROM HOADON where year(HOADON.NgayLap)= @year and month(HOADON.NgayLap) = @month) as 'TyLe'FROM HOADON " +
                    "where year(HOADON.NgayLap)= @year and month(HOADON.NgayLap) = @month " +
                    "group by date(NgayLap)";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int a = 3;
            }
            return k;
        }

        public DataTable loadDuLieuKho(int month, int year)
        {

            var k = new DataTable();
            k.Columns.Add("manl", typeof(string));
            k.Columns.Add("tennl", typeof(string));
            k.Columns.Add("tendv", typeof(string));
            k.Columns.Add("SoLuongTon", typeof(float));
            k.Columns.Add("GiaNhap", typeof(float));
            k.Columns.Add("GiaBan", typeof(float));
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {

                string sql = "select manl,tennl,dv.tendv,SoLuongTon,gianhap,giaban " +
                    "from nguyenlieu nl,donvi dv " +
                    "where dv.madv=nl.madv ";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int a = 3;
            }
            return k;
        }

        public DataTable loadBaoCao(string _tag)
        {

            var k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string sql = "select mabc,nv.tennv,loai,thoigian " +
                    " from baocao bc, nhanvien nv " +
                    " where bc.manv=nv.manv and loai='" + _tag+"'";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
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

        public DataTable loadBaoCaoAll()
        {

            var k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string sql = "select mabc,nv.tennv,loai,thoigian " +
                    " from baocao bc, nhanvien nv " +
                    " where bc.manv=nv.manv";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
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

        public DataTable selectByKeyWordDV(string sKeyword)
        {

            string query = string.Empty;
            query += " select mabc,nv.tennv,loai,thoigian ";
            query += " from baocao bc, nhanvien nv ";
            query += " WHERE ((upper(bc.mabc) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and bc.manv=nv.manv) ";
            query += " OR ((upper(nv.tennv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and bc.manv=nv.manv)";

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

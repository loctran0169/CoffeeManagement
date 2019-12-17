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
    public class NhanVienDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public NhanVienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public DataTable loadDuLieuNhanVien()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select manv, tennv, ngaysinh, gioitinh, sdt from nhanvien";
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

        public DataTable loadDuLieuNhanVienTuMaUsers(string MaNv)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select * from nhanvien where MaNV='" + MaNv + "'";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {

            }
            return k;
        }

        public bool them(NhanVienDTO nv)
        {

            string query = string.Empty;
            query += "INSERT INTO NHANVIEN(tennv,ngaysinh,gioitinh,diachi,sdt,matk,email,ghichu) VALUES (@tennv,@ngaysinh,@gioitinh,@diachi,@sdt,@matk,@email,@ghichu)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tennv", nv.TenNV1);
                    cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh1);
                    cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh1);
                    cmd.Parameters.AddWithValue("@diachi", nv.DiaChi1);
                    cmd.Parameters.AddWithValue("@sdt", nv.SDT1);
                    cmd.Parameters.AddWithValue("@matk", nv.MaTK1);
                    cmd.Parameters.AddWithValue("@email", nv.Email1);
                    cmd.Parameters.AddWithValue("@ghichu", nv.GhiChu1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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

        public bool sua(NhanVienDTO nv)
        {
            string query = string.Empty;
            query += "UPDATE nhanvien SET tennv = @tennv, ngaysinh = @ngaysinh, gioitinh = @gioitinh,diachi = @diachi,sdt=@sdt, email=@email, ghichu=@ghichu WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nv.MaNV1);
                    cmd.Parameters.AddWithValue("@tennv", nv.TenNV1);
                    cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh1);
                    cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh1);
                    cmd.Parameters.AddWithValue("@diachi", nv.DiaChi1);
                    cmd.Parameters.AddWithValue("@sdt", nv.SDT1);
                    cmd.Parameters.AddWithValue("@email", nv.Email1);
                    cmd.Parameters.AddWithValue("@ghichu", nv.GhiChu1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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

        public bool xoa(NhanVienDTO nvDTO)
        {
            string query = string.Empty;
            query += "DELETE FROM nhanvien WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nvDTO.MaNV1);
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

        public DataTable selectByKeyWord(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT manv, tennv, ngaysinh, gioitinh, sdt";
            query += " FROM nhanvien";
            query += " WHERE (manv LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%'))";
            query += " OR (upper(tennv) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%'))";

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

        public DataTable loadOneNhanVien(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM nhanvien";
            query += " WHERE manv='" + sKeyword.ToUpper()+ "'";

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
            }
            return k;
        }
        public DataTable loadNhanViewDangNhap(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM nhanvien";
            query += " WHERE matk='" + sKeyword+ "'";

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
            }
            return k;
        }
    }
}

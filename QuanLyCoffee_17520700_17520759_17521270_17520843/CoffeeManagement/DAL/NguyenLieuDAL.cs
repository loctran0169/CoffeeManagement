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
    public class NguyenLieuDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public NguyenLieuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(NguyenLieuDTO bn)
        {

            string query = string.Empty;
            query += "INSERT INTO nguyenlieu(MaNL,TenNL,MaDV,SoLuongTon) VALUES (@manl,@tennl,@madv,@soluongton)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manl", bn.MaNL1);
                    cmd.Parameters.AddWithValue("@tennl", bn.TenNL1);
                    cmd.Parameters.AddWithValue("@madv", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@soluongton", bn.SoLuongTon1);
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

        public bool sua(NguyenLieuDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE nguyenlieu SET manl = @manl,tennl=@tennl,madv = @madv,soluongton = @soluongton  WHERE manl = @manl";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manl", bn.MaNL1);
                    cmd.Parameters.AddWithValue("@tennl", bn.TenNL1);
                    cmd.Parameters.AddWithValue("@madv", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@soluongton", bn.SoLuongTon1);

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

        public bool xoa(NguyenLieuDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM nguyenlieu WHERE manl = @manl";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manl", bn.MaNL1);
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

        public List<NguyenLieuDTO> select()
        {
            string query = string.Empty;
            query += "SELECT manl,tennl,soluongton,gianhap,giaban ";
            query += "FROM nguyenlieu";

            List<NguyenLieuDTO> listthuoc = new List<NguyenLieuDTO>();

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
                                NguyenLieuDTO bn = new NguyenLieuDTO();
                                bn.MaNL1 = reader["manl"].ToString();
                                bn.TenNL1 = reader["tennl"].ToString();
                                bn.MaDV1 = reader["tendv"].ToString();
                                bn.SoLuongTon1 = float.Parse(reader["soluongton"].ToString());
                                bn.GiaNhap1 = float.Parse(reader["gianhap"].ToString());
                                bn.GiaBan1 = float.Parse(reader["giaban"].ToString());
                                listthuoc.Add(bn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return new List<NguyenLieuDTO>();
                    }

                }
            }
            return listthuoc;
        }

        public DataTable selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT manl,tennl,dv.tendv,soluongton,gianhap,giaban ";
            query += " FROM nguyenlieu nl, donvi dv ";
            query += " WHERE ((upper(nl.manl) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and nl.madv=dv.madv) ";
            query += " OR ((upper(nl.tennl) LIKE CONCAT('%','" + sKeyword.ToUpper() + "','%')) and nl.madv=dv.madv)";

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

        public DataTable loadDuLieuNguyenLieu()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select manl,tennl,dv.tendv,soluongton,gianhap,giaban from donvi dv join nguyenlieu t on dv.Madv = t.MaDV";
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

        public DataTable loadToCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select nl.manl, nl.tennl,dv.madv,dv.tendv, nl.soluongton,nl.gianhap,nl.giaban " +
                    "from nguyenlieu nl, donvi dv " +
                    "where nl.madv=dv.madv";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                return new DataTable();
            }
            return k;
        }

        public DataTable loadNL(string s)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select * from nguyenlieu where manl='"+s+"'";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Objects;
using QuanLyCuaHangTienLoi.Controls;


namespace QuanLyCuaHangTienLoi.Models
{
    class HoaDonBanMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonBan_getData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetDataByTenNV(Objects.HoaDonBan hoadonbanObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonBan_searchDataByTenNV";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@manv", hoadonbanObj.Manhanvien);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetDataByNgayLap(string ngaybatdau, string ngayketthuc)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonBan_searchDataByNgayLap";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
                        cm.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetDataByTenANDngay(Objects.HoaDonBan hoadonbanObj, string ngaybatdau, string ngayketthuc)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonBan_searchDataByTenANDNgayLap";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@manv", hoadonbanObj.Manhanvien);
                        cm.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
                        cm.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return dt;
                }
            }
        }

        public bool InsertHoaDonBan()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblBanhang_insertHD";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@manv", Convert.ToInt32(LoginInfo.Manv));
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                return false;
            }
        }
    }
}

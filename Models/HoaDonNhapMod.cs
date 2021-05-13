using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Objects;

namespace QuanLyCuaHangTienLoi.Models
{
    class HoaDonNhapMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        //get data
        public DataTable GetDataHoaDonNhap()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonNhap_getData";
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
                        cm.Dispose();
                    }
                }
                return dt;
            }
        }

        public DataTable GetDataByTenNV(Objects.HoaDonNhap hoadonnhapObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonNhap_searchDataByTenNV";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@manv", hoadonnhapObj.MaNV);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        cm.Dispose();
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
                string query = "sp_tblHoaDonNhap_searchDataByNgayLap";
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
                        cm.Dispose();
                    }
                    return dt;
                }
            }
        }

        public DataTable GetDataByTenANDngay(Objects.HoaDonNhap hoadonnhapObj, string ngaybatdau, string ngayketthuc)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblHoaDonNhap_searchDataByTenANDNgayLap";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@manv", hoadonnhapObj.MaNV);
                        cm.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
                        cm.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        cm.Dispose();
                    }
                    return dt;
                }
            }
        }

        //Insert to db
        public bool InsertHoaDonNhap(HoaDonNhap nhaphangObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_insertNhaphang";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@mancc", nhaphangObj.MaNCC);
                        cm.Parameters.AddWithValue("@manv", nhaphangObj.MaNV);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        cm.Dispose();
                    }
                }
                return false;
            }
        }

    }
}

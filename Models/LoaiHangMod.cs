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
    class LoaiHangMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblLoaiHang_getData";
                using(SqlCommand cm = new SqlCommand(query, cn)) {
                    try {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
                return dt;
            }
        }

        public DataTable SearchData(string search)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblLoaiHang_searchData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@search", search);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return dt;
            }
        }

        public bool InsertData(LoaiHang loaihangObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblLoaiHang_insertData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@tenloaihang", loaihangObj.Tenloaihang);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loại hàng đã tồn tại!");
                    }
                }
                return false;
            }
        }

        public bool UpdateData(LoaiHang loaihangObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblLoaiHang_updateDataById";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ma", loaihangObj.Maloaihang);
                        cm.Parameters.AddWithValue("@ten", loaihangObj.Tenloaihang);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loại hàng đã tồn tại!");
                    }
                }
                return false;
            }
        }
    }
}

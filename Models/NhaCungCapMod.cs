using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Objects;
using System.Configuration;

namespace QuanLyCuaHangTienLoi.Models
{
    class NhaCungCapMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhaCungCap_getData";
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

        public DataTable SearchData(string search)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhaCungCap_searchData";
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
                    return dt;
                }
            }
        }

        public bool InsertData(NhaCungCap nccObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhaCungCap_insertData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ten", nccObj.Tennhacungcap);
                        cm.Parameters.AddWithValue("@sdt", nccObj.Sdt);
                        cm.Parameters.AddWithValue("@diachi", nccObj.Diachi);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return false;
        }

        public bool UpdateData(NhaCungCap nccObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhaCungCap_updateData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ma", nccObj.Manhacungcap);
                        cm.Parameters.AddWithValue("@ten", nccObj.Tennhacungcap);
                        cm.Parameters.AddWithValue("@sdt", nccObj.Sdt);
                        cm.Parameters.AddWithValue("@diachi", nccObj.Diachi);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return false;
        }
    }
}

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

namespace QuanLyCuaHangTienLoi.Models
{
    class ChiTietBanMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblChiTietBan_getData";
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

        public DataTable GetDataByHoaDon(Objects.HoaDonBan hodonbanObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblChiTietBan_getDataByHoaDon";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@mahoadon", hodonbanObj.Mahoadon);
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

        public bool InsertChiTietBan(ChiTietBan ctbObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblBanhang_insert";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@mamh", ctbObj.Mamathang);
                        cm.Parameters.AddWithValue("@sl", ctbObj.Soluong);
                        cm.Parameters.AddWithValue("@giaban", decimal.Parse(ctbObj.Giaban));
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

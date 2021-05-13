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
    class MatHangMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_getData";
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
                }
            }
            return dt;
        }

        public DataTable GetDataByMaVach(MatHang mathangObj)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_getDataByMaVach";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@mavach", mathangObj.Mavach);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return dt;
        }

        public DataTable GetDataByLoaiHang(MatHang mathangObj)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_getDataByLoaiHang";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@maloai", mathangObj.Maloai);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return dt;
        }

        public DataTable SearchData(string search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_searchData";
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
            }
            return dt;
        }

        public bool InsertData(MatHang mathangObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_insertData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@maloai", mathangObj.Maloai);
                        cm.Parameters.AddWithValue("@tenhang", mathangObj.Tenmathang);
                        cm.Parameters.AddWithValue("@giaban", mathangObj.Giaban);
                        cm.Parameters.AddWithValue("@soluong", mathangObj.Soluong);
                        cm.Parameters.AddWithValue("@donvitinh", mathangObj.Donvitinh);
                        cm.Parameters.AddWithValue("@mavach", mathangObj.Mavach);
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

        public bool UpdateData(MatHang mathangObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblMatHang_updateData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@mahang", mathangObj.Mamathang);
                        cm.Parameters.AddWithValue("@maloai", mathangObj.Maloai);
                        cm.Parameters.AddWithValue("@tenhang", mathangObj.Tenmathang);
                        cm.Parameters.AddWithValue("@giaban", mathangObj.Giaban);
                        cm.Parameters.AddWithValue("@soluong", mathangObj.Soluong);
                        cm.Parameters.AddWithValue("@donvitinh", mathangObj.Donvitinh);
                        cm.Parameters.AddWithValue("@mavach", mathangObj.Mavach);
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


        //Hàng Hỏng
        public DataTable GetDataHangHong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblHangHong_getData";
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
                }
            }
            return dt;
        }

        public bool InsertDataHangHong(HangHong hanghongObj)
        {

            {
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    string query = "sp_tblHanghong_insertData";
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        try
                        {
                            cn.Open();
                            cm.CommandType = CommandType.StoredProcedure;
                            cm.Parameters.AddWithValue("@mamathang", hanghongObj.Mamathang);
                            cm.Parameters.AddWithValue("@soluong", hanghongObj.Soluong);
                            cm.Parameters.AddWithValue("@mota", hanghongObj.Mota);
                            DateTime ngaylap = Convert.ToDateTime(hanghongObj.Ngaylap);
                            cm.Parameters.AddWithValue("@ngaylap", ngaylap);
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

        public DataTable SearchDataHangHong(string search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblHangHong_searchData";
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
            }
            return dt;
        }
     }
}

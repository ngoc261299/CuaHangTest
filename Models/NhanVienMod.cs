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
    class NhanVienMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanLyCuaHang"].ToString();

        public bool User(NhanVien nvObj) //login
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_getDataByUserAndPass";
                cn.Open();
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@username", nvObj.Username);
                    cm.Parameters.AddWithValue("@password", nvObj.Password);
                    try
                    {
                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        } 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                return false;
            }
            
        }

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhanVien_getData";
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

        public bool ChekEmail(string email)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "select sEmail from tblNhanVien where sEmail = '" + email + "'";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.Text;
                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        if(dr.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        cm.Dispose();
                    }
                    return false;
                }
            }
        }

        public bool ChekSDT(string sdt)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "select sSDT from tblNhanVien where sSDT = " + sdt;
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.Text;
                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        cm.Dispose();
                    }
                    return false;
                }
            }
        }

        public DataTable SearchData(string search)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhanVien_searchData";
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

        public DataTable GetDataByUser(NhanVien nvObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhanVien_getDataByUser";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@username", nvObj.Username);
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

        public bool UpdatePass(NhanVien nvObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_updatePass";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@username", nvObj.Username);
                        cm.Parameters.AddWithValue("@password", nvObj.Password);
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

        public bool InsertData(NhanVien nvObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_insertData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@hoten", nvObj.Hoten);
                        cm.Parameters.AddWithValue("@ngaysinh", nvObj.Ngaysinh);
                        cm.Parameters.AddWithValue("@gioitinh", nvObj.Gioitinh);
                        cm.Parameters.AddWithValue("@sdt", nvObj.Sdt);
                        cm.Parameters.AddWithValue("@email", nvObj.Email);
                        cm.Parameters.AddWithValue("@diachi", nvObj.Diachi);
                        cm.Parameters.AddWithValue("@user", nvObj.Username);
                        cm.Parameters.AddWithValue("@pass", nvObj.Password);
                        cm.Parameters.AddWithValue("@quyen", nvObj.Quyen);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("tài khoản người dùng đã tồn tại!");
                    }
                }
            }
            return false;
        }
        public bool UpdateData(NhanVien nvObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_updateData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ma", nvObj.Manv);
                        cm.Parameters.AddWithValue("@hoten", nvObj.Hoten);
                        cm.Parameters.AddWithValue("@ngaysinh", nvObj.Ngaysinh);
                        cm.Parameters.AddWithValue("@gioitinh", nvObj.Gioitinh);
                        cm.Parameters.AddWithValue("@sdt", nvObj.Sdt);
                        cm.Parameters.AddWithValue("@email", nvObj.Email);
                        cm.Parameters.AddWithValue("@diachi", nvObj.Diachi);
                        cm.Parameters.AddWithValue("@user", nvObj.Username);
                        cm.Parameters.AddWithValue("@pass", nvObj.Password);
                        cm.Parameters.AddWithValue("@quyen", nvObj.Quyen);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("tài khoản người dùng đã tồn tại!");
                    }
                }
            }
            return false;
        }
    }
}

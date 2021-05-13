using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Controls;

namespace QuanLyCuaHangTienLoi.Views.NhanVien
{
    public partial class frmProfile : Form
    {
        DangNhapCtrl dangnhap = new DangNhapCtrl();
        Objects.NhanVien nvObj = new Objects.NhanVien();

        public frmProfile()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            nvObj.Username = LoginInfo.UserName;

            dt = dangnhap.GetDataByUser(nvObj);

            foreach (DataRow row in dt.Rows)
            {
                txtHoten.Text = row["sHoten"].ToString();
                DateTime date = Convert.ToDateTime(row["dNgaysinh"]);
                txtNgaysinh.Text = date.ToShortDateString();
                if (row["bGioitinh"].ToString() == "True")
                {
                    txtGioitinh.Text = "Nam";
                }else {
                    txtGioitinh.Text = "Nữ";
                }
                txtDiachi.Text = row["sDiachi"].ToString();
                txtSdt.Text = row["sSDT"].ToString();
                txtEmail.Text = row["sEmail"].ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

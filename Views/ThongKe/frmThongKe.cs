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

namespace QuanLyCuaHangTienLoi.Views.ThongKe
{
    public partial class frmThongKe : Form
    {
        QuanLyNhaCungCapCtrl nccCtrl = new QuanLyNhaCungCapCtrl();
        Objects.NhaCungCap nccObj = new Objects.NhaCungCap();
        string mancc;
        Controls.QuanLyMatHangCtrl qlml = new Controls.QuanLyMatHangCtrl();
        Objects.HangHong hanghongObj = new Objects.HangHong();
        Objects.MatHang mathangObj = new Objects.MatHang();
        

        public frmThongKe()
        {
            InitializeComponent();
            Init();
            LoadForm();
        }
        void LoadForm()
        {
            DataTable dt = qlml.GetDataHangHong();
            dgvHanghong.DataSource = dt;
            dgvHanghong.Columns["sNgaythang"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        int flash;
        DataTable dt = new DataTable();

        void Init()
        {
            dt = nccCtrl.GetData();
            dgvNhaCC.DataSource = dt;
        }
        private void btnTkKhiLogin_Click(object sender, EventArgs e)
        {
            txtTKKhiLogin.Text = LoginInfo.Tien.ToString();
        }

        private void dgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtTimNcc_TextChanged(object sender, EventArgs e)
        {

        }

       

  

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

      

        private void btnTimNcc_Click(object sender, EventArgs e)
        {
            if (txtTimNcc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp, hoặc địa chỉ, số điện thoại vào ô tìm kiếm!");
            }
            else
            {
                DataTable dt = nccCtrl.SearchData(txtTimNcc.Text.Trim());
                dgvNhaCC.DataSource = dt;
                txtTimNcc.Text = "";
            }
        }

        private void btnHuyTim_Click(object sender, EventArgs e)
        {
            Init();
            txtTimNcc.Text = "";
        }

        private void txtTimNcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimNcc_Click(sender, e);
            }
        }
        void SearchDataHangHong()
        {
            if (txtTimHangHong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng hỏng vào ô để tìm kiếm");
                txtTimHangHong.Focus();
            }
            else
            {
                DataTable dt = qlml.SearchDataHangHong(txtTimHangHong.Text.Trim());
                dgvHanghong.DataSource = dt;
            }
        }
        private void btnTimHangHong_Click(object sender, EventArgs e)
        {
            SearchDataHangHong();
        }
        private void txtTimHangHong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchDataHangHong();
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
    }


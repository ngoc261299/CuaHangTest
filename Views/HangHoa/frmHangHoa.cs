using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Views.Hàng_hóa;
using QuanLyCuaHangTienLoi.Controls;
using QuanLyCuaHangTienLoi.Objects;

namespace QuanLyCuaHangTienLoi.Views
{
    public partial class frmHangHoa : Form
    {
        QuanLyLoaiHangCtrl qllh = new QuanLyLoaiHangCtrl();
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();
        LoaiHang loaihangObj = new LoaiHang();
        MatHang mathangObj = new MatHang();

        public frmHangHoa()
        {
            InitializeComponent();
            LoadLoaiHang();
            LoadMatHang();
        }

        private void LoadLoaiHang()
        {
            DataTable dt = qllh.GetData();
            dgvLoaiHang.DataSource = dt;
        }

        private void LoadMatHang()
        {
            DataTable dt = qlmh.GetData();
            dgvHangHoa.DataSource = dt;
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            frmThemHangHoa formThemHang = new frmThemHangHoa();
            formThemHang.ShowDialog();
            LoadMatHang();
        }

        string tenloai, maloai;

        public void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            tenloai = dgvLoaiHang.CurrentRow.Cells[1].Value.ToString();
            maloai = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();

            loaihangObj.Maloaihang = maloai;
            loaihangObj.Tenloaihang = tenloai;
            
            frmSuaLoaiHang frmSualoaihang = new frmSuaLoaiHang(loaihangObj);
            frmSualoaihang.ShowDialog();
            LoadLoaiHang();
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang frmThemloaihang = new frmThemLoaiHang();
            frmThemloaihang.ShowDialog();
            LoadLoaiHang();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            string mahang, tenhang, donvitinh, mavach, loaihang;
            int soluong, giaban;

            mahang = dgvHangHoa.CurrentRow.Cells["sMa"].Value.ToString();
            tenhang = dgvHangHoa.CurrentRow.Cells["sTenhang"].Value.ToString();
            donvitinh = dgvHangHoa.CurrentRow.Cells["sDonvitinh"].Value.ToString();
            mavach = dgvHangHoa.CurrentRow.Cells["sMavach"].Value.ToString();
            loaihang = dgvHangHoa.CurrentRow.Cells["sLoaihang"].Value.ToString();
            giaban = int.Parse(dgvHangHoa.CurrentRow.Cells["sGiaban"].Value.ToString());
            soluong = int.Parse(dgvHangHoa.CurrentRow.Cells["sSoluong"].Value.ToString());

            mathangObj.Mamathang = mahang;
            mathangObj.Tenmathang = tenhang;
            mathangObj.Giaban = giaban;
            mathangObj.Donvitinh = donvitinh;
            mathangObj.Soluong = soluong;
            mathangObj.Mavach = mavach;
            
            frmSuaHangHoa frmSuahanghoa = new frmSuaHangHoa(mathangObj);
            frmSuahanghoa.ShowDialog();
            LoadMatHang();
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maloai = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();
            mathangObj.Maloai = int.Parse(maloai);
            DataTable dt = qlmh.GetDataByLoaiHang(mathangObj);
            dgvHangHoa.DataSource = dt;
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        void SearchMatHang()
        {
            if (txtTimMatHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã vạch hoặc tên hàng để tìm kiếm");
            }
            else
            {
                DataTable dt = qlmh.SearchData(txtTimMatHang.Text.Trim());
                dgvHangHoa.DataSource = dt;
            }
            txtTimMatHang.Text = "";
        }

        void SearchLoaiHang()
        {
            if (txtTimLoaiHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng để tìm kiếm");
            }
            else
            {
                DataTable dt = qllh.SearchData(txtTimLoaiHang.Text.Trim());
                dgvLoaiHang.DataSource = dt;
            }
            txtTimLoaiHang.Text = "";
        }

        private void btnTimLoaiHang_Click(object sender, EventArgs e)
        {
            SearchLoaiHang();
        }

        private void btnTimMatHang_Click(object sender, EventArgs e)
        {
            SearchMatHang();
        }

        private void txtTimMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMatHang();
            }
        }

        private void txtTimLoaiHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchLoaiHang();
            }
        }

        private void btnXemLoaiHang_Click(object sender, EventArgs e)
        {
            LoadLoaiHang();
        }

    }
}

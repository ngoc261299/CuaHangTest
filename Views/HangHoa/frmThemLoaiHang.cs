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
using QuanLyCuaHangTienLoi.Objects;

namespace QuanLyCuaHangTienLoi.Views.Hàng_hóa
{
    public partial class frmThemLoaiHang : Form
    {
        QuanLyLoaiHangCtrl qlmh = new QuanLyLoaiHangCtrl();

        LoaiHang loaihangObj = new LoaiHang();

        public frmThemLoaiHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GanDuLieu()
        {
            loaihangObj.Maloaihang = "";
            loaihangObj.Tenloaihang = txtTenloaihang.Text.Trim();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenloaihang.Text.Trim() == "")
            {
                MessageBox.Show("Cần nhập đủ thông tin");
            }
            else
            {
                GanDuLieu();
                if (qlmh.InsertData(loaihangObj))
                {
                    MessageBox.Show("Thêm mặt hàng thành công");
                    this.Close();
                }
            }
        }

        private void frmThemLoaiHang_Load(object sender, EventArgs e)
        {

        }
    }
}

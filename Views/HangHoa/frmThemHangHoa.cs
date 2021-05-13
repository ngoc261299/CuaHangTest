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
    public partial class frmThemHangHoa : Form
    {
        QuanLyLoaiHangCtrl qllh = new QuanLyLoaiHangCtrl();
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();
        MatHang mathangObj = new MatHang();

        public frmThemHangHoa()
        {
            InitializeComponent();
            Init();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenhang.Text.Trim() == "" || txtSoluong.Text.Trim() == "" || txtMavach.Text.Trim() == "" || txtGia.Text.Trim() == "" || txtDovitinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            else if (txtMavach.Text.Length != 13)
            {
                MessageBox.Show("Mã vạch phải có 13 chữ số!");
                txtMavach.Focus();
            }
            else
            {
                GanDuLieu();
                if (qlmh.InsertData(mathangObj))
                {
                    MessageBox.Show("Thêm mặt hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mặt hàng thất bại!");
                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Init()
        {
            DataTable dt = qllh.GetData();
            cboLoaihang.DataSource = dt;
            cboLoaihang.DisplayMember = "sTenloaihang";
            cboLoaihang.ValueMember = "PK_iMaloaihangID";
        }

        private void GanDuLieu()
        {
            mathangObj.Maloai = int.Parse(cboLoaihang.SelectedValue.ToString());
            mathangObj.Tenmathang = txtTenhang.Text.Trim();
            mathangObj.Giaban = int.Parse(txtGia.Text.Trim());
            mathangObj.Soluong = int.Parse(txtSoluong.Text.Trim());
            mathangObj.Donvitinh = txtDovitinh.Text.Trim();
            mathangObj.Mavach = txtMavach.Text.Trim();
        }

        void IsDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập vào phải là số!");
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void txtMavach_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }
    }
}

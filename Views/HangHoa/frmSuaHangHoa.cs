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

namespace QuanLyCuaHangTienLoi.Views.Hàng_hóa
{
    public partial class frmSuaHangHoa : Form
    {
        QuanLyLoaiHangCtrl qllh = new QuanLyLoaiHangCtrl();
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();
        private Objects.MatHang mathangObj;

        public frmSuaHangHoa(Objects.MatHang mathangObj)
        {
            InitializeComponent();
            this.mathangObj = mathangObj;
            Init();
            BidingData();
        }

        private void Init()
        {
            DataTable dt = qllh.GetData();
            cboLoaihang.DataSource = dt;
            cboLoaihang.DisplayMember = "sTenloaihang";
            cboLoaihang.ValueMember = "PK_iMaloaihangID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenhang.Text.Trim() == "" || txtSoluong.Text.Trim() == "" || txtGia.Text.Trim() == "" || txtDonvitinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            else
            {
                GanDuLieu();
                if (qlmh.UpdateData(mathangObj))
                {
                    MessageBox.Show("Sửa thông tin mặt hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin mặt hàng thất bại!");
                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void BidingData()
        {
            txtTenhang.Text = mathangObj.Tenmathang;
            txtSoluong.Text = mathangObj.Soluong.ToString();
            txtGia.Text = mathangObj.Giaban.ToString();
            txtDonvitinh.Text = mathangObj.Donvitinh;
        }

        private void GanDuLieu()
        {
            mathangObj.Maloai = int.Parse(cboLoaihang.SelectedValue.ToString());
            mathangObj.Tenmathang = txtTenhang.Text.Trim();
            mathangObj.Giaban = int.Parse(txtGia.Text.Trim());
            mathangObj.Soluong = int.Parse(txtSoluong.Text.Trim());
            mathangObj.Donvitinh = txtDonvitinh.Text.Trim();
        }

        void IsDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập vào phải là số!");
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

    }
}

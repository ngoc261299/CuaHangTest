using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi.Views.HangHoa
{
    public partial class frmHangHong : Form
    {
        Controls.QuanLyMatHangCtrl qlml = new Controls.QuanLyMatHangCtrl();
        Objects.HangHong hanghongObj = new Objects.HangHong();
        Objects.MatHang mathangObj = new Objects.MatHang();

        public frmHangHong()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            DataTable dt = qlml.GetDataHangHong();
            dgvHanghong.DataSource = dt;
            dgvHanghong.Columns["sNgaythang"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grHanghong.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nmSoluong.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hàng hỏng");
            }
            else if (txtMota.Text == "" || txtMavach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                GanDuLieu();
                if (qlml.InsertDataHangHong(hanghongObj))
                {
                    MessageBox.Show("Thêm hàng hỏng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm hàng hỏng thất bại!");
                }
                LoadForm();
                Clear();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtMavach.Text = "";
            txtTenhang.Text = "";
            nmSoluong.ResetText();
            txtMota.Text = "";

            grHanghong.Enabled = false;
        }

        string mamathang; //mã hàng hỏng
        void GanDuLieu()
        {
            hanghongObj.Mamathang = mamathang;
            hanghongObj.Soluong = int.Parse(nmSoluong.Value.ToString());
            hanghongObj.Mota = txtMota.Text.Trim();
            DateTime dt = DateTime.Now;
            dt.ToShortDateString();
            hanghongObj.Ngaylap = Convert.ToString(dt);
        }

        private void txtMavach_Leave(object sender, EventArgs e)
        {
            mathangObj.Mavach = txtMavach.Text.Trim();
            DataTable dt = qlml.GetDataByMaVach(mathangObj);
            if (dt.Rows.Count > 0)
            {
                txtTenhang.Text = dt.Rows[0]["sTenhang"].ToString();
                mamathang = dt.Rows[0]["PK_iMamathangID"].ToString();
            }
            else
            {
                MessageBox.Show("Không có mặt hàng có mã vạch : " + txtMavach.Text);
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

        private void txtTimHangHong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

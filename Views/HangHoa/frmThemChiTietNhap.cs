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
    public partial class frmThemChiTietNhap : Form
    {
        public frmThemChiTietNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public static string sl = "", gia = "";
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (txtGianhap.Text.Trim() != "")
            {
                gia = txtGianhap.Text.Trim();
            }
            if (txtSL.Text.Trim() != "")
            {
                sl = txtSL.Text.Trim();
            }
            this.Dispose();
        }

        void IsDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("chỉ được nhập số!");
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }
    }
}

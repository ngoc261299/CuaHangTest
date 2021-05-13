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

namespace QuanLyCuaHangTienLoi.Views.NhaCungCap
{
    public partial class frmNhaCungCap : Form
    {
        QuanLyNhaCungCapCtrl nccCtrl = new QuanLyNhaCungCapCtrl();
        Objects.NhaCungCap nccObj = new Objects.NhaCungCap();
        string mancc;

        public frmNhaCungCap()
        {
            InitializeComponent();
            Init();
        }

        int flash;
        DataTable dt = new DataTable();

        void Init()
        {
            dt = nccCtrl.GetData();
            dgvNhaCC.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flash = 1;
            grForm.Enabled = true;
            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flash = 0;
            grForm.Enabled = true;
            BidingData(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtSdt.Text.Trim() == "" || txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                GanDuLieu();
                if (flash == 1)
                {
                    //thêm
                    if (nccCtrl.InsertData(nccObj))
                    {
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại");
                        return;
                    }
                }
                else
                {
                    // Sửa
                    nccObj.Manhacungcap = mancc;
                    if (txtTen.Text.Trim() == txtTen.Tag.ToString() && txtDiachi.Text.Trim() == txtDiachi.Tag.ToString() && txtSdt.Text.Trim() == txtSdt.Tag.ToString())
                    {
                        MessageBox.Show("Thông tin chưa đc thay đổi");
                        return;
                    }
                    else
                    {
                        if (nccCtrl.UpdateData(nccObj))
                        {
                            MessageBox.Show("Sửa thông tin thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới thất bại");
                            return;
                        }
                    }
                }
                Clear();
                grForm.Enabled = false;
                Init();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Clear();
            grForm.Enabled = false;
        }

        public void Clear()
        {
            txtTen.Text = "";
            txtSdt.Text = "";
            txtDiachi.Text = "";
        }

        void GanDuLieu()
        {
            nccObj.Tennhacungcap = txtTen.Text.Trim();
            nccObj.Sdt = txtSdt.Text.Trim();
            nccObj.Diachi = txtDiachi.Text.Trim();
        }

        void BidingData(object sender, EventArgs e)
        {
            mancc = dgvNhaCC.CurrentRow.Cells["sMa"].Value.ToString();
            txtTen.Text = dgvNhaCC.CurrentRow.Cells["sTen"].Value.ToString();
            txtTen.Tag = dgvNhaCC.CurrentRow.Cells["sTen"].Value.ToString();
            txtSdt.Text = dgvNhaCC.CurrentRow.Cells["sSdt"].Value.ToString();
            txtSdt.Tag = dgvNhaCC.CurrentRow.Cells["sSdt"].Value.ToString();
            txtDiachi.Text = dgvNhaCC.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtDiachi.Tag = dgvNhaCC.CurrentRow.Cells["sDiachi"].Value.ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTimNcc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

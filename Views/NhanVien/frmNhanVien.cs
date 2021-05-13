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
using System.Text.RegularExpressions;

namespace QuanLyCuaHangTienLoi.Views
{
    public partial class frmNhanVien : Form
    {
        QuanLyNhanVienCtrl qlnv = new QuanLyNhanVienCtrl();
        Objects.NhanVien nvObj = new Objects.NhanVien();

        int flash;

        public frmNhanVien()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            DataTable dt = qlnv.GetData();
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.Columns["dNgaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flash = 1;
            groupBox2.Enabled = true;
            Clear();
        }

        void GanDuLieu()
        {
            nvObj.Hoten = txtHoten.Text.Trim();
            nvObj.Ngaysinh = dtNgaysinh.Value.ToString("dd/MM/yyyy");
            if (rdoNam.Checked)
            {
                nvObj.Gioitinh = true;
            }
            else
            {
                nvObj.Gioitinh = false;
            }
            nvObj.Sdt = txtSdt.Text.Trim();
            nvObj.Diachi = txtDiachi.Text.Trim();
            nvObj.Email = txtEmail.Text.Trim();
            nvObj.Username = txtUser.Text.Trim();
            nvObj.Password = txtPassword.Text.Trim();
            if (rdoAdmin.Checked)
            {
                nvObj.Quyen = true;
            }
            else
            {
                nvObj.Quyen = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flash = 0;
            groupBox2.Enabled = true;
            string manv = BidingData(sender, e);
            GanDuLieu();
            nvObj.Manv = manv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtHoten.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtSdt.Text.Trim() == "" || txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            else
            {
                bool match;

                //check họ tên
                string theName = @"[!@#$&*\\/\.\?\+_]";
                match = Regex.IsMatch(txtHoten.Text.Trim(), theName);
                if (match)
                {
                    MessageBox.Show("Họ tên không được có ký tự đặc biệt");
                    return;
                }
                if (txtHoten.Text.Length > 50)
                {
                    MessageBox.Show("Họ tên không được vượt quá 50 ký tự");
                    return;
                }
                else if (txtHoten.Text.Length < 5)
                {
                    MessageBox.Show("Họ tên không được quá ngắn");
                    return;
                }

                //check email
                string theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                    + "@"
                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                match = Regex.IsMatch(txtEmail.Text.Trim(), theEmailPattern);
                if (!match)
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return;
                }


                //check địa chỉ
                if (txtDiachi.Text.Length > 150)
                {
                    MessageBox.Show("Địa chỉ không được vượt quá 150 ký tự");
                    return;
                }
                else if (txtDiachi.Text.Length < 8)
                {
                    MessageBox.Show("Địa chỉ không được quá ngắn");
                    return;
                }

                if (flash == 1) // khi nhấn nút thêm
                {
                    //Check email
                    if (qlnv.CheckEmail(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Email đã tồn tại!");
                        return;
                    }

                    //check số điện thoại
                    if (qlnv.CheckSDT(txtSdt.Text.Trim()))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                        return;
                    }
                    GanDuLieu();
                    if (qlnv.InsertData(nvObj))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                }
                else // Khi nhấn nút sửa
                {
                    GanDuLieu();
                    if (qlnv.UpdateData(nvObj))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!");
                    }
                }

                LoadForm();
                btnHuy_Click(sender, e);
            }

        }

        public void Clear()
        {
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtHoten.Text = "";
            txtPassword.Text = "";
            txtSdt.Text = "";
            txtUser.Text = "";
            dtNgaysinh.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Clear();
            groupBox2.Enabled = false;
        }

        //chuyển dữ liệu từ dgvNhanVien ra textBox
        public string BidingData(object sender, EventArgs e)
        {
            string manv;
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells["sHoten"].Value.ToString();
            dtNgaysinh.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells["dNgaySinh"].Value);
            txtSdt.Text = dgvNhanVien.CurrentRow.Cells["sSdt"].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells["sEmail"].Value.ToString();
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtUser.Text = dgvNhanVien.CurrentRow.Cells["sUser"].Value.ToString();
            txtPassword.Text = dgvNhanVien.CurrentRow.Cells["sPass"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["bGioitinh"].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            if (dgvNhanVien.CurrentRow.Cells["bQuyen"].Value.ToString() == "Admin")
            {
                rdoAdmin.Checked = true;
            }
            else
            {
                rdoSeller.Checked = true;
            }
            return manv = dgvNhanVien.CurrentRow.Cells["sMa"].Value.ToString();
        }

        void SearchData()
        {
            if (txtTimNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên hoặc địa chỉ hoặc tài khoản vào ô tìm kiếm!");
            }
            else
            {
                DataTable dt = qlnv.SearchData(txtTimNhanVien.Text.Trim());
                dgvNhanVien.DataSource = dt;
                txtTimNhanVien.Text = "";
            }
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void bntHuyTim_Click(object sender, EventArgs e)
        {
            LoadForm();
            txtTimNhanVien.Text = "";
        }

        private void txtTimNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimNhanVien_Click(sender, e);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số!");
                return;
            }
        }

        private void txtSdt_Leave(object sender, EventArgs e)
        {
            if (txtSdt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            else
            {
                if (txtSdt.Text.Length < 10 || txtSdt.Text.Length > 11)
                {
                    MessageBox.Show("Số điện thoại phải có 10 hoặc 11 số");
                    txtSdt.Focus();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       
    }
}

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

namespace QuanLyCuaHangTienLoi.Views.NhanVien
{
    public partial class frmChangePass : Form
    {
        DangNhapCtrl dangnhap = new DangNhapCtrl();
        Objects.NhanVien nvObj = new Objects.NhanVien();

        public frmChangePass()
        {
            InitializeComponent();
            txtUsername.Text = LoginInfo.UserName;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nvObj.Username = LoginInfo.UserName;
            nvObj.Password = txtOldPass.Text;

            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtPassConfirm.Text == "")
            {
                MessageBox.Show("Thông tin cần được nhập đầy đủ");
                return;
            } else if(txtOldPass.Text == txtNewPass.Text) {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ");
            }
            else
            {
                if (dangnhap.User(nvObj))
                {
                    if (txtNewPass.Text == txtPassConfirm.Text)
                    {
                        nvObj.Password = txtNewPass.Text;
                        dangnhap.UpdatePass(nvObj);
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp nhau");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != "" || txtOldPass.Text != "" || txtPassConfirm.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}

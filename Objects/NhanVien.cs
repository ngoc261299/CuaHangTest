using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class NhanVien
    {
        private string manv;
        private string hoten;
        private string ngaysinh;
        private bool gioitinh;
        private string sdt;
        private string email;
        private string diachi;
        private string username;
        private string password;
        private bool quyen;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }     

        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }     

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }       

        public string Email
        {
            get { return email; }
            set { email = value; }
        }       

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public NhanVien() { }

        public NhanVien(string manv, string hoten, string ngaysinh, bool gioitinh, string sdt, string email, string diachi, string username, string password, bool quyen)
        {
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.email = email;
            this.diachi = diachi;
            this.username = username;
            this.password = password;
            this.quyen = quyen;
        }

    }


}

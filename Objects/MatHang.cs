using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    public class MatHang
    {
        string mamathang, tenmathang, donvitinh, mavach;
        int soluong, giaban, maloai;

        public int Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        public int Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public string Mavach
        {
            get { return mavach; }
            set { mavach = value; }
        }

        public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }

        public string Tenmathang
        {
            get { return tenmathang; }
            set { tenmathang = value; }
        }

        public string Mamathang
        {
            get { return mamathang; }
            set { mamathang = value; }
        }

        public MatHang() { }

        public MatHang(string mamathang, int maloai, string tenmathang, int soluong, string donvitinh, string mavach, int giaban)
        {
            this.mamathang = mamathang;
            this.tenmathang = tenmathang;
            this.soluong = soluong;
            this.donvitinh = donvitinh;
            this.mavach = mavach;
            this.giaban = giaban;
            this.maloai = maloai;
        }
    }
}

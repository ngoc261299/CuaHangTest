using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class ChiTietBan
    {
        int mahoadon, mamathang, soluong;
        string giaban;

        public string Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int Mamathang
        {
            get { return mamathang; }
            set { mamathang = value; }
        }

        public int Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }

        public ChiTietBan() { }

        public ChiTietBan(int mahoadon, int mamathang, string giaban, int soluong)
        {
            this.mahoadon = mahoadon;
            this.mamathang = mamathang;
            this.giaban = giaban;
            this.soluong = soluong;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    public class ChiTietNhap
    {
        int mahang, sl;
        float gia;
        public int Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }
        public int Soluong
        {
            get { return sl; }
            set { sl = value; }
        }
        public float Gianhap
        {
            get { return gia; }
            set { gia = value; }
        }

        ~ChiTietNhap() { }
    }
}

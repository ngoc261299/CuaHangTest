using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class HoaDonNhap
    {
        int mancc, manv, mahoadon;
        string ngaylap;

        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public int Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        public int MaNCC
        {
            get { return mancc; }
            set { mancc = value; }
        }
        public int MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        public HoaDonNhap() { }

        ~HoaDonNhap() { }
    }
}

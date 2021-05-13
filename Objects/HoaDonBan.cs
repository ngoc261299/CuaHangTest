using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class HoaDonBan
    {
        int mahoadon, manhanvien;
        string ngaylap;

        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public int Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }

        public int Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }

        public HoaDonBan() { }

        public HoaDonBan(int mahoadon, int manhanvien, string ngaylap)
        {
            this.mahoadon = mahoadon;
            this.manhanvien = manhanvien;
            this.ngaylap = ngaylap;
        }
    }
}

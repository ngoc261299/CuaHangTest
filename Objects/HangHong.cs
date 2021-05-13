using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class HangHong
    {
        string mamathang, mota, ngaylap;
        int soluong;

        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        public string Mamathang
        {
            get { return mamathang; }
            set { mamathang = value; }
        }
        
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public HangHong() { }

        public HangHong(string mamathang, string mota, string ngaylap, int soluong)
        {
            this.mamathang = mamathang;
            this.mota = mota;
            this.ngaylap = ngaylap; 
            this.soluong = soluong;
        }
    }
}

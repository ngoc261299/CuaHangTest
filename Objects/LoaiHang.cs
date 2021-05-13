using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    public class LoaiHang
    {
        string maloaihang, tenloaihang;

        public string Maloaihang
        {
            get { return maloaihang; }
            set { maloaihang = value; }
        }

        public string Tenloaihang
        {
          get { return tenloaihang; }
          set { tenloaihang = value; }
        }

        public LoaiHang() { }

        public LoaiHang(string maloaihang, string tenloaihang)
        {
            this.maloaihang = maloaihang;
            this.tenloaihang = tenloaihang;
        }
    }
}

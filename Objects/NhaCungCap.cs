using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Objects
{
    class NhaCungCap
    {
        string manhacungcap, tennhacungcap, sdt, diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Tennhacungcap
        {
            get { return tennhacungcap; }
            set { tennhacungcap = value; }
        }

        public string Manhacungcap
        {
            get { return manhacungcap; }
            set { manhacungcap = value; }
        }

        public NhaCungCap() { }

        public NhaCungCap(string manhacungcap, string tennhacungcap, string sdt, string diachi)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.sdt = sdt;
            this.diachi = diachi;
        }
    }
}

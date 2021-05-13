using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyCuaHangTienLoi.Models;
using QuanLyCuaHangTienLoi.Objects;

namespace QuanLyCuaHangTienLoi.Controls
{
    class QuanLyNhaCungCapCtrl
    {
        NhaCungCapMod nccMod = new NhaCungCapMod();

        public DataTable GetData()
        {
            return nccMod.GetData();
        }

        public DataTable SearchData(string search)
        {
            return nccMod.SearchData(search);
        }

        public bool InsertData(NhaCungCap nccObj)
        {
            return nccMod.InsertData(nccObj);
        }

        public bool UpdateData(NhaCungCap nccObj)
        {
            return nccMod.UpdateData(nccObj);
        }
    }
}

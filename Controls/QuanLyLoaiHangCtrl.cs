using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangTienLoi.Models;
using System.Data;
using QuanLyCuaHangTienLoi.Objects;

namespace QuanLyCuaHangTienLoi.Controls
{
    class QuanLyLoaiHangCtrl
    {
        LoaiHangMod loaiHang = new LoaiHangMod();

        public DataTable GetData()
        {
            return loaiHang.GetData();
        }

        public DataTable SearchData(string search)
        {
            return loaiHang.SearchData(search);
        }

        public bool InsertData(LoaiHang loaihangObj)
        {
            return loaiHang.InsertData(loaihangObj);
        }

        public bool UpdateData(LoaiHang loaihangObj)
        {
            return loaiHang.UpdateData(loaihangObj);
        }
    }
}

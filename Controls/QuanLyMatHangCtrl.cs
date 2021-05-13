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
    class QuanLyMatHangCtrl
    {
        MatHangMod mathangMod = new MatHangMod();

        public DataTable GetData()
        {
            return mathangMod.GetData();
        }

        public DataTable GetDataByMaVach(MatHang mathangObj)
        {
            return mathangMod.GetDataByMaVach(mathangObj);
        }

        public DataTable GetDataByLoaiHang(MatHang mathangObj)
        {
            return mathangMod.GetDataByLoaiHang(mathangObj);
        }

        public DataTable SearchData(string search)
        {
            return mathangMod.SearchData(search);
        }

        public bool InsertData(MatHang mathangObj)
        {
            return mathangMod.InsertData(mathangObj);
        }

        public bool UpdateData(MatHang mathangObj)
        {
            return mathangMod.UpdateData(mathangObj);
        }

        public DataTable GetDataHangHong()
        {
            return mathangMod.GetDataHangHong();
        }

        public bool InsertDataHangHong(HangHong hanghongObj)
        {
            return mathangMod.InsertDataHangHong(hanghongObj);
        }

        public DataTable SearchDataHangHong(string search)
        {
            return mathangMod.SearchDataHangHong(search);
        }
    }
}

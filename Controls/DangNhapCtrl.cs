using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangTienLoi.Models;
using QuanLyCuaHangTienLoi.Objects;
using System.Data;

namespace QuanLyCuaHangTienLoi.Controls
{
    class DangNhapCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();

        public bool User(NhanVien nvObj)
        {
            return nvMod.User(nvObj);


            ///adadadadada
        }

        public DataTable GetDataByUser(NhanVien nvObj)
        {
            return nvMod.GetDataByUser(nvObj);
        }

        public bool UpdatePass(NhanVien nvObj)
        {
            return nvMod.UpdatePass(nvObj);
        }
    }

    public static class LoginInfo
    {
        public static string UserName;
        public static string Manv;
        public static bool Quyen;
        public static int Tien;
    }
}

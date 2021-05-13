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
    class QuanLyHoaDonCtrl
    {
        HoaDonBanMod hoadonMod = new HoaDonBanMod();
        ChiTietBanMod chitietbanMod = new ChiTietBanMod();

        // Hóa đơn bán
        public DataTable GetDataHoaDon()
        {
            return hoadonMod.GetData();
        }

        public DataTable GetDataHoaDonByTenNV(Objects.HoaDonBan hoadonbanObj)
        {
            return hoadonMod.GetDataByTenNV(hoadonbanObj);
        }

        public DataTable GetDataHoaDonByNgayLap(string ngaybatdau, string ngayketthuc)
        {
            return hoadonMod.GetDataByNgayLap(ngaybatdau, ngayketthuc);
        }

        public DataTable GetDataHoaDonByTenANDngay(Objects.HoaDonBan hoadonbanObj, string ngaybatdau, string ngayketthuc)
        {
            return hoadonMod.GetDataByTenANDngay(hoadonbanObj, ngaybatdau, ngayketthuc);
        }

        public bool InsertHoaDonBan()
        {
            return hoadonMod.InsertHoaDonBan();
        }

        // Chi tiết hóa đơn bán
        public DataTable GetDataChiTietBan()
        {
            return chitietbanMod.GetData();
        }

        public DataTable GetDataChiTietBan_byHoaDon(Objects.HoaDonBan hodonbanObj)
        {
            return chitietbanMod.GetDataByHoaDon(hodonbanObj);
        }

        public bool InsertChiTietBan(ChiTietBan ctbObj)
        {
            return chitietbanMod.InsertChiTietBan(ctbObj);
        }

        //Hóa đơn nhập
        HoaDonNhapMod hoadonnhapMod = new HoaDonNhapMod();
        ChiTietNhapMod chitietnhapMod = new ChiTietNhapMod();

        public DataTable GetDataHoaDonNhap()
        {
            return hoadonnhapMod.GetDataHoaDonNhap();
        }

        public DataTable GetDataHoaDonNhapByTenNV(Objects.HoaDonNhap hoadonnhapObj)
        {
            return hoadonnhapMod.GetDataByTenNV(hoadonnhapObj);
        }

        public DataTable GetDataHoaDonNhapByNgayLap(string ngaybatdau, string ngayketthuc)
        {
            return hoadonnhapMod.GetDataByNgayLap(ngaybatdau, ngayketthuc);
        }

        public DataTable GetDataHoaDonNhapByTenANDngay(Objects.HoaDonNhap hoadonnhapObj, string ngaybatdau, string ngayketthuc)
        {
            return hoadonnhapMod.GetDataByTenANDngay(hoadonnhapObj, ngaybatdau, ngayketthuc);
        }

        public bool InsertHoaDonNhap(HoaDonNhap nhaphangObj)
        {
            return hoadonnhapMod.InsertHoaDonNhap(nhaphangObj);
        }

        // Chi tiết hóa đơn nhập
        public DataTable GetDataChiTietNhap()
        {
            return chitietnhapMod.GetData();
        }

        public DataTable GetDataChiTietNhap_byHoaDon(HoaDonNhap hoadonnhapObj)
        {
            return chitietnhapMod.GetDataChiTietNhap_byHoaDon(hoadonnhapObj);
        }

        public bool InsertChiTietNhap(ChiTietNhap chitietObj)
        {
            return chitietnhapMod.InsertChiTietNhap(chitietObj);
        }
    }
}

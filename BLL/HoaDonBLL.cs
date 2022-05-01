using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonAccess hoaDonAccess;
        public HoaDonBLL()
        {
            hoaDonAccess = new HoaDonAccess();
        }
        public void ThemHoaDon(string maMatHang, string maKhachHang, string maNguoiTao,
            DateTime thoiGian, int soLuong, int khachTra, string phuongThuc, string trangThai)
        {
            hoaDonAccess.InsertHoaDon(maMatHang, maKhachHang, maNguoiTao, thoiGian, soLuong, khachTra, phuongThuc, trangThai);
        }
        public void CapNhatHoaDon(string maMatHang, string maKhachHang, string maNguoiTao,
            DateTime thoiGian, int soLuong, int khachTra, string phuongThuc, string trangThai)
        {
            hoaDonAccess.Update(maMatHang, maKhachHang, maNguoiTao, thoiGian, soLuong, khachTra, phuongThuc, trangThai);
        }
        public void XoaHoaDon(string maMatHang, string maKhachHang)
        {
            hoaDonAccess.Del(maMatHang, maKhachHang);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XuLyDonHangDAL
    {
        private DatabaseAccess databaseAccess;
        public XuLyDonHangDAL()
        {
            databaseAccess = new DatabaseAccess();
        }
        public DataSet LoadForm(string maPhieu)
        {
            string query = "WITH TMP AS( " +
                "SELECT GiaBan, TenHang, GioHang.SoLuong, MaPhieu, MaSanPham " +
                "FROM CuaHang INNER JOIN GioHang " +
                "ON CuaHang.MaMatHang = GioHang.MaSanPham) " +
                "SELECT TenHang as TenSanPham, SoLuong, GiaBan, MaSanPham, KhachTra " +
                "FROM TMP INNER JOIN HoaDon " +
                "ON TMP.MaPhieu = HoaDon.MaPhieu " +
                "WHERE HoaDon.MaPhieu = N'" + maPhieu + "'";
            return databaseAccess.executeQuery(query);
        }
        public void Update(string maPhieu, int[] soLuong, string[] maSanPham, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string query = "UPDATE GioHang SET SoLuong = '" + soLuong[i] + "' " +
                    "WHERE MaPhieu = '" + maPhieu + "' AND MaSanPham = N'" + maSanPham[i] + "'";
                databaseAccess.executeNonQuery(query);
            }
        }
        public void Delete(string maPhieu, string maSanPham)
        {
            string query = "DELETE FROM GioHang WHERE MaPhieu = '" + maPhieu + "' AND MaSanPham = '" + maSanPham + "'";
            databaseAccess.executeNonQuery(query);
        }
        public void ThanhToan(int thanhToan, string maPhieu)
        {
            string query = "UPDATE HoaDon SET KhachTra = " + thanhToan + " WHERE MaPhieu = '" + maPhieu + "'";
            databaseAccess.executeNonQuery(query);
        }
    }
}

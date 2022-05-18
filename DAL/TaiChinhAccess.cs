using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class TaiChinhAccess
    {
        private DatabaseAccess databaseAccess;
        public TaiChinhAccess()
        {
            databaseAccess = new DatabaseAccess();
        }
        public DataSet LoadVon()
        {
            string query = "SELECT * FROM TaiChinh";
            return databaseAccess.executeQuery(query);
        }
        public DataSet LoadDoanhThu()
        {
            string query = "WITH TMP AS( " +
                "SELECT HoaDon.MaPhieu, MaSanPham, SoLuong, NgayGiaoDich, KhachTra " +
                "FROM GioHang INNER JOIN HoaDon ON GioHang.MaPhieu = HoaDon.MaPhieu ) " +
                "SELECT MaMatHang, SUM(TMP.SoLuong) AS SLuong, NgayGiaoDich, SUM(KhachTra) AS TongGia, TenHang, GiaBan " +
                "FROM TMP INNER JOIN CuaHang ON TMP.MaSanPham = CuaHang.MaMatHang " +
                "GROUP BY MaMatHang, NgayGiaoDich, TenHang, GiaBan";
            return databaseAccess.executeQuery(query);
        }
        public DataSet doanhThu()
        {
            string query = "SELECT SUM(KhachTra) AS TongGia FROM HoaDon WHERE YEAR(NgayGiaoDich) = " + DateTime.Now.Year + "";
            return databaseAccess.executeQuery(query);
        }
        public DataSet LoadChiTieu()
        {
            string query = "SELECT MaMatHang, TenHang, NgayNhap, SoLuongNhap, GiaNhap, (SoLuong * GiaNhap) AS TongGia " +
                "FROM Kho INNER JOIN CuaHang ON Kho.MaSanPham = CuaHang.MaMatHang";
            return databaseAccess.executeQuery(query);
        }
        public DataSet LoadThongKe(int value)
        {
            string query = "WITH TMP AS(SELECT GioHang.MaPhieu, MaSanPham, SoLuong " +
                "FROM GioHang INNER JOIN HoaDon ON GioHang.MaPhieu = HoaDon.MaPhieu " +
                "WHERE MONTH(NgayGiaoDich) = " + value + " AND YEAR(NgayGiaoDich) = " + DateTime.Now.Year + " )" +
                "SELECT SUM(TMP.SoLuong*GiaBan) AS TongGia, TenHang AS SanPham " +
                "FROM TMP INNER JOIN CuaHang ON TMP.MaSanPham = CuaHang.MaMatHang GROUP BY TenHang";
            return databaseAccess.executeQuery(query);
        }
        public DataSet LoadThongKeNam(int value)
        {
            string query = "WITH TMP AS(SELECT GioHang.MaPhieu, MaSanPham, SoLuong " +
                "FROM GioHang INNER JOIN HoaDon ON GioHang.MaPhieu = HoaDon.MaPhieu " +
                "WHERE YEAR(NgayGiaoDich) = " + value + " )" +
                "SELECT SUM(TMP.SoLuong*GiaBan) AS TongGia, TenHang AS SanPham " +
                "FROM TMP INNER JOIN CuaHang ON TMP.MaSanPham = CuaHang.MaMatHang GROUP BY TenHang";
            return databaseAccess.executeQuery(query);
        }
        public int[] LoadThongKeTong(int value)
        {
            int[] tongGia = new int[13];
            for (int i = 1; i <= 12; i++)
            {
                string query = "WITH TMP AS(SELECT GioHang.MaPhieu, MaSanPham, SoLuong " +
                "FROM GioHang INNER JOIN HoaDon ON GioHang.MaPhieu = HoaDon.MaPhieu " +
                "WHERE MONTH(NgayGiaoDich) = " + i + " AND YEAR(NgayGiaoDich) = " + value + " ) " +
                "SELECT SUM(TMP.SoLuong*GiaBan) AS TongGia " +
                "FROM TMP INNER JOIN CuaHang ON TMP.MaSanPham = CuaHang.MaMatHang";
                DataRow dr = databaseAccess.executeQuery(query).Tables[0].Rows[0];
                tongGia[i] = Convert.ToInt32(dr["TongGia"]);
            }
            return tongGia;
        }

        public void Update(string mng, string tng, int von, DateTime tg, string email, string nguon)
        {
            string query = "UPDATE TaiChinh " +
                "SET TenNguoiGop = N'" + tng + "', Von = " + von + ", NgayGopVon = '" + tg + "', " +
                "Email = '" + email + "', Nguon = N'" + nguon + "' " +
                "WHERE MaNguoiGop = '" + mng + "'";
            databaseAccess.executeNonQuery(query);
        }
        public void InsertVon(string mng, string tng, int von, DateTime tg, string email, string nguon)
        {
            string query = "INSERT INTO TaiChinh(MaNguoiGop, TenNguoiGop, Von, NgayGopVon, Email, Nguon) " +
                "VALUES ('" + mng + "', N'" + tng + "', " + von + ", '" + tg + "', '" + email + "', N'" + nguon + "')";
            databaseAccess.executeNonQuery(query);
        }
    }
}

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
    public class HoaDonAccess
    {
        private DatabaseAccess databaseAccess;

        public HoaDonAccess()
        {
            databaseAccess = new DatabaseAccess();
        }

        public DataSet LoadHoaDon()
        {
            string query = "SELECT MaPhieu, NgayGiaoDich, KhachHang.MaKhachHang, TenKhachHang, KhachTra, No " +
                "FROM HoaDon INNER JOIN KhachHang " +
                "ON HoaDon.MaKhachHang = KhachHang.MaKhachHang";
            return databaseAccess.executeQuery(query);
        }

        public DataSet Search(string valueSearch)
        {
            string query = "SELECT MaPhieu, NgayGiaoDich, KhachHang.MaKhachHang, TenKhachHang, KhachTra, No " +
                "FROM HoaDon INNER JOIN KhachHang " +
                "ON HoaDon.MaKhachHang = KhachHang.MaKhachHang " +
                "WHERE MaPhieu LIKE N'%" + valueSearch + "%' OR TenKhachHang LIKE N'%" + valueSearch + "%'";
            return databaseAccess.executeQuery(query);
        }

        public void UpdateVon(string mp, int von)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.HoaDons.SingleOrDefault(t => t.MaPhieu == mp);
                var tim1 = db.CuaHangs.SingleOrDefault(t => t.MaMatHang == "");
                if (tim != null)
                {
                    tim.KhachTra = von;
                    /*if (tim.so * tim1.GiaBan == tim.KhachTra)
                    {
                        tim.No = "Không";
                    }*/
                }
                db.SaveChanges();
            }
        }
    }
}

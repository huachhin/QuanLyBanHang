using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using DTO;

namespace DAL
{
    public class HoaDonAccess
    {
        public DataTable LoadHoaDon()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.CuaHangs
                            join p in db.HoaDons
                            on q.MaMatHang equals p.MaMatHang
                            select new
                            {
                                TenMatHang = q.TenHang,
                                MaPhieu = p.MaPhieu,
                                SoLuong = p.SoLuong,
                                NgayGiaoDich = p.NgayGiaoDich,
                                MaKhachHang = p.MaKhachHang,
                                KhachTra = p.KhachTra,
                                GiaBan = q.GiaBan,
                                TongGia = p.TongGia,
                                No = p.No
                            };
                var query1 = from t in db.KhachHangs
                             join r in query
                             on t.MaKhachHang equals r.MaKhachHang
                             select new
                             {
                                 TenKhachHang = t.TenKhachHang,
                                 GiaBan = r.GiaBan,
                                 TenMatHang = r.TenMatHang,
                                 MaPhieu = r.MaPhieu,
                                 SoLuong = r.SoLuong,
                                 NgayGiaoDich = r.NgayGiaoDich,
                                 KhachTra = r.KhachTra,
                                 TongGia = r.TongGia,
                                 No = r.No
                             };

                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query1, "MaPhieu", "TenKhachHang", "TenMatHang", "NgayGiaoDich", "GiaBan", "SoLuong", "TongGia", "KhachTra", "No");
                dt.Load(reader);
                return dt;
            }
        }        
        public DataTable Search(string valueSearch)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.CuaHangs
                            join p in db.HoaDons
                            on q.MaMatHang equals p.MaMatHang
                            select new
                            {
                                TenMatHang = q.TenHang,
                                MaPhieu = p.MaPhieu,
                                SoLuong = p.SoLuong,
                                NgayGiaoDich = p.NgayGiaoDich,
                                MaKhachHang = p.MaKhachHang,
                                KhachTra = p.KhachTra,
                                GiaBan = q.GiaBan,
                                TongGia = p.TongGia,
                                No = p.No
                            };
                var query1 = from t in db.KhachHangs
                             join r in query
                             on t.MaKhachHang equals r.MaKhachHang
                             where t.TenKhachHang.Contains(valueSearch) 
                             || r.MaPhieu.Contains(valueSearch)
                             || r.TenMatHang.Contains(valueSearch)
                             select new
                             {
                                 TenKhachHang = t.TenKhachHang,
                                 GiaBan = r.GiaBan,
                                 TenMatHang = r.TenMatHang,
                                 MaPhieu = r.MaPhieu,
                                 SoLuong = r.SoLuong,
                                 NgayGiaoDich = r.NgayGiaoDich,
                                 KhachTra = r.KhachTra,
                                 TongGia = r.TongGia,
                                 No = r.No
                             };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query1, "MaPhieu", "TenKhachHang", "TenMatHang", "NgayGiaoDich", "GiaBan", "SoLuong", "TongGia", "KhachTra", "No");
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable GopDon()
        {
            using(var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from d in db.HoaDons
                            group d by d.MaKhachHang into g
                            select g;
                //select new
                //{
                //    MaKhachHang = g.Key,
                //    TongGia = (from gg in g
                //               select gg.TongGia),
                //};
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
    }
}

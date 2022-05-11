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
        public DataTable LoadHoaDon()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.CuaHangs
                            join p in db.HoaDons
                            on q.MaMatHang equals p.MaMatHang
                            where p.No == "Nợ"
                            select new
                            {
                                TenMatHang = q.TenHang,
                                MaPhieu = p.MaPhieu,
                                SoLuong = p.SoLuong,
                                NgayGiaoDich = p.NgayGiaoDich,
                                MaKhachHang = p.MaKhachHang,
                                KhachTra = p.KhachTra,
                                GiaBan = q.GiaBan,
                                TongGia = p.SoLuong * q.GiaBan,
                                No = p.No
                            };
                var query1 = from t in db.KhachHangs
                             join r in query
                             on t.MaKhachHang equals r.MaKhachHang
                             select new
                             {
                                 TenKhachHang = t.TenKhachHang,
                                 MaKhachHang = t.MaKhachHang,
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
                var reader = ObjectReader.Create(query1, "MaPhieu", "TenKhachHang", "MaKhachHang", "TenMatHang", "NgayGiaoDich", "GiaBan", "SoLuong", "TongGia", "KhachTra", "No");
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable LoadLichSu()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from ls in db.HoaDons
                            join q in db.CuaHangs
                            on ls.MaMatHang equals q.MaMatHang
                            where ls.No == "Không"
                            select new
                            {
                                MaPhieu = ls.MaPhieu,
                                MaKhachHang = ls.MaKhachHang,
                                NgayGiaoDich = ls.NgayGiaoDich,
                                MaNguoiTao = ls.MaNguoiTao,
                                TongGia = ls.SoLuong * q.GiaBan,
                                PhuongThuc = ls.PhuongThuc,
                            };
                var query1 = from ls in query
                             join p in db.NhanViens
                             on ls.MaNguoiTao equals p.MaNhanVien
                             select new
                             {
                                 MaPhieu = ls.MaPhieu,
                                 MaKhachHang = ls.MaKhachHang,
                                 NgayGiaoDich = ls.NgayGiaoDich,
                                 TenNhanVien = p.TenNhanVien,
                                 TongGia = ls.TongGia,
                                 PhuongThuc = ls.PhuongThuc,
                             };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query1);
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable HienThiChiTiet(string mp)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from ls in db.HoaDons
                            join q in db.CuaHangs
                            on ls.MaMatHang equals q.MaMatHang
                            where ls.MaPhieu == mp
                            select new
                            {
                                MaPhieu = ls.MaPhieu,
                                MaKhachHang = ls.MaKhachHang,
                                MaMatHang = ls.MaMatHang,
                                MaNguoiTao = ls.MaNguoiTao,
                                NgayGiaoDich = ls.NgayGiaoDich,
                                SoLuong = ls.SoLuong,
                                TongGia = ls.SoLuong * q.GiaBan,
                                KhachTra = ls.KhachTra,
                                PhuongThuc = ls.PhuongThuc,
                            };
                var query1 = from ls in query
                             join p in db.NhanViens
                             on ls.MaNguoiTao equals p.MaNhanVien
                             select new
                             {
                                 MaPhieu = ls.MaPhieu,
                                 MaKhachHang = ls.MaKhachHang,
                                 MaMatHang = ls.MaMatHang,
                                 TenNhanVien = p.TenNhanVien,
                                 NgayGiaoDich = ls.NgayGiaoDich,
                                 SoLuong = ls.SoLuong,
                                 TongGia = ls.TongGia,
                                 KhachTra = ls.KhachTra,
                                 PhuongThuc = ls.PhuongThuc,
                             };
                var query2 = from ls in query1
                             join p in db.KhachHangs
                             on ls.MaKhachHang equals p.MaKhachHang
                             select new
                             {
                                 MaPhieu = ls.MaPhieu,
                                 MaKhachHang = ls.MaKhachHang,
                                 MaMatHang = ls.MaMatHang,
                                 TenNhanVien = ls.TenNhanVien,
                                 TenKhachHang = p.TenKhachHang,
                                 NgayGiaoDich = ls.NgayGiaoDich,
                                 SoLuong = ls.SoLuong,
                                 TongGia = ls.TongGia,
                                 KhachTra = ls.KhachTra,
                                 PhuongThuc = ls.PhuongThuc,
                             };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query2);
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
                            where p.No == "Nợ"
                            select new
                            {
                                TenMatHang = q.TenHang,
                                MaPhieu = p.MaPhieu,
                                SoLuong = p.SoLuong,
                                NgayGiaoDich = p.NgayGiaoDich,
                                MaKhachHang = p.MaKhachHang,
                                KhachTra = p.KhachTra,
                                GiaBan = q.GiaBan,
                                TongGia = p.SoLuong * q.GiaBan,
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
                                 MaKhachHang = t.MaKhachHang,
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
                var reader = ObjectReader.Create(query1, "MaPhieu", "TenKhachHang", "MaKhachHang", "TenMatHang", "NgayGiaoDich", "GiaBan", "SoLuong", "TongGia", "KhachTra", "No");
                dt.Load(reader);
                return dt;
            }
        }
        public void UpdateVon(string mp, int von)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.HoaDons.SingleOrDefault(t => t.MaPhieu == mp);
                var tim1 = db.CuaHangs.SingleOrDefault(t => t.MaMatHang == tim.MaMatHang);
                if (tim != null)
                {
                    tim.KhachTra = von;
                    if(tim.SoLuong * tim1.GiaBan == tim.KhachTra)
                    {
                        tim.No = "Không";
                    }
                }
                db.SaveChanges();
            }
        }
        public void GopDon(string[] maphieu)
        {
            string temp = maphieu[0];
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.HoaDons.SingleOrDefault(t => t.MaPhieu.Contains(temp));
                var tim1 = db.CuaHangs.SingleOrDefault(t => t.MaMatHang == tim.MaMatHang);
                var query = from hd in db.HoaDons
                            where hd.MaKhachHang == tim.MaKhachHang
                            group hd by hd.MaKhachHang into g
                            select new
                            {
                                MaKhacHang = g.Key,
                                SoLuong = g.Sum(s => s.SoLuong),
                                KhachTra = g.Sum(k => k.KhachTra)
                            };
                foreach (var item in query)
                {
                    if (tim != null)
                    {

                        tim.SoLuong = item.SoLuong;
                        tim.KhachTra = item.KhachTra;                        
                    }
                }
                for (int j = 1; j < maphieu.Length; j++)
                {
                    temp = maphieu[j];
                    var mp = db.HoaDons.SingleOrDefault(t => t.MaPhieu.Contains(temp));
                    db.HoaDons.Remove(mp);
                }
                db.SaveChanges();
            }
        }
    }
}

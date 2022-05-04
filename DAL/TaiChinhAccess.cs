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
    public class TaiChinhAccess
    {
        public DataTable LoadVon()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.TaiChinhs
                            select q;
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable LoadThongKe()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from d in db.HoaDons
                            select d;
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable LoadDoanhThu()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.HoaDons
                            join p in db.CuaHangs
                            on q.MaMatHang equals p.MaMatHang
                            select new
                            {
                                MaMatHang = p.MaMatHang,
                                TenHang = p.TenHang,
                                SoLuong = q.SoLuong,
                                GiaBan = p.GiaBan,
                                NgayGiaoDich = q.NgayGiaoDich
                            };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public DataTable LoadChiTieu()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.Khoes
                            join p in db.CuaHangs
                            on q.MaSanPham equals p.MaMatHang
                            select new
                            {
                                MaMatHang = p.MaMatHang,
                                TenHang = p.TenHang,
                                SoLuongNhap = q.SoLuongNhap,
                                GiaNhap = q.GiaNhap,
                                NgayNhap = q.NgayNhap
                            };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public void InsertVon(string mng, string tng, int von, DateTime tg, string email, string nguon)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.TaiChinhs.SingleOrDefault(t => t.MaNguoiGop == mng);
                if (tim != null)
                {                    
                    tim.TenNguoiGop = tng;
                    tim.NgayGopVon = tg;
                    tim.Email = email;
                    tim.Von = von;
                }
                else
                {
                    var tc = new TaiChinh()
                    {
                        TenNguoiGop = tng,
                        MaNguoiGop = mng,
                        Von = von,
                        NgayGopVon = tg,
                        Nguon = nguon,
                        Email = email
                    };
                    db.TaiChinhs.Add(tc);
                }
                db.SaveChanges();
            }
        }
        public void UpdateVon(string mng, int von)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.TaiChinhs.SingleOrDefault(t => t.MaNguoiGop == mng);
                if (tim != null)
                {
                    tim.Von = von;
                }
                db.SaveChanges();
            }
        }
    }
}

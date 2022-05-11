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
        public DataTable LoadThongKe(int value)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from hd in db.HoaDons
                            join ch in db.CuaHangs
                            on hd.MaMatHang equals ch.MaMatHang
                            where hd.NgayGiaoDich.Value.Year == value || hd.NgayGiaoDich.Value.Month == value
                            select new
                            {
                                TenHang = ch.TenHang,
                                TongGia = hd.SoLuong * ch.GiaBan
                            };
                var query1 = from q in query
                             group q by q.TenHang into g
                             select new
                             {
                                SanPham = g.Key,
                                TongGia = g.Sum(t => t.TongGia)
                             };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query1);
                dt.Load(reader);
                return dt;
            }
        }
        public int[] LoadThongKeTong(int value)
        {
            int[] tongGia = new int[13];
            int temp;
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from hd in db.HoaDons
                            join q in db.CuaHangs
                            on hd.MaMatHang equals q.MaMatHang
                            where hd.NgayGiaoDich.Value.Year == value
                            select new
                            {
                                TongGia = hd.SoLuong * q.GiaBan,
                                NgayGD = hd.NgayGiaoDich
                            };
                for (int i = 1; i <= 12; i++)
                {
                    temp = 0;
                    var query1 = from q in query
                                 where q.NgayGD.Value.Month == i
                                 select q.TongGia;
                    foreach (var item in query1)
                    {
                        temp += item.Value;
                    }
                    tongGia[i] = temp;
                }
                return tongGia;
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
                                NgayGiaoDich = q.NgayGiaoDich,
                                TongGia = p.GiaBan * q.SoLuong
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
                                NgayNhap = q.NgayNhap,
                                TongGia = q.SoLuongNhap * q.GiaNhap
                            };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public void Update(string mng, string tng, int von, DateTime tg, string email, string nguon)
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
                    tim.Nguon = nguon;
                }
                db.SaveChanges();
            }
        }
        public void InsertVon(string mng, string tng, int von, DateTime tg, string email, string nguon)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.TaiChinhs.SingleOrDefault(t => t.MaNguoiGop == mng);
                if (tim != null)
                {
                    MessageBox.Show("Người góp hiện tại đã có!");
                    return;
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

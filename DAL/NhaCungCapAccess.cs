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
    public class NhaCungCapAccess
    {
        public DataTable LoadForm()
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var query = from q in db.NhaCungCaps
                            select new
                            {
                                MaNhaCungCap = q.MaNhaCungCap,
                                TenNhaCungCap = q.TenNhaCungCap,
                                DiaChi = q.DiaChi,
                                SDT = q.SDT,
                                Email = q.Email
                            };
                DataTable dt = new DataTable();
                var reader = ObjectReader.Create(query);
                dt.Load(reader);
                return dt;
            }
        }
        public void InsertNCC(string mNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.NhaCungCaps.SingleOrDefault(t => t.MaNhaCungCap == mNcc);
                if (tim != null)
                {
                    tim.TenNhaCungCap = tenNcc;
                    tim.DiaChi = diaChi;
                    tim.SDT = sdt;
                    tim.Email = email;
                }
                else
                {
                    var ncc = new NhaCungCap
                    {
                        MaNhaCungCap = mNcc,
                        TenNhaCungCap = tenNcc,
                        DiaChi = diaChi,
                        Email = email,
                        SDT = sdt,
                    };
                    db.NhaCungCaps.Add(ncc);
                }
                db.SaveChanges();
            }
        }
        public void DelNCC(string mNcc)
        {
            using (var db = new QuanLyBanDienThoaiEntities())
            {
                var tim = db.NhaCungCaps.SingleOrDefault(t => t.MaNhaCungCap == mNcc);
                if (tim != null)
                {
                    db.NhaCungCaps.Remove(tim);
                }
                db.SaveChanges();
            }
        }
    }
}
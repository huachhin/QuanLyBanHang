using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class XuLyDonHangBLL
    {
        private XuLyDonHangDAL XuLyDonHang;
        public XuLyDonHangBLL()
        {
            XuLyDonHang = new XuLyDonHangDAL();
        }
        public DataSet LoadForm(string maPhieu)
        {
            return XuLyDonHang.LoadForm(maPhieu);
        }
        public void CapNhat(string maPhieu, int[] soLuong, string[] maSanPham, int count)
        {
            XuLyDonHang.Update(maPhieu, soLuong, maSanPham, count);
        }
        public void XoaSanPham(string maPhieu, string maSanPham)
        {
            XuLyDonHang.Delete(maSanPham, maSanPham);
        }
        public void ThanhToan(int thanhToan, string maPhieu)
        {
            XuLyDonHang.ThanhToan(thanhToan, maPhieu);
        }
    }
}

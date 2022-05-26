using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class CapNhatNccDAL
    {
        private DatabaseAccess databaseAccess;

        public CapNhatNccDAL()
        {
            databaseAccess = new DatabaseAccess();
        }

        public void InsertNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt, string tenMathang)
        {
            string query = "INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, Email, SDT, MatHang) " +
                "VALUES('" + maNcc + "', N'" + tenNcc + "', N'" + diaChi + "', '" + email + "','" + sdt + "', N'" + tenMathang + "')";
            databaseAccess.executeNonQuery(query);
        }

        public void UpdateNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt, string tenMathang)
        {
            string query = "UPDATE NhaCungCap SET TenNhaCungCap = N'" + tenNcc + "', " +
                "DiaChi = N'" + diaChi + "', Email = '" + email + "', SDT = '" + sdt + "', " +
                "MatHang = N'" + tenMathang + "' " +
                "WHERE MaNhaCungCap = '" + maNcc + "'";
            databaseAccess.executeNonQuery(query);
        }
    }
}

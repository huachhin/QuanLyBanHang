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
        private DatabaseAccess databaseAccess;

        public NhaCungCapAccess()
        {
            databaseAccess = new DatabaseAccess();
        }

        public DataSet LoadForm()
        {
            string query = "SELECT * FROM NhaCungCap";
            return databaseAccess.executeQuery(query);
        }

        public void InsertNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            string query = "INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, Email, SDT) " +
                "VALUES('" + maNcc + "', N'" + tenNcc + "', '" + diaChi + "', '" + email + "','" + sdt + "')";
            databaseAccess.executeNonQuery(query);
        }

        public void DelNCC(string mNcc)
        {
            string query = "DELETE NhaCungCap WHERE MaNhaCungCap = '" + mNcc + "'";
            databaseAccess.executeNonQuery(query);
        }
    }
}
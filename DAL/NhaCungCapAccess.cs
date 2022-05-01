using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapAccess
    {
        private DatabaseAccess dbConnection;
        public NhaCungCapAccess()
        {
            dbConnection = new DatabaseAccess();
        }
        private SqlParameter[] Parameter(string maNCC, string tenNCC, string diaChi, string sdt, string matHang)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@maNCC", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maNCC);
            sqlParameters[1] = new SqlParameter("@tenNCC", System.Data.SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(tenNCC);
            sqlParameters[2] = new SqlParameter("@diaChi", System.Data.SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(diaChi);
            sqlParameters[3] = new SqlParameter("@sdt", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(sdt);
            sqlParameters[4] = new SqlParameter("@matHang", System.Data.SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(matHang);
            return sqlParameters;
        }
        public void InsertNCC(string maNCC, string tenNCC, string diaChi, string sdt, string matHang)
        {
            const string sql = "Insert into NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, SDT, MatHang) values(@maNCC, @tenNCC, @diaChi, @sdt, @matHang)";

            SqlParameter[] sqlParameters = Parameter(maNCC, tenNCC, diaChi, sdt, matHang);
            dbConnection.executeQuery(sql, sqlParameters);
        }
        public void Update(string maNCC, string tenNCC, string diaChi, string sdt, string matHang)
        {
            const string sql = "Update NhaCungCap set TenNhaCungCap = @tenNCC, DiaChi = @diaChi, SDT = @sdt, MatHang = @matHang  where MaNhaCungCap = @maNCC";

            SqlParameter[] sqlParameters = Parameter(maNCC, tenNCC, diaChi, sdt, matHang);
            dbConnection.executeQuery(sql, sqlParameters);
        }
        public void Del(string maNCC)
        {
            const string sql = "Delete from NhaCungCap where MaNhaCungCap = @maNCC";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maNCC", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maNCC);
            dbConnection.executeQuery(sql, sqlParameters);
        }
    }
}

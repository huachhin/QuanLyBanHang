using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiChinhAccess
    {
        private DatabaseAccess dbConnection;
        public TaiChinhAccess()
        {
            dbConnection = new DatabaseAccess();
        }
        private SqlParameter[] Parameter(string maNguoiGop, int von, DateTime thoiGian, string email)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@maNguoiGop", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maNguoiGop);
            sqlParameters[1] = new SqlParameter("@von", System.Data.SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(von);
            sqlParameters[2] = new SqlParameter("@thoiGian", System.Data.SqlDbType.DateTime);
            sqlParameters[2].Value = Convert.ToString(thoiGian);
            sqlParameters[3] = new SqlParameter("@email", System.Data.SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(email);
            return sqlParameters;
        }
        public DataTable LoadDs()
        {
            const string sql = "SELECT * FROM TaiChinh";

            SqlDataReader sqlDataReader = dbConnection.executeReader(sql);

            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            return dt;
        }
        public void UpdateTaiChinh(string maNguoiGop, int von, DateTime thoiGian, string email)
        {
            const string sql = "Update TaiChinh set Von = @von, ThoiGian = @thoiGian, Email = @email where MaNguoiGop = @maNguoiGop";

            SqlParameter[] sqlParameters = Parameter(maNguoiGop, von, thoiGian, email);
            dbConnection.executeQuery(sql, sqlParameters);
        }
        public void Del(string maNguoiGop)
        {
            const string sql = "Delete from TaiChinh where MaNguoiGop = @maNguoiGop";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maNguoiGop", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maNguoiGop);
            dbConnection.executeQuery(sql, sqlParameters);
        }
    }
}

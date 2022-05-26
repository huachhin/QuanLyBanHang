using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiaCoTucDAL
    {
        private DatabaseAccess databaseAccess;

        public ChiaCoTucDAL()
        {
            databaseAccess = new DatabaseAccess();
        }

        public DataSet LoadCoDong()
        {
            DataRow dr = databaseAccess.executeQuery("SELECT SUM(Von) AS TongVon FROM TaiChinh").Tables[0].Rows[0];
            long tongVon = Convert.ToInt64(dr[0]);
            string query = "SELECT MaNguoiGop, TenNguoiGop, Von FROM TaiChinh WHERE Von >= " + tongVon * 0.05 + " AND MaNguoiGop != 'DN'";
            return databaseAccess.executeQuery(query);
        }        

        public void CapNhat(long von, string[] maNG, long doanhThu)
        {
            for (int i = 0; i < maNG.Length; i++)
            {
                string query = "UPDATE TaiChinh SET Von += " + von + " WHERE MaNguoiGop = '" + maNG[i] + "'";
                databaseAccess.executeNonQuery(query);
            }
            string query1 = "UPDATE TaiChinh SET Von += " + doanhThu + " WHERE MaNguoiGop = 'DN'";
            databaseAccess.executeNonQuery(query1);
        }
    }
}

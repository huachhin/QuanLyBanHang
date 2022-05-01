using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonAccess
    {
        private DatabaseAccess dbConnection;
        public HoaDonAccess()
        {
            dbConnection = new DatabaseAccess();
        }
        private SqlParameter[] Parameter(string maMatHang, string maKhachHang, string maNguoiTao,
            DateTime thoiGian, int soLuong, int khachTra, string phuongThuc, string trangThai)
        {
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@maMatHang", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maMatHang);
            sqlParameters[1] = new SqlParameter("@maKhachHang", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maKhachHang);
            sqlParameters[2] = new SqlParameter("@maNguoiTao", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(maNguoiTao);
            sqlParameters[3] = new SqlParameter("@thoiGian", System.Data.SqlDbType.DateTime);
            sqlParameters[3].Value = Convert.ToString(thoiGian);
            sqlParameters[4] = new SqlParameter("@soLuong", System.Data.SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(soLuong);
            sqlParameters[5] = new SqlParameter("@khachTra", System.Data.SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToString(khachTra);
            sqlParameters[6] = new SqlParameter("@phuongThuc", System.Data.SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(phuongThuc);
            sqlParameters[7] = new SqlParameter("@trangThai", System.Data.SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(trangThai);
            return sqlParameters;
        }
        public void InsertHoaDon(string maMatHang, string maKhachHang, string maNguoiTao,
            DateTime thoiGian, int soLuong, int khachTra, string phuongThuc, string trangThai)
        {
            const string sql = "Insert into HoaDon(MaMatHang, MaKhachHang, MaNguoiTao, ThoiGian, SoLuong, KhachTra, PhuongThuc, TrangThai) " +
                "values(@maMatHang, @maKhachHang, @maNguoiTao, @thoiGian, @soLuong, @khachTra, @phuongThuc, @trangThai)";

            SqlParameter[] sqlParameters = Parameter(maMatHang, maKhachHang, maNguoiTao, thoiGian, soLuong, khachTra, phuongThuc, trangThai);
            dbConnection.executeQuery(sql, sqlParameters);
        }
        public void Update(string maMatHang, string maKhachHang, string maNguoiTao,
            DateTime thoiGian, int soLuong, int khachTra, string phuongThuc, string trangThai)
        {
            const string sql = "Update HoaDon set MaNguoiTao = @maNguoiTao, ThoiGian = @thoiGian, SoLuong = @soLuong," +
                " KhachTra = @khachTra  where MaMatHang = @maMatHang AND MaKhachHang = @maKhachHang";

            SqlParameter[] sqlParameters = Parameter(maMatHang, maKhachHang, maNguoiTao, thoiGian, soLuong, khachTra, phuongThuc, trangThai);
            dbConnection.executeQuery(sql, sqlParameters);
        }
        public void Del(string maMatHang, string maKhachHang)
        {
            const string sql = "Delete from HoaDon where MaMatHang = @maMatHang AND MaKhachHang = @maKhachHang";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maMatHang", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maMatHang);
            sqlParameters[1] = new SqlParameter("@maKhachHang", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maKhachHang);
            dbConnection.executeQuery(sql, sqlParameters);
        }
    }
}

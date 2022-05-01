using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using FastMember;

namespace BLL
{
    public class TaiChinhBLL
    {
        private TaiChinhAccess taiChinhAccess;
        public TaiChinhBLL()
        {
            taiChinhAccess = new TaiChinhAccess();
        }
        public DataTable LamMoiDs()
        {
            return taiChinhAccess.LoadDs();
        }
        public void CapNhatVon(string maNguoiGop, int von, DateTime thoiGian, string email)
        {
            taiChinhAccess.UpdateTaiChinh(maNguoiGop, von, thoiGian, email);
        }
        public void XoaVon(string maNguoiGop)
        {
            taiChinhAccess.Del(maNguoiGop);
        }
    }
}

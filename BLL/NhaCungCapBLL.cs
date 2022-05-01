using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapAccess nccAccess;
        public NhaCungCapBLL()
        {
            nccAccess = new NhaCungCapAccess();
        }
        public void ThemNCC(string maNCC, string tenNCC, string diaChi, string sdt, string matHang)
        {
            nccAccess.InsertNCC(maNCC, tenNCC, diaChi, sdt, matHang);
        }
        public void CapNhatNCC(string maNCC, string tenNCC, string diaChi, string sdt, string matHang)
        {
            nccAccess.Update(maNCC, tenNCC, diaChi, sdt, matHang);
        }
        public void XoaNCC(string maNCC)
        {
            nccAccess.Del(maNCC);
        }
    }
}

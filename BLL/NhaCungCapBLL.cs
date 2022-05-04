using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable LamMoiForm()
        {
            return nccAccess.LoadForm();
        }
        public void Them(string mNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            nccAccess.InsertNCC(mNcc, tenNcc, diaChi, email, sdt);
        }
    }
}

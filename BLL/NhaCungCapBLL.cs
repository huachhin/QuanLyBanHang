using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapAccess nccAccess;

        private KTraHopLe KTraHopLe;

        public NhaCungCapBLL()
        {
            nccAccess = new NhaCungCapAccess();
            KTraHopLe = new KTraHopLe();
        }

        public DataSet LamMoiForm()
        {
            return nccAccess.LoadForm();
        }

        public void Them(string mNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            if (!KTraHopLe.IsValidMail(email) || !KTraHopLe.IsValidVietNamPhoneNumber(sdt))
            {
                MessageBox.Show("Email hoặc Số điện thoại không hợp lệ!");
                return;
            }
            nccAccess.InsertNCC(mNcc, tenNcc, diaChi, email, sdt);
        }

        public void XoaNCC(string mNcc)
        {
            nccAccess.DelNCC(mNcc);
        }
    }
}
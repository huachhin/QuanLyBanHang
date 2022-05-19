using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class CapNhatNccBLL
    {
        private CapNhatNccDAL CapNhatNcc;
        private KTraHopLe hopLe;
        public CapNhatNccBLL()
        {
            CapNhatNcc = new CapNhatNccDAL();
            hopLe = new KTraHopLe();
        }
        public void ThemNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt, string tenMathang)
        {
            if (!hopLe.IsValidMail(email) || !hopLe.IsValidVietNamPhoneNumber(sdt))
            {
                MessageBox.Show("Email OR SĐT not valid!!");
                return;
            }
            CapNhatNcc.InsertNCC(maNcc, tenNcc, diaChi, email, sdt, tenMathang);
        }
        public void CapNhatNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt, string tenMathang)
        {
            if (!hopLe.IsValidMail(email) || !hopLe.IsValidVietNamPhoneNumber(sdt))
            {
                MessageBox.Show("Email OR SĐT not valid!!");
                return;
            }
            CapNhatNcc.UpdateNCC(maNcc, tenNcc, diaChi, email, sdt, tenMathang);
        }
    }
}

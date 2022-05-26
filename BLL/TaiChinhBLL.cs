using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public DataSet LamMoiVon()
        {
            return taiChinhAccess.LoadVon();
        }

        public DataSet LamMoiDoanhThu()
        {
            return taiChinhAccess.LoadDoanhThu();
        }

        public DataSet doanhThu()
        {
            return taiChinhAccess.doanhThu();
        }

        public DataSet LamMoiChiTieu()
        {
            return taiChinhAccess.LoadChiTieu();
        }

        public void ThemVon(string mng, string tng, int von, DateTime tg, string email, string nguon, string soVonRut)
        {
            if (soVonRut == "")
            {
                soVonRut = "0";
            }
            KTraHopLe kTraHopLe = new KTraHopLe();
            if (!kTraHopLe.IsValidMail(email))
            {
                MessageBox.Show("Email nhập không hợp lệ");
                return;
            }
            int temp = Convert.ToInt32(soVonRut);
            von = von + temp;
            taiChinhAccess.InsertVon(mng, tng, von, tg, email, nguon);
        }
       
        public void CapNhat(string mng, string tng, int von, DateTime tg, string email, string nguon, string soVonRut)
        {
            if (soVonRut == "")
            {
                soVonRut = "0";
            }
            KTraHopLe kTraHopLe = new KTraHopLe();
            if (!kTraHopLe.IsValidMail(email))
            {
                MessageBox.Show("Email nhập không hợp lệ");
                return;
            }
            int temp = Convert.ToInt32(soVonRut);
            von = von + temp;
            taiChinhAccess.Update(mng, tng, von, tg, email, nguon);
        }
       
        public DataSet CapNhatBieuDoMonth(int value)
        {      
            return taiChinhAccess.LoadThongKe(value);
        }
        
        public DataSet CapNhatBieuDoYear(int value)
        {
            return taiChinhAccess.LoadThongKeNam(value);
        }
        
        public int[] CapNhatBieuDoTong(int value)
        {
            return taiChinhAccess.LoadThongKeTong(value);
        }
    }
}

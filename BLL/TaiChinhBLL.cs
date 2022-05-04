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
        public DataTable LamMoiVon()
        {
            return taiChinhAccess.LoadVon();
        }
        public DataTable LamMoiDoanhThu()
        {
            return taiChinhAccess.LoadDoanhThu();
        }
        public DataTable LamMoiChiTieu()
        {
            return taiChinhAccess.LoadChiTieu();
        }
        public void ThemVon(string mng, string tng, int von, DateTime tg, string email, string nguon, string soVonRut)
        {
            try
            {
                if (soVonRut == "")
                {
                    soVonRut = "0";
                }
                int temp = Convert.ToInt32(soVonRut);
                von = von + temp;
                taiChinhAccess.InsertVon(mng, tng, von, tg, email, nguon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CapNhatVon(string mng, int von, string soVonRut)
        {
            try
            {
                if (soVonRut == "")
                {
                    soVonRut = "0";
                }
                int temp = Convert.ToInt32(soVonRut);
                temp = von - temp;
                taiChinhAccess.UpdateVon(mng, temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable CapNhatBieuDo()
        {
            return taiChinhAccess.LoadThongKe();
        }
    }
}

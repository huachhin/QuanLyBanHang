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
    public class HoaDonBLL
    {
        private HoaDonAccess hoaDonAccess;
        public HoaDonBLL()
        {
            hoaDonAccess = new HoaDonAccess();
        }
        public DataTable LamMoiHoaDon()
        {
            return hoaDonAccess.LoadHoaDon();
        }
        public DataTable LamMoiLichSu()
        {
            return hoaDonAccess.LoadLichSu();
        }
        public DataTable ThongTinChiTiet(string mp)
        {
            return hoaDonAccess.HienThiChiTiet(mp);
        }
        public DataTable TimKiem(string valueSearch)
        {
            return hoaDonAccess.Search(valueSearch);
        }
        public void CapNhatVon(string mng, int von, string soVonRut)
        {
            if (soVonRut == "")
            {
                soVonRut = "0";
            }
            int temp = Convert.ToInt32(soVonRut);
            temp = von + temp;
            hoaDonAccess.UpdateVon(mng, temp);
        }
        public void Gop(string[] makh)
        {
            hoaDonAccess.GopDon(makh);
        }
    }
}

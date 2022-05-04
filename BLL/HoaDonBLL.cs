using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DataTable TimKiem(string valueSearch)
        {
            return hoaDonAccess.Search(valueSearch);
        }
        public DataTable Gop()
        {
            return hoaDonAccess.GopDon();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ChiaCoTucBLL
    {
        private ChiaCoTucDAL chiaCoTucDAL;

        public ChiaCoTucBLL()
        {
            chiaCoTucDAL = new ChiaCoTucDAL();
        }

        public DataSet CoDong()
        {
            return chiaCoTucDAL.LoadCoDong();
        }

        public void CapNhat(long von, string[] maNG, long doanhThu)
        {
            chiaCoTucDAL.CapNhat(von, maNG, doanhThu);
        }
    }
}

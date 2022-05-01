using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Project
{
    public partial class frmTaiChinh : Form
    {
        public frmTaiChinh()
        {
            InitializeComponent();
        }

        private void ucVon3_Load(object sender, EventArgs e)
        {
            
        }

        private void frmTaiChinh_Load(object sender, EventArgs e)
        {
            TaiChinhBLL taiChinhBLL = new TaiChinhBLL();
            ucVonGop.LoadData(taiChinhBLL.LamMoiDs());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "Search")
            {
                txtSearchHoaDon.Text = "";
                txtSearchHoaDon.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "")
            {
                txtSearchHoaDon.Text = "Search";
                txtSearchHoaDon.ForeColor = Color.Silver;
            }
        }
    }
}

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
    public partial class frmCuaHang : Form
    {
        public frmCuaHang()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

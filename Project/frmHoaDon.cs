using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using BLL;

namespace Project
{
    public partial class frmHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        public frmHoaDon()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
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
                LoadForm();
                txtSearchHoaDon.ForeColor = Color.Silver;
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            dtGridViewHoaDon.DataSource = hoaDonBLL.LamMoiHoaDon();
        }

        private void txtSearchHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchHoaDon.Text != "")
                {
                    dtGridViewHoaDon.DataSource = hoaDonBLL.TimKiem(txtSearchHoaDon.Text);                    
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void btGop_Click(object sender, EventArgs e)
        {
            dtGridViewHoaDon.DataSource = hoaDonBLL.Gop();
        }
    }
}

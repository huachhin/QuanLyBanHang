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
using System.Data.SqlClient;

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
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            dtGridViewHoaDon.DataSource = hoaDonBLL.LamMoiHoaDon().Tables[0];
        }

        private string maPhieu;
        private string tenKhachHang;
        private void btXuLy_Click(object sender, EventArgs e)
        {
            frmXuLyDonHang frmXuLyDonHang = new frmXuLyDonHang(maPhieu, tenKhachHang);
            frmXuLyDonHang.Show();
        }
        private void dtGridViewHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewHoaDon.RowCount - 1)) return;
            maPhieu = dtGridViewHoaDon.Rows[e.RowIndex].Cells["MP"].Value.ToString();
            tenKhachHang = dtGridViewHoaDon.Rows[e.RowIndex].Cells["KhachHang"].Value.ToString();
        }
        private void txtSearchHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "")
            {
                txtSearchHoaDon.Text = "Search";
                txtSearchHoaDon.ForeColor = Color.Silver;
                LoadForm();
            }
        }

        private void txtSearchHoaDon_Enter(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "Search")
            {
                txtSearchHoaDon.Text = "";
                LoadForm();
                txtSearchHoaDon.ForeColor = Color.Black;
            }
        }

        private void txtSearchHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text != "")
            {
                dtGridViewHoaDon.DataSource = hoaDonBLL.TimKiem(txtSearchHoaDon.Text).Tables[0];
            }
        }

        private void btInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon inHoaDon = new frmInHoaDon(maPhieu, tenKhachHang);
            inHoaDon.Show();
        }
    }
}

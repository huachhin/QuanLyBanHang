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
    public partial class frmCapNhatNCC : Form
    {
        private CapNhatNccBLL capNhatNccBLL;
        private string maNcc;
        private string tenNcc;
        private string diaChi;
        private string email;
        private string sdt;
        private string matHang;
        public frmCapNhatNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            InitializeComponent();
            capNhatNccBLL = new CapNhatNccBLL();
            this.maNcc = maNcc;
            this.tenNcc = tenNcc;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
        }

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            capNhatNccBLL.ThemNCC(tbMaNCC.Text, tbTenNCC.Text, tbDiaChi.Text, tbEmail.Text, tbSDT.Text, tbMatHang.Text);
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            capNhatNccBLL.CapNhatNCC(tbMaNCC.Text, tbTenNCC.Text, tbDiaChi.Text, tbEmail.Text, tbSDT.Text, tbMatHang.Text);
            this.Close();
        }

        private void frmCapNhatNCC_Load(object sender, EventArgs e)
        {
            tbMaNCC.Text = maNcc;
            tbTenNCC.Text = tenNcc;
            tbDiaChi.Text = diaChi;
            tbEmail.Text = email;
            tbSDT.Text = sdt;
        }
    }
}

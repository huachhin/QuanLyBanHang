using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Project
{
    public partial class frmCapNhatNCC : Form
    {
        private DatabaseAccess databaseAccess;
        private string maNcc;
        private string tenNcc;
        private string diaChi;
        private string email;
        private string sdt;
        private string matHang;
        public frmCapNhatNCC(string maNcc, string tenNcc, string diaChi, string email, string sdt)
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            this.maNcc = maNcc;
            this.tenNcc = tenNcc;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
        }

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, Email, SDT, MatHang) " +
                "VALUES('" + tbMaNCC.Text + "', N'" + tbTenNCC.Text + "', '" + tbDiaChi.Text + "', '" + tbEmail.Text + "','" + tbSDT.Text + "', '" + tbMatHang.Text + "')";
            databaseAccess.executeNonQuery(query);
            this.Close();            
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NhaCungCap SET TenNhaCungCap = '" + tbTenNCC.Text + "', " +
                "DiaChi = '" + tbDiaChi.Text + "', Email = '" + tbEmail.Text + "', SDT = '" + tbSDT.Text + "', " +
                "MatHang = '" + tbMatHang.Text + "' " +
                "WHERE MaNhaCungCap = '" + tbMaNCC.Text + "'";
            databaseAccess.executeNonQuery(query);
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

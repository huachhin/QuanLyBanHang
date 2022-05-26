using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmGiaoDien : Form
    {
        private frmMatHang frmMatHang = new frmMatHang();

        public frmGiaoDien()
        {
            InitializeComponent();
            frmMatHang.Refresh_Cart();
        }

        private Form CurrentChildForm;
        
        // Mở Form con trong panel Hiển Thị ở Form cha
        public void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
                CurrentChildForm.Close();
            CurrentChildForm = childForm;            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;            
            pnlHienThi.Controls.Add(childForm);
            pnlHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCC());
        }

        private void btTaiChinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiChinh());
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btCuaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCuaHang());
        }

        private void btMatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMatHang());
        }

        private void btKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho());
        }

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmMatHang());
        }

     
    }
}

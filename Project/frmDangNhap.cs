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
    public partial class frmDangNhap : Form
    {
        private DatabaseAccess databaseAccess;
        private int frm = 0; // 0 GiaoDien     1 TaiChinh
        private long doanhThu = 0;

        public frmDangNhap(int frm, long doanhThu)
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            this.frm = frm;
            this.doanhThu = doanhThu;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Username WHERE TaiKhoan = '" + tbUsername.Text + "'";
                if (frm == 1 && tbUsername.Text != "admin")
                {
                    MessageBox.Show("Không được phép truy cập vào Form này!!", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow dr = databaseAccess.executeQuery(query).Tables[0].Rows[0];
                if (dr["TaiKhoan"].ToString().Trim() == tbUsername.Text && dr["MatKhau"].ToString().Trim() == tbPassword.Text)
                {
                    this.Hide();
                    if (frm == 1)
                    {
                        frmChiaCoTuc chiaCoTuc = new frmChiaCoTuc(doanhThu);
                        chiaCoTuc.Show();
                        return;
                    }
                    frmGiaoDien giaoDien = new frmGiaoDien();
                    giaoDien.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.PasswordChar = '*';
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
                tbPassword.PasswordChar = '\0';
            }
        }
        
    }
}

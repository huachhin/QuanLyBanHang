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
    public partial class frmDangKy : Form
    {
        private DatabaseAccess databaseAccess;
        public frmDangKy()
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
        }
        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == tbConfirm.Text)
                {
                    string query = "INSERT Username(TaiKhoan, MatKhau) " +
                        "VALUES('" + tbUsername.Text + "', '" + tbPassword.Text + "')";
                    databaseAccess.executeNonQuery(query);
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại");
            }
            finally
            {
                this.Close();
            }
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbConfirm_Enter(object sender, EventArgs e)
        {
            if (tbConfirm.Text == "Confirm Password")
            {
                tbConfirm.Text = "";
                tbConfirm.ForeColor = Color.Black;
                tbConfirm.PasswordChar = '*';
            }
        }

        private void tbConfirm_Leave(object sender, EventArgs e)
        {
            if (tbConfirm.Text == "")
            {
                tbConfirm.Text = "Confirm Password";
                tbConfirm.ForeColor = Color.Silver;
                tbConfirm.PasswordChar = '\0';
            }
        }        
    }
}

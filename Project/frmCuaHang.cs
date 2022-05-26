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
    public partial class frmCuaHang : Form
    {
        private CuaHangBLL cuaHangBLL;
        public frmCuaHang()
        {
            InitializeComponent();
            cuaHangBLL = new CuaHangBLL();
        }

        private void frmCuaHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {

        }
    }
}

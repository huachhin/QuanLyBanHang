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
    public partial class frmNhaCC : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        public frmNhaCC()
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL();
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            LoadForm();   
        }
        private void LoadForm()
        {
            dtGridViewNCC.DataSource = nhaCungCapBLL.LamMoiForm();
        }
        private void btThemNCC_Click(object sender, EventArgs e)
        {
            nhaCungCapBLL.Them(maNcc, tenNcc, diaChi, email, sdt);
            LoadForm();
        }
        private string maNcc;
        private string tenNcc;
        private string diaChi;
        private string email;
        private string sdt;
        
        private void dtGridViewNCC_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                maNcc = dtGridViewNCC.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
                tenNcc = dtGridViewNCC.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
                diaChi = dtGridViewNCC.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                email = dtGridViewNCC.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                sdt = dtGridViewNCC.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

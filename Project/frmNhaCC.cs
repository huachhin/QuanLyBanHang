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
        private string maNcc;
        private string tenNcc;
        private string diaChi;
        private string email;
        private string sdt;
        public frmNhaCC()
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL();
        }
        public void frmNhaCC_Load(object sender, EventArgs e)
        {
            LoadForm();   
        }
        public void LoadForm()
        {
            dtGridViewNCC.DataSource = nhaCungCapBLL.LamMoiForm().Tables[0];
        }
        private void btThemNCC_Click(object sender, EventArgs e)
        {
            frmCapNhatNCC frmCapNhat = new frmCapNhatNCC(maNcc, tenNcc, diaChi, email, sdt);
            frmCapNhat.Show();
        }
        
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

        private void btXoaNCC_Click(object sender, EventArgs e)
        {
            nhaCungCapBLL.XoaNCC(maNcc);
            LoadForm();
        }

        private void dtGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewNCC.RowCount - 1)) return;
            maNcc = dtGridViewNCC.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
        }
    }
}

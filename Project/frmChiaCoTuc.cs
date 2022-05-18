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
    public partial class frmChiaCoTuc : Form
    {
        private ChiaCoTucBLL chiaCoTucBLL;
        private long doanhThu;
        private long PE;
        public frmChiaCoTuc(long doanhThu)
        {
            InitializeComponent();
            chiaCoTucBLL = new ChiaCoTucBLL();
            this.doanhThu = doanhThu;
        }

        private void frmChiaCoTuc_Load(object sender, EventArgs e)
        {
            tbDoanhThu.Text = doanhThu.ToString();
            tbLoiNhuan.Text = (doanhThu * 0.4).ToString();
            dataGridViewCoDong.DataSource = chiaCoTucBLL.CoDong().Tables[0];
        }

        private void dataGridViewCoDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbPE.Text == "")
            {
                MessageBox.Show("Please enter the amount to pay", "Price To Earn?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (dataGridViewCoDong.Columns[e.ColumnIndex].Name == "Payment")
            {
                if (MessageBox.Show("Are you sure want to Payment this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ma = dataGridViewCoDong.Rows[e.RowIndex].Cells["MaNguoiGop"].Value.ToString();
                    string ten = dataGridViewCoDong.Rows[e.RowIndex].Cells["TenNguoiGop"].Value.ToString();
                    int von = Convert.ToInt32(dataGridViewCoDong.Rows[e.RowIndex].Cells["Von"].Value);
                    dataGridViewCoTuc.Rows.Add(ma, ten, von);
                    dataGridViewCoDong.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void tbPE_Leave(object sender, EventArgs e)
        {
            if(tbPE.Text != "")
                PE = (long)(doanhThu * 0.4 * Convert.ToInt64(tbPE.Text) / 100);
        }

        private void dataGridViewCoTuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCoTuc.Columns[e.ColumnIndex].Name == "Refund")
            {
                //string ma = dataGridViewCoTuc.Rows[e.RowIndex].Cells["MaNG"].Value.ToString();
                //string ten = dataGridViewCoTuc.Rows[e.RowIndex].Cells["TenNG"].Value.ToString();
                //int von = Convert.ToInt32(dataGridViewCoTuc.Rows[e.RowIndex].Cells["VonGop"].Value);
                ////dataGridViewCoDong.Rows.Insert(dataGridViewCoDong.RowCount, ma, ten, von);
                //var index = dataGridViewCoDong.Rows.Add();
                //dataGridViewCoDong.Rows[index].Cells["MaNguoiGop"].Value = ma;
                //dataGridViewCoDong.Rows[index].Cells["TenNguoiGop"].Value = ten;
                //dataGridViewCoDong.Rows[index].Cells["Von"].Value = von;
                
                //dataGridViewCoTuc.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            long von = PE / dataGridViewCoDong.RowCount;
            string[] maNG = new string[dataGridViewCoDong.RowCount];
            if (dataGridViewCoDong.RowCount < 0)
            {
                MessageBox.Show("Không có cổ đông nào để chia");
                return;
            }
            for (int i = 0; i < dataGridViewCoDong.RowCount - 1; i++)
            {
                maNG[i] = dataGridViewCoDong.Rows[i].Cells["MaNguoiGop"].Value.ToString();
            }
            chiaCoTucBLL.CapNhat(von, maNG, (long)(doanhThu * 0.4 - PE));
            frmChiaCoTuc_Load(sender, e);
        }
    }
}

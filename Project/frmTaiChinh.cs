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
using FastMember;

namespace Project
{
    public partial class frmTaiChinh : Form
    {
        private TaiChinhBLL taiChinhBLL;
        public frmTaiChinh()
        {
            InitializeComponent();
            taiChinhBLL = new TaiChinhBLL();
        }

        private void frmTaiChinh_Load(object sender, EventArgs e)
        {
            dtGridViewVon.DataSource = taiChinhBLL.LamMoiVon();
            dataGridViewDoanhThu.DataSource = taiChinhBLL.LamMoiDoanhThu();
            dataGridViewChiTieu.DataSource = taiChinhBLL.LamMoiChiTieu();

            
            chartThongKe.DataSource = taiChinhBLL.CapNhatBieuDo();
            chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "MaPhieu";
            chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "TongGia";
            chartThongKe.Series["Series1"].XValueMember = "MaPhieu";
            chartThongKe.Series["Series1"].YValueMembers = "TongGia";
            //chartThongKe.Series["MaPhieu"].XValueMember = "MaPhieu";
            //chartThongKe.Series["MaPhieu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chartThongKe.Series["MaPhieu"].XValueMember = "TongGia";
            //chartThongKe.Series["MaPhieu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
        private string mng;
        private string tng;
        private int von;
        private string email;
        private DateTime tg;
        private string nguon;
        private void btThemVon_Click(object sender, EventArgs e)
        {
            taiChinhBLL.ThemVon(mng, tng, von, tg, email, nguon, tbSoVonRut.Text);
            frmTaiChinh_Load(sender, e);
        }

        private void btRutVon_Click(object sender, EventArgs e)
        {
            taiChinhBLL.CapNhatVon(mng, von, tbSoVonRut.Text);
            frmTaiChinh_Load(sender, e);
        }

        private void dtGridViewVon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewVon.RowCount - 1)) return;
            mng = dtGridViewVon.Rows[e.RowIndex].Cells["MaNgGop"].Value.ToString();
            von = Convert.ToInt32(dtGridViewVon.Rows[e.RowIndex].Cells["VonGop"].Value);
        }
        private void dtGridViewVon_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                mng = dtGridViewVon.Rows[e.RowIndex].Cells["MaNgGop"].Value.ToString();
                tng = dtGridViewVon.Rows[e.RowIndex].Cells["TenNgGop"].Value.ToString();
                von = Convert.ToInt32(dtGridViewVon.Rows[e.RowIndex].Cells["VonGop"].Value);
                email = dtGridViewVon.Rows[e.RowIndex].Cells["EmailGop"].Value.ToString();
                tg = Convert.ToDateTime(dtGridViewVon.Rows[e.RowIndex].Cells["NgayGop"].Value);
                nguon = dtGridViewVon.Rows[e.RowIndex].Cells["NguonGop"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSoVonRut_Leave(object sender, EventArgs e)
        {

        }
    }
}

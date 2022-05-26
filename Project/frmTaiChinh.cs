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
        private long doanhThu = 0;
        private string maNguoiGop = "";
        private string tenNguoiGop = "";
        private int von = 0;
        private string email = "";
        private DateTime thoiGian = DateTime.Now;
        private string nguon = "";

        public frmTaiChinh()
        {
            InitializeComponent();
            taiChinhBLL = new TaiChinhBLL();
        }

        private void frmTaiChinh_Load(object sender, EventArgs e)
        {
            doanhThu = 0;
            dtGridViewVon.DataSource = taiChinhBLL.LamMoiVon().Tables[0];
            dataGridViewDoanhThu.DataSource = taiChinhBLL.LamMoiDoanhThu().Tables[0];
            dataGridViewChiTieu.DataSource = taiChinhBLL.LamMoiChiTieu().Tables[0];
            foreach (DataRow item in taiChinhBLL.doanhThu().Tables[0].Rows)
            {
                doanhThu += Convert.ToInt64(item["TongGia"]);
            }
            LoadBieuDoTong(DateTime.Now.Year);
        }

        private void LoadBieuDoTong(int value)
        {
            lbThongKe.Text = "Doanh Thu Tổng Theo Năm";
            var objChart = chartThongKe.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //month 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;

            chartThongKe.Series.Clear();
            //loop rows to draw multi line chart c#
            int j = 1;
            chartThongKe.Series.Add("Month");
            chartThongKe.Series["Month"].Legend = "Legend1";
            chartThongKe.Series["Month"].ChartArea = "ChartArea1";
            chartThongKe.Series["Month"].Color = Color.Red;
            chartThongKe.Series["Month"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            foreach (var i in taiChinhBLL.CapNhatBieuDoTong(value))
            {
                chartThongKe.Series["Month"].Points.AddXY(j, i);
                j += 1;
            }
        }

        private void LoadBieuDoMonth(int value)
        {
            try
            {
                chartThongKe.Series.Clear();
                chartThongKe.Series.Add("SanPham");
                chartThongKe.DataSource = taiChinhBLL.CapNhatBieuDoMonth(value);
                chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "SanPham";
                chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "TongGia";
                chartThongKe.Series["SanPham"].XValueMember = "SanPham";
                chartThongKe.Series["SanPham"].YValueMembers = "TongGia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadBieuDoYear(int value)
        {
            try
            {
                chartThongKe.Series.Clear();
                chartThongKe.Series.Add("SanPham");
                chartThongKe.DataSource = taiChinhBLL.CapNhatBieuDoYear(value);
                chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "SanPham";
                chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "TongGia";
                chartThongKe.Series["SanPham"].XValueMember = "SanPham";
                chartThongKe.Series["SanPham"].YValueMembers = "TongGia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btThemVon_Click(object sender, EventArgs e)
        {
            taiChinhBLL.ThemVon(maNguoiGop, tenNguoiGop, von, thoiGian, email, nguon, tbSoVonRut.Text);
            frmTaiChinh_Load(sender, e);
        }

        private void btCapNhatVon_Click(object sender, EventArgs e)
        {
            taiChinhBLL.CapNhat(maNguoiGop, tenNguoiGop, von, thoiGian, email, nguon, tbSoVonRut.Text);
            frmTaiChinh_Load(sender, e);
        }

        private void btThang_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtSearchThongKe.Text);
            if (value < 1 || value > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            lbThongKe.Text = "Doanh Thu Từng Tháng";
            if (txtSearchThongKe.Text == "")
            {
                MessageBox.Show("Input incorrect");
                return;
            }
            LoadBieuDoMonth(value);
        }

        private void btTheoNam_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtSearchThongKe.Text);
            if (value < 1990 || value > 2050)
            {
                MessageBox.Show("Năm không hợp lệ");
                return;
            }
            lbThongKe.Text = "Doanh Thu Sản Phẩm Theo Năm";
            if (txtSearchThongKe.Text == "") 
            {
                MessageBox.Show("Input incorrect");
                return; 
            }
            LoadBieuDoYear(value);
        }

        private void btChiaCoTuc_Click(object sender, EventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap(1, doanhThu);
            dangNhap.Show();        
        }

        private void dataGridViewChiTieu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewChiTieu.RowCount - 1)
            {
                int tongGia = 0, giaBan = 0, soLuong = 0;
                for (int i = 0; i < dataGridViewChiTieu.RowCount - 1; i++)
                {
                    tongGia += Convert.ToInt32(dataGridViewChiTieu.Rows[i].Cells["TongGiaChi"].Value);
                    giaBan += Convert.ToInt32(dataGridViewChiTieu.Rows[i].Cells["GiaNhap"].Value);
                    soLuong += Convert.ToInt32(dataGridViewChiTieu.Rows[i].Cells["SoLuongNhap"].Value);
                }
                dataGridViewChiTieu.Rows[e.RowIndex].Cells["MaHangNhap"].Value = "Tổng:";
                dataGridViewChiTieu.Rows[e.RowIndex].Cells["TongGiaChi"].Value = tongGia;
                dataGridViewChiTieu.Rows[e.RowIndex].Cells["GiaNhap"].Value = giaBan;
                dataGridViewChiTieu.Rows[e.RowIndex].Cells["SoLuongNhap"].Value = soLuong;
            }
        }

        private void dtGridViewVon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewVon.RowCount - 1)) return;
            maNguoiGop = dtGridViewVon.Rows[e.RowIndex].Cells["MaNgGop"].Value.ToString();
            von = Convert.ToInt32(dtGridViewVon.Rows[e.RowIndex].Cells["VonGop"].Value);
            tenNguoiGop = dtGridViewVon.Rows[e.RowIndex].Cells["TenNgGop"].Value.ToString();
            email = dtGridViewVon.Rows[e.RowIndex].Cells["EmailGop"].Value.ToString();
            thoiGian = Convert.ToDateTime(dtGridViewVon.Rows[e.RowIndex].Cells["NgayGop"].Value);
            nguon = dtGridViewVon.Rows[e.RowIndex].Cells["NguonGop"].Value.ToString();
        }

        private void dtGridViewVon_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                maNguoiGop = dtGridViewVon.Rows[e.RowIndex].Cells["MaNgGop"].Value.ToString();
                tenNguoiGop = dtGridViewVon.Rows[e.RowIndex].Cells["TenNgGop"].Value.ToString();
                von = Convert.ToInt32(dtGridViewVon.Rows[e.RowIndex].Cells["VonGop"].Value);
                email = dtGridViewVon.Rows[e.RowIndex].Cells["EmailGop"].Value.ToString();
                thoiGian = Convert.ToDateTime(dtGridViewVon.Rows[e.RowIndex].Cells["NgayGop"].Value);
                nguon = dtGridViewVon.Rows[e.RowIndex].Cells["NguonGop"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
            LoadBieuDoTong(2022);
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
        private void LoadBieuDo(int value)
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
            try
            {
                if (e.RowIndex == -1 || e.RowIndex == (dtGridViewVon.RowCount - 1)) return;
                mng = dtGridViewVon.Rows[e.RowIndex].Cells["MaNgGop"].Value.ToString();
                von = Convert.ToInt32(dtGridViewVon.Rows[e.RowIndex].Cells["VonGop"].Value);
                tng = dtGridViewVon.Rows[e.RowIndex].Cells["TenNgGop"].Value.ToString();
                email = dtGridViewVon.Rows[e.RowIndex].Cells["EmailGop"].Value.ToString();
                tg = Convert.ToDateTime(dtGridViewVon.Rows[e.RowIndex].Cells["NgayGop"].Value);
                nguon = dtGridViewVon.Rows[e.RowIndex].Cells["NguonGop"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void btThang_Click(object sender, EventArgs e)
        {
            lbThongKe.Text = "Doanh Thu Từng Tháng";
            if (txtSearchThongKe.Text == "")
            {
                MessageBox.Show("Input incorrect");
                return;
            }
            LoadBieuDo(Convert.ToInt32(txtSearchThongKe.Text));
        }

        private void btTheoNam_Click(object sender, EventArgs e)
        {
            lbThongKe.Text = "Doanh Thu Sản Phẩm Theo Năm";
            if (txtSearchThongKe.Text == "") 
            {
                MessageBox.Show("Input incorrect");
                return; 
            }
            LoadBieuDo(Convert.ToInt32(txtSearchThongKe.Text));
        }

        private void btCapNhatVon_Click(object sender, EventArgs e)
        {
            taiChinhBLL.CapNhat(mng, tng, von, tg, email, nguon, tbSoVonRut.Text);
            frmTaiChinh_Load(sender, e);
        }

        private void dataGridViewDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewDoanhThu.RowCount - 1)
            {
                int tongGia = 0, giaBan = 0, soLuong = 0;
                for (int i = 0; i < dataGridViewDoanhThu.RowCount - 1; i++)
                {
                    tongGia += Convert.ToInt32(dataGridViewDoanhThu.Rows[i].Cells["TongGia"].Value);
                    giaBan += Convert.ToInt32(dataGridViewDoanhThu.Rows[i].Cells["GiaBan"].Value);
                    soLuong += Convert.ToInt32(dataGridViewDoanhThu.Rows[i].Cells["SoLuong"].Value);
                }
                dataGridViewDoanhThu.Rows[e.RowIndex].Cells["MaMatHang"].Value = "Tổng:";
                dataGridViewDoanhThu.Rows[e.RowIndex].Cells["TongGia"].Value = tongGia;
                dataGridViewDoanhThu.Rows[e.RowIndex].Cells["GiaBan"].Value = giaBan;
                dataGridViewDoanhThu.Rows[e.RowIndex].Cells["SoLuong"].Value = soLuong;
            }
        }

        private void dataGridViewChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}

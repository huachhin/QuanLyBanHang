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
    public partial class frmHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        public frmHoaDon()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "Search")
            {
                txtSearchHoaDon.Text = "";
                txtSearchHoaDon.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearchHoaDon.Text == "")
            {
                txtSearchHoaDon.Text = "Search";
                LoadForm();
                txtSearchHoaDon.ForeColor = Color.Silver;
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadForm();
            dtGridViewLsThanhToan.DataSource = hoaDonBLL.LamMoiLichSu();
        }
        private void LoadForm()
        {
            dtGridViewHoaDon.DataSource = hoaDonBLL.LamMoiHoaDon();
        }

        private void txtSearchHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchHoaDon.Text != "")
                {
                    dtGridViewHoaDon.DataSource = hoaDonBLL.TimKiem(txtSearchHoaDon.Text);                    
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void btGop_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dtGridViewHoaDon.Rows.GetRowCount(DataGridViewElementStates.Selected);
            string[] maphieu = new string[selectedRowCount];
            string[] maKhachHang = new string[selectedRowCount];
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    maphieu[i] = dtGridViewHoaDon.SelectedRows[i].Cells["MaPhieu"].Value.ToString();
                    maKhachHang[i] = dtGridViewHoaDon.SelectedRows[i].Cells["MaKhachHang"].Value.ToString();
                }
            }
            if (maKhachHang.Length == 1) return;
            for (int i = 0; i < maKhachHang.Length - 1; i++)
            {
                if (maKhachHang[i].ToLower() != maKhachHang[i + 1].ToLower()) {
                    MessageBox.Show("Khác mã khách hàng");
                    return;
                }
            }
            hoaDonBLL.Gop(maphieu);
            LoadForm();
        }

        string mp;
        int von;
        int khachTra;
        private void dtGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewHoaDon.RowCount - 1)) return;
            mp = dtGridViewHoaDon.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            von = Convert.ToInt32(dtGridViewHoaDon.Rows[e.RowIndex].Cells["TongGia"].Value);
            khachTra = Convert.ToInt32(dtGridViewHoaDon.Rows[e.RowIndex].Cells["KhachTraHD"].Value);
        }

        private void dtGridViewLsThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dtGridViewLsThanhToan.RowCount - 1)) return;
            string maphieu = dtGridViewLsThanhToan.Rows[e.RowIndex].Cells["LsMaPhieu"].Value.ToString();
            foreach (DataRow row in hoaDonBLL.ThongTinChiTiet(maphieu).Rows)
            {
                MessageBox.Show("Mã Phiếu: \t\t" + row["MaPhieu"].ToString() +
                    "\nMã Khách Hàng: \t\t" + row["MaKhachHang"].ToString() +
                    "\nMã Mặt Hàng: \t\t" + row["MaMatHang"].ToString() +
                    "\nTên Nhân Viên: \t\t" + row["TenNhanVien"].ToString() +
                    "\nTên Khách Hàng: \t\t" + row["TenKhachHang"].ToString() +
                    "\nNgày Giao Dịch: \t\t" + row["NgayGiaoDich"].ToString() +
                    "\nSố Lượng: \t\t" + row["SoLuong"].ToString() +
                    "\nTổng Giá: \t\t" + row["TongGia"].ToString() +
                    "\nPhương Thức Thanh Toán: \t" + row["PhuongThuc"].ToString() +
                    "\nKhách Trả: \t\t" + row["KhachTra"].ToString());
            }                                
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if(von < Convert.ToInt32(tbSoTienTT.Text) + khachTra)
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ");
                return;
            }
            hoaDonBLL.CapNhatVon(mp, khachTra, tbSoTienTT.Text);
            LoadForm();
            dtGridViewLsThanhToan.DataSource = hoaDonBLL.LamMoiLichSu();
        }
    }
}

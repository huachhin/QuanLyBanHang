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
    public partial class frmXuLyDonHang : Form
    {
        private DatabaseAccess databaseAccess;
        private string maPhieu;
        private string tenKhachHang;
        int[] soLuong = new int[100];
        string[] maSanPham = new string[100];
        int tongGia;
        int khachTra;
        public frmXuLyDonHang(string maPhieu, string tenKhachHang)
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            this.maPhieu = maPhieu;
            this.tenKhachHang = tenKhachHang;
        }
        private void frmXuLyDonHang_Load(object sender, EventArgs e)
        {           
            lbMaPhieu.Text = maPhieu;
            lbKhachHang.Text = tenKhachHang;

            string query = "WITH TMP AS( " +
                "SELECT GiaBan, TenHang, GioHang.SoLuong, MaPhieu, MaSanPham " +
                "FROM CuaHang INNER JOIN GioHang " +
                "ON CuaHang.MaMatHang = GioHang.MaSanPham) " +
                "SELECT TenHang as TenSanPham, SoLuong, GiaBan, MaSanPham, KhachTra " +
                "FROM TMP INNER JOIN HoaDon " +
                "ON TMP.MaPhieu = HoaDon.MaPhieu " +
                "WHERE HoaDon.MaPhieu = N'" + maPhieu + "'";

            dataGridViewSanPham.DataSource = databaseAccess.executeQuery(query).Tables[0];

            tongGia = 0;
            for (int i = 0; i < dataGridViewSanPham.Rows.Count; i++)
            {
                soLuong[i] = Convert.ToInt32(dataGridViewSanPham.Rows[i].Cells["SLuong"].Value);
                maSanPham[i] = Convert.ToString(dataGridViewSanPham.Rows[i].Cells["MaSP"].Value);
                tongGia += Convert.ToInt32(dataGridViewSanPham.Rows[i].Cells["GiaBan"].Value) * soLuong[i];
            }
            khachTra = Convert.ToInt32(dataGridViewSanPham.Rows[0].Cells["KTra"].Value);
            if (khachTra > tongGia)
            {
                MessageBox.Show("The amount of the refund to the customer is: " + (khachTra - tongGia).ToString(), "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tbTongDonHang.Text = tongGia.ToString();
            tbKhachTra.Text = khachTra.ToString();
            tbNo.Text = (tongGia - khachTra).ToString();
        }
        
        private void btCapNhatDonHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewSanPham.Rows.Count; i++)
            {
                soLuong[i] = Convert.ToInt32(dataGridViewSanPham.Rows[i].Cells["SLuong"].Value);
                maSanPham[i] = Convert.ToString(dataGridViewSanPham.Rows[i].Cells["MaSP"].Value);
            }
            for (int i = 0; i < dataGridViewSanPham.Rows.Count; i++)
            {
                string query = "UPDATE GioHang SET SoLuong = '" + soLuong[i] + "' " +
                    "WHERE MaPhieu = '" + maPhieu + "' AND MaSanPham = N'" + maSanPham[i] + "'";
                databaseAccess.executeNonQuery(query);
            }
            frmXuLyDonHang_Load(sender, e);
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSanPham.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (dataGridViewSanPham.Rows[e.RowIndex].Cells["LyDo"].Value == null)
                {
                    MessageBox.Show("Please enter a reason for the return", "Reason return", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                string query = "DELETE FROM GioHang " +
                    "WHERE MaPhieu = '" + maPhieu + "' AND MaSanPham = N'" + maSanPham[e.RowIndex] + "'";
                databaseAccess.executeNonQuery(query);
                frmXuLyDonHang_Load(sender, e);
            }
        }

        private void tbThanhToan_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update your invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int thanhToan = khachTra + Convert.ToInt32(tbThanhToan.Text);
                if (tongGia >= thanhToan)
                {
                    string query = "UPDATE HoaDon SET KhachTra = " + thanhToan + " WHERE MaPhieu = '" + maPhieu + "'";
                    databaseAccess.executeNonQuery(query);
                    frmXuLyDonHang_Load(sender, e);
                }                
            }
        }
    }
}

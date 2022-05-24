using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmThanhToan : Form
    {
        private frmMatHang frmMatHang = new frmMatHang();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void groupBox_thtinKhachhang_Enter(object sender, EventArgs e)
        {

        }

        private void btn_huyBo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhToan();
                MessageBox.Show("Thanh toán thành công!");
                frmMatHang.Refresh_Cart();
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán không thành công");
            };
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLBHDataSet1.NhanVien);
            // TODO: This line of code loads data into the 'qLBHDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBHDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'qLBHDataSet1.NhanVien' table. You can move, or remove it, as needed.

        }

        private string GetId_NhanVien(string name)
        {
            using(QLBHEntities db = new QLBHEntities())
            {
                
                NhanVien nv = db.NhanViens.Where(q => q.TenNhanVien.Contains(name)).SingleOrDefault();
                if (nv != null)
                    return nv.MaNhanVien;
                return "";
            }
            
        }
        private string GetId_KhachHang(string name)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                KhachHang khachHang = db.KhachHangs.Where(p => p.TenKhachHang.Contains(name)).SingleOrDefault();
                if (khachHang != null)
                    return khachHang.MaKhachHang;
                return "";
            }

        }

        public void ThanhToan()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                // Đưa thông tin vào db Hóa đơn
                HoaDon hoaDon = new HoaDon()
                {
                    MaPhieu = txtbox_maPhieu.Text,
                    MaKhachHang = GetId_KhachHang(comboBox_tenKhachHang.SelectedValue.ToString()),
                    MaNguoiTao = GetId_NhanVien(comboBox_NguoiTao.SelectedValue.ToString()),
                    NgayGiaoDich = dateTimePicker_ngayGiaodich.Value,
                    KhachTra = Convert.ToInt32(textBox_khachTra.Text),
                    PhuongThuc = comboBox_phuongThuc.SelectedItem.ToString(),
                    No = comboBox_No.SelectedItem.ToString(),
                    TrangThai = comboBox_trangThai.SelectedItem.ToString(),
                };
                try {            
                    db.HoaDons.Add(hoaDon);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                };
            }

            // Đưa thông tin vào db Giỏ hàng
            using (QLBHEntities db2 = new QLBHEntities())
            {
                var query2 = from q in db2.Carts
                             select q;

                foreach (var gh in query2.ToList())
                {
                    GioHang GioHang = new GioHang()
                    {
                        MaPhieu = txtbox_maPhieu.Text,
                        MaSanPham = gh.MaSP,
                        SoLuong = gh.SoLuong,
                    };
                    try
                    {
                        db2.GioHangs.Add(GioHang);
                        db2.SaveChanges();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        // Kiểm tra đầu vào
        private void textBox_khachTra_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_khachTra.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!!");
                textBox_khachTra.Text = textBox_khachTra.Text.Remove(textBox_khachTra.Text.Length - 1);
            }
        }

    }
}

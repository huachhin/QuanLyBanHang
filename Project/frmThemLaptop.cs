using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmThemLaptop : Form
    {
        private frmThemDienThoai frmThemDienThoai = new frmThemDienThoai();
        public frmThemLaptop()
        {
            InitializeComponent();
        }

        // Upload image from This PC
        private void button_uploadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anhLaptop.ImageLocation = openFileDialog.FileName;
            }
        }


        // Feature ---------------------
        public void AddMatHangLapTop()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                MatHang matHang = new MatHang()
                {
                    Id = textBox_id.Text,
                    TenSanPham = textBox_tenSp.Text,
                    Gia = Convert.ToInt32(textBox_gia.Text),
                    LoaiSanPham = "Laptop"
                };

                try
                {
                    db.MatHangs.Add(matHang);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!");

                    using (QLBHEntities db2 = new QLBHEntities())
                    {
                        ChitietLaptop ctLaptop = new ChitietLaptop()
                        {
                            IdMatHang = textBox_id.Text,
                            TenSanPham = textBox_tenSp.Text,
                            Gia = Convert.ToInt32(textBox_gia.Text),
                            Anh = frmThemDienThoai.ImageToByteArray(pictureBox_anhLaptop),
                            Manhinh = textBox_manHinh.Text,
                            CPU = textBox_CPU.Text,
                            RAM = textBox_Ram.Text,
                            Ocung = textBox_oCung.Text,
                            DoHoa = textBox_doHoa.Text,
                            HeDieuHanh = textBox_heDieuhanh.Text,
                            KichThuoc = textBox_kichThuoc.Text,
                            TrongLuong = textBox_trongLuong.Text,
                            XuatXu = textBox_xuatXu.Text,
                        };
                        try
                        {
                            db2.ChitietLaptops.Add(ctLaptop);
                            db2.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác!");
                        }
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác!");
                }
            }
        }

        // Envent click ---------------------
        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_reLoad_Click(object sender, EventArgs e)
        {
            textBox_id.Text =
            textBox_tenSp.Text =
            textBox_gia.Text =
            textBox_manHinh.Text =
            textBox_CPU.Text =
            textBox_oCung.Text =
            textBox_doHoa.Text =
            textBox_trongLuong.Text =
            textBox_Ram.Text = 
            textBox_kichThuoc.Text = 
            textBox_heDieuhanh.Text =
            textBox_xuatXu.Text = "";
        }
        
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddMatHangLapTop();    
        }

        // Check input
        private void textBox_gia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_gia.Text, "[^0-9/]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                textBox_gia.Text = textBox_gia.Text.Remove(textBox_gia.Text.Length - 1);
            }
        }

        private void textBox_namRaMat_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_namRaMat.Text, "[^0-9/]"))
            {
                MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng nhập lại (mm/yyyy)!");
                textBox_namRaMat.Text = textBox_namRaMat.Text.Remove(textBox_namRaMat.Text.Length - 1);
            }
        }
    }
}

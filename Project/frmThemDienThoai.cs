using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Project
{
    public partial class frmThemDienThoai : Form
    {
        public frmThemDienThoai()
        {
            InitializeComponent();
        }

        // Upload image from This PC
        private void button_upAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anhDienThoai.ImageLocation = openFileDialog.FileName;
            }
        }

        // Convert image to byte
        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        // Check input
        private void textBox_gia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_gia.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!!");
                textBox_gia.Text = textBox_gia.Text.Remove(textBox_gia.Text.Length - 1);
            }
        }

        // Feature ---------------------
        public void AddMatHangDienThoai()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                MatHang matHang = new MatHang()
                {
                    Id = textBox_id.Text,
                    TenSanPham = textBox_tenSp.Text,
                    Gia = Convert.ToInt32(textBox_gia.Text),
                    LoaiSanPham = "Dienthoai"
                };

                try
                {
                    db.MatHangs.Add(matHang);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!");

                    using (QLBHEntities db2 = new QLBHEntities())
                    {
                        ChitietDienThoai ctDienthoai = new ChitietDienThoai()
                        {
                            IdMatHang = textBox_id.Text,
                            TenSanPham = textBox_tenSp.Text,
                            Gia = Convert.ToInt32(textBox_gia.Text),
                            Anh = ImageToByteArray(pictureBox_anhDienThoai),
                            ManHinh = textBox_manHinh.Text,
                            CamSau = textBox_camSau.Text,
                            CamSelfie = textBox_camSelfie.Text,
                            Ram = textBox_ram.Text,
                            BoNhoTrong = textBox_boNhotrong.Text,
                            CPU = textBox_CPU.Text,
                            GPU = textBox_GPU.Text,
                            Pin = textBox_pin.Text,
                            Sim = textBox_sim.Text,
                            HeDieuHanh = textBox_heDieuhanh.Text,
                            XuatXu = textBox_xuatXu.Text,
                            NamRaMat = textBox_namRaMat.Text
                        };
                        try
                        {
                            db2.ChitietDienThoais.Add(ctDienthoai);
                            db2.SaveChanges();
                        }
                        catch (Exception )
                        {
                            MessageBox.Show("Error 404 rồi má ơi!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác!");
                }
            }


        }

        // Event click
        private void button_add_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text != "" && textBox_tenSp.Text != "" && 
               textBox_sim.Text != "" && textBox_ram.Text != "" &&
               textBox_pin.Text != "" && textBox_manHinh.Text != "" &&
               textBox_heDieuhanh.Text != "" && textBox_gia.Text != "" &&
               textBox_CPU.Text != "" && textBox_camSau.Text != "" &&
               textBox_camSelfie.Text != "" && textBox_boNhotrong.Text != "" )
            {
                AddMatHangDienThoai();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
                
        }

        private void button_reLoad_Click(object sender, EventArgs e)
        {
            textBox_id.Text =
            textBox_tenSp.Text =
            textBox_gia.Text =
            textBox_manHinh.Text =
            textBox_camSau.Text =
            textBox_camSelfie.Text =
            textBox_ram.Text =
            textBox_boNhotrong.Text =
            textBox_camSau.Text =
            textBox_CPU.Text =
            textBox_GPU.Text =
            textBox_gia.Text =
            textBox_pin.Text =
            textBox_sim.Text =
            textBox_heDieuhanh.Text =
            textBox_xuatXu.Text = 
            textBox_namRaMat.Text = "";
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

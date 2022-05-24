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
using System.IO;

namespace Project
{
    public partial class frmChiTietDienThoai : Form
    {
        private frmMatHang frmMatHang = new frmMatHang();
        public frmChiTietDienThoai()
        {
            InitializeComponent();
            LoadData();
        }

        private string ReadFile_MaSp()
        {
            string a = File.ReadAllText("MaSp.txt");
            return a;
        }
        private void LoadData()
        {
            string maSp = ReadFile_MaSp();
            using (var db = new QLBHEntities())
            {
                var query = from q in db.ChitietDienThoais
                            where q.IdMatHang.Contains(maSp)
                            select q;

                List<ChitietDienThoai> chitietDienThoais = query.ToList();
                foreach (var ctdt in chitietDienThoais)
                {
                    label_tenSp.Text = ctdt.TenSanPham;
                    label_gia.Text = ctdt.Gia.ToString() + "đ";
                    label_ndManhinh.Text = ctdt.ManHinh;
                    label_ndCamsau.Text = ctdt.CamSau;
                    label_ndCamselfie.Text = ctdt.CamSelfie;
                    label_ndBonhotrong.Text = ctdt.BoNhoTrong;
                    label_ndCPU.Text = ctdt.CPU;
                    label_ndGPU.Text = ctdt.GPU;
                    label_ndDlpin.Text = ctdt.Pin;
                    label_ndHedieuhanh.Text = ctdt.HeDieuHanh;
                    label_ndRam.Text = ctdt.Ram;
                    label_ndtheSim.Text = ctdt.Sim;
                    label_ndXuatxu.Text = ctdt.XuatXu;
                    label_ndNamRaMat.Text = ctdt.NamRaMat;

                    if(ctdt.Anh != null)
                    {
                        MemoryStream memory = new MemoryStream(ctdt.Anh);
                        pictureBox_anh.Image = Image.FromStream(memory);
                    }
                    
                }
            }       
        }

        private void button_themGiohang_Click(object sender, EventArgs e)
        {
            string id = File.ReadAllText("Giohang.txt");
            try
            {
                
                frmMatHang.AddToCart(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác không thành công! Vui lòng thử lại.");
            }
            
        }

        private void frmChiTietDienThoai_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMatHang.LoadDataGioHang();
        }

        private void frmChiTietDienThoai_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMatHang.LoadDataGioHang();
        }
    }
}

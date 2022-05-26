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
    public partial class frmChitietLaptop : Form
    {
        private frmMatHang frmMatHang = new frmMatHang();
        public frmChitietLaptop()
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
                var query = from q in db.ChitietLaptops
                            where q.IdMatHang.Contains(maSp)
                            select q;

                List<ChitietLaptop> chitietLaptops = query.ToList();
                foreach (var a in chitietLaptops)
                {
                    label_tenSp.Text = a.TenSanPham;
                    label_gia.Text = a.Gia.ToString() + "đ";
                    label_ndManhinh.Text = a.Manhinh;                  
                    label_ndCPU.Text = a.CPU;
                    label_ndRam.Text = a.RAM;
                    label_ndOcung.Text = a.Ocung;
                    label_ndDoHoa.Text = a.DoHoa;
                    label_ndHedieuhanh.Text = a.HeDieuHanh;
                    label_ndTrongluong.Text = a.TrongLuong;
                    label_ndKichthuoc.Text = a.KichThuoc;      
                    label_ndXuatxu.Text = a.XuatXu;
                    label_ndNamRaMat.Text = a.NamRaMat;

                    if (a.Anh != null)
                    {
                        MemoryStream memory = new MemoryStream(a.Anh);
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

        private void frmChitietLaptop_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMatHang.LoadDataGioHang();
        }
    }
}

using DTO;
using FastMember;
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
    public partial class frmMatHang : Form
    {
        private string maSP = null;
        private string loaiSp = null;

        public frmMatHang()
        {
            InitializeComponent();
            LoadDataMatHang();
            LoadDataGioHang();
        }


        private void LoadDataMatHang()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                var query = from q in db.MatHangs
                            select new
                            {     
                                MaMatHang = q.Id,
                                TenSanPham = q.TenSanPham,
                                Gia = q.Gia,
                                LoaiSP = q.LoaiSanPham
                            };

                dtGridView_MatHang.DataSource = query.ToList();
            }
        }

        public void LoadDataGioHang()
        {
            using (var db = new QLBHEntities())
            {
                var query = from q in db.MatHangs
                            select new
                            {
                                MaMatHang = q.Id,
                                TenSanPham = q.TenSanPham,
                                Gia = q.Gia,
                                LoaiSP = q.LoaiSanPham
                            };

                var query2 = from q in db.Carts
                             join p in query
                             on q.MaSP equals p.MaMatHang
                             select new
                             {
                                 MaSp = p.MaMatHang,
                                 TenSanPham = p.TenSanPham,
                                 SoLuong = q.SoLuong,
                             };
                dataGridView_gioHang.DataSource = query2.ToList();
            }
        }

        public void AddToCart(string id)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                Cart cart1 = db.Carts.Where(p => p.MaSP.Contains(id)).SingleOrDefault();
                if (cart1 != null)
                {
                    cart1.SoLuong++;
                    db.SaveChanges();
                }
                else
                {
                    Cart cart = new Cart()
                    {
                        MaSP = id,
                        SoLuong = 1
                    };
                    db.Carts.Add(cart);
                    db.SaveChanges();
                }  
            }
        }

        private void Search(string valueSearch)
        {
            using (var db = new QLBHEntities())
            {
                var query = from q in db.MatHangs
                            where q.TenSanPham.Contains(valueSearch)
                            || q.Id.Contains(valueSearch)
                            select new
                            {
                                MaMatHang = q.Id,
                                TenSanPham = q.TenSanPham,
                                Gia = q.Gia
                            };
                dtGridView_MatHang.DataSource = query.ToList();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void button_themSpDT_Click(object sender, EventArgs e)
        {
            frmThemDienThoai frmThemDienThoai = new frmThemDienThoai();
            frmThemDienThoai.ShowDialog();
        }

        private void button_themLaptop_Click(object sender, EventArgs e)
        {
            frmThemLaptop frmThemLaptop = new frmThemLaptop();
            frmThemLaptop.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    Search(txtSearch.Text);
                }
                else
                {
                    LoadDataMatHang();
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        string tensp;
        private void dtGridView_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtGridView_MatHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtGridView_MatHang.CurrentRow.Selected = true;
                    maSP = dtGridView_MatHang.Rows[e.RowIndex].Cells["MaMH"].FormattedValue.ToString();
                    loaiSp = dtGridView_MatHang.Rows[e.RowIndex].Cells["LoaiSanPham"].FormattedValue.ToString();
                    tensp = dtGridView_MatHang.Rows[e.RowIndex].Cells["TenSP"].FormattedValue.ToString();
                    File.WriteAllText("Giohang.txt", maSP);
                    //  For cart
                }
            }
            catch (Exception)
            {
            };

            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex != -1)
                {
                    // File MaSp.txt ở trong thư mục Bin\debug
                    WriteFile("MaSp.txt", maSP);
                    try
                    {
                        if (loaiSp.Contains("Dienthoai"))
                        {
                            frmChiTietDienThoai chiTietDienThoai = new frmChiTietDienThoai();
                            chiTietDienThoai.ShowDialog();
                        }
                        else
                        {
                            frmChitietLaptop chitietLaptop = new frmChitietLaptop();
                            chitietLaptop.ShowDialog();
                        }
                    }
                    catch (Exception)
                    {
                    };
                }
            }
        }

        private void WriteFile(string nameFile, string value)
        {
            File.WriteAllText(nameFile, value);
        }

        //Choose product form menuStrip ------------------------
        private void menuStrip_matHang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Search(e.ClickedItem.Text);
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Samsung_J_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Samsung Galaxy J");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Samsung_A_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Samsung Galaxy A");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_13_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone 13");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_12_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone 12");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_11_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone 11");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_X_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone X");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_8_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone 8");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void iPhone_SE_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("iPhone SE");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vsmart_Joy_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vsmart Joy");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vsmart_Star_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vsmart Star");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vsmart_Active_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vsmart Active");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vsmart_Live_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vsmart Live");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vivo_X_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vivo X");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vivo_V_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vivo V");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vivo_Y_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vivo Y");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vivo_U_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vivo U");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void vivo_S_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Vivo S");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void oppo_A_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Oppo A");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void oppo_Reno_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Oppo Reno");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void oppo_FindX_series_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Oppo Find X");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Mi_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Xiaomi Mi");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Mi_Note_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Xiaomi Mi Note");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Mi_Max_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Xiaomi Mi Max");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Mi_Mix_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Xiaomi Mi Mix");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Mi_A_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Xiaomi Mi A");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Readmi_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Readmi");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Readmi_Note_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Readmi Note");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Readmi_K_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Readmi K");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Readmi_S_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Readmi S");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Xiaomi_Readmi_Y_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Readmi Y");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_5i_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme 5i");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_C11_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme C11");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_6_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme 6");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_7pro_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme 7 Pro");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_Narzo_30A_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme Narzo 30A");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_C32Y_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme C32Y");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Realme_8pro_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Realdme 8 Pro");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Lenovo_Thinkpad_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Lenovo ThinkPad");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Lenovo_ThinkBook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Lenovo ThinkBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Lenovo_Gaming_Legion_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Lenovo Gaming Legion");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Lenovo_IdeaPad_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Lenovo IdeaPad");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Lenovo_Yoga_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Lenovo Yoga");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void ASUS_VivoBook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("ASUS VivoBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void ASUS_ZenBook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("ASUS ZenBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void ASUS_ExpertBook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("ASUS ExpertBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void ASUS_TUF_Click(object sender, EventArgs e)
        {
            try
            {
                Search("ASUS TUF");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void MacBook_Air_Click(object sender, EventArgs e)
        {
            try
            {
                Search("MacBook Air");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Macbook_12_Click(object sender, EventArgs e)
        {
            try
            {
                Search("MacBook 12");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Macbook_Pro_Click(object sender, EventArgs e)
        {
            try
            {
                Search("MacBook Pro");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void HP_Probook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("HP ProBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void HP_EliteBook_Click(object sender, EventArgs e)
        {
            try
            {
                Search("HP EliteBook");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void HP_Envy_Click(object sender, EventArgs e)
        {
            try
            {
                Search("HP Envy");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void HP_Pavilion_Click(object sender, EventArgs e)
        {
            try
            {
                Search("HP Pavilion");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Dell_XPS_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Dell XPS");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Dell_Gaming_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Dell Gaming");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Dell_Inspiron_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Dell Inspiron");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Dell_Vostro_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Dell Vostro");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void Dell_Latitude_Click(object sender, EventArgs e)
        {
            try
            {
                Search("Dell Latitude");
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        public void Refresh_Cart()
        {
            using(QLBHEntities db = new QLBHEntities())
            {
                var rows = from o in db.Carts
                           select o;
                foreach (var row in rows)
                {
                    db.Carts.Remove(row);

                }
                db.SaveChanges();
            }
        }

        private void dataGridView_gioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex != -1)
                {
                    string maSp_gioHang = dataGridView_gioHang.Rows[e.RowIndex].Cells["MaMatHang"].FormattedValue.ToString();

                    using (QLBHEntities db = new QLBHEntities())
                    {
                        Cart cart = db.Carts.Find(maSp_gioHang);
                        try
                        {
                            db.Carts.Remove(cart);
                            db.SaveChanges();
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString());
                        }
                    }
                    LoadDataGioHang();
                }
                    
            }
        }

        // Tính năng chưa hoàn thành
        private void button_themGiohang_Click(object sender, EventArgs e)
        {
            try
            {
                AddToCart(maSP);
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm thất bại!");
            }
            LoadDataGioHang();

        }


        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan frmThanhToan = new frmThanhToan();
            frmThanhToan.ShowDialog();
        }

    }

}

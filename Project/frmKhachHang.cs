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
using DTO;

namespace Project
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }

        // Load data from Database to datagridview
        private void LoadDataKhachHang()
        {
            using (var db = new QLBHEntities())
            {
                var query = from q in db.KhachHangs
                            select new
                            {
                                MaKhachHang = q.MaKhachHang,
                                HoTen = q.TenKhachHang,
                                NgaySinh = q.NgaySinh,
                                DiaChi = q.DiaChi,
                                SDT = q.SDT,
                                GioiTinh = q.GioiTinh,
                            };
                dtGridView_khachHang.DataSource = query.ToList();
            }
        }

        // Search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch_khachHang.Text != "")
                {
                    Search(txtSearch_khachHang.Text);
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        // How to search
        public void Search(string valueSearch)
        {
            using (var db = new QLBHEntities())
            { 
                var query = from q in db.KhachHangs
                            where q.TenKhachHang.Contains(valueSearch)
                            || q.DiaChi.Contains(valueSearch)
                            || q.GioiTinh.Contains(valueSearch)
                            || q.MaKhachHang.Contains(valueSearch)
                            || q.SDT.Contains(valueSearch)
                            || q.NgaySinh.ToString().Contains(valueSearch)
                            select new
                            {
                                MaKhachHang = q.MaKhachHang,
                                HoTen = q.TenKhachHang,
                                NgaySinh = q.NgaySinh,
                                DiaChi = q.DiaChi,
                                SDT = q.SDT,
                                GioiTinh = q.GioiTinh,
                            };
                dtGridView_khachHang.DataSource = query.ToList();
            }
        }

        private void dtGridView_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddBinding();
        }

        public void AddBinding()
        {
            // Clear bindings
            textBox_id.DataBindings.Clear();
            textBox_hoten.DataBindings.Clear();
            comboBox_gioiTinh.DataBindings.Clear();
            dateTimePicker_ngaySinh.DataBindings.Clear();
            textBox_sdt.DataBindings.Clear();
            textBox_diachi.DataBindings.Clear();

            textBox_id.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "MaKhachHang"));
            textBox_hoten.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "HoTen"));
            comboBox_gioiTinh.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "GioiTinh"));
            dateTimePicker_ngaySinh.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "NgaySinh"));
            textBox_sdt.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "SDT"));
            textBox_diachi.DataBindings.Add(new Binding("Text", dtGridView_khachHang.DataSource, "DiaChi"));
        }

        //------------------------- Features --------------------------
        public void AddKhachHang()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                KhachHang khachHang = new KhachHang()
                {
                    MaKhachHang = textBox_id.Text,
                    TenKhachHang = textBox_hoten.Text,
                    NgaySinh = dateTimePicker_ngaySinh.Value,
                    GioiTinh = comboBox_gioiTinh.Text,
                    SDT = textBox_sdt.Text,
                    DiaChi = textBox_diachi.Text
                };
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
            }
        }

        public void DelKhachHang()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                KhachHang khachHang = db.KhachHangs.Where(p => p.MaKhachHang.Contains(textBox_id.Text)).SingleOrDefault();
                db.KhachHangs.Remove(khachHang);
                db.SaveChanges();
            }
        }

        public void EditKhachHang()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                string idKhachHang = dtGridView_khachHang.SelectedCells[0].OwningRow.Cells["MaKhachHang"].Value.ToString();
                KhachHang kh = db.KhachHangs.Find(idKhachHang);
                kh.MaKhachHang = textBox_id.Text;
                kh.TenKhachHang = textBox_hoten.Text;
                kh.NgaySinh = dateTimePicker_ngaySinh.Value;
                kh.GioiTinh = comboBox_gioiTinh.Text;
                kh.SDT = textBox_sdt.Text;
                kh.DiaChi = textBox_diachi.Text;
                db.SaveChanges();
            }
        }

        //------------------------- Features --------------------------
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                DelKhachHang();
                MessageBox.Show("Xóa thành công!");
                ClearAllTextBox();
                LoadDataKhachHang();
            }
        }

        private void ClearAllTextBox()
        {
            textBox_id.Text =
            textBox_hoten.Text =
            textBox_diachi.Text =
            textBox_sdt.Text =
            dateTimePicker_ngaySinh.Text =
            comboBox_gioiTinh.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            AddKhachHang();
            LoadDataKhachHang();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                EditKhachHang();
            }catch(Exception )
            {
                MessageBox.Show("Mã khách hàng là cố định, không được phép thay đổi!");
            }
            LoadDataKhachHang();
        }

        // Check Input
        private void textBox_sdt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_sdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                textBox_sdt.Text = textBox_sdt.Text.Remove(textBox_sdt.Text.Length - 1);
            }
        }

        private void comboBox_gioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_sdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                textBox_sdt.Text = textBox_sdt.Text.Remove(textBox_sdt.Text.Length - 1);
            }
        }

        private void txtSearch_khachHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch_khachHang.Text != "")
                {
                    Search(txtSearch_khachHang.Text);
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        // Change hightligh for textSearcH
        private void txtSearch_khachHang_Enter_1(object sender, EventArgs e)
        {
            if (txtSearch_khachHang.Text == "Search")
            {
                txtSearch_khachHang.Text = "";
                txtSearch_khachHang.ForeColor = Color.Black;
            }
        }

        private void txtSearch_khachHang_Leave_1(object sender, EventArgs e)
        {
            if (txtSearch_khachHang.Text == "")
            {
                txtSearch_khachHang.Text = "Search";
                txtSearch_khachHang.ForeColor = Color.Silver;
            }
        }

    }
}

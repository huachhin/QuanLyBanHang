using FastMember;
using System;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            LoadDataNhanVien();
        }

        private void txtSearch_nhanVien_Enter(object sender, EventArgs e)
        {
            if (txtSearch_nhanVien.Text == "Search")
            {
                txtSearch_nhanVien.Text = "";
                txtSearch_nhanVien.ForeColor = Color.Black;
            }
        }

        private void txtSearch_nhanVien_Leave(object sender, EventArgs e)
        {
            if (txtSearch_nhanVien.Text == "")
            {
                txtSearch_nhanVien.Text = "Search";
                txtSearch_nhanVien.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_nhanVien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch_nhanVien.Text != "")
                {
                    Search(txtSearch_nhanVien.Text);
                }
                else
                {
                    LoadDataNhanVien();
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void dtGridView_Nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddBinding();
        }

        private void ClearAllTextBox()
        {
            textBox_id.Text =
            textBox_hoten.Text =
            textBox_diaChi.Text =
            textBox_sdt.Text =
            dateTimePicker_ngaySinh.Text =
            comboBox_gioiTinh.Text =
            textBox_email.Text = "";
        }

        public void AddBinding()
        {
            // Clear bindings
            textBox_id.DataBindings.Clear();
            textBox_hoten.DataBindings.Clear();
            comboBox_gioiTinh.DataBindings.Clear();
            dateTimePicker_ngaySinh.DataBindings.Clear();
            textBox_sdt.DataBindings.Clear();
            textBox_diaChi.DataBindings.Clear();
            textBox_email.DataBindings.Clear();

            textBox_id.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "MaNhanVien"));
            textBox_hoten.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "HoTen"));
            comboBox_gioiTinh.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "GioiTinh"));
            dateTimePicker_ngaySinh.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "NgaySinh"));
            textBox_sdt.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "SDT"));
            textBox_diaChi.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "DiaChi"));
            textBox_email.DataBindings.Add(new Binding("Text", dtGridView_Nhanvien.DataSource, "Email"));
        }

        //------------------------- Features --------------------------
        private void LoadDataNhanVien()
        {
            using (var db = new DTO.QLBHEntities())
            {
                var query = from q in db.NhanViens
                            select new
                            {
                                MaNhanVien = q.MaNhanVien,
                                HoTen = q.TenNhanVien,
                                DiaChi = q.DiaChi,
                                NgaySinh = q.NgaySinh,
                                GioiTinh = q.GioiTinh,
                                SDT = q.SDT,
                                Email = q.Email
                            };
                dtGridView_Nhanvien.DataSource = query.ToList();
            }
        }

        public void Search(string valueSearch)
        {
            using (var db = new QLBHEntities())
            {
                var query = from q in db.NhanViens
                            where q.MaNhanVien.Contains(valueSearch)
                            || q.TenNhanVien.Contains(valueSearch)
                            || q.GioiTinh.Contains(valueSearch)
                            || q.NgaySinh.Value.ToString().Contains(valueSearch)
                            || q.SDT.Contains(valueSearch)
                            select new
                            {
                                MaNhanVien = q.MaNhanVien,
                                HoTen = q.TenNhanVien,
                                DiaChi = q.DiaChi,
                                NgaySinh = q.NgaySinh,
                                GioiTinh = q.GioiTinh,
                                SDT = q.SDT,
                                Email = q.Email
                            };
                dtGridView_Nhanvien.DataSource = query.ToList();
            }
        }

        public void AddNhanVien()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                NhanVien nhanVien = new NhanVien()
                {
                    MaNhanVien = textBox_id.Text,
                    TenNhanVien = textBox_hoten.Text,
                    NgaySinh = dateTimePicker_ngaySinh.Value,
                    GioiTinh = comboBox_gioiTinh.Text,
                    SDT = textBox_sdt.Text,
                    DiaChi = textBox_diaChi.Text,
                    Email = textBox_email.Text
                };
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
        }

        public void DelNhanVien()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                HoaDon hoaDon = db.HoaDons.Where(p => p.MaNguoiTao.Contains(textBox_id.Text)).SingleOrDefault();
                try
                {   
                    db.HoaDons.Remove(hoaDon);
                    db.SaveChanges();
                }catch(Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }
            }    

            using (QLBHEntities db2 = new QLBHEntities())
            {
                NhanVien nhanVien = db2.NhanViens.Where(p => p.MaNhanVien.Contains(textBox_id.Text)).SingleOrDefault();
                try
                {
                    db2.NhanViens.Remove(nhanVien);
                    db2.SaveChanges();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }    
            }
        }

        public void EditNhanVien()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                string idNhanVien = dtGridView_Nhanvien.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();
                NhanVien nv = db.NhanViens.Find(idNhanVien);

                nv.MaNhanVien = textBox_id.Text;
                nv.TenNhanVien = textBox_hoten.Text;
                nv.NgaySinh = dateTimePicker_ngaySinh.Value;
                nv.GioiTinh = comboBox_gioiTinh.Text;
                nv.SDT = textBox_sdt.Text;
                nv.DiaChi = textBox_diaChi.Text;
                nv.Email = textBox_email.Text;
                db.SaveChanges();
            }
        } 

        // Add - Delete - Edit
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddNhanVien();
            LoadDataNhanVien();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                DelNhanVien();
                MessageBox.Show("Xóa thành công!");
                ClearAllTextBox();
                LoadDataNhanVien();
            }  
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                EditNhanVien();
            }
            catch (Exception )
            {
                MessageBox.Show("Mã nhân viên là cố định, không được phép thay đổi!");
            }
            LoadDataNhanVien();
        }

        // Check input
        private void textBox_sdt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_sdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                textBox_sdt.Text = textBox_sdt.Text.Remove(textBox_sdt.Text.Length - 1);
            }
        }

    }
}
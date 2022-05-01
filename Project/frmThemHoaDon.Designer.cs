
namespace Project
{
    partial class frmThemHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNguoiTao = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbNguoiBan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timePickerThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtGridViewThemHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btTra = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTongSoLuong = new System.Windows.Forms.TextBox();
            this.tbTongTienHang = new System.Windows.Forms.TextBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.tbSauGiam = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewThemHoaDon)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.cbNguoiTao);
            this.panel4.Controls.Add(this.cbTrangThai);
            this.panel4.Controls.Add(this.cbNguoiBan);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.timePickerThoiGian);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbTenKH);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbMaHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 241);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(746, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 2);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(746, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(746, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 2);
            this.panel1.TabIndex = 19;
            // 
            // cbNguoiTao
            // 
            this.cbNguoiTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNguoiTao.FormattingEnabled = true;
            this.cbNguoiTao.Location = new System.Drawing.Point(746, 164);
            this.cbNguoiTao.Name = "cbNguoiTao";
            this.cbNguoiTao.Size = new System.Drawing.Size(265, 33);
            this.cbNguoiTao.TabIndex = 14;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Hoàn Thành",
            "Chưa Hoàn Thành"});
            this.cbTrangThai.Location = new System.Drawing.Point(746, 47);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(265, 33);
            this.cbTrangThai.TabIndex = 15;
            // 
            // cbNguoiBan
            // 
            this.cbNguoiBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNguoiBan.FormattingEnabled = true;
            this.cbNguoiBan.Location = new System.Drawing.Point(746, 110);
            this.cbNguoiBan.Name = "cbNguoiBan";
            this.cbNguoiBan.Size = new System.Drawing.Size(265, 33);
            this.cbNguoiBan.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Người Tạo";
            // 
            // timePickerThoiGian
            // 
            this.timePickerThoiGian.Location = new System.Drawing.Point(251, 108);
            this.timePickerThoiGian.Name = "timePickerThoiGian";
            this.timePickerThoiGian.Size = new System.Drawing.Size(265, 30);
            this.timePickerThoiGian.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Người Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời Gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khách Hàng:";
            // 
            // tbTenKH
            // 
            this.tbTenKH.BackColor = System.Drawing.Color.White;
            this.tbTenKH.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTenKH.Location = new System.Drawing.Point(251, 167);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(265, 30);
            this.tbTenKH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.BackColor = System.Drawing.Color.White;
            this.tbMaHoaDon.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbMaHoaDon.Location = new System.Drawing.Point(251, 42);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(265, 30);
            this.tbMaHoaDon.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtGridViewThemHoaDon);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1118, 476);
            this.panel5.TabIndex = 6;
            // 
            // dtGridViewThemHoaDon
            // 
            this.dtGridViewThemHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridViewThemHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtGridViewThemHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewThemHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.GiamGia,
            this.GiaBan,
            this.ThanhTien});
            this.dtGridViewThemHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewThemHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewThemHoaDon.Name = "dtGridViewThemHoaDon";
            this.dtGridViewThemHoaDon.RowHeadersWidth = 51;
            this.dtGridViewThemHoaDon.RowTemplate.Height = 24;
            this.dtGridViewThemHoaDon.Size = new System.Drawing.Size(1118, 355);
            this.dtGridViewThemHoaDon.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 160;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 130;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // GiamGia
            // 
            this.GiamGia.HeaderText = "Giảm Giá";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 140;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSauGiam);
            this.panel6.Controls.Add(this.tbTongTienHang);
            this.panel6.Controls.Add(this.tbGiamGia);
            this.panel6.Controls.Add(this.tbTongSoLuong);
            this.panel6.Controls.Add(this.btTra);
            this.panel6.Controls.Add(this.btHuy);
            this.panel6.Controls.Add(this.btThem);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 355);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1118, 121);
            this.panel6.TabIndex = 0;
            // 
            // btTra
            // 
            this.btTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btTra.Image = global::Project.Properties.Resources.icons8_minus_45px_2;
            this.btTra.Location = new System.Drawing.Point(802, 34);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(128, 55);
            this.btTra.TabIndex = 2;
            this.btTra.Text = "Trả";
            this.btTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTra.UseVisualStyleBackColor = false;
            // 
            // btHuy
            // 
            this.btHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHuy.BackColor = System.Drawing.Color.Pink;
            this.btHuy.Image = global::Project.Properties.Resources.icons8_cancel_35px;
            this.btHuy.Location = new System.Drawing.Point(978, 34);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(128, 55);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuy.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btThem.Image = global::Project.Properties.Resources.icons8_add_45px_1;
            this.btThem.Location = new System.Drawing.Point(626, 34);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(128, 55);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Sau giảm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giảm giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng số lượng:";
            // 
            // tbTongSoLuong
            // 
            this.tbTongSoLuong.Location = new System.Drawing.Point(178, 21);
            this.tbTongSoLuong.Name = "tbTongSoLuong";
            this.tbTongSoLuong.Size = new System.Drawing.Size(136, 30);
            this.tbTongSoLuong.TabIndex = 3;
            // 
            // tbTongTienHang
            // 
            this.tbTongTienHang.Location = new System.Drawing.Point(178, 65);
            this.tbTongTienHang.Name = "tbTongTienHang";
            this.tbTongTienHang.Size = new System.Drawing.Size(136, 30);
            this.tbTongTienHang.TabIndex = 3;
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(469, 21);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(136, 30);
            this.tbGiamGia.TabIndex = 3;
            // 
            // tbSauGiam
            // 
            this.tbSauGiam.Location = new System.Drawing.Point(469, 65);
            this.tbSauGiam.Name = "tbSauGiam";
            this.tbSauGiam.Size = new System.Drawing.Size(136, 30);
            this.tbSauGiam.TabIndex = 3;
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 717);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemHoaDon";
            this.Text = "frmThemHoaDon";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewThemHoaDon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNguoiTao;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbNguoiBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timePickerThoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dtGridViewThemHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox tbTongTienHang;
        private System.Windows.Forms.TextBox tbTongSoLuong;
        private System.Windows.Forms.TextBox tbSauGiam;
        private System.Windows.Forms.TextBox tbGiamGia;
    }
}
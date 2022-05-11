namespace Project
{
    partial class frmCuaHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabThietBi = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBH = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKhuyenMai = new MetroFramework.Controls.MetroTabPage();
            this.dtgvKM = new System.Windows.Forms.DataGridView();
            this.ChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaikm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabThietBi.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBH)).BeginInit();
            this.tabKhuyenMai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 94);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(889, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm hàng";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button.BackColor = System.Drawing.Color.Pink;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.Location = new System.Drawing.Point(1094, 20);
            this.button.Margin = new System.Windows.Forms.Padding(5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(162, 54);
            this.button.TabIndex = 6;
            this.button.Text = "Trả hàng";
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 614);
            this.panel2.TabIndex = 5;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabThietBi);
            this.metroTabControl1.Controls.Add(this.tabKhuyenMai);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(250, 50);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1333, 614);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabThietBi
            // 
            this.tabThietBi.BackColor = System.Drawing.Color.White;
            this.tabThietBi.Controls.Add(this.panel3);
            this.tabThietBi.HorizontalScrollbarBarColor = true;
            this.tabThietBi.HorizontalScrollbarHighlightOnWheel = false;
            this.tabThietBi.HorizontalScrollbarSize = 1;
            this.tabThietBi.Location = new System.Drawing.Point(4, 54);
            this.tabThietBi.Name = "tabThietBi";
            this.tabThietBi.Size = new System.Drawing.Size(1325, 556);
            this.tabThietBi.TabIndex = 0;
            this.tabThietBi.Text = "Bảo hành";
            this.tabThietBi.VerticalScrollbarBarColor = true;
            this.tabThietBi.VerticalScrollbarHighlightOnWheel = false;
            this.tabThietBi.VerticalScrollbarSize = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 556);
            this.panel3.TabIndex = 3;
            // 
            // dtgvBH
            // 
            this.dtgvBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TinhTrang,
            this.NgayNhan,
            this.NhanVienNhan,
            this.TrangThai});
            this.dtgvBH.Location = new System.Drawing.Point(-1, 0);
            this.dtgvBH.Name = "dtgvBH";
            this.dtgvBH.Size = new System.Drawing.Size(1300, 560);
            this.dtgvBH.TabIndex = 2;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // NgayNhan
            // 
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày nhận";
            this.NgayNhan.Name = "NgayNhan";
            // 
            // NhanVienNhan
            // 
            this.NhanVienNhan.DataPropertyName = "NhanVienNhan";
            this.NhanVienNhan.HeaderText = "Nhân viên nhận";
            this.NhanVienNhan.Name = "NhanVienNhan";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // tabKhuyenMai
            // 
            this.tabKhuyenMai.BackColor = System.Drawing.Color.White;
            this.tabKhuyenMai.Controls.Add(this.dtgvKM);
            this.tabKhuyenMai.HorizontalScrollbarBarColor = true;
            this.tabKhuyenMai.HorizontalScrollbarHighlightOnWheel = false;
            this.tabKhuyenMai.HorizontalScrollbarSize = 1;
            this.tabKhuyenMai.Location = new System.Drawing.Point(4, 54);
            this.tabKhuyenMai.Name = "tabKhuyenMai";
            this.tabKhuyenMai.Size = new System.Drawing.Size(1325, 556);
            this.tabKhuyenMai.TabIndex = 1;
            this.tabKhuyenMai.Text = "Khuyến mãi";
            this.tabKhuyenMai.VerticalScrollbarBarColor = true;
            this.tabKhuyenMai.VerticalScrollbarHighlightOnWheel = false;
            this.tabKhuyenMai.VerticalScrollbarSize = 1;
            // 
            // dtgvKM
            // 
            this.dtgvKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChuongTrinh,
            this.Apdung,
            this.ThoiHan,
            this.TrangThaikm,
            this.NguoiTao});
            this.dtgvKM.Location = new System.Drawing.Point(0, 0);
            this.dtgvKM.Name = "dtgvKM";
            this.dtgvKM.Size = new System.Drawing.Size(1277, 536);
            this.dtgvKM.TabIndex = 2;
            // 
            // ChuongTrinh
            // 
            this.ChuongTrinh.DataPropertyName = "ChuongTrinh";
            this.ChuongTrinh.HeaderText = "Chương trình";
            this.ChuongTrinh.Name = "ChuongTrinh";
            // 
            // Apdung
            // 
            this.Apdung.DataPropertyName = "ApDung";
            this.Apdung.HeaderText = "Áp dụng";
            this.Apdung.Name = "Apdung";
            // 
            // ThoiHan
            // 
            this.ThoiHan.DataPropertyName = "ThoiHan";
            this.ThoiHan.HeaderText = "Thời hạn";
            this.ThoiHan.Name = "ThoiHan";
            // 
            // TrangThaikm
            // 
            this.TrangThaikm.DataPropertyName = "TrangThaiKM";
            this.TrangThaikm.HeaderText = "Trạng thái";
            this.TrangThaikm.Name = "TrangThaikm";
            // 
            // NguoiTao
            // 
            this.NguoiTao.DataPropertyName = "NguoiTao";
            this.NguoiTao.HeaderText = "Người tạo";
            this.NguoiTao.Name = "NguoiTao";
            // 
            // frmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng";
            this.Load += new System.EventHandler(this.frmCuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabThietBi.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBH)).EndInit();
            this.tabKhuyenMai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabThietBi;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabPage tabKhuyenMai;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvKM;
        private System.Windows.Forms.DataGridView dtgvBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apdung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaikm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTao;
    }
}
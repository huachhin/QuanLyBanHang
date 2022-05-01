
namespace Project
{
    partial class frmHoaDon
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabHoaDon = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGop = new System.Windows.Forms.Button();
            this.btInHoaDon = new System.Windows.Forms.Button();
            this.txtSearchHoaDon = new System.Windows.Forms.TextBox();
            this.tabLichSu = new MetroFramework.Controls.MetroTabPage();
            this.dtGridViewLsThanhToan = new System.Windows.Forms.DataGridView();
            this.lsSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsGiaTriPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsPhuongThuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lsTrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lsThuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLsThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabHoaDon);
            this.metroTabControl1.Controls.Add(this.tabLichSu);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(250, 50);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1075, 684);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.BackColor = System.Drawing.Color.White;
            this.tabHoaDon.Controls.Add(this.panel2);
            this.tabHoaDon.Controls.Add(this.panel1);
            this.tabHoaDon.HorizontalScrollbarBarColor = true;
            this.tabHoaDon.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHoaDon.HorizontalScrollbarSize = 1;
            this.tabHoaDon.Location = new System.Drawing.Point(4, 54);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Size = new System.Drawing.Size(1067, 626);
            this.tabHoaDon.TabIndex = 0;
            this.tabHoaDon.Text = "Hóa Đơn";
            this.tabHoaDon.VerticalScrollbarBarColor = true;
            this.tabHoaDon.VerticalScrollbarHighlightOnWheel = false;
            this.tabHoaDon.VerticalScrollbarSize = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtGridViewHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 548);
            this.panel2.TabIndex = 3;
            // 
            // dtGridViewHoaDon
            // 
            this.dtGridViewHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhieu,
            this.ThoiGian,
            this.KhachHang,
            this.GiaBan,
            this.SoLuong,
            this.TongGia,
            this.KhachTra});
            this.dtGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewHoaDon.Name = "dtGridViewHoaDon";
            this.dtGridViewHoaDon.RowHeadersWidth = 51;
            this.dtGridViewHoaDon.RowTemplate.Height = 24;
            this.dtGridViewHoaDon.Size = new System.Drawing.Size(1067, 548);
            this.dtGridViewHoaDon.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 140;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Width = 160;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // TongGia
            // 
            this.TongGia.HeaderText = "Tổng Giá";
            this.TongGia.MinimumWidth = 6;
            this.TongGia.Name = "TongGia";
            this.TongGia.Width = 140;
            // 
            // KhachTra
            // 
            this.KhachTra.HeaderText = "Khách Trả";
            this.KhachTra.MinimumWidth = 6;
            this.KhachTra.Name = "KhachTra";
            this.KhachTra.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGop);
            this.panel1.Controls.Add(this.btInHoaDon);
            this.panel1.Controls.Add(this.txtSearchHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 78);
            this.panel1.TabIndex = 2;
            // 
            // btGop
            // 
            this.btGop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btGop.Image = global::Project.Properties.Resources.icons8_merge_documents_48px;
            this.btGop.Location = new System.Drawing.Point(848, 5);
            this.btGop.Name = "btGop";
            this.btGop.Size = new System.Drawing.Size(155, 66);
            this.btGop.TabIndex = 1;
            this.btGop.Text = "Gộp Đơn";
            this.btGop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGop.UseVisualStyleBackColor = false;
            // 
            // btInHoaDon
            // 
            this.btInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btInHoaDon.Image = global::Project.Properties.Resources.icons8_print_48px_1;
            this.btInHoaDon.Location = new System.Drawing.Point(636, 6);
            this.btInHoaDon.Name = "btInHoaDon";
            this.btInHoaDon.Size = new System.Drawing.Size(155, 66);
            this.btInHoaDon.TabIndex = 1;
            this.btInHoaDon.Text = " In Hóa Đơn";
            this.btInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInHoaDon.UseVisualStyleBackColor = false;
            // 
            // txtSearchHoaDon
            // 
            this.txtSearchHoaDon.BackColor = System.Drawing.Color.White;
            this.txtSearchHoaDon.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchHoaDon.Location = new System.Drawing.Point(32, 21);
            this.txtSearchHoaDon.Name = "txtSearchHoaDon";
            this.txtSearchHoaDon.Size = new System.Drawing.Size(290, 30);
            this.txtSearchHoaDon.TabIndex = 0;
            this.txtSearchHoaDon.Text = "Search";
            this.txtSearchHoaDon.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearchHoaDon.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.White;
            this.tabLichSu.Controls.Add(this.dtGridViewLsThanhToan);
            this.tabLichSu.HorizontalScrollbarBarColor = true;
            this.tabLichSu.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLichSu.HorizontalScrollbarSize = 1;
            this.tabLichSu.Location = new System.Drawing.Point(4, 54);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Size = new System.Drawing.Size(1067, 626);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch Sử Thanh Toán";
            this.tabLichSu.VerticalScrollbarBarColor = true;
            this.tabLichSu.VerticalScrollbarHighlightOnWheel = false;
            this.tabLichSu.VerticalScrollbarSize = 1;
            // 
            // dtGridViewLsThanhToan
            // 
            this.dtGridViewLsThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewLsThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewLsThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lsSTT,
            this.lsMaPhieu,
            this.lsThoiGian,
            this.lsNguoiTao,
            this.lsGiaTriPhieu,
            this.lsPhuongThuc,
            this.lsTrangThai,
            this.lsThuChi});
            this.dtGridViewLsThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewLsThanhToan.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewLsThanhToan.Name = "dtGridViewLsThanhToan";
            this.dtGridViewLsThanhToan.RowHeadersWidth = 51;
            this.dtGridViewLsThanhToan.RowTemplate.Height = 24;
            this.dtGridViewLsThanhToan.Size = new System.Drawing.Size(1067, 626);
            this.dtGridViewLsThanhToan.TabIndex = 5;
            // 
            // lsSTT
            // 
            this.lsSTT.HeaderText = "STT";
            this.lsSTT.MinimumWidth = 6;
            this.lsSTT.Name = "lsSTT";
            this.lsSTT.Width = 60;
            // 
            // lsMaPhieu
            // 
            this.lsMaPhieu.HeaderText = "Mã Phiếu";
            this.lsMaPhieu.MinimumWidth = 6;
            this.lsMaPhieu.Name = "lsMaPhieu";
            this.lsMaPhieu.Width = 125;
            // 
            // lsThoiGian
            // 
            this.lsThoiGian.HeaderText = "Thời Gian";
            this.lsThoiGian.MinimumWidth = 6;
            this.lsThoiGian.Name = "lsThoiGian";
            this.lsThoiGian.Width = 140;
            // 
            // lsNguoiTao
            // 
            this.lsNguoiTao.HeaderText = "Người Tạo";
            this.lsNguoiTao.MinimumWidth = 6;
            this.lsNguoiTao.Name = "lsNguoiTao";
            this.lsNguoiTao.Width = 160;
            // 
            // lsGiaTriPhieu
            // 
            this.lsGiaTriPhieu.HeaderText = "Giá Trị Phiếu";
            this.lsGiaTriPhieu.MinimumWidth = 6;
            this.lsGiaTriPhieu.Name = "lsGiaTriPhieu";
            this.lsGiaTriPhieu.Width = 125;
            // 
            // lsPhuongThuc
            // 
            this.lsPhuongThuc.HeaderText = "Phương Thức TT";
            this.lsPhuongThuc.MinimumWidth = 6;
            this.lsPhuongThuc.Name = "lsPhuongThuc";
            this.lsPhuongThuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lsPhuongThuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lsPhuongThuc.Width = 125;
            // 
            // lsTrangThai
            // 
            this.lsTrangThai.HeaderText = "Trạng Thái";
            this.lsTrangThai.MinimumWidth = 6;
            this.lsTrangThai.Name = "lsTrangThai";
            this.lsTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lsTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lsTrangThai.Width = 140;
            // 
            // lsThuChi
            // 
            this.lsThuChi.HeaderText = "Thu/Chi";
            this.lsThuChi.MinimumWidth = 6;
            this.lsThuChi.Name = "lsThuChi";
            this.lsThuChi.Width = 150;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 684);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.metroTabControl1.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLsThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabHoaDon;
        private MetroFramework.Controls.MetroTabPage tabLichSu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGop;
        private System.Windows.Forms.TextBox txtSearchHoaDon;
        private System.Windows.Forms.DataGridView dtGridViewHoaDon;
        private System.Windows.Forms.Button btInHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachTra;
        private System.Windows.Forms.DataGridView dtGridViewLsThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsNguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsGiaTriPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn lsPhuongThuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn lsTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsThuChi;
    }
}
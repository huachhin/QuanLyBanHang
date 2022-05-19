
namespace Project
{
    partial class frmXuLyDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.lbNgayGD = new System.Windows.Forms.Label();
            this.lbTongGia = new System.Windows.Forms.Label();
            this.lbKhachTra = new System.Windows.Forms.Label();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.btCapNhatDonHang = new System.Windows.Forms.Button();
            this.lbNo = new System.Windows.Forms.Label();
            this.tbThanhToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbKhachTra = new System.Windows.Forms.TextBox();
            this.tbTongDonHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPham,
            this.SLuong,
            this.GiaBan,
            this.Delete,
            this.LyDo,
            this.MaSP,
            this.KTra});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(17, 182);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(771, 316);
            this.dataGridViewSanPham.TabIndex = 5;
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "TenSanPham";
            this.SanPham.HeaderText = "Sản Phẩm";
            this.SanPham.MinimumWidth = 6;
            this.SanPham.Name = "SanPham";
            this.SanPham.Width = 200;
            // 
            // SLuong
            // 
            this.SLuong.DataPropertyName = "SoLuong";
            this.SLuong.HeaderText = "Số Lượng";
            this.SLuong.MinimumWidth = 6;
            this.SLuong.Name = "SLuong";
            this.SLuong.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N0";
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 140;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.HeaderText = "Trả Hàng";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 200;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSanPham";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = false;
            this.MaSP.Width = 125;
            // 
            // KTra
            // 
            this.KTra.DataPropertyName = "KhachTra";
            this.KTra.HeaderText = "KhachTra";
            this.KTra.MinimumWidth = 6;
            this.KTra.Name = "KTra";
            this.KTra.Visible = false;
            this.KTra.Width = 125;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbKhachHang.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.Red;
            this.lbKhachHang.Location = new System.Drawing.Point(130, 22);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(548, 73);
            this.lbKhachHang.TabIndex = 6;
            this.lbKhachHang.Text = "Khách Hàng";
            this.lbKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaPhieu.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.ForeColor = System.Drawing.Color.Red;
            this.lbMaPhieu.Location = new System.Drawing.Point(14, 114);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(281, 47);
            this.lbMaPhieu.TabIndex = 6;
            this.lbMaPhieu.Text = "Mã Phiếu";
            this.lbMaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayGD
            // 
            this.lbNgayGD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgayGD.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGD.ForeColor = System.Drawing.Color.Red;
            this.lbNgayGD.Location = new System.Drawing.Point(513, 114);
            this.lbNgayGD.Name = "lbNgayGD";
            this.lbNgayGD.Size = new System.Drawing.Size(281, 47);
            this.lbNgayGD.TabIndex = 6;
            this.lbNgayGD.Text = "Ngày Giao Dịch";
            this.lbNgayGD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTongGia
            // 
            this.lbTongGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongGia.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongGia.ForeColor = System.Drawing.Color.Black;
            this.lbTongGia.Location = new System.Drawing.Point(354, 579);
            this.lbTongGia.Name = "lbTongGia";
            this.lbTongGia.Size = new System.Drawing.Size(210, 47);
            this.lbTongGia.TabIndex = 6;
            this.lbTongGia.Text = "Tổng Đơn Hàng: ";
            this.lbTongGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKhachTra
            // 
            this.lbKhachTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbKhachTra.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachTra.ForeColor = System.Drawing.Color.Black;
            this.lbKhachTra.Location = new System.Drawing.Point(354, 517);
            this.lbKhachTra.Name = "lbKhachTra";
            this.lbKhachTra.Size = new System.Drawing.Size(210, 47);
            this.lbKhachTra.TabIndex = 6;
            this.lbKhachTra.Text = "Khách Trả: ";
            this.lbKhachTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btHuyBo
            // 
            this.btHuyBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btHuyBo.BackColor = System.Drawing.Color.Pink;
            this.btHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyBo.Image = global::Project.Properties.Resources.cancel1;
            this.btHuyBo.Location = new System.Drawing.Point(200, 638);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(168, 62);
            this.btHuyBo.TabIndex = 7;
            this.btHuyBo.Text = "Hủy Bỏ";
            this.btHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuyBo.UseVisualStyleBackColor = false;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // btCapNhatDonHang
            // 
            this.btCapNhatDonHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCapNhatDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btCapNhatDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatDonHang.Image = global::Project.Properties.Resources.icon_update;
            this.btCapNhatDonHang.Location = new System.Drawing.Point(437, 638);
            this.btCapNhatDonHang.Name = "btCapNhatDonHang";
            this.btCapNhatDonHang.Size = new System.Drawing.Size(168, 62);
            this.btCapNhatDonHang.TabIndex = 8;
            this.btCapNhatDonHang.Text = "Cập Nhật";
            this.btCapNhatDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCapNhatDonHang.UseVisualStyleBackColor = false;
            this.btCapNhatDonHang.Click += new System.EventHandler(this.btCapNhatDonHang_Click);
            // 
            // lbNo
            // 
            this.lbNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNo.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.ForeColor = System.Drawing.Color.Black;
            this.lbNo.Location = new System.Drawing.Point(14, 579);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(160, 47);
            this.lbNo.TabIndex = 6;
            this.lbNo.Text = "Nợ: ";
            this.lbNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbThanhToan
            // 
            this.tbThanhToan.Location = new System.Drawing.Point(167, 526);
            this.tbThanhToan.Name = "tbThanhToan";
            this.tbThanhToan.Size = new System.Drawing.Size(181, 30);
            this.tbThanhToan.TabIndex = 9;
            this.tbThanhToan.Leave += new System.EventHandler(this.tbThanhToan_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thanh toán:";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(167, 588);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(181, 30);
            this.tbNo.TabIndex = 9;
            // 
            // tbKhachTra
            // 
            this.tbKhachTra.Location = new System.Drawing.Point(570, 531);
            this.tbKhachTra.Name = "tbKhachTra";
            this.tbKhachTra.ReadOnly = true;
            this.tbKhachTra.Size = new System.Drawing.Size(193, 30);
            this.tbKhachTra.TabIndex = 9;
            // 
            // tbTongDonHang
            // 
            this.tbTongDonHang.Location = new System.Drawing.Point(570, 593);
            this.tbTongDonHang.Name = "tbTongDonHang";
            this.tbTongDonHang.ReadOnly = true;
            this.tbTongDonHang.Size = new System.Drawing.Size(193, 30);
            this.tbTongDonHang.TabIndex = 9;
            // 
            // frmXuLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTongDonHang);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.tbKhachTra);
            this.Controls.Add(this.tbThanhToan);
            this.Controls.Add(this.btHuyBo);
            this.Controls.Add(this.btCapNhatDonHang);
            this.Controls.Add(this.lbNgayGD);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.lbKhachTra);
            this.Controls.Add(this.lbTongGia);
            this.Controls.Add(this.lbMaPhieu);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmXuLyDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.frmXuLyDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Label lbNgayGD;
        private System.Windows.Forms.Button btHuyBo;
        private System.Windows.Forms.Button btCapNhatDonHang;
        private System.Windows.Forms.Label lbTongGia;
        private System.Windows.Forms.Label lbKhachTra;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.TextBox tbThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbKhachTra;
        private System.Windows.Forms.TextBox tbTongDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTra;
    }
}
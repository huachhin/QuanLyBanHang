
namespace Project
{
    partial class frmGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btKho = new System.Windows.Forms.Button();
            this.btTaiChinh = new System.Windows.Forms.Button();
            this.btNhaCC = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btMatHang = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btCuaHang = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 130);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Project.Properties.Resources.cancel1;
            this.pictureBox2.Location = new System.Drawing.Point(1094, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.bussines;
            this.pictureBox1.Location = new System.Drawing.Point(100, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 619);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(207)))), ((int)(((byte)(233)))));
            this.panel4.Controls.Add(this.btKho);
            this.panel4.Controls.Add(this.btTaiChinh);
            this.panel4.Controls.Add(this.btNhaCC);
            this.panel4.Controls.Add(this.btHoaDon);
            this.panel4.Controls.Add(this.btMatHang);
            this.panel4.Controls.Add(this.btKhachHang);
            this.panel4.Controls.Add(this.btCuaHang);
            this.panel4.Controls.Add(this.btNhanVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 619);
            this.panel4.TabIndex = 1;
            // 
            // btKho
            // 
            this.btKho.BackColor = System.Drawing.Color.White;
            this.btKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKho.Image = global::Project.Properties.Resources.warehouse;
            this.btKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKho.Location = new System.Drawing.Point(12, 452);
            this.btKho.Name = "btKho";
            this.btKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btKho.Size = new System.Drawing.Size(232, 55);
            this.btKho.TabIndex = 0;
            this.btKho.Text = "Kho";
            this.btKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKho.UseVisualStyleBackColor = false;
            this.btKho.Click += new System.EventHandler(this.btKho_Click);
            // 
            // btTaiChinh
            // 
            this.btTaiChinh.BackColor = System.Drawing.Color.White;
            this.btTaiChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiChinh.Image = global::Project.Properties.Resources.profit;
            this.btTaiChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiChinh.Location = new System.Drawing.Point(12, 208);
            this.btTaiChinh.Name = "btTaiChinh";
            this.btTaiChinh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTaiChinh.Size = new System.Drawing.Size(232, 55);
            this.btTaiChinh.TabIndex = 0;
            this.btTaiChinh.Text = "Tài Chính";
            this.btTaiChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiChinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaiChinh.UseVisualStyleBackColor = false;
            this.btTaiChinh.Click += new System.EventHandler(this.btTaiChinh_Click);
            // 
            // btNhaCC
            // 
            this.btNhaCC.BackColor = System.Drawing.Color.White;
            this.btNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhaCC.Image = global::Project.Properties.Resources.provider;
            this.btNhaCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhaCC.Location = new System.Drawing.Point(12, 391);
            this.btNhaCC.Name = "btNhaCC";
            this.btNhaCC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btNhaCC.Size = new System.Drawing.Size(232, 55);
            this.btNhaCC.TabIndex = 0;
            this.btNhaCC.Text = "N.Cung Cấp";
            this.btNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhaCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNhaCC.UseVisualStyleBackColor = false;
            this.btNhaCC.Click += new System.EventHandler(this.btNhaCC_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.Color.White;
            this.btHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDon.Image = global::Project.Properties.Resources.bill1;
            this.btHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHoaDon.Location = new System.Drawing.Point(12, 147);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btHoaDon.Size = new System.Drawing.Size(232, 55);
            this.btHoaDon.TabIndex = 0;
            this.btHoaDon.Text = "Hóa Đơn";
            this.btHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHoaDon.UseVisualStyleBackColor = false;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btMatHang
            // 
            this.btMatHang.BackColor = System.Drawing.Color.White;
            this.btMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatHang.Image = global::Project.Properties.Resources.product;
            this.btMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMatHang.Location = new System.Drawing.Point(12, 330);
            this.btMatHang.Name = "btMatHang";
            this.btMatHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btMatHang.Size = new System.Drawing.Size(232, 55);
            this.btMatHang.TabIndex = 0;
            this.btMatHang.Text = "Mặt Hàng";
            this.btMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMatHang.UseVisualStyleBackColor = false;
            this.btMatHang.Click += new System.EventHandler(this.btMatHang_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.White;
            this.btKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.Image = global::Project.Properties.Resources.kh1;
            this.btKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKhachHang.Location = new System.Drawing.Point(12, 86);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btKhachHang.Size = new System.Drawing.Size(232, 55);
            this.btKhachHang.TabIndex = 0;
            this.btKhachHang.Text = "Khách Hàng";
            this.btKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btCuaHang
            // 
            this.btCuaHang.BackColor = System.Drawing.Color.White;
            this.btCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCuaHang.Image = global::Project.Properties.Resources.store;
            this.btCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCuaHang.Location = new System.Drawing.Point(12, 269);
            this.btCuaHang.Name = "btCuaHang";
            this.btCuaHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btCuaHang.Size = new System.Drawing.Size(232, 55);
            this.btCuaHang.TabIndex = 0;
            this.btCuaHang.Text = "Cửa Hàng";
            this.btCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCuaHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCuaHang.UseVisualStyleBackColor = false;
            this.btCuaHang.Click += new System.EventHandler(this.btCuaHang_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.White;
            this.btNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btNhanVien.Image")));
            this.btNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanVien.Location = new System.Drawing.Point(12, 25);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btNhanVien.Size = new System.Drawing.Size(232, 55);
            this.btNhanVien.TabIndex = 0;
            this.btNhanVien.Text = "Nhân Viên";
            this.btNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNhanVien.UseVisualStyleBackColor = false;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHienThi.Location = new System.Drawing.Point(259, 130);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(868, 619);
            this.pnlHienThi.TabIndex = 2;
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 749);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btTaiChinh;
        private System.Windows.Forms.Button btKho;
        private System.Windows.Forms.Button btNhaCC;
        private System.Windows.Forms.Button btMatHang;
        private System.Windows.Forms.Button btCuaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHienThi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


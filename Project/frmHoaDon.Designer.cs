
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXuLy = new System.Windows.Forms.Button();
            this.btInHoaDon = new System.Windows.Forms.Button();
            this.txtSearchHoaDon = new System.Windows.Forms.TextBox();
            this.MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachTraHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtGridViewHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 606);
            this.panel2.TabIndex = 5;
            // 
            // dtGridViewHoaDon
            // 
            this.dtGridViewHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MP,
            this.ThoiGian,
            this.MaKhachHang,
            this.KhachHang,
            this.KhachTraHD,
            this.No});
            this.dtGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewHoaDon.Name = "dtGridViewHoaDon";
            this.dtGridViewHoaDon.RowHeadersWidth = 51;
            this.dtGridViewHoaDon.RowTemplate.Height = 24;
            this.dtGridViewHoaDon.Size = new System.Drawing.Size(1297, 606);
            this.dtGridViewHoaDon.TabIndex = 4;
            this.dtGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewHoaDon_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXuLy);
            this.panel1.Controls.Add(this.btInHoaDon);
            this.panel1.Controls.Add(this.txtSearchHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 78);
            this.panel1.TabIndex = 4;
            // 
            // btXuLy
            // 
            this.btXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btXuLy.Image = global::Project.Properties.Resources.icons8_online_payment_32px;
            this.btXuLy.Location = new System.Drawing.Point(809, 6);
            this.btXuLy.Name = "btXuLy";
            this.btXuLy.Size = new System.Drawing.Size(193, 66);
            this.btXuLy.TabIndex = 1;
            this.btXuLy.Text = "Xử lý đơn hàng";
            this.btXuLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXuLy.UseVisualStyleBackColor = false;
            this.btXuLy.Click += new System.EventHandler(this.btXuLy_Click);
            // 
            // btInHoaDon
            // 
            this.btInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btInHoaDon.Image = global::Project.Properties.Resources.icons8_print_48px_1;
            this.btInHoaDon.Location = new System.Drawing.Point(1022, 6);
            this.btInHoaDon.Name = "btInHoaDon";
            this.btInHoaDon.Size = new System.Drawing.Size(193, 66);
            this.btInHoaDon.TabIndex = 1;
            this.btInHoaDon.Text = " In Hóa Đơn";
            this.btInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInHoaDon.UseVisualStyleBackColor = false;
            this.btInHoaDon.Click += new System.EventHandler(this.btInHoaDon_Click);
            // 
            // txtSearchHoaDon
            // 
            this.txtSearchHoaDon.BackColor = System.Drawing.Color.White;
            this.txtSearchHoaDon.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchHoaDon.Location = new System.Drawing.Point(67, 24);
            this.txtSearchHoaDon.Name = "txtSearchHoaDon";
            this.txtSearchHoaDon.Size = new System.Drawing.Size(564, 30);
            this.txtSearchHoaDon.TabIndex = 0;
            this.txtSearchHoaDon.Text = "Search";
            this.txtSearchHoaDon.TextChanged += new System.EventHandler(this.txtSearchHoaDon_TextChanged);
            this.txtSearchHoaDon.Enter += new System.EventHandler(this.txtSearchHoaDon_Enter);
            this.txtSearchHoaDon.Leave += new System.EventHandler(this.txtSearchHoaDon_Leave);
            // 
            // MP
            // 
            this.MP.DataPropertyName = "MaPhieu";
            this.MP.HeaderText = "Mã Phiếu";
            this.MP.MinimumWidth = 6;
            this.MP.Name = "MP";
            this.MP.Width = 200;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "NgayGiaoDich";
            this.ThoiGian.HeaderText = "Ngày Giao Dịch";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 200;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Visible = false;
            this.MaKhachHang.Width = 125;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "TenKhachHang";
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Width = 200;
            // 
            // KhachTraHD
            // 
            this.KhachTraHD.DataPropertyName = "KhachTra";
            dataGridViewCellStyle1.Format = "N0";
            this.KhachTraHD.DefaultCellStyle = dataGridViewCellStyle1;
            this.KhachTraHD.HeaderText = "Khách Trả";
            this.KhachTraHD.MinimumWidth = 6;
            this.KhachTraHD.Name = "KhachTraHD";
            this.KhachTraHD.Width = 200;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "Nợ";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 125;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtGridViewHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXuLy;
        private System.Windows.Forms.Button btInHoaDon;
        private System.Windows.Forms.TextBox txtSearchHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachTraHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
    }
}
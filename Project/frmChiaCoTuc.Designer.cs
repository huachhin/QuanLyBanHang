
namespace Project
{
    partial class frmChiaCoTuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbLoiNhuan = new System.Windows.Forms.TextBox();
            this.tbDoanhThu = new System.Windows.Forms.TextBox();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.lbLoiNhuan = new System.Windows.Forms.Label();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.dataGridViewCoDong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCoTuc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPE = new System.Windows.Forms.TextBox();
            this.lbPE = new System.Windows.Forms.Label();
            this.MaNguoiGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refund = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoTuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLoiNhuan
            // 
            this.tbLoiNhuan.Location = new System.Drawing.Point(354, 181);
            this.tbLoiNhuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoiNhuan.Name = "tbLoiNhuan";
            this.tbLoiNhuan.ReadOnly = true;
            this.tbLoiNhuan.Size = new System.Drawing.Size(250, 26);
            this.tbLoiNhuan.TabIndex = 12;
            // 
            // tbDoanhThu
            // 
            this.tbDoanhThu.Location = new System.Drawing.Point(354, 113);
            this.tbDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.tbDoanhThu.Name = "tbDoanhThu";
            this.tbDoanhThu.ReadOnly = true;
            this.tbDoanhThu.Size = new System.Drawing.Size(250, 26);
            this.tbDoanhThu.TabIndex = 13;
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(45, 94);
            this.lbTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(279, 59);
            this.lbTongDoanhThu.TabIndex = 10;
            this.lbTongDoanhThu.Text = "Tổng Doanh Thu:";
            this.lbTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoiNhuan
            // 
            this.lbLoiNhuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoiNhuan.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoiNhuan.ForeColor = System.Drawing.Color.Black;
            this.lbLoiNhuan.Location = new System.Drawing.Point(45, 164);
            this.lbLoiNhuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoiNhuan.Name = "lbLoiNhuan";
            this.lbLoiNhuan.Size = new System.Drawing.Size(262, 59);
            this.lbLoiNhuan.TabIndex = 11;
            this.lbLoiNhuan.Text = "Lợi Nhuận:";
            this.lbLoiNhuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDoanhThu.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lbDoanhThu.Location = new System.Drawing.Point(186, 10);
            this.lbDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(685, 91);
            this.lbDoanhThu.TabIndex = 14;
            this.lbDoanhThu.Text = "Doanh Thu";
            this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCoDong
            // 
            this.dataGridViewCoDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewCoDong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dataGridViewCoDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguoiGop,
            this.TenNguoiGop,
            this.Von,
            this.Payment});
            this.dataGridViewCoDong.Location = new System.Drawing.Point(150, 228);
            this.dataGridViewCoDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCoDong.Name = "dataGridViewCoDong";
            this.dataGridViewCoDong.RowHeadersWidth = 51;
            this.dataGridViewCoDong.RowTemplate.Height = 24;
            this.dataGridViewCoDong.Size = new System.Drawing.Size(766, 286);
            this.dataGridViewCoDong.TabIndex = 15;
            this.dataGridViewCoDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoDong_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 188);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cổ Đông";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCoTuc
            // 
            this.dataGridViewCoTuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewCoTuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dataGridViewCoTuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoTuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNG,
            this.TenNG,
            this.VonGop,
            this.Refund});
            this.dataGridViewCoTuc.Location = new System.Drawing.Point(150, 547);
            this.dataGridViewCoTuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCoTuc.Name = "dataGridViewCoTuc";
            this.dataGridViewCoTuc.RowHeadersWidth = 51;
            this.dataGridViewCoTuc.RowTemplate.Height = 24;
            this.dataGridViewCoTuc.Size = new System.Drawing.Size(766, 286);
            this.dataGridViewCoTuc.TabIndex = 15;
            this.dataGridViewCoTuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoTuc_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 595);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 188);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cổ Tức";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPE
            // 
            this.tbPE.Location = new System.Drawing.Point(678, 181);
            this.tbPE.Margin = new System.Windows.Forms.Padding(4);
            this.tbPE.Name = "tbPE";
            this.tbPE.Size = new System.Drawing.Size(279, 26);
            this.tbPE.TabIndex = 18;
            this.tbPE.Leave += new System.EventHandler(this.tbPE_Leave);
            // 
            // lbPE
            // 
            this.lbPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPE.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPE.ForeColor = System.Drawing.Color.Black;
            this.lbPE.Location = new System.Drawing.Point(678, 101);
            this.lbPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPE.Name = "lbPE";
            this.lbPE.Size = new System.Drawing.Size(279, 59);
            this.lbPE.TabIndex = 17;
            this.lbPE.Text = "Price To Earn:";
            this.lbPE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaNguoiGop
            // 
            this.MaNguoiGop.DataPropertyName = "MaNguoiGop";
            this.MaNguoiGop.HeaderText = "Mã Người Góp";
            this.MaNguoiGop.MinimumWidth = 6;
            this.MaNguoiGop.Name = "MaNguoiGop";
            this.MaNguoiGop.Width = 200;
            // 
            // TenNguoiGop
            // 
            this.TenNguoiGop.DataPropertyName = "TenNguoiGop";
            this.TenNguoiGop.HeaderText = "Tên Người Góp";
            this.TenNguoiGop.MinimumWidth = 6;
            this.TenNguoiGop.Name = "TenNguoiGop";
            this.TenNguoiGop.Width = 200;
            // 
            // Von
            // 
            this.Von.DataPropertyName = "Von";
            this.Von.HeaderText = "Vốn";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            this.Von.Width = 125;
            // 
            // Payment
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Payment.DefaultCellStyle = dataGridViewCellStyle3;
            this.Payment.HeaderText = "";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.Text = "Payment";
            this.Payment.UseColumnTextForButtonValue = true;
            this.Payment.Width = 125;
            // 
            // MaNG
            // 
            this.MaNG.DataPropertyName = "MaNguoiGop";
            this.MaNG.HeaderText = "Mã Người Góp";
            this.MaNG.MinimumWidth = 6;
            this.MaNG.Name = "MaNG";
            this.MaNG.Width = 200;
            // 
            // TenNG
            // 
            this.TenNG.DataPropertyName = "TenNguoiGop";
            this.TenNG.HeaderText = "Tên Người Góp";
            this.TenNG.MinimumWidth = 6;
            this.TenNG.Name = "TenNG";
            this.TenNG.Width = 200;
            // 
            // VonGop
            // 
            this.VonGop.DataPropertyName = "Von";
            this.VonGop.HeaderText = "Vốn";
            this.VonGop.MinimumWidth = 6;
            this.VonGop.Name = "VonGop";
            this.VonGop.Width = 125;
            // 
            // Refund
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.Refund.DefaultCellStyle = dataGridViewCellStyle4;
            this.Refund.HeaderText = "";
            this.Refund.MinimumWidth = 6;
            this.Refund.Name = "Refund";
            this.Refund.Text = "Refund";
            this.Refund.UseColumnTextForButtonValue = true;
            this.Refund.Width = 125;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(955, 438);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 177);
            this.btCapNhat.TabIndex = 19;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // frmChiaCoTuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 853);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.tbPE);
            this.Controls.Add(this.lbPE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCoTuc);
            this.Controls.Add(this.dataGridViewCoDong);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.tbLoiNhuan);
            this.Controls.Add(this.tbDoanhThu);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.lbLoiNhuan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiaCoTuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lợi nhuận";
            this.Load += new System.EventHandler(this.frmChiaCoTuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoTuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoiNhuan;
        private System.Windows.Forms.TextBox tbDoanhThu;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.Label lbLoiNhuan;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.DataGridView dataGridViewCoDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCoTuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPE;
        private System.Windows.Forms.Label lbPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguoiGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewButtonColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonGop;
        private System.Windows.Forms.DataGridViewButtonColumn Refund;
        private System.Windows.Forms.Button btCapNhat;
    }
}
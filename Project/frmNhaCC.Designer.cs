
namespace Project
{
    partial class frmNhaCC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGridViewNCC = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDatHang = new System.Windows.Forms.Button();
            this.btLienHe = new System.Windows.Forms.Button();
            this.btXoaNCC = new System.Windows.Forms.Button();
            this.btThemNCC = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewNCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtGridViewNCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 597);
            this.panel2.TabIndex = 1;
            // 
            // dtGridViewNCC
            // 
            this.dtGridViewNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewNCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridViewNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNCC,
            this.TenNCC,
            this.Email,
            this.DiaChi,
            this.SDT});
            this.dtGridViewNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewNCC.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewNCC.Name = "dtGridViewNCC";
            this.dtGridViewNCC.RowHeadersWidth = 51;
            this.dtGridViewNCC.RowTemplate.Height = 24;
            this.dtGridViewNCC.Size = new System.Drawing.Size(1084, 597);
            this.dtGridViewNCC.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã Nhà CC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.HeaderText = "Tên Nhà CC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDatHang);
            this.panel1.Controls.Add(this.btLienHe);
            this.panel1.Controls.Add(this.btXoaNCC);
            this.panel1.Controls.Add(this.btThemNCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 680);
            this.panel1.TabIndex = 0;
            // 
            // btDatHang
            // 
            this.btDatHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btDatHang.Image = global::Project.Properties.Resources.icons8_add_shopping_cart_48px_1;
            this.btDatHang.Location = new System.Drawing.Point(92, 600);
            this.btDatHang.Name = "btDatHang";
            this.btDatHang.Size = new System.Drawing.Size(203, 62);
            this.btDatHang.TabIndex = 3;
            this.btDatHang.Text = "   Đặt Hàng";
            this.btDatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDatHang.UseVisualStyleBackColor = false;
            // 
            // btLienHe
            // 
            this.btLienHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLienHe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btLienHe.Image = global::Project.Properties.Resources.icons8_contact_48px_1;
            this.btLienHe.Location = new System.Drawing.Point(321, 600);
            this.btLienHe.Name = "btLienHe";
            this.btLienHe.Size = new System.Drawing.Size(203, 62);
            this.btLienHe.TabIndex = 3;
            this.btLienHe.Text = "   Liên Hệ";
            this.btLienHe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLienHe.UseVisualStyleBackColor = false;
            // 
            // btXoaNCC
            // 
            this.btXoaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoaNCC.BackColor = System.Drawing.Color.Pink;
            this.btXoaNCC.Image = global::Project.Properties.Resources.cancel1;
            this.btXoaNCC.Location = new System.Drawing.Point(781, 600);
            this.btXoaNCC.Name = "btXoaNCC";
            this.btXoaNCC.Size = new System.Drawing.Size(203, 62);
            this.btXoaNCC.TabIndex = 3;
            this.btXoaNCC.Text = "Xóa Nhà CC";
            this.btXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaNCC.UseVisualStyleBackColor = false;
            // 
            // btThemNCC
            // 
            this.btThemNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btThemNCC.Image = global::Project.Properties.Resources.icons8_calendar_plus_48px_1;
            this.btThemNCC.Location = new System.Drawing.Point(549, 600);
            this.btThemNCC.Name = "btThemNCC";
            this.btThemNCC.Size = new System.Drawing.Size(203, 62);
            this.btThemNCC.TabIndex = 3;
            this.btThemNCC.Text = "Thêm Nhà CC";
            this.btThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemNCC.UseVisualStyleBackColor = false;
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhaCC";
            this.Text = "frmNhaCC";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtGridViewNCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btLienHe;
        private System.Windows.Forms.Button btXoaNCC;
        private System.Windows.Forms.Button btThemNCC;
        private System.Windows.Forms.Button btDatHang;
    }
}

namespace Project
{
    partial class frmNhanVien
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
            this.dtGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdNV = new System.Windows.Forms.TextBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hoten = new System.Windows.Forms.Label();
            this.btTimNV = new System.Windows.Forms.Button();
            this.tbHoTenNV = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.label_namsinh = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbNamSinhNV = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.label_sdt = new System.Windows.Forms.Label();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.tbSdtNV = new System.Windows.Forms.TextBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label_gioitinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewNhanVien
            // 
            this.dtGridViewNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtGridViewNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGridViewNhanVien.Location = new System.Drawing.Point(0, 239);
            this.dtGridViewNhanVien.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dtGridViewNhanVien.Name = "dtGridViewNhanVien";
            this.dtGridViewNhanVien.RowHeadersWidth = 62;
            this.dtGridViewNhanVien.RowTemplate.Height = 28;
            this.dtGridViewNhanVien.Size = new System.Drawing.Size(1308, 501);
            this.dtGridViewNhanVien.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Năm sinh";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SDT";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chức vụ";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIdNV);
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_hoten);
            this.groupBox1.Controls.Add(this.btTimNV);
            this.groupBox1.Controls.Add(this.tbHoTenNV);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.label_namsinh);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.tbNamSinhNV);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label_sdt);
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.tbSdtNV);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.label_gioitinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 234);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // tbIdNV
            // 
            this.tbIdNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdNV.Location = new System.Drawing.Point(175, 42);
            this.tbIdNV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbIdNV.Name = "tbIdNV";
            this.tbIdNV.Size = new System.Drawing.Size(308, 26);
            this.tbIdNV.TabIndex = 30;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Nhân viên thu ngân",
            "Nhân viên sale"});
            this.cbChucVu.Location = new System.Drawing.Point(663, 159);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(230, 37);
            this.cbChucVu.TabIndex = 45;
            this.cbChucVu.Text = "Nhân viên bán hàng";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(32, 44);
            this.label_id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 25);
            this.label_id.TabIndex = 29;
            this.label_id.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chức vụ:";
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.Location = new System.Drawing.Point(32, 101);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(83, 25);
            this.label_hoten.TabIndex = 31;
            this.label_hoten.Text = "Họ Tên:";
            // 
            // btTimNV
            // 
            this.btTimNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btTimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimNV.Image = global::Project.Properties.Resources.icon_search;
            this.btTimNV.Location = new System.Drawing.Point(913, 40);
            this.btTimNV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btTimNV.Name = "btTimNV";
            this.btTimNV.Size = new System.Drawing.Size(163, 56);
            this.btTimNV.TabIndex = 43;
            this.btTimNV.Text = "  Tìm";
            this.btTimNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTimNV.UseVisualStyleBackColor = false;
            // 
            // tbHoTenNV
            // 
            this.tbHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTenNV.Location = new System.Drawing.Point(175, 101);
            this.tbHoTenNV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbHoTenNV.Name = "tbHoTenNV";
            this.tbHoTenNV.Size = new System.Drawing.Size(308, 26);
            this.tbHoTenNV.TabIndex = 32;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::Project.Properties.Resources.icon_update;
            this.btSua.Location = new System.Drawing.Point(913, 135);
            this.btSua.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(163, 60);
            this.btSua.TabIndex = 42;
            this.btSua.Text = "  Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // label_namsinh
            // 
            this.label_namsinh.AutoSize = true;
            this.label_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namsinh.Location = new System.Drawing.Point(32, 159);
            this.label_namsinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_namsinh.Name = "label_namsinh";
            this.label_namsinh.Size = new System.Drawing.Size(100, 25);
            this.label_namsinh.TabIndex = 33;
            this.label_namsinh.Text = "Năm sinh:";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::Project.Properties.Resources.icon_delete;
            this.btXoa.Location = new System.Drawing.Point(1109, 135);
            this.btXoa.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(163, 60);
            this.btXoa.TabIndex = 41;
            this.btXoa.Text = "  Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // tbNamSinhNV
            // 
            this.tbNamSinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamSinhNV.Location = new System.Drawing.Point(175, 160);
            this.tbNamSinhNV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbNamSinhNV.Name = "tbNamSinhNV";
            this.tbNamSinhNV.Size = new System.Drawing.Size(308, 26);
            this.tbNamSinhNV.TabIndex = 34;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::Project.Properties.Resources.icon_plus;
            this.btThem.Location = new System.Drawing.Point(1109, 40);
            this.btThem.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(163, 60);
            this.btThem.TabIndex = 40;
            this.btThem.Text = "  Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdt.Location = new System.Drawing.Point(520, 46);
            this.label_sdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(59, 25);
            this.label_sdt.TabIndex = 35;
            this.label_sdt.Text = "SĐT:";
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNu.Location = new System.Drawing.Point(809, 100);
            this.radioNu.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(58, 29);
            this.radioNu.TabIndex = 39;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // tbSdtNV
            // 
            this.tbSdtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdtNV.Location = new System.Drawing.Point(663, 44);
            this.tbSdtNV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbSdtNV.Name = "tbSdtNV";
            this.tbSdtNV.Size = new System.Drawing.Size(230, 26);
            this.tbSdtNV.TabIndex = 36;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNam.Location = new System.Drawing.Point(663, 100);
            this.radioNam.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(74, 29);
            this.radioNam.TabIndex = 38;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioitinh.Location = new System.Drawing.Point(520, 102);
            this.label_gioitinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(88, 25);
            this.label_gioitinh.TabIndex = 37;
            this.label_gioitinh.Text = "Giới tính:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridViewNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdNV;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Button btTimNV;
        private System.Windows.Forms.TextBox tbHoTenNV;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label_namsinh;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbNamSinhNV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.TextBox tbSdtNV;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label_gioitinh;
    }
}
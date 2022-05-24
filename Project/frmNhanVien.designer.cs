
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
            this.dtGridView_Nhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label_sdt = new System.Windows.Forms.Label();
            this.label_namsinh = new System.Windows.Forms.Label();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.groupBox_thtinKhachhang = new System.Windows.Forms.GroupBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.comboBox_gioiTinh = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtSearch_nhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Nhanvien)).BeginInit();
            this.groupBox_thtinKhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView_Nhanvien
            // 
            this.dtGridView_Nhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.dtGridView_Nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.SDT,
            this.GioiTinh,
            this.Email});
            this.dtGridView_Nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGridView_Nhanvien.Location = new System.Drawing.Point(0, 242);
            this.dtGridView_Nhanvien.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dtGridView_Nhanvien.Name = "dtGridView_Nhanvien";
            this.dtGridView_Nhanvien.RowHeadersWidth = 62;
            this.dtGridView_Nhanvien.RowTemplate.Height = 28;
            this.dtGridView_Nhanvien.Size = new System.Drawing.Size(1308, 498);
            this.dtGridView_Nhanvien.TabIndex = 33;
            this.dtGridView_Nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_Nhanvien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioitinh.Location = new System.Drawing.Point(520, 59);
            this.label_gioitinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(88, 25);
            this.label_gioitinh.TabIndex = 37;
            this.label_gioitinh.Text = "Giới tính:";
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(663, 16);
            this.textBox_sdt.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(230, 30);
            this.textBox_sdt.TabIndex = 36;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox_sdt_TextChanged);
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdt.Location = new System.Drawing.Point(520, 18);
            this.label_sdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(59, 25);
            this.label_sdt.TabIndex = 35;
            this.label_sdt.Text = "SĐT:";
            // 
            // label_namsinh
            // 
            this.label_namsinh.AutoSize = true;
            this.label_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namsinh.Location = new System.Drawing.Point(32, 131);
            this.label_namsinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_namsinh.Name = "label_namsinh";
            this.label_namsinh.Size = new System.Drawing.Size(105, 25);
            this.label_namsinh.TabIndex = 33;
            this.label_namsinh.Text = "Ngày sinh:";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoten.Location = new System.Drawing.Point(175, 86);
            this.textBox_hoten.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(308, 30);
            this.textBox_hoten.TabIndex = 32;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.Location = new System.Drawing.Point(32, 86);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(83, 25);
            this.label_hoten.TabIndex = 31;
            this.label_hoten.Text = "Họ Tên:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(520, 152);
            this.label_email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(66, 25);
            this.label_email.TabIndex = 44;
            this.label_email.Text = "Email:";
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
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(175, 42);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(308, 30);
            this.textBox_id.TabIndex = 30;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(663, 148);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(230, 30);
            this.textBox_email.TabIndex = 45;
            // 
            // groupBox_thtinKhachhang
            // 
            this.groupBox_thtinKhachhang.BackColor = System.Drawing.Color.White;
            this.groupBox_thtinKhachhang.Controls.Add(this.label_diachi);
            this.groupBox_thtinKhachhang.Controls.Add(this.textBox_diaChi);
            this.groupBox_thtinKhachhang.Controls.Add(this.comboBox_gioiTinh);
            this.groupBox_thtinKhachhang.Controls.Add(this.dateTimePicker_ngaySinh);
            this.groupBox_thtinKhachhang.Controls.Add(this.textBox_email);
            this.groupBox_thtinKhachhang.Controls.Add(this.textBox_id);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_id);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_email);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_hoten);
            this.groupBox_thtinKhachhang.Controls.Add(this.textBox_hoten);
            this.groupBox_thtinKhachhang.Controls.Add(this.btn_sua);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_namsinh);
            this.groupBox_thtinKhachhang.Controls.Add(this.btn_xoa);
            this.groupBox_thtinKhachhang.Controls.Add(this.btn_them);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_sdt);
            this.groupBox_thtinKhachhang.Controls.Add(this.textBox_sdt);
            this.groupBox_thtinKhachhang.Controls.Add(this.label_gioitinh);
            this.groupBox_thtinKhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_thtinKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_thtinKhachhang.Location = new System.Drawing.Point(0, 59);
            this.groupBox_thtinKhachhang.Name = "groupBox_thtinKhachhang";
            this.groupBox_thtinKhachhang.Size = new System.Drawing.Size(1308, 183);
            this.groupBox_thtinKhachhang.TabIndex = 35;
            this.groupBox_thtinKhachhang.TabStop = false;
            this.groupBox_thtinKhachhang.Text = "Thông tin nhân viên";
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diachi.Location = new System.Drawing.Point(520, 108);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(77, 25);
            this.label_diachi.TabIndex = 54;
            this.label_diachi.Text = "Địa chỉ:";
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diaChi.Location = new System.Drawing.Point(663, 106);
            this.textBox_diaChi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.Size = new System.Drawing.Size(230, 30);
            this.textBox_diaChi.TabIndex = 55;
            // 
            // comboBox_gioiTinh
            // 
            this.comboBox_gioiTinh.DisplayMember = "Nam";
            this.comboBox_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gioiTinh.FormattingEnabled = true;
            this.comboBox_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioiTinh.Location = new System.Drawing.Point(663, 58);
            this.comboBox_gioiTinh.Name = "comboBox_gioiTinh";
            this.comboBox_gioiTinh.Size = new System.Drawing.Size(230, 33);
            this.comboBox_gioiTinh.TabIndex = 53;
            this.comboBox_gioiTinh.Text = "Nam";
            // 
            // dateTimePicker_ngaySinh
            // 
            this.dateTimePicker_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaySinh.Location = new System.Drawing.Point(175, 128);
            this.dateTimePicker_ngaySinh.Name = "dateTimePicker_ngaySinh";
            this.dateTimePicker_ngaySinh.Size = new System.Drawing.Size(308, 30);
            this.dateTimePicker_ngaySinh.TabIndex = 52;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::Project.Properties.Resources.icon_update;
            this.btn_sua.Location = new System.Drawing.Point(993, 68);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(152, 45);
            this.btn_sua.TabIndex = 42;
            this.btn_sua.Text = "  Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::Project.Properties.Resources.icon_delete;
            this.btn_xoa.Location = new System.Drawing.Point(993, 121);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(152, 45);
            this.btn_xoa.TabIndex = 41;
            this.btn_xoa.Text = "  Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::Project.Properties.Resources.icon_plus;
            this.btn_them.Location = new System.Drawing.Point(993, 16);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(152, 45);
            this.btn_them.TabIndex = 40;
            this.btn_them.Text = "  Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txtSearch_nhanVien
            // 
            this.txtSearch_nhanVien.BackColor = System.Drawing.Color.White;
            this.txtSearch_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_nhanVien.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch_nhanVien.Location = new System.Drawing.Point(175, 15);
            this.txtSearch_nhanVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSearch_nhanVien.Multiline = true;
            this.txtSearch_nhanVien.Name = "txtSearch_nhanVien";
            this.txtSearch_nhanVien.Size = new System.Drawing.Size(490, 30);
            this.txtSearch_nhanVien.TabIndex = 52;
            this.txtSearch_nhanVien.Text = "Search";
            this.txtSearch_nhanVien.TextChanged += new System.EventHandler(this.txtSearch_nhanVien_TextChanged);
            this.txtSearch_nhanVien.Enter += new System.EventHandler(this.txtSearch_nhanVien_Enter);
            this.txtSearch_nhanVien.Leave += new System.EventHandler(this.txtSearch_nhanVien_Leave);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1308, 740);
            this.Controls.Add(this.txtSearch_nhanVien);
            this.Controls.Add(this.groupBox_thtinKhachhang);
            this.Controls.Add(this.dtGridView_Nhanvien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Nhanvien)).EndInit();
            this.groupBox_thtinKhachhang.ResumeLayout(false);
            this.groupBox_thtinKhachhang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridView_Nhanvien;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label_namsinh;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.GroupBox groupBox_thtinKhachhang;
        private System.Windows.Forms.TextBox txtSearch_nhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaySinh;
        private System.Windows.Forms.ComboBox comboBox_gioiTinh;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}
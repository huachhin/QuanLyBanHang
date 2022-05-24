
namespace Project
{
    partial class frmThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.btn_huyBo = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.groupBox_thanhToan = new System.Windows.Forms.GroupBox();
            this.comboBox_trangThai = new System.Windows.Forms.ComboBox();
            this.comboBox_phuongThuc = new System.Windows.Forms.ComboBox();
            this.comboBox_No = new System.Windows.Forms.ComboBox();
            this.comboBox_tenKhachHang = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_NguoiTao = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_ngayGiaodich = new System.Windows.Forms.DateTimePicker();
            this.label_No = new System.Windows.Forms.Label();
            this.label_trangThai = new System.Windows.Forms.Label();
            this.label_phuongThuc = new System.Windows.Forms.Label();
            this.label_khachTra = new System.Windows.Forms.Label();
            this.label_ngayGiaoDich = new System.Windows.Forms.Label();
            this.label_Nguoitao = new System.Windows.Forms.Label();
            this.label_KhachHang = new System.Windows.Forms.Label();
            this.textBox_khachTra = new System.Windows.Forms.TextBox();
            this.txtbox_maPhieu = new System.Windows.Forms.TextBox();
            this.label_maPhieu = new System.Windows.Forms.Label();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet1 = new Project.QLBHDataSet();
            this.khachHangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new Project.QLBHDataSetTableAdapters.KhachHangTableAdapter();
            this.khachHangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter1 = new Project.QLBHDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_thanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_huyBo
            // 
            this.btn_huyBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_huyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btn_huyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huyBo.Location = new System.Drawing.Point(318, 502);
            this.btn_huyBo.Name = "btn_huyBo";
            this.btn_huyBo.Size = new System.Drawing.Size(227, 62);
            this.btn_huyBo.TabIndex = 42;
            this.btn_huyBo.Text = "Hủy bỏ";
            this.btn_huyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_huyBo.UseVisualStyleBackColor = false;
            this.btn_huyBo.Click += new System.EventHandler(this.btn_huyBo_Click);
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btn_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.Image = global::Project.Properties.Resources.icons8_online_payment_32px;
            this.btn_thanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhToan.Location = new System.Drawing.Point(12, 502);
            this.btn_thanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_thanhToan.Size = new System.Drawing.Size(237, 62);
            this.btn_thanhToan.TabIndex = 44;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // groupBox_thanhToan
            // 
            this.groupBox_thanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_thanhToan.Controls.Add(this.comboBox_trangThai);
            this.groupBox_thanhToan.Controls.Add(this.comboBox_phuongThuc);
            this.groupBox_thanhToan.Controls.Add(this.comboBox_No);
            this.groupBox_thanhToan.Controls.Add(this.comboBox_tenKhachHang);
            this.groupBox_thanhToan.Controls.Add(this.comboBox_NguoiTao);
            this.groupBox_thanhToan.Controls.Add(this.dateTimePicker_ngayGiaodich);
            this.groupBox_thanhToan.Controls.Add(this.label_No);
            this.groupBox_thanhToan.Controls.Add(this.label_trangThai);
            this.groupBox_thanhToan.Controls.Add(this.label_phuongThuc);
            this.groupBox_thanhToan.Controls.Add(this.label_khachTra);
            this.groupBox_thanhToan.Controls.Add(this.label_ngayGiaoDich);
            this.groupBox_thanhToan.Controls.Add(this.label_Nguoitao);
            this.groupBox_thanhToan.Controls.Add(this.label_KhachHang);
            this.groupBox_thanhToan.Controls.Add(this.textBox_khachTra);
            this.groupBox_thanhToan.Controls.Add(this.txtbox_maPhieu);
            this.groupBox_thanhToan.Controls.Add(this.label_maPhieu);
            this.groupBox_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_thanhToan.ForeColor = System.Drawing.Color.Red;
            this.groupBox_thanhToan.Location = new System.Drawing.Point(12, 12);
            this.groupBox_thanhToan.Name = "groupBox_thanhToan";
            this.groupBox_thanhToan.Size = new System.Drawing.Size(556, 462);
            this.groupBox_thanhToan.TabIndex = 61;
            this.groupBox_thanhToan.TabStop = false;
            this.groupBox_thanhToan.Text = "Thanh Toán";
            // 
            // comboBox_trangThai
            // 
            this.comboBox_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_trangThai.FormattingEnabled = true;
            this.comboBox_trangThai.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.comboBox_trangThai.Location = new System.Drawing.Point(240, 364);
            this.comboBox_trangThai.Name = "comboBox_trangThai";
            this.comboBox_trangThai.Size = new System.Drawing.Size(293, 33);
            this.comboBox_trangThai.TabIndex = 84;
            this.comboBox_trangThai.Text = "Hoàn thành";
            // 
            // comboBox_phuongThuc
            // 
            this.comboBox_phuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_phuongThuc.FormattingEnabled = true;
            this.comboBox_phuongThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ tín dụng"});
            this.comboBox_phuongThuc.Location = new System.Drawing.Point(240, 314);
            this.comboBox_phuongThuc.Name = "comboBox_phuongThuc";
            this.comboBox_phuongThuc.Size = new System.Drawing.Size(293, 33);
            this.comboBox_phuongThuc.TabIndex = 83;
            this.comboBox_phuongThuc.Text = "Tiền mặt";
            // 
            // comboBox_No
            // 
            this.comboBox_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_No.FormattingEnabled = true;
            this.comboBox_No.Items.AddRange(new object[] {
            "Nợ ",
            "Không"});
            this.comboBox_No.Location = new System.Drawing.Point(240, 419);
            this.comboBox_No.Name = "comboBox_No";
            this.comboBox_No.Size = new System.Drawing.Size(293, 33);
            this.comboBox_No.TabIndex = 82;
            this.comboBox_No.Text = "Nợ ";
            // 
            // comboBox_tenKhachHang
            // 
            this.comboBox_tenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource3, "TenKhachHang", true));
            this.comboBox_tenKhachHang.DataSource = this.khachHangBindingSource2;
            this.comboBox_tenKhachHang.DisplayMember = "TenKhachHang";
            this.comboBox_tenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tenKhachHang.FormattingEnabled = true;
            this.comboBox_tenKhachHang.Location = new System.Drawing.Point(240, 101);
            this.comboBox_tenKhachHang.Name = "comboBox_tenKhachHang";
            this.comboBox_tenKhachHang.Size = new System.Drawing.Size(293, 33);
            this.comboBox_tenKhachHang.TabIndex = 81;
            this.comboBox_tenKhachHang.ValueMember = "TenKhachHang";
            // 
            // comboBox_NguoiTao
            // 
            this.comboBox_NguoiTao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nhanVienBindingSource4, "TenNhanVien", true));
            this.comboBox_NguoiTao.DataSource = this.nhanVienBindingSource3;
            this.comboBox_NguoiTao.DisplayMember = "TenNhanVien";
            this.comboBox_NguoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NguoiTao.FormattingEnabled = true;
            this.comboBox_NguoiTao.Location = new System.Drawing.Point(240, 158);
            this.comboBox_NguoiTao.Name = "comboBox_NguoiTao";
            this.comboBox_NguoiTao.Size = new System.Drawing.Size(293, 33);
            this.comboBox_NguoiTao.TabIndex = 80;
            this.comboBox_NguoiTao.ValueMember = "TenNhanVien";
            // 
            // dateTimePicker_ngayGiaodich
            // 
            this.dateTimePicker_ngayGiaodich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngayGiaodich.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayGiaodich.Location = new System.Drawing.Point(240, 210);
            this.dateTimePicker_ngayGiaodich.Name = "dateTimePicker_ngayGiaodich";
            this.dateTimePicker_ngayGiaodich.Size = new System.Drawing.Size(293, 30);
            this.dateTimePicker_ngayGiaodich.TabIndex = 79;
            // 
            // label_No
            // 
            this.label_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_No.ForeColor = System.Drawing.Color.Black;
            this.label_No.Location = new System.Drawing.Point(14, 419);
            this.label_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_No.Name = "label_No";
            this.label_No.Size = new System.Drawing.Size(175, 30);
            this.label_No.TabIndex = 78;
            this.label_No.Text = "Nợ:";
            this.label_No.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_trangThai
            // 
            this.label_trangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_trangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trangThai.ForeColor = System.Drawing.Color.Black;
            this.label_trangThai.Location = new System.Drawing.Point(14, 364);
            this.label_trangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_trangThai.Name = "label_trangThai";
            this.label_trangThai.Size = new System.Drawing.Size(175, 30);
            this.label_trangThai.TabIndex = 76;
            this.label_trangThai.Text = "Trạng thái:";
            this.label_trangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_phuongThuc
            // 
            this.label_phuongThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_phuongThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_phuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phuongThuc.ForeColor = System.Drawing.Color.Black;
            this.label_phuongThuc.Location = new System.Drawing.Point(14, 314);
            this.label_phuongThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phuongThuc.Name = "label_phuongThuc";
            this.label_phuongThuc.Size = new System.Drawing.Size(175, 30);
            this.label_phuongThuc.TabIndex = 75;
            this.label_phuongThuc.Text = "Phương thức:";
            this.label_phuongThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_khachTra
            // 
            this.label_khachTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_khachTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_khachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_khachTra.ForeColor = System.Drawing.Color.Black;
            this.label_khachTra.Location = new System.Drawing.Point(14, 263);
            this.label_khachTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_khachTra.Name = "label_khachTra";
            this.label_khachTra.Size = new System.Drawing.Size(175, 30);
            this.label_khachTra.TabIndex = 74;
            this.label_khachTra.Text = "Khách trả:";
            this.label_khachTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ngayGiaoDich
            // 
            this.label_ngayGiaoDich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ngayGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_ngayGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayGiaoDich.ForeColor = System.Drawing.Color.Black;
            this.label_ngayGiaoDich.Location = new System.Drawing.Point(14, 212);
            this.label_ngayGiaoDich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ngayGiaoDich.Name = "label_ngayGiaoDich";
            this.label_ngayGiaoDich.Size = new System.Drawing.Size(175, 30);
            this.label_ngayGiaoDich.TabIndex = 73;
            this.label_ngayGiaoDich.Text = "Ngày giao dịch:";
            this.label_ngayGiaoDich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Nguoitao
            // 
            this.label_Nguoitao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Nguoitao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Nguoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nguoitao.ForeColor = System.Drawing.Color.Black;
            this.label_Nguoitao.Location = new System.Drawing.Point(14, 158);
            this.label_Nguoitao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nguoitao.Name = "label_Nguoitao";
            this.label_Nguoitao.Size = new System.Drawing.Size(175, 30);
            this.label_Nguoitao.TabIndex = 72;
            this.label_Nguoitao.Text = "Người tạo:";
            this.label_Nguoitao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_KhachHang
            // 
            this.label_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KhachHang.ForeColor = System.Drawing.Color.Black;
            this.label_KhachHang.Location = new System.Drawing.Point(14, 104);
            this.label_KhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KhachHang.Name = "label_KhachHang";
            this.label_KhachHang.Size = new System.Drawing.Size(175, 30);
            this.label_KhachHang.TabIndex = 71;
            this.label_KhachHang.Text = "Khách hàng:";
            this.label_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_khachTra
            // 
            this.textBox_khachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_khachTra.Location = new System.Drawing.Point(240, 263);
            this.textBox_khachTra.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_khachTra.Name = "textBox_khachTra";
            this.textBox_khachTra.Size = new System.Drawing.Size(293, 30);
            this.textBox_khachTra.TabIndex = 67;
            this.textBox_khachTra.TextChanged += new System.EventHandler(this.textBox_khachTra_TextChanged);
            // 
            // txtbox_maPhieu
            // 
            this.txtbox_maPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_maPhieu.Location = new System.Drawing.Point(240, 48);
            this.txtbox_maPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_maPhieu.Name = "txtbox_maPhieu";
            this.txtbox_maPhieu.Size = new System.Drawing.Size(293, 30);
            this.txtbox_maPhieu.TabIndex = 62;
            // 
            // label_maPhieu
            // 
            this.label_maPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_maPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_maPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maPhieu.ForeColor = System.Drawing.Color.Black;
            this.label_maPhieu.Location = new System.Drawing.Point(14, 48);
            this.label_maPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_maPhieu.Name = "label_maPhieu";
            this.label_maPhieu.Size = new System.Drawing.Size(175, 30);
            this.label_maPhieu.TabIndex = 61;
            this.label_maPhieu.Text = "Mã phiếu:";
            this.label_maPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qLBHDataSet1
            // 
            this.qLBHDataSet1.DataSetName = "QLBHDataSet";
            this.qLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource2
            // 
            this.khachHangBindingSource2.DataMember = "KhachHang";
            this.khachHangBindingSource2.DataSource = this.qLBHDataSet1;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangBindingSource3
            // 
            this.khachHangBindingSource3.DataMember = "KhachHang";
            this.khachHangBindingSource3.DataSource = this.qLBHDataSet1;
            // 
            // qLBHDataSet1BindingSource
            // 
            this.qLBHDataSet1BindingSource.DataSource = this.qLBHDataSet1;
            this.qLBHDataSet1BindingSource.Position = 0;
            // 
            // nhanVienBindingSource3
            // 
            this.nhanVienBindingSource3.DataMember = "NhanVien";
            this.nhanVienBindingSource3.DataSource = this.qLBHDataSet1BindingSource;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource4
            // 
            this.nhanVienBindingSource4.DataMember = "NhanVien";
            this.nhanVienBindingSource4.DataSource = this.qLBHDataSet1;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 584);
            this.Controls.Add(this.groupBox_thanhToan);
            this.Controls.Add(this.btn_thanhToan);
            this.Controls.Add(this.btn_huyBo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox_thanhToan.ResumeLayout(false);
            this.groupBox_thanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_huyBo;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.GroupBox groupBox_thanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayGiaodich;
        private System.Windows.Forms.Label label_No;
        private System.Windows.Forms.Label label_trangThai;
        private System.Windows.Forms.Label label_phuongThuc;
        private System.Windows.Forms.Label label_khachTra;
        private System.Windows.Forms.Label label_ngayGiaoDich;
        private System.Windows.Forms.Label label_Nguoitao;
        private System.Windows.Forms.Label label_KhachHang;
        private System.Windows.Forms.TextBox textBox_khachTra;
        private System.Windows.Forms.TextBox txtbox_maPhieu;
        private System.Windows.Forms.Label label_maPhieu;
        private System.Windows.Forms.ComboBox comboBox_NguoiTao;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.ComboBox comboBox_tenKhachHang;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.BindingSource khachHangBindingSource1;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private QLBHDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_No;
        private System.Windows.Forms.ComboBox comboBox_phuongThuc;
        private System.Windows.Forms.ComboBox comboBox_trangThai;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private QLBHDataSet qLBHDataSet1;
        private System.Windows.Forms.BindingSource khachHangBindingSource2;
        private QLBHDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource3;
        private System.Windows.Forms.BindingSource qLBHDataSet1BindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource3;
        private QLBHDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource4;
    }
}
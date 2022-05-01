
namespace Project
{
    partial class frmTaiChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiChinh));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabTongVon = new MetroFramework.Controls.MetroTabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbVon = new System.Windows.Forms.TabPage();
            this.ucVonGop = new Project.UCVon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRutVon = new System.Windows.Forms.Button();
            this.btThemVon = new System.Windows.Forms.Button();
            this.tbThu = new System.Windows.Forms.TabPage();
            this.ucVayNo = new Project.UCVon();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTraNo = new System.Windows.Forms.Button();
            this.btVayNo = new System.Windows.Forms.Button();
            this.tbThongKe = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btTheoNam = new System.Windows.Forms.Button();
            this.btThang = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDoanhThu = new MetroFramework.Controls.MetroTabPage();
            this.ucDoanhThu = new Project.UCThuChi();
            this.tabChiTieu = new MetroFramework.Controls.MetroTabPage();
            this.ucChiTieu = new Project.UCThuChi();
            this.metroTabControl1.SuspendLayout();
            this.tabTongVon.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbVon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbThu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbThongKe.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabDoanhThu.SuspendLayout();
            this.tabChiTieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabTongVon);
            this.metroTabControl1.Controls.Add(this.tabDoanhThu);
            this.metroTabControl1.Controls.Add(this.tabChiTieu);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(250, 50);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1000, 653);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabTongVon
            // 
            this.tabTongVon.BackColor = System.Drawing.Color.White;
            this.tabTongVon.Controls.Add(this.tabControl1);
            this.tabTongVon.HorizontalScrollbarBarColor = true;
            this.tabTongVon.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTongVon.HorizontalScrollbarSize = 1;
            this.tabTongVon.Location = new System.Drawing.Point(4, 54);
            this.tabTongVon.Name = "tabTongVon";
            this.tabTongVon.Size = new System.Drawing.Size(992, 595);
            this.tabTongVon.TabIndex = 0;
            this.tabTongVon.Text = "Tổng Vốn";
            this.tabTongVon.VerticalScrollbarBarColor = true;
            this.tabTongVon.VerticalScrollbarHighlightOnWheel = false;
            this.tabTongVon.VerticalScrollbarSize = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tbVon);
            this.tabControl1.Controls.Add(this.tbThu);
            this.tabControl1.Controls.Add(this.tbThongKe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 595);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tbVon
            // 
            this.tbVon.Controls.Add(this.ucVonGop);
            this.tbVon.Controls.Add(this.panel1);
            this.tbVon.Location = new System.Drawing.Point(33, 4);
            this.tbVon.Name = "tbVon";
            this.tbVon.Padding = new System.Windows.Forms.Padding(3);
            this.tbVon.Size = new System.Drawing.Size(955, 587);
            this.tbVon.TabIndex = 0;
            this.tbVon.Text = "Vốn Góp";
            this.tbVon.UseVisualStyleBackColor = true;
            // 
            // ucVonGop
            // 
            this.ucVonGop.BackColor = System.Drawing.Color.White;
            this.ucVonGop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVonGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucVonGop.Location = new System.Drawing.Point(3, 3);
            this.ucVonGop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucVonGop.Name = "ucVonGop";
            this.ucVonGop.Size = new System.Drawing.Size(949, 489);
            this.ucVonGop.TabIndex = 2;
            this.ucVonGop.Load += new System.EventHandler(this.ucVon3_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRutVon);
            this.panel1.Controls.Add(this.btThemVon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 92);
            this.panel1.TabIndex = 1;
            // 
            // btRutVon
            // 
            this.btRutVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRutVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btRutVon.Image = ((System.Drawing.Image)(resources.GetObject("btRutVon.Image")));
            this.btRutVon.Location = new System.Drawing.Point(707, 18);
            this.btRutVon.Name = "btRutVon";
            this.btRutVon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRutVon.Size = new System.Drawing.Size(198, 55);
            this.btRutVon.TabIndex = 3;
            this.btRutVon.Text = "   Rút Vốn";
            this.btRutVon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRutVon.UseVisualStyleBackColor = false;
            // 
            // btThemVon
            // 
            this.btThemVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btThemVon.Image = ((System.Drawing.Image)(resources.GetObject("btThemVon.Image")));
            this.btThemVon.Location = new System.Drawing.Point(461, 18);
            this.btThemVon.Name = "btThemVon";
            this.btThemVon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btThemVon.Size = new System.Drawing.Size(198, 55);
            this.btThemVon.TabIndex = 5;
            this.btThemVon.Text = "   Thêm Vốn";
            this.btThemVon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemVon.UseVisualStyleBackColor = false;
            // 
            // tbThu
            // 
            this.tbThu.Controls.Add(this.ucVayNo);
            this.tbThu.Controls.Add(this.panel2);
            this.tbThu.Location = new System.Drawing.Point(33, 4);
            this.tbThu.Name = "tbThu";
            this.tbThu.Padding = new System.Windows.Forms.Padding(3);
            this.tbThu.Size = new System.Drawing.Size(955, 587);
            this.tbThu.TabIndex = 1;
            this.tbThu.Text = "Vay Nợ";
            this.tbThu.UseVisualStyleBackColor = true;
            // 
            // ucVayNo
            // 
            this.ucVayNo.BackColor = System.Drawing.Color.White;
            this.ucVayNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucVayNo.Location = new System.Drawing.Point(3, 3);
            this.ucVayNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucVayNo.Name = "ucVayNo";
            this.ucVayNo.Size = new System.Drawing.Size(949, 489);
            this.ucVayNo.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTraNo);
            this.panel2.Controls.Add(this.btVayNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 92);
            this.panel2.TabIndex = 2;
            // 
            // btTraNo
            // 
            this.btTraNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTraNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btTraNo.Image = ((System.Drawing.Image)(resources.GetObject("btTraNo.Image")));
            this.btTraNo.Location = new System.Drawing.Point(707, 18);
            this.btTraNo.Name = "btTraNo";
            this.btTraNo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTraNo.Size = new System.Drawing.Size(198, 55);
            this.btTraNo.TabIndex = 3;
            this.btTraNo.Text = "   Trả Nợ";
            this.btTraNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTraNo.UseVisualStyleBackColor = false;
            // 
            // btVayNo
            // 
            this.btVayNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVayNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btVayNo.Image = ((System.Drawing.Image)(resources.GetObject("btVayNo.Image")));
            this.btVayNo.Location = new System.Drawing.Point(461, 18);
            this.btVayNo.Name = "btVayNo";
            this.btVayNo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btVayNo.Size = new System.Drawing.Size(198, 55);
            this.btVayNo.TabIndex = 5;
            this.btVayNo.Text = "   Vay Nợ";
            this.btVayNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVayNo.UseVisualStyleBackColor = false;
            // 
            // tbThongKe
            // 
            this.tbThongKe.BackColor = System.Drawing.Color.White;
            this.tbThongKe.Controls.Add(this.panel3);
            this.tbThongKe.Controls.Add(this.chart1);
            this.tbThongKe.Location = new System.Drawing.Point(33, 4);
            this.tbThongKe.Name = "tbThongKe";
            this.tbThongKe.Size = new System.Drawing.Size(955, 587);
            this.tbThongKe.TabIndex = 2;
            this.tbThongKe.Text = "Thống Kê";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btTheoNam);
            this.panel3.Controls.Add(this.btThang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 100);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống Kê:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(174, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // btTheoNam
            // 
            this.btTheoNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTheoNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btTheoNam.Location = new System.Drawing.Point(692, 27);
            this.btTheoNam.Name = "btTheoNam";
            this.btTheoNam.Size = new System.Drawing.Size(199, 55);
            this.btTheoNam.TabIndex = 3;
            this.btTheoNam.Text = "Theo Năm";
            this.btTheoNam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTheoNam.UseVisualStyleBackColor = false;
            // 
            // btThang
            // 
            this.btThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btThang.Location = new System.Drawing.Point(440, 27);
            this.btThang.Name = "btThang";
            this.btThang.Size = new System.Drawing.Size(199, 55);
            this.btThang.TabIndex = 4;
            this.btThang.Text = "Theo Tháng";
            this.btThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThang.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(34, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(892, 478);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.BackColor = System.Drawing.Color.White;
            this.tabDoanhThu.Controls.Add(this.ucDoanhThu);
            this.tabDoanhThu.HorizontalScrollbarBarColor = true;
            this.tabDoanhThu.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDoanhThu.HorizontalScrollbarSize = 1;
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 54);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Size = new System.Drawing.Size(992, 595);
            this.tabDoanhThu.TabIndex = 1;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.VerticalScrollbarBarColor = true;
            this.tabDoanhThu.VerticalScrollbarHighlightOnWheel = false;
            this.tabDoanhThu.VerticalScrollbarSize = 1;
            // 
            // ucDoanhThu
            // 
            this.ucDoanhThu.BackColor = System.Drawing.Color.White;
            this.ucDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.ucDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDoanhThu.Name = "ucDoanhThu";
            this.ucDoanhThu.Size = new System.Drawing.Size(992, 595);
            this.ucDoanhThu.TabIndex = 2;
            // 
            // tabChiTieu
            // 
            this.tabChiTieu.Controls.Add(this.ucChiTieu);
            this.tabChiTieu.HorizontalScrollbarBarColor = true;
            this.tabChiTieu.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChiTieu.HorizontalScrollbarSize = 1;
            this.tabChiTieu.Location = new System.Drawing.Point(4, 54);
            this.tabChiTieu.Name = "tabChiTieu";
            this.tabChiTieu.Size = new System.Drawing.Size(992, 595);
            this.tabChiTieu.TabIndex = 2;
            this.tabChiTieu.Text = "Chi Tiêu";
            this.tabChiTieu.VerticalScrollbarBarColor = true;
            this.tabChiTieu.VerticalScrollbarHighlightOnWheel = false;
            this.tabChiTieu.VerticalScrollbarSize = 1;
            // 
            // ucChiTieu
            // 
            this.ucChiTieu.BackColor = System.Drawing.Color.White;
            this.ucChiTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucChiTieu.Location = new System.Drawing.Point(0, 0);
            this.ucChiTieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucChiTieu.Name = "ucChiTieu";
            this.ucChiTieu.Size = new System.Drawing.Size(992, 595);
            this.ucChiTieu.TabIndex = 2;
            // 
            // frmTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 653);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaiChinh";
            this.Text = "frmTaiChinh";
            this.Load += new System.EventHandler(this.frmTaiChinh_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabTongVon.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbVon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbThongKe.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabDoanhThu.ResumeLayout(false);
            this.tabChiTieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabTongVon;
        private MetroFramework.Controls.MetroTabPage tabDoanhThu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbThu;
        private System.Windows.Forms.TabPage tbThongKe;
        private MetroFramework.Controls.MetroTabPage tabChiTieu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTraNo;
        private System.Windows.Forms.Button btVayNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTheoNam;
        private System.Windows.Forms.Button btThang;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbVon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRutVon;
        private System.Windows.Forms.Button btThemVon;
        private UCVon ucVonGop;
        private UCVon ucVayNo;
        private UCThuChi ucDoanhThu;
        private UCThuChi ucChiTieu;
    }
}
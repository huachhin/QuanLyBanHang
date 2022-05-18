using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Microsoft.Reporting.WinForms;

namespace Project
{
    public partial class frmInHoaDon : Form
    {
        private DatabaseAccess databaseAccess;
        private string maPhieu;
        private string tenKhachHang;
        public frmInHoaDon(string maPhieu, string tenKhachHang)
        {
            InitializeComponent();
            databaseAccess = new DatabaseAccess();
            this.maPhieu = maPhieu;
            this.tenKhachHang = tenKhachHang;
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            string query = "WITH TMP AS( " +
                "SELECT GiaBan, TenHang, GioHang.SoLuong, MaPhieu " +
                "FROM CuaHang INNER JOIN GioHang ON CuaHang.MaMatHang = GioHang.MaSanPham ) " +
                "SELECT TenHang as SanPham, TMP.SoLuong, GiaBan " +
                "FROM TMP INNER JOIN HoaDon ON TMP.MaPhieu = HoaDon.MaPhieu " +
                "WHERE HoaDon.MaPhieu = '" + maPhieu + "'";
            //string query = "SELECT * FROM GioHang";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportHoaDon.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = databaseAccess.executeQuery(query).Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string query = "WITH TMP AS( " +
                "SELECT GiaBan, TenHang, GioHang.SoLuong, MaPhieu " +
                "FROM CuaHang INNER JOIN GioHang ON CuaHang.MaMatHang = GioHang.MaSanPham ) " +
                "SELECT TenHang as SanPham, TMP.SoLuong, GiaBan " +
                "FROM TMP INNER JOIN HoaDon ON TMP.MaPhieu = HoaDon.MaPhieu " +
                "WHERE HoaDon.MaPhieu = '" + maPhieu + "'";
            //string query = "SELECT * FROM GioHang";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportHoaDon.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = databaseAccess.executeQuery(query).Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}

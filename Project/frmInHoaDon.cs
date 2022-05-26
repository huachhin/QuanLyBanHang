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

        private int tongGia;

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
                "SELECT TenHang as SanPham, TMP.SoLuong, GiaBan, KhachTra " +
                "FROM TMP INNER JOIN HoaDon ON TMP.MaPhieu = HoaDon.MaPhieu " +
                "WHERE HoaDon.MaPhieu = '" + maPhieu + "'";
            //string query = "SELECT * FROM GioHang";

            DataTable ds = databaseAccess.executeQuery(query).Tables[0];

            tongGia = 0;
            int khachTra = 0;
            foreach (DataRow item in ds.Rows)
            {
                khachTra = Convert.ToInt32(item["KhachTra"]);
                tongGia += Convert.ToInt32(item["GiaBan"]) * Convert.ToInt32(item["SoLuong"]);
            }
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.ReportHoaDon.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds;
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("tbMaPhieu", maPhieu));
            reportParameters.Add(new ReportParameter("tbTenKhachHang", tenKhachHang));
            reportParameters.Add(new ReportParameter("tbTongGia", String.Format("{0:N0}", tongGia)));
            reportParameters.Add(new ReportParameter("tbKhachTra", String.Format("{0:N0}", khachTra)));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();
        }
    }
}

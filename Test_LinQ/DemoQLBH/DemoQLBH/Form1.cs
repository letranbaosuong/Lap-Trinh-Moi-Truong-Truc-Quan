using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            KhachHang khachHangMoi = new KhachHang();
            khachHangMoi.MaKH = txtMaKH.Text.Trim();
            khachHangMoi.TenKH = txtTenKH.Text.Trim();
            khachHangMoi.DiaChi = txtDiaChi.Text.Trim();
            khachHangMoi.Sdt = txtSDT.Text.Trim();

            db.KhachHangs.InsertOnSubmit(khachHangMoi);
            db.SubmitChanges();

            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            KhachHang capNhatKhachHangTheoMaKH = db.KhachHangs.Single(kh => kh.MaKH.Equals(txtMaKH.Text.Trim()));
            capNhatKhachHangTheoMaKH.TenKH = txtTenKH.Text.Trim();
            capNhatKhachHangTheoMaKH.DiaChi = txtDiaChi.Text.Trim();
            capNhatKhachHangTheoMaKH.Sdt = txtSDT.Text.Trim();

            db.SubmitChanges();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            KhachHang xoaKhachHangTheoMaKH = db.KhachHangs.Single(kh => kh.MaKH.Equals(txtMaKH.Text.Trim()));

            db.KhachHangs.DeleteOnSubmit(xoaKhachHangTheoMaKH);
            db.SubmitChanges();

            HienThi();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            // lambda expression
            //dtgvQLBH.DataSource = db.KhachHangs.Select(kh => kh);
            //dtgvQLBH.DataSource = db.KhachHangs.Where(kh => kh.MaKH.CompareTo("KH001") == 0);
            //dtgvQLBH.DataSource = db.KhachHangs.Select(kh => kh).OrderBy(kh => kh.TenKH);
            //dtgvQLBH.DataSource = db.KhachHangs.Where(kh=>kh.MaKH.Contains("KH001")).OrderByDescending(kh => kh.TenKH);

            // truy vấn linq to sql 1 cách bình thường
            /*dtgvQLBH.DataSource = from kh in db.KhachHangs
                                  where kh.MaKH.Contains("KH001")
                                  orderby kh.TenKH descending
                                  select kh;*/

            dtgvQLBH.DataSource = from kh in db.KhachHangs
                                  where kh.MaKH.Contains(txtXem.Text.Trim())
                                  select new
                                  {
                                      kh.TenKH,
                                      kh.DiaChi,
                                      kh.Sdt
                                  };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            dtgvQLBH.DataSource = from kh in db.KhachHangs
                                  select kh;
        }

        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            // 2.Cho biet thong tin nhung don dat hang khong duoc giao
            // hien thi ma dat ngay dat ten khach hang
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            dtgvQLBH.DataSource = from ddh in db.DonDatHangs
                                  join kh in db.KhachHangs on ddh.MaKH equals kh.MaKH
                                  where ddh.TinhTrang.Equals("0")
                                  select new
                                  {
                                      ddh.MaDH,
                                      ddh.NgayDat,
                                      kh.TenKH
                                  };
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            /* cau 5
            --5 Cho biet tong tien cua tung phieu giao hang trong nam 2012
            --hien thi ma giao ngay giao tong tien voi so tien = SUM(SLGiao * DonGiaGiao)*/
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            dtgvQLBH.DataSource = from pgh in db.PhieuGiaoHangs
                                  join ctgh in db.ChiTietGiaoHangs on pgh.MaGH equals ctgh.MaGH into g
                                  where pgh.NgayGH.Value.Year.Equals(2012)
                                  select new
                                  {
                                      pgh.MaGH,
                                      pgh.NgayGH,
                                      TongTien = g.Sum(tbl => (tbl.SLGiao * tbl.DonGiaGiao)),
                                  };
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}

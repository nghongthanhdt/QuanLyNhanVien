using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhanVien.Models;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraSplashScreen;
using QuanLyNhanVien.Controllers;

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private List<T_Lib_ThietBi> listThietBi = new List<T_Lib_ThietBi>();
        private DataTable dtPhieuNhap = new DataTable();
        private DataTable dtChiTiet = new DataTable();
        public int maKho = 1;
        public FormDanhSachPhieuNhap()
        {
            InitializeComponent();
            
            dtChiTiet.Columns.Add("MaThietBi");
            dtChiTiet.Columns.Add("STT");
            dtChiTiet.Columns.Add("TenThietBi");
            dtChiTiet.Columns.Add("DonVi");
            dtChiTiet.Columns.Add("SoLuong", Type.GetType("System.Decimal"));
            dtChiTiet.Columns.Add("DonGia", Type.GetType("System.Decimal"));
            dtChiTiet.Columns.Add("ThanhTien", Type.GetType("System.Decimal"));
        }
        private void FormDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            loadDanhSachPhieuNhap();
        }
        private void loadDanhSachPhieuNhap()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            listThietBi = db.T_Lib_ThietBi.Where(x => x.IsEnable == true).OrderBy(x => x.TenThietBi).ToList();
            datetimeNgayNhap.DateTime = DateTime.Now;
            dateTuNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateDenNgay.DateTime = DateTime.Now;
            btnXem.PerformClick();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            DateTime tuNgay = DateTime.Parse(dateTuNgay.DateTime.ToShortDateString());
            DateTime denNgay = DateTime.Parse(dateDenNgay.DateTime.ToShortDateString());
            gcDanhSachPhieuNhap.DataSource = db.P_DanhSachPhieuNhap(tuNgay, denNgay).ToList();
        }
        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            FormPhieuNhapKhoThemThietBi f = new FormPhieuNhapKhoThemThietBi();
            f.ShowDialog();
            if (f.isSelected == false) return;
            int i = 1;
            foreach (DataRow r in dtChiTiet.Rows)
            {                
                if(r["MaThietBi"].ToString() == f.outMaThietBi)
                {
                    MessageBox.Show("Món này đã chọn rồi, vui lòng kiểm tra lại");
                    return;
                }
                r["STT"] = i;
                i++;
            }
            int maThietBi = int.Parse(f.outMaThietBi);
            var selectedThietBi = listThietBi.Where(x => x.MaThietBi == maThietBi).ToList();
            T_Lib_ThietBi thietBi = new T_Lib_ThietBi();
            if (selectedThietBi.Any())
            {
                thietBi = selectedThietBi.First();
            }

            DataRow row = dtChiTiet.NewRow();
            row["MaThietBi"] = thietBi.MaThietBi;
            row["STT"] = i;
            row["TenThietBi"] = thietBi.TenThietBi;
            row["DonVi"] = thietBi.DonVi;
            row["SoLuong"] = 0;
            row["DonGia"] = 0;
            row["ThanhTien"] = 0;
            dtChiTiet.Rows.Add(row);

            gcDanhSachThietBi.DataSource = dtChiTiet;            
        }      
        private void btnNhanVienLuu_Click(object sender, EventArgs e)
        {
            tinhTien();
            if (validatePhieuNhap() == true)
            {                
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                if (txtMaPhieuNhap.Text == "")
                {
                    // insert phiếu nhập
                    
                    int thang = datetimeNgayNhap.DateTime.Month;
                    int nam = datetimeNgayNhap.DateTime.Year;
                    string nguoiNhap = txtNguoiNhap.Text;
                    DateTime ngayNhap = datetimeNgayNhap.DateTime;
                    string nhaCungCap = txtNhaCungCap.Text;
                    string ghiChu = txtGhiChu.Text;
                    // chạy store insert phieu nhap lấy ra ID phiếu nhập vừa thêm và số phiếu
                    var _newPhieuNhap = db.P_InsertPhieuNhap(maKho, nhaCungCap, ngayNhap, nguoiNhap, ghiChu).ToList();
                    int newMaPhieuNhap = 0;
                    if (_newPhieuNhap.Any())
                    {
                        txtMaPhieuNhap.Text = _newPhieuNhap.First().MaPhieuNhap.ToString();
                        txtSoPhieu.Text = _newPhieuNhap.First().SoPhieu.ToString();
                        newMaPhieuNhap = int.Parse(txtMaPhieuNhap.Text);
                    }

                    if (newMaPhieuNhap > 0)
                    {
                        // nạp chi tiết phiếu
                        T_PhieuNhap_ChiTiet chiTiet;
                        int i = 0;
                        foreach (DataRow row in dtChiTiet.Rows)
                        {
                            i++;
                            chiTiet = new T_PhieuNhap_ChiTiet();
                            chiTiet.MaPhieuNhap = newMaPhieuNhap;
                            chiTiet.STT = i;
                            chiTiet.MaThietBi = int.Parse(row["MaThietBi"].ToString());
                            chiTiet.SoLuong = decimal.Parse(row["SoLuong"].ToString());
                            chiTiet.DonGia = decimal.Parse(row["DonGia"].ToString());
                            chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;
                            db.T_PhieuNhap_ChiTiet.Add(chiTiet);
                        }
                        db.SaveChanges();                        
                    }
                } else
                {
                    // update                    
                    int maPhieuNhap = int.Parse(txtMaPhieuNhap.Text);
                    if (maPhieuNhap > 0)
                    {
                        T_PhieuNhap phieuNhap = db.T_PhieuNhap.Find(maPhieuNhap);                        
                        phieuNhap.NguoiNhap = txtNguoiNhap.Text;
                        phieuNhap.NgayNhap = datetimeNgayNhap.DateTime;
                        phieuNhap.NhaCungCap = txtNhaCungCap.Text;
                        phieuNhap.GhiChu = txtGhiChu.Text;

                        // xóa hết chi tiết phiếu nạp lại
                        List<T_PhieuNhap_ChiTiet> listChiTiet = db.T_PhieuNhap_ChiTiet.Where(x => x.MaPhieuNhap == maPhieuNhap).ToList();
                        db.T_PhieuNhap_ChiTiet.RemoveRange(listChiTiet);
                        T_PhieuNhap_ChiTiet chiTiet;
                        int i = 0;
                        foreach (DataRow row in dtChiTiet.Rows)
                        {
                            i++;
                            chiTiet = new T_PhieuNhap_ChiTiet();
                            chiTiet.MaPhieuNhap = maPhieuNhap;
                            chiTiet.STT = i;//int.Parse(row["STT"].ToString());
                            chiTiet.MaThietBi = int.Parse(row["MaThietBi"].ToString());
                            chiTiet.SoLuong = decimal.Parse(row["SoLuong"].ToString());
                            chiTiet.DonGia = decimal.Parse(row["DonGia"].ToString());
                            chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;
                            db.T_PhieuNhap_ChiTiet.Add(chiTiet);
                        }
                        db.SaveChanges();
                    }
                }
                SplashScreenManager.ShowForm(typeof(SplashScreenSaveOK));
                SplashScreenManager.CloseForm(false, 1500, this);
                btnXem.PerformClick();
            }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            tinhTien();
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            resetFormPhieuNhap();
        }
        private void resetFormPhieuNhap()
        {
            txtMaPhieuNhap.Text = "";
            txtSoPhieu.Text = "";
            txtNhaCungCap.Text = "";
            txtNguoiNhap.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            dtChiTiet.Rows.Clear();
            gcDanhSachThietBi.DataSource = dtChiTiet;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gcDanhSachPhieuNhap_Click(object sender, EventArgs e)
        {
            loadPhieuNhap();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa ?"))
            {
                int maPhieuNhap = int.Parse(txtMaPhieuNhap.Text);
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                var phieuNhap = db.T_PhieuNhap.Find(maPhieuNhap);

                var listChiTiet = phieuNhap.T_PhieuNhap_ChiTiet.ToList();
                if (listChiTiet.Any())
                {
                    db.T_PhieuNhap_ChiTiet.RemoveRange(listChiTiet);
                }
                db.T_PhieuNhap.Remove(phieuNhap);
                db.SaveChanges();
                loadDanhSachPhieuNhap();
                resetFormPhieuNhap();
            }
        }
        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDanhSachThietBi.FocusedRowHandle >= 0)
                {
                    int maThietBi = int.Parse(gvDanhSachThietBi.GetFocusedRowCellValue("MaThietBi").ToString());
                    DataTable dtThietBi = gcDanhSachThietBi.DataSource as DataTable;
                    int i = -1;
                    int deletedRowNumber = 0;
                    foreach (DataRow row in dtThietBi.Rows)
                    {
                        i++;
                        if (int.Parse(row["MaThietBi"].ToString()) == maThietBi)
                        {
                            
                            deletedRowNumber = i;
                            break;
                        }
                    }
                    dtThietBi.Rows.RemoveAt(deletedRowNumber);
                    gcDanhSachThietBi.DataSource = dtThietBi;
                }
                

            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            loadPhieuNhap();
        }
        private void FormDanhSachPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuu.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                btnHuyBo.PerformClick();
            }
            if (e.Shift && e.KeyCode == Keys.Delete)
            {
                btnXoa.PerformClick();
            }
        }
        private void loadPhieuNhap()
        {
            try
            {
                int maPhieuNhap = int.Parse(gvDanhSachPhieuNhap.GetFocusedRowCellValue("MaPhieuNhap").ToString());
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                T_PhieuNhap phieuNhap = db.T_PhieuNhap.Find(maPhieuNhap);
                txtMaPhieuNhap.Text = phieuNhap.MaPhieuNhap.ToString();
                datetimeNgayNhap.DateTime = phieuNhap.NgayNhap;
                txtSoPhieu.Text = phieuNhap.SoPhieu;
                txtNguoiNhap.Text = phieuNhap.NguoiNhap;
                txtNhaCungCap.Text = phieuNhap.NhaCungCap;
                txtGhiChu.Text = phieuNhap.GhiChu;

                var listChiTiet = db.P_DanhSachChiTietPhieuNhap(maPhieuNhap).ToList();
                //convert list to DataTable;
                dtChiTiet.Rows.Clear();
                foreach (var item in listChiTiet)
                {
                    DataRow row = dtChiTiet.NewRow();
                    row["MaThietBi"] = item.MaThietBi;
                    row["STT"] = item.STT;
                    row["TenThietBi"] = item.TenThietBi;
                    row["DonVi"] = item.DonVi;
                    row["SoLuong"] = item.SoLuong;
                    row["DonGia"] = item.DonGia;
                    row["ThanhTien"] = item.ThanhTien;
                    dtChiTiet.Rows.Add(row);
                }
                gcDanhSachThietBi.DataSource = dtChiTiet;
                tinhTien();

            }
            catch (Exception ex)
            {
                resetFormPhieuNhap();
            }
        }
        private void tinhTien()
        {
            decimal tongTien = 0;
            if (gvDanhSachThietBi.RowCount > 0)
            {
                dtChiTiet = gcDanhSachThietBi.DataSource as DataTable;
                int i = 0;
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    i++;
                    row["STT"] = i;
                    decimal soLuong = 0;
                    try
                    {
                        soLuong = decimal.Parse(row["SoLuong"].ToString());
                    }
                    catch
                    {
                        if (row["SoLuong"].ToString() != "")
                        {
                            MessageBox.Show("Lỗi số lượng ở món hàng \"" + row["TenThietBi"].ToString() + "\", vui lòng kiểm tra lại");
                            return;
                        }
                    }
                    decimal donGia = 0;
                    decimal.TryParse(row["DonGia"].ToString(), out donGia);
                    row["ThanhTien"] = soLuong * donGia;
                    tongTien += soLuong * donGia;
                }
                gcDanhSachThietBi.DataSource = dtChiTiet;
                txtTongTien.Text = tongTien.ToString("#,#");
            }
        }
        private bool validatePhieuNhap()
        {
            if (txtNguoiNhap.Text == "")
            {
                MessageBox.Show("Nhập tên người nhập");
                return false;
            }
            return true;
        }
    }
}
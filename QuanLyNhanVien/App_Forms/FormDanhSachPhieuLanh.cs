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

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormDanhSachPhieuLanh : DevExpress.XtraEditors.XtraForm
    {
        private List<T_Lib_ThietBi> listThietBi = new List<T_Lib_ThietBi>();
        private List<T_NguoiDung> listNguoiDung = new List<T_NguoiDung>();
        DataTable dtChiTiet = new DataTable();
        QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();

        NguoiDung nguoiDung = new NguoiDung();

        public FormDanhSachPhieuLanh()
        {
            InitializeComponent();

            dtChiTiet.Columns.Add("MaThietBi");
            dtChiTiet.Columns.Add("STT");
            dtChiTiet.Columns.Add("TenThietBi");
            dtChiTiet.Columns.Add("DonVi");
            dtChiTiet.Columns.Add("SoLuong", Type.GetType("System.Decimal"));

            listThietBi = db.T_Lib_ThietBi.Where(x => x.IsEnable == true).OrderBy(x => x.TenThietBi).ToList();


            loadselectKhoaPhong();
            // người dùng sau khi đăng nhập

            nguoiDung.MaNguoiDung = 1;
            nguoiDung.HoTen = "Nguyễn Hồng Thanh";
            nguoiDung.MaKhoa = "KH";
            nguoiDung.MatKhau = "123123";
            nguoiDung.TenDangNhap = "nghongthanhdt";
            nguoiDung.TenKhoa = "Phòng kế hoạch tổng hợp";

            ChucNang chucNang;
            List<ChucNang> listChucNang = new List<ChucNang>();
            chucNang = new ChucNang();
            chucNang.MaChucNang = "lanhvpp";
            chucNang.TenChucNang = "Lãnh văn phòng phẩm";
            listChucNang.Add(chucNang);

            chucNang = new ChucNang();
            chucNang.MaChucNang = "qlvpp";
            chucNang.TenChucNang = "Quản lý văn phòng phẩm";
            listChucNang.Add(chucNang);

            nguoiDung.ListChucNang = listChucNang;


            selectKhoaPhong.EditValue = nguoiDung.MaKhoa;


            listNguoiDung = db.T_NguoiDung.OrderBy(x => x.HoTen).ToList();
            selectNguoiLanh.Properties.DataSource = listNguoiDung;
            selectNguoiLanh.EditValue = nguoiDung.MaNguoiDung;



            selectKhoaPhong.Enabled = false;
            selectNguoiLanh.Enabled = false;
            foreach (var item in nguoiDung.ListChucNang)
            {
                if (item.MaChucNang == "qlvpp")
                {
                    selectNguoiLanh.Enabled = true;
                    selectKhoaPhong.Enabled = true;
                }
            }


            selectThang.SelectedIndex = 0;
            selectNam.SelectedIndex = 0;

            loadDanhSachPhieuLanh();
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            FormPhieuNhapKhoThemThietBi f = new FormPhieuNhapKhoThemThietBi();
            f.ShowDialog();
            if (f.isSelected == false) return;
            int i = 1;
            foreach (DataRow r in dtChiTiet.Rows)
            {
                if (r["MaThietBi"].ToString() == f.outMaThietBi)
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
            dtChiTiet.Rows.Add(row);

            gcDanhSachThietBi.DataSource = dtChiTiet;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }


        private void loadselectKhoaPhong()
        {
            var list = db.T_KhoaPhong.OrderBy(x => x.STT).ToList();
            if (list.Any())
            {
                selectKhoaPhong.Properties.DataSource = list;
            }
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            resetFormPhieuLanh();
        }
        private void resetFormPhieuLanh()
        {
            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            selectKhoaPhong.EditValue = "--";
            selectNguoiLanh.Properties.DataSource = null;
            dtChiTiet.Rows.Clear();
            gcDanhSachThietBi.DataSource = dtChiTiet;

            checkboxChoDuyet.Checked = false;
            checkboxDaDuyet.Checked = false;
            checkboxDaPhat.Checked = false;
            
        }

        private void FormDanhSachPhieuLanh_Load(object sender, EventArgs e)
        {
            
        }
        private void loadselectThangNam()
        {
            selectThang.SelectedIndex = 0;
            selectNam.SelectedIndex = 0;
        }
        private void loadDanhSachPhieuLanh()
        {
            try
            {
                int thang = int.Parse(selectThang.Text);
                int nam = int.Parse(selectNam.Text);

                gcDanhSachPhieuLanh.DataSource = db.P_DanhSachPhieuLanh(thang, nam);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDanhSachPhieuLanh();
        }

        private void gcDanhSachPhieuLanh_Click(object sender, EventArgs e)
        {
            
        }
        private void loadPhieuLanh()
        {
            try
            {
                int maPhieuLanh = int.Parse(gvDanhSachPhieuLanh.GetFocusedRowCellValue("MaPhieuLanh").ToString());
                T_PhieuLanh phieuLanh = db.T_PhieuLanh.Find(maPhieuLanh);
                txtMaPhieuLanh.Text = phieuLanh.MaPhieuLanh.ToString();
                txtThang.Text = phieuLanh.Thang.ToString();
                txtNam.Text = phieuLanh.Nam.ToString();
                txtSoPhieu.Text = phieuLanh.SoPhieu;
                selectNguoiLanh.EditValue = phieuLanh.MaNguoiDung;
                txtGhiChu.Text = phieuLanh.GhiChu;
                selectKhoaPhong.EditValue = phieuLanh.T_KhoThietBi.T_KhoaPhong.MaKhoa;
                txtMaKho.Text = phieuLanh.T_KhoThietBi.MaKho.ToString();

                var listChiTiet = phieuLanh.T_PhieuLanh_ChiTiet.ToList();
                //convert list to DataTable;
                //dtChiTiet.Rows.Clear();
                //foreach (var item in listChiTiet)
                //{
                //    DataRow row = dtChiTiet.NewRow();
                //    row["MaThietBi"] = item.MaThietBi;
                //    row["STT"] = item.STT;
                //    row["TenThietBi"] = item.TenThietBi;
                //    row["DonVi"] = item.DonVi;
                //    row["SoLuong"] = item.SoLuong;
                //    row["DonGia"] = item.DonGia;
                //    row["ThanhTien"] = item.ThanhTien;
                //    dtChiTiet.Rows.Add(row);
                //}
                //gcDanhSachThietBi.DataSource = dtChiTiet;
                //tinhTien();

            }
            catch (Exception ex)
            {
                resetFormPhieuLanh();
            }
        }
    }
}
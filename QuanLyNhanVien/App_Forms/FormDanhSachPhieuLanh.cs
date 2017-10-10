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
    }
}
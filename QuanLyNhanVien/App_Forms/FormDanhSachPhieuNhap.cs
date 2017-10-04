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

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private List<T_Lib_ThietBi> listThietBi = new List<T_Lib_ThietBi>();
        private DataTable dt = new DataTable();
        public FormDanhSachPhieuNhap()
        {
            InitializeComponent();
        }
        private void FormDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            listThietBi = db.T_Lib_ThietBi.Where(x => x.IsEnable == true).OrderBy(x => x.TenThietBi).ToList();

            dt.Columns.Add("MaThietBi");
            dt.Columns.Add("STT");
            dt.Columns.Add("TenThietBi");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong", Type.GetType("System.Decimal"));
            dt.Columns.Add("DonGia", Type.GetType("System.Decimal"));
            dt.Columns.Add("ThanhTien", Type.GetType("System.Decimal"));


            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            datetimeNgayNhap.DateTime = DateTime.Now;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            FormPhieuNhapKhoThemThietBi f = new FormPhieuNhapKhoThemThietBi();
            f.ShowDialog();
            int i = 1;
            foreach (DataRow r in dt.Rows)
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

            
            

            DataRow row = dt.NewRow();
            row["MaThietBi"] = thietBi.MaThietBi;
            row["STT"] = i;
            row["TenThietBi"] = thietBi.TenThietBi;
            row["DonVi"] = thietBi.DonVi;
            row["SoLuong"] = 0;
            row["DonGia"] = 0;
            row["ThanhTien"] = 0;
            dt.Rows.Add(row);

            gcDanhSachThietBi.DataSource = dt;

            
        }

        private void btnNhanVienThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVienLuu_Click(object sender, EventArgs e)
        {
            tinhTien();

            validatePhieuNhap();
        }

        private void validatePhieuNhap()
        {
            if (txtThang.Text == "")
            {
                MessageBox.Show("Nhập tháng");
                return;
            }
            if (txtNam.Text == "")
            {
                MessageBox.Show("Nhập năm");
                return;
            }
            if (txtNguoiNhap.Text == "")
            {
                MessageBox.Show("Nhập tên người nhập");
                return;
            }

            try
            {
                int thang = int.Parse(txtThang.Text);
                if (thang <= 0 && thang > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ");
                    return;
                }
            }
            catch {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            try
            {
                int nam = int.Parse(txtNam.Text);
                if (nam <= 0 && nam > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSachThietBi_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
        }

        private void gvDanhSachThietBi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            tinhTien();
        }

        private void tinhTien()
        {
            decimal tongTien = 0;
            if (gvDanhSachThietBi.RowCount > 0)
            {
                dt = gcDanhSachThietBi.DataSource as DataTable;
                
                foreach (DataRow row in dt.Rows)
                {
                    decimal soLuong = 0;
                    try
                    {
                        soLuong = decimal.Parse(row["SoLuong"].ToString());
                    } catch
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
                gcDanhSachThietBi.DataSource = dt;
                txtTongTien.Text = tongTien.ToString("#,#");



            }
        }
    }
}
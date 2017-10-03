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
using DevExpress.XtraSplashScreen;
using QuanLyNhanVien.Controllers;

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormDanhMucVanPhongPham : DevExpress.XtraEditors.XtraForm
    {
        public FormDanhMucVanPhongPham()
        {
            InitializeComponent();
        }

        private void FormDanhMucVanPhongPham_Load(object sender, EventArgs e)
        {
            loadDanhSachThietBi();
        }
        private void loadDanhSachThietBi()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            gcDanhSachThietBi.DataSource = db.T_Lib_ThietBi.Where(x => x.IsEnable == true).ToList();

        }

        private void resetFormThietBi()
        {
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtDonVi.Text = "";
            gvDanhSachThietBi.FocusedRowHandle = -1;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            resetFormThietBi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtTenThietBi.Text == "")
            {
                MessageBox.Show("Chưa nhập tên thiết bị");
                return;
            }
            if (txtDonVi.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn vị");
                return;
            }

            string tenThietBi = txtTenThietBi.Text;
            string donVi = txtDonVi.Text;

            

            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            try
            {
                if (txtMaThietBi.Text == "")
                {
                    T_Lib_ThietBi thietBi = new T_Lib_ThietBi();
                    thietBi.TenThietBi = tenThietBi;
                    thietBi.DonVi = donVi;
                    thietBi.IsEnable = true;
                    db.T_Lib_ThietBi.Add(thietBi);
                    db.SaveChanges();

                    txtMaThietBi.Text = thietBi.MaThietBi.ToString();
                }
                else
                {
                    int maThietBi = int.Parse(txtMaThietBi.Text);
                    T_Lib_ThietBi thietBi = db.T_Lib_ThietBi.Find(maThietBi);
                    thietBi.TenThietBi = tenThietBi;
                    thietBi.DonVi = donVi;
                    thietBi.IsEnable = true;
                    db.SaveChanges();
                }
                SplashScreenManager.ShowForm(typeof(SplashScreenSaveOK));
                SplashScreenManager.CloseForm(false, 1500, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            loadDanhSachThietBi();
        }

        private void gcDanhSachThietBi_Click(object sender, EventArgs e)
        {
            if (gvDanhSachThietBi.FocusedRowHandle >= 0)
            {
                string maThietBi = gvDanhSachThietBi.GetFocusedRowCellValue("MaThietBi").ToString();
                string tenThietBi = gvDanhSachThietBi.GetFocusedRowCellValue("TenThietBi").ToString();
                string donVi = gvDanhSachThietBi.GetFocusedRowCellValue("DonVi").ToString();
                txtMaThietBi.Text = maThietBi;
                txtDonVi.Text = donVi;
                txtTenThietBi.Text = tenThietBi;
            }
            else
            {
                resetFormThietBi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text == "")
            {
                MessageBox.Show("Chưa chọn dòng cần xóa");
                return;
            }
            if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa"))
            {
                try
                {
                    int maThietBi = int.Parse(gvDanhSachThietBi.GetFocusedRowCellValue("MaThietBi").ToString());
                    QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                    T_Lib_ThietBi thietBi = db.T_Lib_ThietBi.Find(maThietBi);
                    thietBi.IsEnable = false;
                    db.SaveChanges();
                    loadDanhSachThietBi();
                    resetFormThietBi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kho đã có các phiếu nhập, vui lòng xóa các phiếu nhập trước");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
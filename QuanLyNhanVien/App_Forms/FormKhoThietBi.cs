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
    public partial class FormKhoThietBi : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoThietBi()
        {
            InitializeComponent();
        }

        private void FormKhoThietBi_Load(object sender, EventArgs e)
        {
            
            loadselectKhoaPhong();
            loadDanhSachKhoThietBi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            resetFormKhoThietBi();
        }
        private void resetFormKhoThietBi()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtKyHieu.Text = "";
            gvKhoThietBi.FocusedRowHandle = -1;
        }
        private void loadselectKhoaPhong ()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            selectKhoaPhong.Properties.DataSource = db.T_KhoaPhong.OrderBy(x => x.STT).ToList();
            selectKhoaPhong.Properties.ValueMember = "MaKhoa";
            selectKhoaPhong.Properties.DisplayMember = "TenKhoa";
            
            
        }
        private void loadDanhSachKhoThietBi()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            gcKhoThietBi.DataSource = db.P_DanhSachKhoThietBi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            

            if (selectKhoaPhong.EditValue == null)
            {
                MessageBox.Show("Chưa chọn khoa phòng !");
                return;
            }
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Chưa nhập tên kho");
                return;
            }
            string maKhoa = selectKhoaPhong.EditValue.ToString();
            string tenKho = txtTenKho.Text;
            string kyHieu = txtKyHieu.Text;

            T_KhoThietBi kho = new T_KhoThietBi();
            kho.MaKhoa = maKhoa;
            kho.TenKho = tenKho;

            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            try
            {
                if (txtMaKho.Text == "")
                {
                    db.P_InsertKho(maKhoa, tenKho);
                }
                else
                {
                    int mKho = int.Parse(txtMaKho.Text);
                    db.P_UpdateKho(mKho, maKhoa, tenKho, kyHieu);


                }
                SplashScreenManager.ShowForm(typeof(SplashScreenSaveOK));
                SplashScreenManager.CloseForm(false, 1500, this);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            


            loadDanhSachKhoThietBi();

        }

        private void gcKhoThietBi_Click(object sender, EventArgs e)
        {
            if (gvKhoThietBi.FocusedRowHandle >= 0)
            {
                string maKho = gvKhoThietBi.GetFocusedRowCellValue("MaKho").ToString();
                string maKhoa = gvKhoThietBi.GetFocusedRowCellValue("MaKhoa").ToString();
                string tenKho = gvKhoThietBi.GetFocusedRowCellValue("TenKho").ToString();
                string kyHieu = gvKhoThietBi.GetFocusedRowCellValue("KyHieu").ToString();
                txtMaKho.Text = maKho;
                txtKyHieu.Text = kyHieu;
                txtTenKho.Text = tenKho;
                selectKhoaPhong.EditValue = maKhoa;
            } else
            {
                resetFormKhoThietBi();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Chưa chọn kho cần xóa");
                return;
            }
            if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa"))
            {
                try
                {
                    int maKho = int.Parse(gvKhoThietBi.GetFocusedRowCellValue("MaKho").ToString());
                    QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                    T_KhoThietBi kho = db.T_KhoThietBi.Find(maKho);
                    db.T_KhoThietBi.Remove(kho);
                    db.SaveChanges();
                    loadDanhSachKhoThietBi();
                    resetFormKhoThietBi();
                } catch (Exception ex) 
                {
                    MessageBox.Show("Kho đang được sử dụng, không thể xóa");
                }
            }
        }
    }
}
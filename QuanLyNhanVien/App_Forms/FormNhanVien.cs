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
using QuanLyNhanVien.Controllers;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                loadDanhSachNhanVien();
                loadlookupKhoaPhong();
                enableButtonTabSucKhoe();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void gcDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            
            int index = gvDanhSachNhanVien.FocusedRowHandle;

            if (index >= 0)
            {
                int maNhanVien = int.Parse(gvDanhSachNhanVien.GetFocusedRowCellValue("MaNhanVien").ToString());

                loadNhanVien(maNhanVien);

                //MessageBox.Show(maNhanVien);
            }


            
        }


        #region ## các hàm load
        private void loadNhanVien(int maNhanVien)
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            var nhanVien = db.T_NhanVien.Find(maNhanVien);
            txtMaNhanVien.EditValue = nhanVien.MaNhanVien;
            lookupKhoaPhong.EditValue = nhanVien.MaKhoa;
            txtTenNhanVien.EditValue = nhanVien.TenNhanVien;
            txtSTT.Text = nhanVien.STT.ToString();
            txtNgaySinh.EditValue = nhanVien.NgaySinh;
            txtThangSinh.EditValue = nhanVien.ThangSinh;
            txtNamSinh.EditValue = nhanVien.NamSinh;
            checkboxNguoiLaoDong.Checked = nhanVien.NguoiLaoDong ?? false;
            checkboxGioiTinhNam.Checked = nhanVien.GioiTinh ?? false;
            txtDiaChi.EditValue = nhanVien.DiaChi;
            txtCMND.EditValue = nhanVien.CMND;
            dateNgayCap.EditValue = nhanVien.NgayCap;
            txtNoiCap.EditValue = nhanVien.NoiCap;
            txtHoKhau.EditValue = nhanVien.HoKhau;
            txtChoOHienNay.EditValue = nhanVien.ChoOHienNay;
            txtNoiHoc.EditValue = nhanVien.NoiHoc;
            txtNganhHoc.EditValue = nhanVien.NganhHoc;
            dateNgayBatDauHoc.EditValue = nhanVien.NgayBatDauHoc;
            txtDiaChiHoc.EditValue = nhanVien.DiaChiHoc;
            txtCongViecTruocDay.EditValue = nhanVien.CongViecTruocDay;
            txtTienSuGiaDinh.EditValue = nhanVien.TienSuGiaDinh;
            txtTienSuBanThan.EditValue = nhanVien.TienSuBanThan;

            // load danh sách ngày sức khỏe của nhân viên

            loadDanhSachSucKhoe();

        }
        private void loadDanhSachSucKhoe()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            string selectedMaNhanVien = "0";
            int index = gvDanhSachNhanVien.FocusedRowHandle;
            if (index >= 0)
            {
                selectedMaNhanVien = gvDanhSachNhanVien.GetFocusedRowCellValue("MaNhanVien").ToString();
                int _maNhanVien = int.Parse(selectedMaNhanVien);
                var listPhieuKham = db.T_PhieuKham.Where(x => x.MaNhanVien == _maNhanVien).OrderByDescending(x => x.NgayKham).ToList();
                gcSucKhoe.DataSource = listPhieuKham;
            }
            enableButtonTabSucKhoe();
        }
        private void loadDanhSachNhanVien()
        {
            // load grid danh sánh nhân viên
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            gcDanhSachNhanVien.DataSource = db.P_DanhSachNhanVien().ToList();
            gvDanhSachNhanVien.ExpandAllGroups();
        }
        private void loadlookupKhoaPhong()
        {
            //load lookup Khoa phòng
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            lookupKhoaPhong.Properties.DataSource = db.P_DanhSachKhoaPhong();
            lookupKhoaPhong.Properties.ValueMember = "MaKhoa";
            lookupKhoaPhong.Properties.DisplayMember = "TenKhoa";

            lookupKhoaPhong.EditValue = "--";
        }

        #endregion

        #region ## các hàm reset form

        private void resetFormHanhChinh()
        {
            txtMaNhanVien.EditValue = "";
            lookupKhoaPhong.EditValue = "--";
            txtTenNhanVien.EditValue = "";
            txtNgaySinh.EditValue = "";
            txtThangSinh.EditValue = "";
            txtNamSinh.EditValue = "";
            checkboxNguoiLaoDong.CheckState = CheckState.Checked;
            checkboxGioiTinhNam.CheckState = CheckState.Checked;
            txtDiaChi.EditValue = "";
            txtCMND.EditValue = "";
            dateNgayCap.EditValue = "";
            txtNoiCap.EditValue = "";
            txtHoKhau.EditValue = "";
            txtChoOHienNay.EditValue = "";
            txtNoiHoc.EditValue = "";
            txtNganhHoc.EditValue = "";
            dateNgayBatDauHoc.EditValue = "";
            txtDiaChiHoc.EditValue = "";
            txtCongViecTruocDay.EditValue = "";
            txtTienSuGiaDinh.EditValue = "";
            txtTienSuBanThan.EditValue = "";

            txtSTT.Text = "1";
        }
        private void resetDanhSachSucKhoe()
        {
            gcSucKhoe.DataSource = null;
            enableButtonTabSucKhoe();
        }

        #endregion

        #region ## các hàm validate
        private bool validateFormHanhChinh()
        {
            errorproviderThongTinNhanVien.ClearErrors();
            bool checksum = true;
            if (lookupKhoaPhong.EditValue == null)
            {
                errorproviderThongTinNhanVien.SetError(lookupKhoaPhong, "Chọn khoa phòng");
                checksum = false;
            }
            if (txtTenNhanVien.Text == "")
            {
                errorproviderThongTinNhanVien.SetError(txtTenNhanVien, "Nhập họ và tên");
                checksum = false;
            }

            try
            {
                if (txtNgaySinh.Text != "")
                {
                    int.Parse(txtNgaySinh.Text);
                }
                
            } catch
            {
                errorproviderThongTinNhanVien.SetError(txtNgaySinh, "Ngày sinh chưa hợp lệ");
                checksum = false;
            }
            try
            {
                if (txtThangSinh.Text != "")
                {
                    int.Parse(txtThangSinh.Text);
                }

            }
            catch
            {
                errorproviderThongTinNhanVien.SetError(txtNgaySinh, "Tháng sinh chưa hợp lệ");
                checksum = false;
            }
            try
            {
                if (txtNamSinh.Text != "")
                {
                    int.Parse(txtNamSinh.Text);
                }

            }
            catch
            {
                errorproviderThongTinNhanVien.SetError(txtNgaySinh, "Năm sinh chưa hợp lệ");
                checksum = false;
            }
            try
            {
                if (txtSTT.Text != "")
                {
                    int.Parse(txtSTT.Text);
                }

            }
            catch
            {
                errorproviderThongTinNhanVien.SetError(txtSTT, "Số thứ tự chưa hợp lệ");
                checksum = false;
            }
            return checksum;
        }
        #endregion

        #region ## các hàm khác

        private void enableButtonTabSucKhoe()
        {
            if (txtMaNhanVien.Text == "")
            {
                btnTabSucKhoeThem.Enabled = false;
            } else
            {
                btnTabSucKhoeThem.Enabled = true;
            }
            if (gvSucKhoe.RowCount == 0)
            {
                btnTabSucKhoeSua.Enabled = false;
                btnCopyPhieuKham.Enabled = false;
                btnTabSucKhoeXoa.Enabled = false;
            } else
            {
                btnTabSucKhoeSua.Enabled = true;
                btnCopyPhieuKham.Enabled = true;
                btnTabSucKhoeXoa.Enabled = true;
            }
        }

        #endregion

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnTabSucKhoeThem_Click(object sender, EventArgs e)
        {
            FormNgayKham f = new FormNgayKham();           

            string selectedMaNhanVien = txtMaNhanVien.Text;            
            if (selectedMaNhanVien != "")
            {
                int _maNhanVien = int.Parse(selectedMaNhanVien);
                f.maNhanVien = _maNhanVien;
                f.ShowDialog();
                loadDanhSachSucKhoe();
                btnTabSucKhoeSua.Focus();
            }

            
        }
        

        // custom function
        
        
        
        

        private void btnNhanVienThemMoi_Click(object sender, EventArgs e)
        {
            resetFormHanhChinh();
            resetDanhSachSucKhoe();
            tabcontainerNhanVien.SelectedTabPageIndex = 0;

        }

        private void btnNhanVienLuu_Click(object sender, EventArgs e)
        {
            
            if (!validateFormHanhChinh())
            {
                return;
            }

            string maNhanVien = (txtMaNhanVien.EditValue??0).ToString();
            if (maNhanVien == "" || maNhanVien == "0")
            {
                //insert
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                T_NhanVien nhanVien = new T_NhanVien();

                //txtMaNhanVien.EditValue

                nhanVien.MaKhoa = lookupKhoaPhong.EditValue.ToString();
                nhanVien.TenNhanVien = txtTenNhanVien.Text.ToString();
                try
                {
                    nhanVien.STT = int.Parse(txtSTT.Text.ToString());
                } catch
                {
                    nhanVien.STT = 1;
                }
                

                short _ngaySinh = 0;
                short.TryParse((txtNgaySinh.EditValue??0).ToString(), out _ngaySinh);
                nhanVien.NgaySinh = _ngaySinh;

                short _thangSinh = 0;
                short.TryParse((txtThangSinh.EditValue??0).ToString(), out _thangSinh);
                nhanVien.ThangSinh = _thangSinh;

                int _namSinh = 0;
                int.TryParse((txtNamSinh.EditValue??0).ToString(), out _namSinh);
                nhanVien.NamSinh = _namSinh;

                nhanVien.NguoiLaoDong = checkboxNguoiLaoDong.Checked;
                nhanVien.GioiTinh = checkboxGioiTinhNam.Checked;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.CMND = txtCMND.Text;

                DateTime _ngayCap = DateTime.MinValue;
                DateTime.TryParse((dateNgayCap.EditValue??DateTime.MinValue).ToString(), out _ngayCap);
                nhanVien.NgayCap = _ngayCap;

                nhanVien.NoiCap = txtNoiCap.Text;
                nhanVien.HoKhau = txtHoKhau.Text;
                nhanVien.ChoOHienNay = txtChoOHienNay.Text;
                nhanVien.NoiHoc = txtNoiHoc.Text;
                nhanVien.NganhHoc = txtNganhHoc.Text;
                
                DateTime _ngayBatDauHoc = DateTime.MinValue;
                DateTime.TryParse((dateNgayBatDauHoc.EditValue??DateTime.MinValue).ToString(), out _ngayBatDauHoc);
                nhanVien.NgayBatDauHoc = _ngayBatDauHoc;

                nhanVien.DiaChiHoc = txtDiaChiHoc.Text;
                nhanVien.CongViecTruocDay = txtCongViecTruocDay.Text;
                nhanVien.TienSuGiaDinh = txtTienSuGiaDinh.Text;
                nhanVien.TienSuBanThan = txtTienSuBanThan.Text;

                db.T_NhanVien.Add(nhanVien);

                
                db.SaveChanges();

                
                loadNhanVien(nhanVien.MaNhanVien);

                SplashScreenManager.ShowForm(typeof(SplashScreenSaveOK));
                SplashScreenManager.CloseForm(false, 1500, this);



            }
            else
            {
                //update
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                T_NhanVien nhanVien = db.T_NhanVien.Find(int.Parse(maNhanVien));

                //txtMaNhanVien.EditValue

                nhanVien.MaKhoa = lookupKhoaPhong.EditValue.ToString();
                nhanVien.TenNhanVien = txtTenNhanVien.EditValue.ToString();

                try
                {
                    nhanVien.STT = int.Parse(txtSTT.Text.ToString());
                }
                catch
                {
                    nhanVien.STT = 1;
                }

                short _ngaySinh = 0;
                short.TryParse((txtNgaySinh.EditValue ?? 0).ToString(), out _ngaySinh);
                nhanVien.NgaySinh = _ngaySinh;

                short _thangSinh = 0;
                short.TryParse((txtThangSinh.EditValue ?? 0).ToString(), out _thangSinh);
                nhanVien.ThangSinh = _thangSinh;

                int _namSinh = 0;
                int.TryParse((txtNamSinh.EditValue ?? 0).ToString(), out _namSinh);
                nhanVien.NamSinh = _namSinh;

                nhanVien.NguoiLaoDong = checkboxNguoiLaoDong.Checked;
                nhanVien.GioiTinh = checkboxGioiTinhNam.Checked;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.CMND = txtCMND.Text;

                DateTime _ngayCap = DateTime.MinValue;
                DateTime.TryParse((dateNgayCap.EditValue ?? DateTime.MinValue).ToString(), out _ngayCap);
                nhanVien.NgayCap = _ngayCap;

                nhanVien.NoiCap = txtNoiCap.Text;
                nhanVien.HoKhau = txtHoKhau.Text;
                nhanVien.ChoOHienNay = txtChoOHienNay.Text;
                nhanVien.NoiHoc = txtNoiHoc.Text;
                nhanVien.NganhHoc = txtNganhHoc.Text;

                DateTime _ngayBatDauHoc = DateTime.MinValue;
                DateTime.TryParse((dateNgayBatDauHoc.EditValue ?? DateTime.MinValue).ToString(), out _ngayBatDauHoc);
                nhanVien.NgayBatDauHoc = _ngayBatDauHoc;

                nhanVien.DiaChiHoc = txtDiaChiHoc.Text;
                nhanVien.CongViecTruocDay = txtCongViecTruocDay.Text;
                nhanVien.TienSuGiaDinh = txtTienSuGiaDinh.Text;
                nhanVien.TienSuBanThan = txtTienSuBanThan.Text;

                db.SaveChanges();

                SplashScreenManager.ShowForm(typeof(SplashScreenSaveOK));
                SplashScreenManager.CloseForm(false, 1000, this);


            }
            loadDanhSachNhanVien();
        }

        private void btnNhanVienXoa_Click(object sender, EventArgs e)
        {
            int maNhanVien = 0;
            int.TryParse(txtMaNhanVien.Text, out maNhanVien);
            if (maNhanVien > 0)
            {
                if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa"))
                {
                    QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                    T_NhanVien nv = db.T_NhanVien.Find(maNhanVien);
                    
                    var listPK = db.T_PhieuKham.Where(x => x.MaNhanVien == nv.MaNhanVien).ToList();
                    if (listPK.Any())
                    {
                        db.T_PhieuKham.RemoveRange(listPK);
                    }
                    db.T_NhanVien.Remove(nv);
                    db.SaveChanges();
                    loadDanhSachNhanVien();
                    resetFormHanhChinh();
                    MessageBox.Show("Đã xóa nhân viên.");
                }
            } else
            {
                MyMessageBox.ShowError("Chưa chọn nhân viên cần xóa");
            }
        }

        private void gcSucKhoe_DoubleClick(object sender, EventArgs e)
        {
            loadPhieuKham();
        }

        private void btnTabSucKhoeSua_Click(object sender, EventArgs e)
        {
            loadPhieuKham();
        }

        private void loadPhieuKham()
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            string selectedID = "0";
            string selectedMaNhanVien = "0";
            int index = gvSucKhoe.FocusedRowHandle;
            if (index >= 0)
            {
                selectedID = gvSucKhoe.GetFocusedRowCellValue("MaPhieuKham").ToString();
                selectedMaNhanVien = gvSucKhoe.GetFocusedRowCellValue("MaNhanVien").ToString();
                FormPhieuKham f = new FormPhieuKham();
                f.txtID.Text = selectedID;
                f.intMaNhanVien = int.Parse(selectedMaNhanVien);
                f.ShowDialog();
                int _maNhanVien = int.Parse(selectedMaNhanVien);
                var listPhieuKham = db.T_PhieuKham.Where(x => x.MaNhanVien == _maNhanVien).OrderByDescending(x => x.NgayKham).ToList();
                gcSucKhoe.DataSource = listPhieuKham;
            }
        }

        private void btnTabSucKhoeXoa_Click(object sender, EventArgs e)
        {


            if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa ?"))
            {
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                int index = gvSucKhoe.FocusedRowHandle;
                string selectedID = "0";
                if (index >= 0)
                {
                    selectedID = gvSucKhoe.GetFocusedRowCellValue("MaPhieuKham").ToString();
                    int _id = int.Parse(selectedID);
                    T_PhieuKham pk = db.T_PhieuKham.Find(_id);
                    db.T_PhieuKham.Remove(pk);
                    db.SaveChanges();

                    loadDanhSachSucKhoe();
                }
            }
            
        }

        private void btnNhanVienHuyBo_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                resetFormHanhChinh();
            } else
            {
                
                loadNhanVien(int.Parse(txtMaNhanVien.Text));
            }
        }

        private void btnCopyPhieuKham_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                string selectedIDPK = "0";

                int index = gvSucKhoe.FocusedRowHandle;
                if (index >= 0)
                {
                    selectedIDPK = gvSucKhoe.GetFocusedRowCellValue("MaPhieuKham").ToString();

                    FormCopyPhieuKham f = new FormCopyPhieuKham();
                    f.idPK = int.Parse(selectedIDPK);
                    f.ShowDialog();
                    loadDanhSachSucKhoe();                    
                }
            } catch ( Exception ex )
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
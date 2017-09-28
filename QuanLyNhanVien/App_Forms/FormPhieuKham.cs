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

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormPhieuKham : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
        public int intMaNhanVien = 0;
        public FormPhieuKham()
        {
            InitializeComponent();
        }

        private void FormPhieuKham_Load(object sender, EventArgs e)
        {
            //load
            try
            {


                // insert update

                int idPhieuKham = int.Parse(txtID.Text);
                
                if (intMaNhanVien >= 0)
                {
                    T_NhanVien nhanVien = db.T_NhanVien.Find(intMaNhanVien);
                    T_PhieuKham pk = db.T_PhieuKham.Find(idPhieuKham);
                    //người lao động
                    if (nhanVien.NguoiLaoDong != false)
                    {
                        radioHocSinhSinhVien.Checked = false;
                        radioNguoiLaoDong.Checked = true;
                    }
                    else
                    {
                        radioHocSinhSinhVien.Checked = true;
                        radioNguoiLaoDong.Checked = false;
                    }
                    // label họ tên
                    lblTenNhanVien.Text = nhanVien.TenNhanVien;
                    //ngày khám
                    dateNgayKham.DateTime = pk.NgayKham;

                    // khám thể lực
                    txtTLChieuCao.Text = pk.TL_ChieuCao;
                    txtTLCanNang.Text = pk.TL_CanNang;
                    txtTLVongNgucTrungBinh.Text = pk.TL_VongNgucTB;
                    txtTLChiSoBMI.Text = pk.TL_ChiSoBMI;
                    txtTLMach.Text = pk.TL_Mach;
                    txtTLHuyetAp.Text = pk.TL_HuyetAp;
                    txtTLNhietDo.Text = pk.TL_NhietDo;
                    txtTLNhipTho.Text = pk.TL_NhipTho;
                    txtTLPhanLoaiSucKhoe.Text = pk.TL_PhanLoai;
                    txtTLBacSiKham.Text = pk.TL_BacSi;

                    // khám lâm sàng

                    txtLSTuanHoan.Text = pk.LS_TuanHoan;
                    txtLSTuanHoanPhanLoai.Text = pk.LS_TuanHoan_PhanLoai;
                    txtLSTuanHoanBacSiKham.Text = pk.LS_TuanHoan_BacSi;

                    txtLSHoHap.Text = pk.LS_HoHap;
                    txtLSHoHapPhanLoai.Text = pk.LS_HoHap_PhanLoai;
                    txtLSHoHapBacSiKham.Text = pk.LS_HoHap_BacSi;

                    txtLSTieuHoa.Text = pk.LS_TieuHoa;
                    txtLSTieuHoaPhanLoai.Text = pk.LS_TieuHoa_PhanLoai;
                    txtLSTieuHoaBacSiKham.Text = pk.LS_TieuHoa_BacSi;

                    txtLSThanTietNieuSD.Text = pk.LS_ThanTietNieu;
                    txtLSThanTietNieuSDPhanLoai.Text = pk.LS_ThanTietNieu_PhanLoai;
                    txtLSThanTietNieuSDBacSiKham.Text = pk.LS_ThanTietNieu_BacSi;

                    txtLSThanKinh.Text = pk.LS_ThanKinh;
                    txtLSThanKinhPhanLoai.Text = pk.LS_ThanKinh_PhanLoai;
                    txtLSThanKinhBacSiKham.Text = pk.LS_ThanKinh_BacSi;

                    txtLSTamThan.Text = pk.LS_TamThan;
                    txtLSTamThanPhanLoai.Text = pk.LS_TamThan_PhanLoai;
                    txtLSTamThanBacSiKham.Text = pk.LS_TamThan_BacSi;

                    txtLSHeVanDong.Text = pk.LS_HeVanDong;
                    txtLSHeVanDongPhanLoai.Text = pk.LS_HeVanDong_PhanLoai;
                    txtLSHeVanDongBacSiKham.Text = pk.LS_HeVanDong_BacSi;

                    txtLSNoiTiet.Text = pk.LS_NoiTiet;
                    txtLSNoiTietPhanLoai.Text = pk.LS_NoiTiet_PhanLoai;
                    txtLSNoiTietBacSiKham.Text = pk.LS_NoiTiet_BacSi;

                    txtLSDaLieu.Text = pk.LS_DaLieu;
                    txtLSDaLieuPhanLoai.Text = pk.LS_DaLieu_PhanLoai;
                    txtLSDaLieuBacSiKham.Text = pk.LS_DaLieu_BacSi;

                    txtLSNgoaiKhoa.Text = pk.LS_NgoaiKhoa;
                    txtLSNgoaiKhoaPhanLoai.Text = pk.LS_NgoaiKhoa_PhanLoai;
                    txtLSNgoaiKhoaBacSiKham.Text = pk.LS_NgoaiKhoa_BacSiKham;

                    txtLSSanPhuKhoa.Text = pk.LS_SanPhuKhoa;
                    txtLSSanPhuKhoaPhanLoai.Text = pk.LS_SanPhuKhoa_PhanLoai;
                    txtLSSanPhuKhoaBacSiKham.Text = pk.LS_SanPhuKhoa_BacSi;

                    txtLSMatKhongKinhMatPhai.Text = pk.LS_Mat_KhongKinh_MatPhai;
                    txtLSMatKhongKinhMatTrai.Text = pk.LS_Mat_KhongKinh_MatTrai;
                    txtLSMatCoKinhMatPhai.Text = pk.LS_Mat_CoKinh_MatPhai;
                    txtLSMatCoKinhMatTrai.Text = pk.LS_Mat_CoKinh_MatTrai;
                    txtLSMatCacBenhVeMat.Text = pk.LS_Mat;
                    txtLSMatPhanLoai.Text = pk.LS_Mat_PhanLoai;
                    txtLSMatBacSiKham.Text = pk.LS_Mat_BacSi;

                    txtLSTMHTaiTraiNoiThuong.Text = pk.LS_TaiMuiHong_TaiTraiNoiThuong;
                    txtLSTMHTaiPhaiNoiThuong.Text = pk.LS_TaiMuiHong_TaiPhaiNoiThuong;
                    txtLSTMHTaiTraiNoiTham.Text = pk.LS_TaiMuiHong_TaiTraiNoiTham;
                    txtLSTMHTaiPhaiNoiTham.Text = pk.LS_TaiMuiHong_TaiPhaiNoiTham;
                    txtLSTMHCacBenhTaiMuiHong.Text = pk.LS_TaiMuiHong;
                    txtLSTMHPhanLoai.Text = pk.LS_TaiMuiHong_PhanLoai;
                    txtLSTMHBacSiKham.Text = pk.LS_TaiMuiHong_BacSiKham;

                    txtLSRHM.Text = pk.LS_RangHamMat;
                    txtLSRHMPhanLoai.Text = pk.LS_RangHamMat_PhanLoai;
                    txtLSRHMBacSiKham.Text = pk.LS_RangHamMat_BacSi;

                    txtCLSXetNghiemMauSoLuongHC.Text = pk.CLS_XetNghiemMau_SoLuongHC;
                    txtCLSXetNghiemMauSoLuongBC.Text = pk.CLS_XetNghiemMau_BachCau;
                    txtCLSXetNghiemMauSoLuongTC.Text = pk.CLS_XetNghiemMau_TieuCau;
                    txtCLSXetNghiemMauDuongMau.Text = pk.CLS_XetNghiemMau_DuongMau;
                    txtCLSXetNghiemMauKhac.Text = pk.CLS_XetNghiemMau_Khac;

                    txtCLSXetNghiemNuocTieuDuong.Text = pk.CLS_XetNghiemNuocTieu_Duong;
                    txtCLSXetNghiemNuocTieuProtein.Text = pk.CLS_XetNghiemNuocTieu_Protein;
                    txtCLSXetNghiemNuocTieuKhac.Text = pk.CLS_XetNghiemNuocTieu_Khac;

                    if (pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_BinhThuong != false)
                    {
                        radioCLSXQuangBinhThuong.Checked = true;
                        radioCLSXQuangKhongBinhThuong.Checked = false;
                    }
                    else
                    {
                        radioCLSXQuangBinhThuong.Checked = false;
                        radioCLSXQuangKhongBinhThuong.Checked = true;
                    }

                    txtCLSXQuangGhiCuThe.Text = pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_CuThe;
                    txtCLSXQuangKhac.Text = pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_Khac;
                    txtCLSHoTenNguoiGhi.Text = pk.CLS_NguoiGhiKetQua;



                    if (pk.KL_KhoeManh != false)
                    {
                        radioKLKhoeManh.Checked = true;
                        radioKLMacBenh.Checked = false;
                    }
                    else
                    {
                        radioKLKhoeManh.Checked = false;
                        radioKLMacBenh.Checked = true;
                    }
                    txtKLTenBenh.Text = pk.KL_TenBenh;

                    txtKLDatSucKhoeLoai.Text = pk.KL_DatSucKhoeLoai;
                    if (pk.KL_DuDieuKienSucKhoe != false)
                    {
                        checkboxDuDieuKienSucKhoe.Checked = true;
                    }
                    else
                    {
                        checkboxDuDieuKienSucKhoe.Checked = false;
                    }

                    txtMoTaKetLuan.Text = pk.KL_MoTa;

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }

        }


        private void setTocKyTextBox(TextBox textbox, KeyEventArgs e, int loai)
        {
            if ((e.KeyCode == Keys.Enter) && (textbox.Text == ""))
            {
                //    this.SelectNextControl((Control)sender, true, true, true, true);
                FormTocKy f = new FormTocKy();
                f.intLoai = loai;
                f.ShowDialog();
                textbox.Text = f.outText;
            }
        }

        


        private void txtLSTuanHoan_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTuanHoan, e, 1);
        }
        private void txtLSTuanHoanPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTuanHoanPhanLoai, e, 2);
        }
        private void txtLSTuanHoanBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTuanHoanBacSiKham, e, 3);
        }
        private void txtLSHoHap_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHoHap, e, 1);
        }
        private void txtLSHoHapPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHoHapPhanLoai, e, 2);
        }
        private void txtLSHoHapBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHoHapBacSiKham, e, 3);
        }
        private void txtLSTieuHoa_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTieuHoa, e, 1);
        }
        private void txtLSTieuHoaPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTieuHoaPhanLoai, e, 2);
        }
        private void txtLSTieuHoaBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTieuHoaBacSiKham, e, 3);
        }
        private void txtLSThanTietNieuSD_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanTietNieuSD, e, 1);
        }
        private void txtLSThanTietNieuSDPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanTietNieuSDPhanLoai, e, 2);
        }
        private void txtLSThanTietNieuSDBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanTietNieuSDBacSiKham, e, 3);
        }
        private void txtLSThanKinh_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanKinh, e, 1);
        }
        private void txtLSThanKinhPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanKinhPhanLoai, e, 2);
        }
        private void txtLSThanKinhBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSThanKinhBacSiKham, e, 3);
        }
        private void txtLSTamThan_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTamThan, e, 1);
        }
        private void txtLSTamThanPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTamThanPhanLoai, e, 2);
        }
        private void txtLSTamThanBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTamThanBacSiKham, e, 3);
        }
        private void txtLSHeVanDong_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHeVanDong, e, 1);
        }
        private void txtLSHeVanDongPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHeVanDongPhanLoai, e, 2);
        }
        private void txtLSHeVanDongBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSHeVanDongBacSiKham, e, 3);
        }
        private void txtLSNoiTiet_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNoiTiet, e, 1);
        }
        private void txtLSNoiTietPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNoiTietPhanLoai, e, 2);
        }
        private void txtLSNoiTietBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNoiTietBacSiKham, e, 3);
        }
        private void txtLSDaLieu_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSDaLieu, e, 1);
        }
        private void txtLSDaLieuPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSDaLieuPhanLoai, e, 2);
        }
        private void txtLSDaLieuBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSDaLieuBacSiKham, e, 3);
        }

        private void txtLSNgoaiKhoa_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNgoaiKhoa, e, 1);
        }
        private void txtLSNgoaiKhoaPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNgoaiKhoaPhanLoai, e, 2);
        }
        private void txtLSNgoaiKhoaBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSNgoaiKhoaBacSiKham, e, 3);
        }

        private void txtLSSanPhuKhoa_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSSanPhuKhoa, e, 1);
        }
        private void txtLSSanPhuKhoaPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSSanPhuKhoaPhanLoai, e, 2);
        }
        private void txtLSSanPhuKhoaBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSSanPhuKhoaBacSiKham, e, 3);
        }
        private void txtLSMatKhongKinhMatPhai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatKhongKinhMatPhai, e, 1);
        }
        private void txtLSMatKhongKinhMatTrai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatKhongKinhMatTrai, e, 1);
        }
        private void txtLSMatCoKinhMatPhai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatCoKinhMatPhai, e, 1);
        }
        private void txtLSMatCoKinhMatTrai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatCoKinhMatTrai, e, 1);
        }
        private void txtLSMatCacBenhVeMat_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatCacBenhVeMat, e, 1);
        }
        private void txtLSMatPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatPhanLoai, e, 2);
        }
        private void txtLSMatBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSMatBacSiKham, e, 3);
        }
        private void txtLSTMHTaiTraiNoiThuong_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHTaiTraiNoiThuong, e, 1);
        }
        private void txtLSTMHTaiPhaiNoiThuong_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHTaiPhaiNoiThuong, e, 1);
        }
        private void txtLSTMHTaiTraiNoiTham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHTaiTraiNoiTham, e, 1);
        }
        private void txtLSTMHTaiPhaiNoiTham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHTaiPhaiNoiTham, e, 1);
        }
        private void txtLSTMHCacBenhTaiMuiHong_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHCacBenhTaiMuiHong, e, 1);
        }
        private void txtLSTMHPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHPhanLoai, e, 2);
        }
        private void txtLSTMHBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSTMHBacSiKham, e, 3);
        }
        private void txtLSRHM_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSRHM, e, 1);
        }
        private void txtLSRHMPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSRHMPhanLoai, e, 2);
        }
        private void txtLSRHMBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtLSRHMBacSiKham, e, 3);
        }
        private void txtTLPhanLoaiSucKhoe_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtTLPhanLoaiSucKhoe, e, 2);
        }
        private void txtTLBacSiKham_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtTLBacSiKham, e, 3);
        }
        private void txtCLSXetNghiemMauSoLuongHC_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemMauSoLuongHC, e, 1);
        }
        private void txtCLSXetNghiemMauSoLuongBC_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemMauSoLuongBC, e, 1);
        }
        private void txtCLSXetNghiemMauSoLuongTC_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemMauSoLuongTC, e, 1);
        }
        private void txtCLSXetNghiemMauDuongMau_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemMauDuongMau, e, 1);
        }
        private void txtCLSXetNghiemMauKhac_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemMauKhac, e, 1);
        }
        private void txtCLSXetNghiemNuocTieuDuong_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemNuocTieuDuong, e, 1);
        }
        private void txtCLSXetNghiemNuocTieuProtein_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemNuocTieuProtein, e, 1);
        }
        private void txtCLSXetNghiemNuocTieuKhac_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXetNghiemNuocTieuKhac, e, 1);
        }
        private void txtCLSXQuangGhiCuThe_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXQuangGhiCuThe, e, 1);
        }
        private void txtCLSXQuangKhac_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSXQuangKhac, e, 1);
        }
        private void txtCLSHoTenNguoiGhi_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtCLSHoTenNguoiGhi, e, 3);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            try
            {
                 
                int idPhieuKham = int.Parse(txtID.Text);
                T_PhieuKham pk = db.T_PhieuKham.Find(idPhieuKham);



                pk.NgayKham = dateNgayKham.DateTime;

                // khám thể lực
                pk.TL_ChieuCao = txtTLChieuCao.Text;
                pk.TL_CanNang = txtTLCanNang.Text;
                pk.TL_VongNgucTB = txtTLVongNgucTrungBinh.Text;
                pk.TL_ChiSoBMI = txtTLChiSoBMI.Text;
                pk.TL_Mach = txtTLMach.Text;
                pk.TL_HuyetAp = txtTLHuyetAp.Text;
                pk.TL_NhietDo = txtTLNhietDo.Text;
                pk.TL_NhipTho = txtTLNhipTho.Text;
                pk.TL_PhanLoai = txtTLPhanLoaiSucKhoe.Text;
                pk.TL_BacSi = txtTLBacSiKham.Text;


                // khám lâm sàng

                pk.LS_TuanHoan = txtLSTuanHoan.Text;
                pk.LS_TuanHoan_PhanLoai = txtLSTuanHoanPhanLoai.Text;
                pk.LS_TuanHoan_BacSi = txtLSTuanHoanBacSiKham.Text;

                pk.LS_HoHap = txtLSHoHap.Text;
                pk.LS_HoHap_PhanLoai = txtLSHoHapPhanLoai.Text;
                pk.LS_HoHap_BacSi = txtLSHoHapBacSiKham.Text;

                pk.LS_TieuHoa = txtLSTieuHoa.Text;
                pk.LS_TieuHoa_PhanLoai = txtLSTieuHoaPhanLoai.Text;
                pk.LS_TieuHoa_BacSi = txtLSTieuHoaBacSiKham.Text;

                pk.LS_ThanTietNieu = txtLSThanTietNieuSD.Text;
                pk.LS_ThanTietNieu_PhanLoai = txtLSThanTietNieuSDPhanLoai.Text;
                pk.LS_ThanTietNieu_BacSi = txtLSThanTietNieuSDBacSiKham.Text;

                pk.LS_ThanKinh = txtLSThanKinh.Text;
                pk.LS_ThanKinh_PhanLoai = txtLSThanKinhPhanLoai.Text;
                pk.LS_ThanKinh_BacSi = txtLSThanKinhBacSiKham.Text;

                pk.LS_TamThan = txtLSTamThan.Text;
                pk.LS_TamThan_PhanLoai = txtLSTamThanPhanLoai.Text;
                pk.LS_TamThan_BacSi = txtLSTamThanBacSiKham.Text;

                pk.LS_HeVanDong = txtLSHeVanDong.Text;
                pk.LS_HeVanDong_PhanLoai = txtLSHeVanDongPhanLoai.Text;
                pk.LS_HeVanDong_BacSi = txtLSHeVanDongBacSiKham.Text;

                pk.LS_NoiTiet = txtLSNoiTiet.Text;
                pk.LS_NoiTiet_PhanLoai = txtLSNoiTietPhanLoai.Text;
                pk.LS_NoiTiet_BacSi = txtLSNoiTietBacSiKham.Text;

                pk.LS_DaLieu = txtLSDaLieu.Text;
                pk.LS_DaLieu_PhanLoai = txtLSDaLieuPhanLoai.Text;
                pk.LS_DaLieu_BacSi = txtLSDaLieuBacSiKham.Text;

                pk.LS_NgoaiKhoa = txtLSNgoaiKhoa.Text;
                pk.LS_NgoaiKhoa_PhanLoai = txtLSNgoaiKhoaPhanLoai.Text;
                pk.LS_NgoaiKhoa_BacSiKham = txtLSNgoaiKhoaBacSiKham.Text;

                pk.LS_SanPhuKhoa = txtLSSanPhuKhoa.Text;
                pk.LS_SanPhuKhoa_PhanLoai = txtLSSanPhuKhoaPhanLoai.Text;
                pk.LS_SanPhuKhoa_BacSi = txtLSSanPhuKhoaBacSiKham.Text;

                pk.LS_Mat_KhongKinh_MatPhai = txtLSMatKhongKinhMatPhai.Text;
                pk.LS_Mat_KhongKinh_MatTrai = txtLSMatKhongKinhMatTrai.Text;
                pk.LS_Mat_CoKinh_MatPhai = txtLSMatCoKinhMatPhai.Text;
                pk.LS_Mat_CoKinh_MatTrai = txtLSMatCoKinhMatTrai.Text;
                pk.LS_Mat = txtLSMatCacBenhVeMat.Text;
                pk.LS_Mat_PhanLoai = txtLSMatPhanLoai.Text;
                pk.LS_Mat_BacSi = txtLSMatBacSiKham.Text;

                pk.LS_TaiMuiHong_TaiTraiNoiThuong = txtLSTMHTaiTraiNoiThuong.Text;
                pk.LS_TaiMuiHong_TaiPhaiNoiThuong = txtLSTMHTaiPhaiNoiThuong.Text;
                pk.LS_TaiMuiHong_TaiTraiNoiTham = txtLSTMHTaiTraiNoiTham.Text;
                pk.LS_TaiMuiHong_TaiPhaiNoiTham = txtLSTMHTaiPhaiNoiTham.Text;
                pk.LS_TaiMuiHong = txtLSTMHCacBenhTaiMuiHong.Text;
                pk.LS_TaiMuiHong_PhanLoai = txtLSTMHPhanLoai.Text;
                pk.LS_TaiMuiHong_BacSiKham = txtLSTMHBacSiKham.Text;

                pk.LS_RangHamMat = txtLSRHM.Text;
                pk.LS_RangHamMat_PhanLoai = txtLSRHMPhanLoai.Text;
                pk.LS_RangHamMat_BacSi = txtLSRHMBacSiKham.Text;

                pk.CLS_XetNghiemMau_SoLuongHC = txtCLSXetNghiemMauSoLuongHC.Text;
                pk.CLS_XetNghiemMau_BachCau = txtCLSXetNghiemMauSoLuongBC.Text;
                pk.CLS_XetNghiemMau_TieuCau = txtCLSXetNghiemMauSoLuongTC.Text;
                pk.CLS_XetNghiemMau_DuongMau = txtCLSXetNghiemMauDuongMau.Text;
                pk.CLS_XetNghiemMau_Khac = txtCLSXetNghiemMauKhac.Text;

                pk.CLS_XetNghiemNuocTieu_Duong = txtCLSXetNghiemNuocTieuDuong.Text;
                pk.CLS_XetNghiemNuocTieu_Protein = txtCLSXetNghiemNuocTieuProtein.Text;
                pk.CLS_XetNghiemNuocTieu_Khac = txtCLSXetNghiemNuocTieuKhac.Text;

                pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_BinhThuong = radioCLSXQuangBinhThuong.Checked;


                pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_CuThe = txtCLSXQuangGhiCuThe.Text;
                pk.CLS_ChanDoanHinhAnh_XQuangTimPhoi_Khac = txtCLSXQuangKhac.Text;
                pk.CLS_NguoiGhiKetQua = txtCLSHoTenNguoiGhi.Text;


                pk.KL_KhoeManh = radioKLKhoeManh.Checked;
                pk.KL_TenBenh = txtKLTenBenh.Text;
                pk.KL_DatSucKhoeLoai = txtKLDatSucKhoeLoai.Text;
                pk.KL_DuDieuKienSucKhoe = checkboxDuDieuKienSucKhoe.Checked;
                pk.KL_MoTa = txtMoTaKetLuan.Text;

                db.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu thành công");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.ShowConfirm("Bạn thật sự muốn xóa"))
            {
                int id = int.Parse(txtID.Text);
                
                T_PhieuKham pk = db.T_PhieuKham.Find(id);
                db.T_PhieuKham.Remove(pk);
                db.SaveChanges();
                this.Close();
            }
        }

        private void txtCLSHoTenNguoiGhi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKLDatSucKhoeLoai_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtKLDatSucKhoeLoai, e, 2);
        }



        private void txtMoTaKetLuan_KeyUp(object sender, KeyEventArgs e)
        {
            setTocKyTextBox(txtMoTaKetLuan, e, 4);
        }
    }
}
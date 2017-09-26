namespace QuanLyNhanVien.App_Forms
{
    partial class FormBaoCaoDanhSachSucKhoe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCaoDanhSachSucKhoe));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.selectBaoCaoTheo = new System.Windows.Forms.ComboBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachSucKhoe = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachSucKhoe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDSSKMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKGioiTinhNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKGioiTinhNu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKNgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKChieuCao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKCanNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKTLPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSTuanHoanPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSHoHapPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSTieuHoaPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSThanTietNieuPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSThanKinhPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSTamThanPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSHeVanDongPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSNoiTietPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSDaLieuPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSNgoaiKhoaPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSSanPhuKhoaPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSMatPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSTaiMuiHongPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKLSRangHamMatPhanLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKCLSXQuangTimPhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKKLKhoeManh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKKLTenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKKLDatSucKhoeLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKKLMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSSKKLDuDieuKienSucKhoe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectNam = new System.Windows.Forms.ComboBox();
            this.btnInDanhSach = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachSucKhoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSucKhoe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Báo cáo theo:";
            // 
            // selectBaoCaoTheo
            // 
            this.selectBaoCaoTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBaoCaoTheo.FormattingEnabled = true;
            this.selectBaoCaoTheo.Items.AddRange(new object[] {
            "Danh sức khỏe mới nhất",
            "Năm"});
            this.selectBaoCaoTheo.Location = new System.Drawing.Point(85, 9);
            this.selectBaoCaoTheo.Name = "selectBaoCaoTheo";
            this.selectBaoCaoTheo.Size = new System.Drawing.Size(145, 21);
            this.selectBaoCaoTheo.TabIndex = 1;
            this.selectBaoCaoTheo.SelectedIndexChanged += new System.EventHandler(this.selectBaoCaoTheo_SelectedIndexChanged);
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(314, 9);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 34);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(418, 9);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 34);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            // 
            // gcDanhSachSucKhoe
            // 
            this.gcDanhSachSucKhoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachSucKhoe.Location = new System.Drawing.Point(12, 49);
            this.gcDanhSachSucKhoe.MainView = this.gvDanhSachSucKhoe;
            this.gcDanhSachSucKhoe.Name = "gcDanhSachSucKhoe";
            this.gcDanhSachSucKhoe.Size = new System.Drawing.Size(625, 319);
            this.gcDanhSachSucKhoe.TabIndex = 3;
            this.gcDanhSachSucKhoe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachSucKhoe});
            // 
            // gvDanhSachSucKhoe
            // 
            this.gvDanhSachSucKhoe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDSSKMaNhanVien,
            this.colDSSKMaKhoa,
            this.colDSSKTenKhoa,
            this.colDSSKTenNhanVien,
            this.colDSSKGioiTinhNam,
            this.colDSSKGioiTinhNu,
            this.colDSSKNgayKham,
            this.colDSSKChieuCao,
            this.colDSSKCanNang,
            this.colDSSKTLPhanLoai,
            this.colDSSKLSTuanHoanPhanLoai,
            this.colDSSKLSHoHapPhanLoai,
            this.colDSSKLSTieuHoaPhanLoai,
            this.colDSSKLSThanTietNieuPhanLoai,
            this.colDSSKLSThanKinhPhanLoai,
            this.colDSSKLSTamThanPhanLoai,
            this.colDSSKLSHeVanDongPhanLoai,
            this.colDSSKLSNoiTietPhanLoai,
            this.colDSSKLSDaLieuPhanLoai,
            this.colDSSKLSNgoaiKhoaPhanLoai,
            this.colDSSKLSSanPhuKhoaPhanLoai,
            this.colDSSKLSMatPhanLoai,
            this.colDSSKLSTaiMuiHongPhanLoai,
            this.colDSSKLSRangHamMatPhanLoai,
            this.colDSSKCLSXQuangTimPhoi,
            this.colDSSKKLKhoeManh,
            this.colDSSKKLTenBenh,
            this.colDSSKKLDatSucKhoeLoai,
            this.colDSSKKLMoTa,
            this.colDSSKKLDuDieuKienSucKhoe});
            this.gvDanhSachSucKhoe.GridControl = this.gcDanhSachSucKhoe;
            this.gvDanhSachSucKhoe.GroupCount = 1;
            this.gvDanhSachSucKhoe.Name = "gvDanhSachSucKhoe";
            this.gvDanhSachSucKhoe.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvDanhSachSucKhoe.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDSSKTenKhoa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDSSKMaNhanVien
            // 
            this.colDSSKMaNhanVien.Caption = "Mã NV";
            this.colDSSKMaNhanVien.FieldName = "MaNhanVien";
            this.colDSSKMaNhanVien.Name = "colDSSKMaNhanVien";
            // 
            // colDSSKMaKhoa
            // 
            this.colDSSKMaKhoa.Caption = "Mã khoa";
            this.colDSSKMaKhoa.FieldName = "MaKhoa";
            this.colDSSKMaKhoa.Name = "colDSSKMaKhoa";
            // 
            // colDSSKTenKhoa
            // 
            this.colDSSKTenKhoa.Caption = "Khoa";
            this.colDSSKTenKhoa.FieldName = "TenKhoa";
            this.colDSSKTenKhoa.Name = "colDSSKTenKhoa";
            this.colDSSKTenKhoa.Visible = true;
            this.colDSSKTenKhoa.VisibleIndex = 2;
            // 
            // colDSSKTenNhanVien
            // 
            this.colDSSKTenNhanVien.Caption = "Tên NV";
            this.colDSSKTenNhanVien.FieldName = "TenNhanVien";
            this.colDSSKTenNhanVien.Name = "colDSSKTenNhanVien";
            this.colDSSKTenNhanVien.Visible = true;
            this.colDSSKTenNhanVien.VisibleIndex = 0;
            this.colDSSKTenNhanVien.Width = 172;
            // 
            // colDSSKGioiTinhNam
            // 
            this.colDSSKGioiTinhNam.Caption = "Nam";
            this.colDSSKGioiTinhNam.FieldName = "GioiTinh_Nam";
            this.colDSSKGioiTinhNam.Name = "colDSSKGioiTinhNam";
            this.colDSSKGioiTinhNam.Visible = true;
            this.colDSSKGioiTinhNam.VisibleIndex = 1;
            this.colDSSKGioiTinhNam.Width = 49;
            // 
            // colDSSKGioiTinhNu
            // 
            this.colDSSKGioiTinhNu.Caption = "Nữ";
            this.colDSSKGioiTinhNu.FieldName = "GioiTinh_Nu";
            this.colDSSKGioiTinhNu.Name = "colDSSKGioiTinhNu";
            this.colDSSKGioiTinhNu.Visible = true;
            this.colDSSKGioiTinhNu.VisibleIndex = 2;
            this.colDSSKGioiTinhNu.Width = 46;
            // 
            // colDSSKNgayKham
            // 
            this.colDSSKNgayKham.Caption = "Ngày khám";
            this.colDSSKNgayKham.FieldName = "NgayKham";
            this.colDSSKNgayKham.Name = "colDSSKNgayKham";
            this.colDSSKNgayKham.Visible = true;
            this.colDSSKNgayKham.VisibleIndex = 3;
            this.colDSSKNgayKham.Width = 82;
            // 
            // colDSSKChieuCao
            // 
            this.colDSSKChieuCao.Caption = "Chiều cao";
            this.colDSSKChieuCao.FieldName = "TL_ChieuCao";
            this.colDSSKChieuCao.Name = "colDSSKChieuCao";
            this.colDSSKChieuCao.Visible = true;
            this.colDSSKChieuCao.VisibleIndex = 4;
            this.colDSSKChieuCao.Width = 58;
            // 
            // colDSSKCanNang
            // 
            this.colDSSKCanNang.Caption = "Cân nặng";
            this.colDSSKCanNang.FieldName = "TL_CanNang";
            this.colDSSKCanNang.Name = "colDSSKCanNang";
            this.colDSSKCanNang.Visible = true;
            this.colDSSKCanNang.VisibleIndex = 5;
            this.colDSSKCanNang.Width = 56;
            // 
            // colDSSKTLPhanLoai
            // 
            this.colDSSKTLPhanLoai.Caption = "Thể lực";
            this.colDSSKTLPhanLoai.FieldName = "TL_PhanLoai";
            this.colDSSKTLPhanLoai.Name = "colDSSKTLPhanLoai";
            this.colDSSKTLPhanLoai.Visible = true;
            this.colDSSKTLPhanLoai.VisibleIndex = 6;
            this.colDSSKTLPhanLoai.Width = 50;
            // 
            // colDSSKLSTuanHoanPhanLoai
            // 
            this.colDSSKLSTuanHoanPhanLoai.Caption = "Tuần hoàn";
            this.colDSSKLSTuanHoanPhanLoai.FieldName = "LS_TuanHoan_PhanLoai";
            this.colDSSKLSTuanHoanPhanLoai.Name = "colDSSKLSTuanHoanPhanLoai";
            // 
            // colDSSKLSHoHapPhanLoai
            // 
            this.colDSSKLSHoHapPhanLoai.Caption = "Hô hấp";
            this.colDSSKLSHoHapPhanLoai.FieldName = "LS_HoHap_PhanLoai";
            this.colDSSKLSHoHapPhanLoai.Name = "colDSSKLSHoHapPhanLoai";
            // 
            // colDSSKLSTieuHoaPhanLoai
            // 
            this.colDSSKLSTieuHoaPhanLoai.Caption = "Tiêu hóa";
            this.colDSSKLSTieuHoaPhanLoai.FieldName = "LS_TieuHoa_PhanLoai";
            this.colDSSKLSTieuHoaPhanLoai.Name = "colDSSKLSTieuHoaPhanLoai";
            // 
            // colDSSKLSThanTietNieuPhanLoai
            // 
            this.colDSSKLSThanTietNieuPhanLoai.Caption = "Thận - Tiết niệu - Sinh dục";
            this.colDSSKLSThanTietNieuPhanLoai.FieldName = "LS_ThanTietNieu_PhanLoai";
            this.colDSSKLSThanTietNieuPhanLoai.Name = "colDSSKLSThanTietNieuPhanLoai";
            // 
            // colDSSKLSThanKinhPhanLoai
            // 
            this.colDSSKLSThanKinhPhanLoai.Caption = "Thần kinh";
            this.colDSSKLSThanKinhPhanLoai.FieldName = "LS_ThanKinh_PhanLoai";
            this.colDSSKLSThanKinhPhanLoai.Name = "colDSSKLSThanKinhPhanLoai";
            // 
            // colDSSKLSTamThanPhanLoai
            // 
            this.colDSSKLSTamThanPhanLoai.Caption = "Tâm thần";
            this.colDSSKLSTamThanPhanLoai.FieldName = "LS_TamThan_PhanLoai";
            this.colDSSKLSTamThanPhanLoai.Name = "colDSSKLSTamThanPhanLoai";
            // 
            // colDSSKLSHeVanDongPhanLoai
            // 
            this.colDSSKLSHeVanDongPhanLoai.Caption = "Hệ vận động";
            this.colDSSKLSHeVanDongPhanLoai.FieldName = "LS_HeVanDong_PhanLoai";
            this.colDSSKLSHeVanDongPhanLoai.Name = "colDSSKLSHeVanDongPhanLoai";
            // 
            // colDSSKLSNoiTietPhanLoai
            // 
            this.colDSSKLSNoiTietPhanLoai.Caption = "Nội tiết";
            this.colDSSKLSNoiTietPhanLoai.FieldName = "LS_NoiTiet_PhanLoai";
            this.colDSSKLSNoiTietPhanLoai.Name = "colDSSKLSNoiTietPhanLoai";
            // 
            // colDSSKLSDaLieuPhanLoai
            // 
            this.colDSSKLSDaLieuPhanLoai.Caption = "Da liễu";
            this.colDSSKLSDaLieuPhanLoai.FieldName = "LS_DaLieu_PhanLoai";
            this.colDSSKLSDaLieuPhanLoai.Name = "colDSSKLSDaLieuPhanLoai";
            // 
            // colDSSKLSNgoaiKhoaPhanLoai
            // 
            this.colDSSKLSNgoaiKhoaPhanLoai.Caption = "Ngoại khoa";
            this.colDSSKLSNgoaiKhoaPhanLoai.FieldName = "LS_NgoaiKhoa_PhanLoai";
            this.colDSSKLSNgoaiKhoaPhanLoai.Name = "colDSSKLSNgoaiKhoaPhanLoai";
            // 
            // colDSSKLSSanPhuKhoaPhanLoai
            // 
            this.colDSSKLSSanPhuKhoaPhanLoai.Caption = "Sản phụ khoa";
            this.colDSSKLSSanPhuKhoaPhanLoai.FieldName = "LS_SanPhuKhoa_PhanLoai";
            this.colDSSKLSSanPhuKhoaPhanLoai.Name = "colDSSKLSSanPhuKhoaPhanLoai";
            // 
            // colDSSKLSMatPhanLoai
            // 
            this.colDSSKLSMatPhanLoai.Caption = "Mắt";
            this.colDSSKLSMatPhanLoai.FieldName = "LS_Mat_PhanLoai";
            this.colDSSKLSMatPhanLoai.Name = "colDSSKLSMatPhanLoai";
            // 
            // colDSSKLSTaiMuiHongPhanLoai
            // 
            this.colDSSKLSTaiMuiHongPhanLoai.Caption = "Tai mũi họng";
            this.colDSSKLSTaiMuiHongPhanLoai.FieldName = "LS_TaiMuiHong_PhanLoai";
            this.colDSSKLSTaiMuiHongPhanLoai.Name = "colDSSKLSTaiMuiHongPhanLoai";
            // 
            // colDSSKLSRangHamMatPhanLoai
            // 
            this.colDSSKLSRangHamMatPhanLoai.Caption = "Răng hàm mặt";
            this.colDSSKLSRangHamMatPhanLoai.FieldName = "LS_RangHamMat_PhanLoai";
            this.colDSSKLSRangHamMatPhanLoai.Name = "colDSSKLSRangHamMatPhanLoai";
            // 
            // colDSSKCLSXQuangTimPhoi
            // 
            this.colDSSKCLSXQuangTimPhoi.Caption = "X-Quang Tim phổi";
            this.colDSSKCLSXQuangTimPhoi.FieldName = "CLS_XQuangTimPhoi_BinhThuong";
            this.colDSSKCLSXQuangTimPhoi.Name = "colDSSKCLSXQuangTimPhoi";
            // 
            // colDSSKKLKhoeManh
            // 
            this.colDSSKKLKhoeManh.Caption = "Khỏe mạnh";
            this.colDSSKKLKhoeManh.FieldName = "KL_KhoeManh";
            this.colDSSKKLKhoeManh.Name = "colDSSKKLKhoeManh";
            this.colDSSKKLKhoeManh.Visible = true;
            this.colDSSKKLKhoeManh.VisibleIndex = 7;
            this.colDSSKKLKhoeManh.Width = 72;
            // 
            // colDSSKKLTenBenh
            // 
            this.colDSSKKLTenBenh.Caption = "Tên bệnh";
            this.colDSSKKLTenBenh.FieldName = "KL_TenBenh";
            this.colDSSKKLTenBenh.Name = "colDSSKKLTenBenh";
            this.colDSSKKLTenBenh.Visible = true;
            this.colDSSKKLTenBenh.VisibleIndex = 8;
            this.colDSSKKLTenBenh.Width = 118;
            // 
            // colDSSKKLDatSucKhoeLoai
            // 
            this.colDSSKKLDatSucKhoeLoai.Caption = "Đạt sức khỏe loại";
            this.colDSSKKLDatSucKhoeLoai.FieldName = "KL_DatSucKhoeLoai";
            this.colDSSKKLDatSucKhoeLoai.Name = "colDSSKKLDatSucKhoeLoai";
            this.colDSSKKLDatSucKhoeLoai.Visible = true;
            this.colDSSKKLDatSucKhoeLoai.VisibleIndex = 9;
            this.colDSSKKLDatSucKhoeLoai.Width = 133;
            // 
            // colDSSKKLMoTa
            // 
            this.colDSSKKLMoTa.Caption = "Mô tả";
            this.colDSSKKLMoTa.FieldName = "KL_MoTa";
            this.colDSSKKLMoTa.Name = "colDSSKKLMoTa";
            this.colDSSKKLMoTa.Visible = true;
            this.colDSSKKLMoTa.VisibleIndex = 10;
            this.colDSSKKLMoTa.Width = 144;
            // 
            // colDSSKKLDuDieuKienSucKhoe
            // 
            this.colDSSKKLDuDieuKienSucKhoe.Caption = "Đủ sức khỏe đi làm";
            this.colDSSKKLDuDieuKienSucKhoe.FieldName = "KL_DuDieuKienSucKhoe";
            this.colDSSKKLDuDieuKienSucKhoe.Name = "colDSSKKLDuDieuKienSucKhoe";
            this.colDSSKKLDuDieuKienSucKhoe.Visible = true;
            this.colDSSKKLDuDieuKienSucKhoe.VisibleIndex = 11;
            this.colDSSKKLDuDieuKienSucKhoe.Width = 172;
            // 
            // selectNam
            // 
            this.selectNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectNam.FormattingEnabled = true;
            this.selectNam.Items.AddRange(new object[] {
            "Danh sức khỏe mới nhất",
            "Năm"});
            this.selectNam.Location = new System.Drawing.Point(236, 9);
            this.selectNam.Name = "selectNam";
            this.selectNam.Size = new System.Drawing.Size(72, 21);
            this.selectNam.TabIndex = 1;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.Image")));
            this.btnInDanhSach.Location = new System.Drawing.Point(522, 9);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(115, 34);
            this.btnInDanhSach.TabIndex = 2;
            this.btnInDanhSach.Text = "In danh sách";
            // 
            // FormBaoCaoDanhSachSucKhoe
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(649, 380);
            this.Controls.Add(this.gcDanhSachSucKhoe);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.selectNam);
            this.Controls.Add(this.selectBaoCaoTheo);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormBaoCaoDanhSachSucKhoe";
            this.Text = "FormBaoCaoDanhSachSucKhoe";
            this.Load += new System.EventHandler(this.FormBaoCaoDanhSachSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachSucKhoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSucKhoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox selectBaoCaoTheo;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.GridControl gcDanhSachSucKhoe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachSucKhoe;
        private System.Windows.Forms.ComboBox selectNam;
        private DevExpress.XtraEditors.SimpleButton btnInDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKTenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKGioiTinhNam;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKGioiTinhNu;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKNgayKham;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKChieuCao;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKCanNang;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKTLPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSTuanHoanPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSHoHapPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSTieuHoaPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSThanTietNieuPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSThanKinhPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSHeVanDongPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSNoiTietPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSDaLieuPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSNgoaiKhoaPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSSanPhuKhoaPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSMatPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSTaiMuiHongPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSRangHamMatPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKCLSXQuangTimPhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKKLKhoeManh;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKKLDatSucKhoeLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKKLDuDieuKienSucKhoe;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKLSTamThanPhanLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKKLTenBenh;
        private DevExpress.XtraGrid.Columns.GridColumn colDSSKKLMoTa;
    }
}
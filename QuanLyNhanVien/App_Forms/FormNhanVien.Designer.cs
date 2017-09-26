using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace QuanLyNhanVien.App_Forms
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcDanhSachNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDanhSachNVSTTKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachNVMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachNVSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachNVTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachNVTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachNVMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabcontainerNhanVien = new DevExpress.XtraTab.XtraTabControl();
            this.tabHanhChinh = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtSTT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.checkboxNguoiLaoDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaySinh = new DevExpress.XtraEditors.TextEdit();
            this.txtThangSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtNamSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.checkboxGioiTinhNam = new DevExpress.XtraEditors.CheckEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.dateNgayCap = new DevExpress.XtraEditors.DateEdit();
            this.txtNoiCap = new DevExpress.XtraEditors.TextEdit();
            this.txtHoKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtChoOHienNay = new DevExpress.XtraEditors.TextEdit();
            this.txtNganhHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChiHoc = new DevExpress.XtraEditors.TextEdit();
            this.dateNgayBatDauHoc = new DevExpress.XtraEditors.DateEdit();
            this.txtCongViecTruocDay = new DevExpress.XtraEditors.TextEdit();
            this.txtTienSuGiaDinh = new DevExpress.XtraEditors.TextEdit();
            this.txtTienSuBanThan = new DevExpress.XtraEditors.TextEdit();
            this.lookupKhoaPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCMND = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHoKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForChoOHienNay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNganhHoc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoiHoc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiaChiHoc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCongViecTruocDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTienSuGiaDinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTienSuBanThan = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenNhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaKhoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaNhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNguoiLaoDong = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForThangSinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNamSinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgayCap = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoiCap = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgayBatDauHoc = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabSucKhoe = new DevExpress.XtraTab.XtraTabPage();
            this.btnTabSucKhoeXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopyPhieuKham = new DevExpress.XtraEditors.SimpleButton();
            this.btnTabSucKhoeSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnTabSucKhoeThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcSucKhoe = new DevExpress.XtraGrid.GridControl();
            this.gvSucKhoe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhieuKhamMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuKhamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuKhamNgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNhanVienHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhanVienXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhanVienLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhanVienThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.errorproviderThongTinNhanVien = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontainerNhanVien)).BeginInit();
            this.tabcontainerNhanVien.SuspendLayout();
            this.tabHanhChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxNguoiLaoDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThangSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxGioiTinhNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoOHienNay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDauHoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDauHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViecTruocDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienSuGiaDinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienSuBanThan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupKhoaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChoOHienNay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNganhHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChiHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCongViecTruocDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTienSuGiaDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTienSuBanThan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNguoiLaoDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForThangSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayBatDauHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.tabSucKhoe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucKhoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSucKhoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDanhSachNhanVien);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1085, 574);
            this.splitContainerControl1.SplitterPosition = 358;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcDanhSachNhanVien
            // 
            this.gcDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachNhanVien.MainView = this.gvDanhSachNhanVien;
            this.gcDanhSachNhanVien.Name = "gcDanhSachNhanVien";
            this.gcDanhSachNhanVien.Size = new System.Drawing.Size(358, 574);
            this.gcDanhSachNhanVien.TabIndex = 0;
            this.gcDanhSachNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachNhanVien});
            this.gcDanhSachNhanVien.Click += new System.EventHandler(this.gcDanhSachNhanVien_Click);
            // 
            // gvDanhSachNhanVien
            // 
            this.gvDanhSachNhanVien.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvDanhSachNhanVien.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSachNhanVien.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvDanhSachNhanVien.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDanhSachNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDanhSachNVSTTKhoa,
            this.colDanhSachNVMaKhoa,
            this.colDanhSachNVSTT,
            this.colDanhSachNVTenKhoa,
            this.colDanhSachNVTenNV,
            this.colDanhSachNVMaNV});
            this.gvDanhSachNhanVien.GridControl = this.gcDanhSachNhanVien;
            this.gvDanhSachNhanVien.GroupCount = 1;
            this.gvDanhSachNhanVien.Name = "gvDanhSachNhanVien";
            this.gvDanhSachNhanVien.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachNhanVien.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhSachNhanVien.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvDanhSachNhanVien.OptionsBehavior.Editable = false;
            this.gvDanhSachNhanVien.OptionsBehavior.ReadOnly = true;
            this.gvDanhSachNhanVien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDanhSachNVTenKhoa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDanhSachNVSTTKhoa
            // 
            this.colDanhSachNVSTTKhoa.Caption = "STT Khoa";
            this.colDanhSachNVSTTKhoa.FieldName = "STTKhoa";
            this.colDanhSachNVSTTKhoa.Name = "colDanhSachNVSTTKhoa";
            // 
            // colDanhSachNVMaKhoa
            // 
            this.colDanhSachNVMaKhoa.Caption = "Mã khoa";
            this.colDanhSachNVMaKhoa.FieldName = "MaKhoa";
            this.colDanhSachNVMaKhoa.Name = "colDanhSachNVMaKhoa";
            // 
            // colDanhSachNVSTT
            // 
            this.colDanhSachNVSTT.Caption = "STT";
            this.colDanhSachNVSTT.FieldName = "STT";
            this.colDanhSachNVSTT.Name = "colDanhSachNVSTT";
            this.colDanhSachNVSTT.Visible = true;
            this.colDanhSachNVSTT.VisibleIndex = 0;
            this.colDanhSachNVSTT.Width = 53;
            // 
            // colDanhSachNVTenKhoa
            // 
            this.colDanhSachNVTenKhoa.Caption = "Khoa";
            this.colDanhSachNVTenKhoa.FieldName = "TenKhoa";
            this.colDanhSachNVTenKhoa.Name = "colDanhSachNVTenKhoa";
            this.colDanhSachNVTenKhoa.Visible = true;
            this.colDanhSachNVTenKhoa.VisibleIndex = 0;
            // 
            // colDanhSachNVTenNV
            // 
            this.colDanhSachNVTenNV.Caption = "Tên NV";
            this.colDanhSachNVTenNV.FieldName = "TenNhanVien";
            this.colDanhSachNVTenNV.Name = "colDanhSachNVTenNV";
            this.colDanhSachNVTenNV.Visible = true;
            this.colDanhSachNVTenNV.VisibleIndex = 1;
            this.colDanhSachNVTenNV.Width = 287;
            // 
            // colDanhSachNVMaNV
            // 
            this.colDanhSachNVMaNV.Caption = "Mã NV";
            this.colDanhSachNVMaNV.FieldName = "MaNhanVien";
            this.colDanhSachNVMaNV.Name = "colDanhSachNVMaNV";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.btnNhanVienHuyBo);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnNhanVienXoa);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnNhanVienLuu);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnNhanVienThemMoi);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(722, 574);
            this.splitContainerControl2.SplitterPosition = 447;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabcontainerNhanVien);
            this.layoutControl1.Controls.Add(this.lblTitle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(722, 447);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabcontainerNhanVien
            // 
            this.tabcontainerNhanVien.Location = new System.Drawing.Point(12, 36);
            this.tabcontainerNhanVien.Name = "tabcontainerNhanVien";
            this.tabcontainerNhanVien.SelectedTabPage = this.tabHanhChinh;
            this.tabcontainerNhanVien.Size = new System.Drawing.Size(698, 399);
            this.tabcontainerNhanVien.TabIndex = 5;
            this.tabcontainerNhanVien.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabHanhChinh,
            this.tabSucKhoe});
            // 
            // tabHanhChinh
            // 
            this.tabHanhChinh.Controls.Add(this.layoutControl2);
            this.tabHanhChinh.Name = "tabHanhChinh";
            this.tabHanhChinh.Size = new System.Drawing.Size(692, 371);
            this.tabHanhChinh.Text = "Hành chính";
            this.tabHanhChinh.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dataLayoutControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(692, 371);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txtSTT);
            this.dataLayoutControl1.Controls.Add(this.txtMaNhanVien);
            this.dataLayoutControl1.Controls.Add(this.checkboxNguoiLaoDong);
            this.dataLayoutControl1.Controls.Add(this.txtTenNhanVien);
            this.dataLayoutControl1.Controls.Add(this.txtNgaySinh);
            this.dataLayoutControl1.Controls.Add(this.txtThangSinh);
            this.dataLayoutControl1.Controls.Add(this.txtNamSinh);
            this.dataLayoutControl1.Controls.Add(this.txtDiaChi);
            this.dataLayoutControl1.Controls.Add(this.checkboxGioiTinhNam);
            this.dataLayoutControl1.Controls.Add(this.txtCMND);
            this.dataLayoutControl1.Controls.Add(this.dateNgayCap);
            this.dataLayoutControl1.Controls.Add(this.txtNoiCap);
            this.dataLayoutControl1.Controls.Add(this.txtHoKhau);
            this.dataLayoutControl1.Controls.Add(this.txtChoOHienNay);
            this.dataLayoutControl1.Controls.Add(this.txtNganhHoc);
            this.dataLayoutControl1.Controls.Add(this.txtNoiHoc);
            this.dataLayoutControl1.Controls.Add(this.txtDiaChiHoc);
            this.dataLayoutControl1.Controls.Add(this.dateNgayBatDauHoc);
            this.dataLayoutControl1.Controls.Add(this.txtCongViecTruocDay);
            this.dataLayoutControl1.Controls.Add(this.txtTienSuGiaDinh);
            this.dataLayoutControl1.Controls.Add(this.txtTienSuBanThan);
            this.dataLayoutControl1.Controls.Add(this.lookupKhoaPhong);
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(668, 347);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(592, 36);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(64, 20);
            this.txtSTT.StyleController = this.dataLayoutControl1;
            this.txtSTT.TabIndex = 25;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(606, 12);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNhanVien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMaNhanVien.Properties.Mask.EditMask = "N0";
            this.txtMaNhanVien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMaNhanVien.Properties.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(50, 20);
            this.txtMaNhanVien.StyleController = this.dataLayoutControl1;
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // checkboxNguoiLaoDong
            // 
            this.checkboxNguoiLaoDong.EditValue = true;
            this.checkboxNguoiLaoDong.Location = new System.Drawing.Point(437, 12);
            this.checkboxNguoiLaoDong.Name = "checkboxNguoiLaoDong";
            this.checkboxNguoiLaoDong.Properties.Caption = "Nguoi Lao Dong";
            this.checkboxNguoiLaoDong.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkboxNguoiLaoDong.Size = new System.Drawing.Size(61, 19);
            this.checkboxNguoiLaoDong.StyleController = this.dataLayoutControl1;
            this.checkboxNguoiLaoDong.TabIndex = 6;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(116, 36);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(368, 20);
            this.txtTenNhanVien.StyleController = this.dataLayoutControl1;
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(116, 60);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNgaySinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNgaySinh.Properties.Mask.EditMask = "N0";
            this.txtNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(53, 20);
            this.txtNgaySinh.StyleController = this.dataLayoutControl1;
            this.txtNgaySinh.TabIndex = 8;
            // 
            // txtThangSinh
            // 
            this.txtThangSinh.Location = new System.Drawing.Point(173, 60);
            this.txtThangSinh.Name = "txtThangSinh";
            this.txtThangSinh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtThangSinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtThangSinh.Properties.Mask.EditMask = "N0";
            this.txtThangSinh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtThangSinh.Size = new System.Drawing.Size(51, 20);
            this.txtThangSinh.StyleController = this.dataLayoutControl1;
            this.txtThangSinh.TabIndex = 9;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(228, 60);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNamSinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNamSinh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNamSinh.Size = new System.Drawing.Size(68, 20);
            this.txtNamSinh.StyleController = this.dataLayoutControl1;
            this.txtNamSinh.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 84);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(540, 20);
            this.txtDiaChi.StyleController = this.dataLayoutControl1;
            this.txtDiaChi.TabIndex = 11;
            // 
            // checkboxGioiTinhNam
            // 
            this.checkboxGioiTinhNam.Location = new System.Drawing.Point(404, 60);
            this.checkboxGioiTinhNam.Name = "checkboxGioiTinhNam";
            this.checkboxGioiTinhNam.Properties.Caption = "Nam";
            this.checkboxGioiTinhNam.Size = new System.Drawing.Size(252, 19);
            this.checkboxGioiTinhNam.StyleController = this.dataLayoutControl1;
            this.checkboxGioiTinhNam.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(116, 108);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(108, 20);
            this.txtCMND.StyleController = this.dataLayoutControl1;
            this.txtCMND.TabIndex = 13;
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.EditValue = null;
            this.dateNgayCap.Location = new System.Drawing.Point(332, 108);
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayCap.Size = new System.Drawing.Size(100, 20);
            this.dateNgayCap.StyleController = this.dataLayoutControl1;
            this.dateNgayCap.TabIndex = 14;
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(540, 108);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(116, 20);
            this.txtNoiCap.StyleController = this.dataLayoutControl1;
            this.txtNoiCap.TabIndex = 15;
            // 
            // txtHoKhau
            // 
            this.txtHoKhau.Location = new System.Drawing.Point(116, 132);
            this.txtHoKhau.Name = "txtHoKhau";
            this.txtHoKhau.Size = new System.Drawing.Size(540, 20);
            this.txtHoKhau.StyleController = this.dataLayoutControl1;
            this.txtHoKhau.TabIndex = 16;
            // 
            // txtChoOHienNay
            // 
            this.txtChoOHienNay.Location = new System.Drawing.Point(116, 156);
            this.txtChoOHienNay.Name = "txtChoOHienNay";
            this.txtChoOHienNay.Size = new System.Drawing.Size(540, 20);
            this.txtChoOHienNay.StyleController = this.dataLayoutControl1;
            this.txtChoOHienNay.TabIndex = 17;
            // 
            // txtNganhHoc
            // 
            this.txtNganhHoc.Location = new System.Drawing.Point(116, 180);
            this.txtNganhHoc.Name = "txtNganhHoc";
            this.txtNganhHoc.Size = new System.Drawing.Size(540, 20);
            this.txtNganhHoc.StyleController = this.dataLayoutControl1;
            this.txtNganhHoc.TabIndex = 18;
            // 
            // txtNoiHoc
            // 
            this.txtNoiHoc.Location = new System.Drawing.Point(116, 204);
            this.txtNoiHoc.Name = "txtNoiHoc";
            this.txtNoiHoc.Size = new System.Drawing.Size(540, 20);
            this.txtNoiHoc.StyleController = this.dataLayoutControl1;
            this.txtNoiHoc.TabIndex = 19;
            // 
            // txtDiaChiHoc
            // 
            this.txtDiaChiHoc.Location = new System.Drawing.Point(116, 228);
            this.txtDiaChiHoc.Name = "txtDiaChiHoc";
            this.txtDiaChiHoc.Size = new System.Drawing.Size(215, 20);
            this.txtDiaChiHoc.StyleController = this.dataLayoutControl1;
            this.txtDiaChiHoc.TabIndex = 20;
            // 
            // dateNgayBatDauHoc
            // 
            this.dateNgayBatDauHoc.EditValue = null;
            this.dateNgayBatDauHoc.Location = new System.Drawing.Point(439, 228);
            this.dateNgayBatDauHoc.Name = "dateNgayBatDauHoc";
            this.dateNgayBatDauHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBatDauHoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBatDauHoc.Size = new System.Drawing.Size(217, 20);
            this.dateNgayBatDauHoc.StyleController = this.dataLayoutControl1;
            this.dateNgayBatDauHoc.TabIndex = 21;
            // 
            // txtCongViecTruocDay
            // 
            this.txtCongViecTruocDay.Location = new System.Drawing.Point(116, 252);
            this.txtCongViecTruocDay.Name = "txtCongViecTruocDay";
            this.txtCongViecTruocDay.Size = new System.Drawing.Size(540, 20);
            this.txtCongViecTruocDay.StyleController = this.dataLayoutControl1;
            this.txtCongViecTruocDay.TabIndex = 22;
            // 
            // txtTienSuGiaDinh
            // 
            this.txtTienSuGiaDinh.Location = new System.Drawing.Point(116, 276);
            this.txtTienSuGiaDinh.Name = "txtTienSuGiaDinh";
            this.txtTienSuGiaDinh.Size = new System.Drawing.Size(540, 20);
            this.txtTienSuGiaDinh.StyleController = this.dataLayoutControl1;
            this.txtTienSuGiaDinh.TabIndex = 23;
            // 
            // txtTienSuBanThan
            // 
            this.txtTienSuBanThan.Location = new System.Drawing.Point(116, 300);
            this.txtTienSuBanThan.Name = "txtTienSuBanThan";
            this.txtTienSuBanThan.Size = new System.Drawing.Size(540, 20);
            this.txtTienSuBanThan.StyleController = this.dataLayoutControl1;
            this.txtTienSuBanThan.TabIndex = 24;
            // 
            // lookupKhoaPhong
            // 
            this.lookupKhoaPhong.Location = new System.Drawing.Point(116, 12);
            this.lookupKhoaPhong.Name = "lookupKhoaPhong";
            this.lookupKhoaPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupKhoaPhong.Properties.NullText = "";
            this.lookupKhoaPhong.Size = new System.Drawing.Size(213, 20);
            this.lookupKhoaPhong.StyleController = this.dataLayoutControl1;
            this.lookupKhoaPhong.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(668, 347);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNgaySinh,
            this.ItemForDiaChi,
            this.ItemForCMND,
            this.ItemForHoKhau,
            this.ItemForChoOHienNay,
            this.ItemForNganhHoc,
            this.ItemForNoiHoc,
            this.ItemForDiaChiHoc,
            this.ItemForCongViecTruocDay,
            this.ItemForTienSuGiaDinh,
            this.ItemForTienSuBanThan,
            this.ItemForTenNhanVien,
            this.ItemForMaKhoa,
            this.ItemForMaNhanVien,
            this.ItemForNguoiLaoDong,
            this.ItemForThangSinh,
            this.ItemForNamSinh,
            this.ItemForGioiTinh,
            this.ItemForNgayCap,
            this.ItemForNoiCap,
            this.ItemForNgayBatDauHoc,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(648, 327);
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.txtNgaySinh;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(0, 48);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(161, 24);
            this.ItemForNgaySinh.Text = "Ngày sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForDiaChi
            // 
            this.ItemForDiaChi.Control = this.txtDiaChi;
            this.ItemForDiaChi.Location = new System.Drawing.Point(0, 72);
            this.ItemForDiaChi.Name = "ItemForDiaChi";
            this.ItemForDiaChi.Size = new System.Drawing.Size(648, 24);
            this.ItemForDiaChi.Text = "Địa chỉ:";
            this.ItemForDiaChi.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForCMND
            // 
            this.ItemForCMND.Control = this.txtCMND;
            this.ItemForCMND.Location = new System.Drawing.Point(0, 96);
            this.ItemForCMND.Name = "ItemForCMND";
            this.ItemForCMND.Size = new System.Drawing.Size(216, 24);
            this.ItemForCMND.Text = "CMND:";
            this.ItemForCMND.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForHoKhau
            // 
            this.ItemForHoKhau.Control = this.txtHoKhau;
            this.ItemForHoKhau.Location = new System.Drawing.Point(0, 120);
            this.ItemForHoKhau.Name = "ItemForHoKhau";
            this.ItemForHoKhau.Size = new System.Drawing.Size(648, 24);
            this.ItemForHoKhau.Text = "Hộ khẩu:";
            this.ItemForHoKhau.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForChoOHienNay
            // 
            this.ItemForChoOHienNay.Control = this.txtChoOHienNay;
            this.ItemForChoOHienNay.Location = new System.Drawing.Point(0, 144);
            this.ItemForChoOHienNay.Name = "ItemForChoOHienNay";
            this.ItemForChoOHienNay.Size = new System.Drawing.Size(648, 24);
            this.ItemForChoOHienNay.Text = "Chổ ở hiện nay:";
            this.ItemForChoOHienNay.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNganhHoc
            // 
            this.ItemForNganhHoc.Control = this.txtNganhHoc;
            this.ItemForNganhHoc.Location = new System.Drawing.Point(0, 168);
            this.ItemForNganhHoc.Name = "ItemForNganhHoc";
            this.ItemForNganhHoc.Size = new System.Drawing.Size(648, 24);
            this.ItemForNganhHoc.Text = "Ngành học:";
            this.ItemForNganhHoc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNoiHoc
            // 
            this.ItemForNoiHoc.Control = this.txtNoiHoc;
            this.ItemForNoiHoc.Location = new System.Drawing.Point(0, 192);
            this.ItemForNoiHoc.Name = "ItemForNoiHoc";
            this.ItemForNoiHoc.Size = new System.Drawing.Size(648, 24);
            this.ItemForNoiHoc.Text = "Nơi học/làm việc:";
            this.ItemForNoiHoc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForDiaChiHoc
            // 
            this.ItemForDiaChiHoc.Control = this.txtDiaChiHoc;
            this.ItemForDiaChiHoc.Location = new System.Drawing.Point(0, 216);
            this.ItemForDiaChiHoc.Name = "ItemForDiaChiHoc";
            this.ItemForDiaChiHoc.Size = new System.Drawing.Size(323, 24);
            this.ItemForDiaChiHoc.Text = "Địa chỉ học/làm việc:";
            this.ItemForDiaChiHoc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForCongViecTruocDay
            // 
            this.ItemForCongViecTruocDay.Control = this.txtCongViecTruocDay;
            this.ItemForCongViecTruocDay.Location = new System.Drawing.Point(0, 240);
            this.ItemForCongViecTruocDay.Name = "ItemForCongViecTruocDay";
            this.ItemForCongViecTruocDay.Size = new System.Drawing.Size(648, 24);
            this.ItemForCongViecTruocDay.Text = "Công việc trước đây:";
            this.ItemForCongViecTruocDay.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForTienSuGiaDinh
            // 
            this.ItemForTienSuGiaDinh.Control = this.txtTienSuGiaDinh;
            this.ItemForTienSuGiaDinh.Location = new System.Drawing.Point(0, 264);
            this.ItemForTienSuGiaDinh.Name = "ItemForTienSuGiaDinh";
            this.ItemForTienSuGiaDinh.Size = new System.Drawing.Size(648, 24);
            this.ItemForTienSuGiaDinh.Text = "Tiền sử gia đình:";
            this.ItemForTienSuGiaDinh.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForTienSuBanThan
            // 
            this.ItemForTienSuBanThan.Control = this.txtTienSuBanThan;
            this.ItemForTienSuBanThan.Location = new System.Drawing.Point(0, 288);
            this.ItemForTienSuBanThan.Name = "ItemForTienSuBanThan";
            this.ItemForTienSuBanThan.Size = new System.Drawing.Size(648, 39);
            this.ItemForTienSuBanThan.Text = "Tiền sử bản thân:";
            this.ItemForTienSuBanThan.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForTenNhanVien
            // 
            this.ItemForTenNhanVien.Control = this.txtTenNhanVien;
            this.ItemForTenNhanVien.Location = new System.Drawing.Point(0, 24);
            this.ItemForTenNhanVien.Name = "ItemForTenNhanVien";
            this.ItemForTenNhanVien.Size = new System.Drawing.Size(476, 24);
            this.ItemForTenNhanVien.Text = "Họ và tên:";
            this.ItemForTenNhanVien.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForMaKhoa
            // 
            this.ItemForMaKhoa.Control = this.lookupKhoaPhong;
            this.ItemForMaKhoa.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaKhoa.Name = "ItemForMaKhoa";
            this.ItemForMaKhoa.Size = new System.Drawing.Size(321, 24);
            this.ItemForMaKhoa.Text = "Mã khoa:";
            this.ItemForMaKhoa.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForMaNhanVien
            // 
            this.ItemForMaNhanVien.Control = this.txtMaNhanVien;
            this.ItemForMaNhanVien.Location = new System.Drawing.Point(490, 0);
            this.ItemForMaNhanVien.Name = "ItemForMaNhanVien";
            this.ItemForMaNhanVien.Size = new System.Drawing.Size(158, 24);
            this.ItemForMaNhanVien.Text = "Mã nhân viên:";
            this.ItemForMaNhanVien.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNguoiLaoDong
            // 
            this.ItemForNguoiLaoDong.Control = this.checkboxNguoiLaoDong;
            this.ItemForNguoiLaoDong.Location = new System.Drawing.Point(321, 0);
            this.ItemForNguoiLaoDong.Name = "ItemForNguoiLaoDong";
            this.ItemForNguoiLaoDong.Size = new System.Drawing.Size(169, 24);
            this.ItemForNguoiLaoDong.Text = "Người lao động:";
            this.ItemForNguoiLaoDong.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForThangSinh
            // 
            this.ItemForThangSinh.Control = this.txtThangSinh;
            this.ItemForThangSinh.Location = new System.Drawing.Point(161, 48);
            this.ItemForThangSinh.Name = "ItemForThangSinh";
            this.ItemForThangSinh.Size = new System.Drawing.Size(55, 24);
            this.ItemForThangSinh.Text = "Thang Sinh";
            this.ItemForThangSinh.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForThangSinh.TextVisible = false;
            // 
            // ItemForNamSinh
            // 
            this.ItemForNamSinh.Control = this.txtNamSinh;
            this.ItemForNamSinh.Location = new System.Drawing.Point(216, 48);
            this.ItemForNamSinh.Name = "ItemForNamSinh";
            this.ItemForNamSinh.Size = new System.Drawing.Size(72, 24);
            this.ItemForNamSinh.Text = "Nam Sinh";
            this.ItemForNamSinh.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForNamSinh.TextVisible = false;
            // 
            // ItemForGioiTinh
            // 
            this.ItemForGioiTinh.Control = this.checkboxGioiTinhNam;
            this.ItemForGioiTinh.Location = new System.Drawing.Point(288, 48);
            this.ItemForGioiTinh.Name = "ItemForGioiTinh";
            this.ItemForGioiTinh.Size = new System.Drawing.Size(360, 24);
            this.ItemForGioiTinh.Text = "Giới tính:";
            this.ItemForGioiTinh.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNgayCap
            // 
            this.ItemForNgayCap.Control = this.dateNgayCap;
            this.ItemForNgayCap.Location = new System.Drawing.Point(216, 96);
            this.ItemForNgayCap.Name = "ItemForNgayCap";
            this.ItemForNgayCap.Size = new System.Drawing.Size(208, 24);
            this.ItemForNgayCap.Text = "Ngày cấp:";
            this.ItemForNgayCap.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNoiCap
            // 
            this.ItemForNoiCap.Control = this.txtNoiCap;
            this.ItemForNoiCap.Location = new System.Drawing.Point(424, 96);
            this.ItemForNoiCap.Name = "ItemForNoiCap";
            this.ItemForNoiCap.Size = new System.Drawing.Size(224, 24);
            this.ItemForNoiCap.Text = "Nơi cấp:";
            this.ItemForNoiCap.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ItemForNgayBatDauHoc
            // 
            this.ItemForNgayBatDauHoc.Control = this.dateNgayBatDauHoc;
            this.ItemForNgayBatDauHoc.Location = new System.Drawing.Point(323, 216);
            this.ItemForNgayBatDauHoc.Name = "ItemForNgayBatDauHoc";
            this.ItemForNgayBatDauHoc.Size = new System.Drawing.Size(325, 24);
            this.ItemForNgayBatDauHoc.Text = "Ngày bắt đầu:";
            this.ItemForNgayBatDauHoc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSTT;
            this.layoutControlItem4.Location = new System.Drawing.Point(476, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(172, 24);
            this.layoutControlItem4.Text = "STT:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(692, 371);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dataLayoutControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(672, 351);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tabSucKhoe
            // 
            this.tabSucKhoe.Controls.Add(this.btnTabSucKhoeXoa);
            this.tabSucKhoe.Controls.Add(this.btnCopyPhieuKham);
            this.tabSucKhoe.Controls.Add(this.btnTabSucKhoeSua);
            this.tabSucKhoe.Controls.Add(this.btnTabSucKhoeThem);
            this.tabSucKhoe.Controls.Add(this.gcSucKhoe);
            this.tabSucKhoe.Name = "tabSucKhoe";
            this.tabSucKhoe.Size = new System.Drawing.Size(692, 371);
            this.tabSucKhoe.Text = "Sức khỏe";
            // 
            // btnTabSucKhoeXoa
            // 
            this.btnTabSucKhoeXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSucKhoeXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnTabSucKhoeXoa.Image")));
            this.btnTabSucKhoeXoa.Location = new System.Drawing.Point(598, 338);
            this.btnTabSucKhoeXoa.Name = "btnTabSucKhoeXoa";
            this.btnTabSucKhoeXoa.Size = new System.Drawing.Size(79, 26);
            this.btnTabSucKhoeXoa.TabIndex = 3;
            this.btnTabSucKhoeXoa.Text = "Xóa";
            this.btnTabSucKhoeXoa.Click += new System.EventHandler(this.btnTabSucKhoeXoa_Click);
            // 
            // btnCopyPhieuKham
            // 
            this.btnCopyPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPhieuKham.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyPhieuKham.Image")));
            this.btnCopyPhieuKham.Location = new System.Drawing.Point(477, 338);
            this.btnCopyPhieuKham.Name = "btnCopyPhieuKham";
            this.btnCopyPhieuKham.Size = new System.Drawing.Size(115, 26);
            this.btnCopyPhieuKham.TabIndex = 2;
            this.btnCopyPhieuKham.Text = "Copy";
            this.btnCopyPhieuKham.Click += new System.EventHandler(this.btnCopyPhieuKham_Click);
            // 
            // btnTabSucKhoeSua
            // 
            this.btnTabSucKhoeSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSucKhoeSua.Image = ((System.Drawing.Image)(resources.GetObject("btnTabSucKhoeSua.Image")));
            this.btnTabSucKhoeSua.Location = new System.Drawing.Point(354, 338);
            this.btnTabSucKhoeSua.Name = "btnTabSucKhoeSua";
            this.btnTabSucKhoeSua.Size = new System.Drawing.Size(117, 26);
            this.btnTabSucKhoeSua.TabIndex = 2;
            this.btnTabSucKhoeSua.Text = "Sửa";
            this.btnTabSucKhoeSua.Click += new System.EventHandler(this.btnTabSucKhoeSua_Click);
            // 
            // btnTabSucKhoeThem
            // 
            this.btnTabSucKhoeThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSucKhoeThem.Image = ((System.Drawing.Image)(resources.GetObject("btnTabSucKhoeThem.Image")));
            this.btnTabSucKhoeThem.Location = new System.Drawing.Point(231, 338);
            this.btnTabSucKhoeThem.Name = "btnTabSucKhoeThem";
            this.btnTabSucKhoeThem.Size = new System.Drawing.Size(117, 26);
            this.btnTabSucKhoeThem.TabIndex = 1;
            this.btnTabSucKhoeThem.Text = "Thêm";
            this.btnTabSucKhoeThem.Click += new System.EventHandler(this.btnTabSucKhoeThem_Click);
            // 
            // gcSucKhoe
            // 
            this.gcSucKhoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSucKhoe.Location = new System.Drawing.Point(3, 3);
            this.gcSucKhoe.MainView = this.gvSucKhoe;
            this.gcSucKhoe.Name = "gcSucKhoe";
            this.gcSucKhoe.Size = new System.Drawing.Size(686, 329);
            this.gcSucKhoe.TabIndex = 0;
            this.gcSucKhoe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSucKhoe});
            this.gcSucKhoe.DoubleClick += new System.EventHandler(this.gcSucKhoe_DoubleClick);
            // 
            // gvSucKhoe
            // 
            this.gvSucKhoe.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvSucKhoe.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSucKhoe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhieuKhamMaNhanVien,
            this.colPhieuKhamID,
            this.colPhieuKhamNgayKham});
            this.gvSucKhoe.GridControl = this.gcSucKhoe;
            this.gvSucKhoe.Name = "gvSucKhoe";
            this.gvSucKhoe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSucKhoe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSucKhoe.OptionsBehavior.Editable = false;
            this.gvSucKhoe.OptionsBehavior.ReadOnly = true;
            this.gvSucKhoe.OptionsView.ShowGroupPanel = false;
            // 
            // colPhieuKhamMaNhanVien
            // 
            this.colPhieuKhamMaNhanVien.Caption = "Mã nhân viên";
            this.colPhieuKhamMaNhanVien.FieldName = "MaNhanVien";
            this.colPhieuKhamMaNhanVien.Name = "colPhieuKhamMaNhanVien";
            // 
            // colPhieuKhamID
            // 
            this.colPhieuKhamID.Caption = "ID";
            this.colPhieuKhamID.FieldName = "MaPhieuKham";
            this.colPhieuKhamID.Name = "colPhieuKhamID";
            // 
            // colPhieuKhamNgayKham
            // 
            this.colPhieuKhamNgayKham.Caption = "Ngày khám";
            this.colPhieuKhamNgayKham.FieldName = "NgayKham";
            this.colPhieuKhamNgayKham.Name = "colPhieuKhamNgayKham";
            this.colPhieuKhamNgayKham.Visible = true;
            this.colPhieuKhamNgayKham.VisibleIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(698, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(722, 447);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblTitle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(702, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tabcontainerNhanVien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(702, 403);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnNhanVienHuyBo
            // 
            this.btnNhanVienHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVienHuyBo.Image")));
            this.btnNhanVienHuyBo.Location = new System.Drawing.Point(308, 12);
            this.btnNhanVienHuyBo.Name = "btnNhanVienHuyBo";
            this.btnNhanVienHuyBo.Size = new System.Drawing.Size(129, 45);
            this.btnNhanVienHuyBo.TabIndex = 7;
            this.btnNhanVienHuyBo.Text = "Hủy bỏ";
            this.btnNhanVienHuyBo.Click += new System.EventHandler(this.btnNhanVienHuyBo_Click);
            // 
            // btnNhanVienXoa
            // 
            this.btnNhanVienXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVienXoa.Image")));
            this.btnNhanVienXoa.Location = new System.Drawing.Point(443, 12);
            this.btnNhanVienXoa.Name = "btnNhanVienXoa";
            this.btnNhanVienXoa.Size = new System.Drawing.Size(86, 45);
            this.btnNhanVienXoa.TabIndex = 6;
            this.btnNhanVienXoa.Text = "Xóa";
            this.btnNhanVienXoa.Click += new System.EventHandler(this.btnNhanVienXoa_Click);
            // 
            // btnNhanVienLuu
            // 
            this.btnNhanVienLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNhanVienLuu.Appearance.Options.UseFont = true;
            this.btnNhanVienLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVienLuu.Image")));
            this.btnNhanVienLuu.Location = new System.Drawing.Point(129, 12);
            this.btnNhanVienLuu.Name = "btnNhanVienLuu";
            this.btnNhanVienLuu.Size = new System.Drawing.Size(173, 45);
            this.btnNhanVienLuu.TabIndex = 5;
            this.btnNhanVienLuu.Text = "Lưu nhân viên";
            this.btnNhanVienLuu.Click += new System.EventHandler(this.btnNhanVienLuu_Click);
            // 
            // btnNhanVienThemMoi
            // 
            this.btnNhanVienThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVienThemMoi.Image")));
            this.btnNhanVienThemMoi.Location = new System.Drawing.Point(12, 12);
            this.btnNhanVienThemMoi.Name = "btnNhanVienThemMoi";
            this.btnNhanVienThemMoi.Size = new System.Drawing.Size(111, 45);
            this.btnNhanVienThemMoi.TabIndex = 4;
            this.btnNhanVienThemMoi.Text = "Thêm mới";
            this.btnNhanVienThemMoi.Click += new System.EventHandler(this.btnNhanVienThemMoi_Click);
            // 
            // errorproviderThongTinNhanVien
            // 
            this.errorproviderThongTinNhanVien.ContainerControl = this;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 574);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontainerNhanVien)).EndInit();
            this.tabcontainerNhanVien.ResumeLayout(false);
            this.tabHanhChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxNguoiLaoDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThangSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxGioiTinhNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoOHienNay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDauHoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDauHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViecTruocDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienSuGiaDinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienSuBanThan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupKhoaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChoOHienNay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNganhHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChiHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCongViecTruocDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTienSuGiaDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTienSuBanThan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNguoiLaoDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForThangSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoiCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgayBatDauHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.tabSucKhoe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSucKhoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSucKhoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSachNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVTenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVMaNV;
        private SplitContainerControl splitContainerControl2;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraTab.XtraTabControl tabcontainerNhanVien;
        private DevExpress.XtraTab.XtraTabPage tabHanhChinh;
        private DevExpress.XtraTab.XtraTabPage tabSucKhoe;
        private System.Windows.Forms.Label lblTitle;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControl layoutControl2;
        private DataLayoutControl dataLayoutControl1;
        private TextEdit txtMaNhanVien;
        private CheckEdit checkboxNguoiLaoDong;
        private TextEdit txtTenNhanVien;
        private TextEdit txtNgaySinh;
        private TextEdit txtThangSinh;
        private TextEdit txtNamSinh;
        private TextEdit txtDiaChi;
        private CheckEdit checkboxGioiTinhNam;
        private TextEdit txtCMND;
        private DateEdit dateNgayCap;
        private TextEdit txtNoiCap;
        private TextEdit txtHoKhau;
        private TextEdit txtChoOHienNay;
        private TextEdit txtNganhHoc;
        private TextEdit txtNoiHoc;
        private TextEdit txtDiaChiHoc;
        private DateEdit dateNgayBatDauHoc;
        private TextEdit txtCongViecTruocDay;
        private TextEdit txtTienSuGiaDinh;
        private TextEdit txtTienSuBanThan;
        private LayoutControlGroup Root;
        private LayoutControlGroup layoutControlGroup3;
        private LayoutControlItem ItemForMaNhanVien;
        private LayoutControlItem ItemForMaKhoa;
        private LayoutControlItem ItemForNguoiLaoDong;
        private LayoutControlItem ItemForTenNhanVien;
        private LayoutControlItem ItemForNgaySinh;
        private LayoutControlItem ItemForThangSinh;
        private LayoutControlItem ItemForNamSinh;
        private LayoutControlItem ItemForDiaChi;
        private LayoutControlItem ItemForGioiTinh;
        private LayoutControlItem ItemForCMND;
        private LayoutControlItem ItemForNgayCap;
        private LayoutControlItem ItemForNoiCap;
        private LayoutControlItem ItemForHoKhau;
        private LayoutControlItem ItemForChoOHienNay;
        private LayoutControlItem ItemForNganhHoc;
        private LayoutControlItem ItemForNoiHoc;
        private LayoutControlItem ItemForDiaChiHoc;
        private LayoutControlItem ItemForNgayBatDauHoc;
        private LayoutControlItem ItemForCongViecTruocDay;
        private LayoutControlItem ItemForTienSuGiaDinh;
        private LayoutControlItem ItemForTienSuBanThan;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem3;
        private LookUpEdit lookupKhoaPhong;
        private SimpleButton btnTabSucKhoeXoa;
        private SimpleButton btnTabSucKhoeSua;
        private SimpleButton btnTabSucKhoeThem;
        private DevExpress.XtraGrid.GridControl gcSucKhoe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSucKhoe;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuKhamID;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuKhamNgayKham;
        private SimpleButton btnNhanVienXoa;
        private SimpleButton btnNhanVienLuu;
        private SimpleButton btnNhanVienThemMoi;
        private SimpleButton btnNhanVienHuyBo;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorproviderThongTinNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuKhamMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVSTT;
        private TextEdit txtSTT;
        private LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachNVSTTKhoa;
        private SimpleButton btnCopyPhieuKham;
    }
}
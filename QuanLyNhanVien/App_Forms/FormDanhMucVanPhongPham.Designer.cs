namespace QuanLyNhanVien.App_Forms
{
    partial class FormDanhMucVanPhongPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMucVanPhongPham));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtMaThietBi = new DevExpress.XtraEditors.TextEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenThietBi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDanhSachThietBiMaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachThietBiTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachThietBiDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDanhSachThietBi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.txtMaThietBi);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDong);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLuu);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnMoi);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtDonVi);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtTenThietBi);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(848, 345);
            this.splitContainerControl1.SplitterPosition = 429;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaThietBi.Enabled = false;
            this.txtMaThietBi.Location = new System.Drawing.Point(12, 311);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(56, 20);
            this.txtMaThietBi.TabIndex = 20;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(309, 103);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 23);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(208, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(82, 103);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnMoi.Image")));
            this.btnMoi.Location = new System.Drawing.Point(12, 103);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(64, 23);
            this.btnMoi.TabIndex = 19;
            this.btnMoi.Text = "Mới";
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(12, 77);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(111, 20);
            this.txtDonVi.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Đơn vị:";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(12, 31);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(225, 20);
            this.txtTenThietBi.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Tên văn phòng phẩm:";
            // 
            // gcDanhSachThietBi
            // 
            this.gcDanhSachThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachThietBi.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachThietBi.MainView = this.gvDanhSachThietBi;
            this.gcDanhSachThietBi.Name = "gcDanhSachThietBi";
            this.gcDanhSachThietBi.Size = new System.Drawing.Size(429, 345);
            this.gcDanhSachThietBi.TabIndex = 11;
            this.gcDanhSachThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachThietBi});
            this.gcDanhSachThietBi.Click += new System.EventHandler(this.gcDanhSachThietBi_Click);
            // 
            // gvDanhSachThietBi
            // 
            this.gvDanhSachThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDanhSachThietBiMaThietBi,
            this.colDanhSachThietBiTenThietBi,
            this.colDanhSachThietBiDonVi});
            this.gvDanhSachThietBi.GridControl = this.gcDanhSachThietBi;
            this.gvDanhSachThietBi.Name = "gvDanhSachThietBi";
            this.gvDanhSachThietBi.OptionsBehavior.Editable = false;
            this.gvDanhSachThietBi.OptionsBehavior.ReadOnly = true;
            this.gvDanhSachThietBi.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachThietBi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDanhSachThietBiTenThietBi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDanhSachThietBiMaThietBi
            // 
            this.colDanhSachThietBiMaThietBi.Caption = "Mã Thiết Bị";
            this.colDanhSachThietBiMaThietBi.FieldName = "MaThietBi";
            this.colDanhSachThietBiMaThietBi.Name = "colDanhSachThietBiMaThietBi";
            // 
            // colDanhSachThietBiTenThietBi
            // 
            this.colDanhSachThietBiTenThietBi.Caption = "Tên văn phòng phẩm";
            this.colDanhSachThietBiTenThietBi.FieldName = "TenThietBi";
            this.colDanhSachThietBiTenThietBi.Name = "colDanhSachThietBiTenThietBi";
            this.colDanhSachThietBiTenThietBi.Visible = true;
            this.colDanhSachThietBiTenThietBi.VisibleIndex = 0;
            this.colDanhSachThietBiTenThietBi.Width = 796;
            // 
            // colDanhSachThietBiDonVi
            // 
            this.colDanhSachThietBiDonVi.Caption = "Đơn vị";
            this.colDanhSachThietBiDonVi.FieldName = "DonVi";
            this.colDanhSachThietBiDonVi.Name = "colDanhSachThietBiDonVi";
            this.colDanhSachThietBiDonVi.Visible = true;
            this.colDanhSachThietBiDonVi.VisibleIndex = 1;
            this.colDanhSachThietBiDonVi.Width = 356;
            // 
            // FormDanhMucVanPhongPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 345);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormDanhMucVanPhongPham";
            this.Text = "Danh mục Văn phòng phẩm";
            this.Load += new System.EventHandler(this.FormDanhMucVanPhongPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSachThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiMaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiDonVi;
        private DevExpress.XtraEditors.TextEdit txtMaThietBi;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnMoi;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenThietBi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
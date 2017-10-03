namespace QuanLyNhanVien.App_Forms
{
    partial class FormKhoThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoThietBi));
            this.gcKhoThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvKhoThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDanhSachKhoThietBiMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachKhoThietBiTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachKhoThietBiMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachKhoThietBiTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachKhoThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachKhoThietBiSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.btnMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKyHieu = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.selectKhoaPhong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyHieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectKhoaPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKhoThietBi
            // 
            this.gcKhoThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKhoThietBi.Location = new System.Drawing.Point(12, 12);
            this.gcKhoThietBi.MainView = this.gvKhoThietBi;
            this.gcKhoThietBi.Name = "gcKhoThietBi";
            this.gcKhoThietBi.Size = new System.Drawing.Size(662, 275);
            this.gcKhoThietBi.TabIndex = 0;
            this.gcKhoThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoThietBi});
            this.gcKhoThietBi.Click += new System.EventHandler(this.gcKhoThietBi_Click);
            // 
            // gvKhoThietBi
            // 
            this.gvKhoThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDanhSachKhoThietBiMaKho,
            this.colDanhSachKhoThietBiTenKho,
            this.colDanhSachKhoThietBiMaKhoa,
            this.colDanhSachKhoThietBiTenKhoa,
            this.colDanhSachKhoThietBi,
            this.colDanhSachKhoThietBiSTT});
            this.gvKhoThietBi.GridControl = this.gcKhoThietBi;
            this.gvKhoThietBi.GroupCount = 1;
            this.gvKhoThietBi.Name = "gvKhoThietBi";
            this.gvKhoThietBi.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvKhoThietBi.OptionsBehavior.Editable = false;
            this.gvKhoThietBi.OptionsBehavior.ReadOnly = true;
            this.gvKhoThietBi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDanhSachKhoThietBiTenKhoa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDanhSachKhoThietBiMaKho
            // 
            this.colDanhSachKhoThietBiMaKho.Caption = "Mã kho";
            this.colDanhSachKhoThietBiMaKho.FieldName = "MaKho";
            this.colDanhSachKhoThietBiMaKho.Name = "colDanhSachKhoThietBiMaKho";
            this.colDanhSachKhoThietBiMaKho.Width = 97;
            // 
            // colDanhSachKhoThietBiTenKho
            // 
            this.colDanhSachKhoThietBiTenKho.Caption = "Tên kho";
            this.colDanhSachKhoThietBiTenKho.FieldName = "TenKho";
            this.colDanhSachKhoThietBiTenKho.Name = "colDanhSachKhoThietBiTenKho";
            this.colDanhSachKhoThietBiTenKho.Visible = true;
            this.colDanhSachKhoThietBiTenKho.VisibleIndex = 2;
            this.colDanhSachKhoThietBiTenKho.Width = 466;
            // 
            // colDanhSachKhoThietBiMaKhoa
            // 
            this.colDanhSachKhoThietBiMaKhoa.Caption = "Mã khoa";
            this.colDanhSachKhoThietBiMaKhoa.FieldName = "MaKhoa";
            this.colDanhSachKhoThietBiMaKhoa.Name = "colDanhSachKhoThietBiMaKhoa";
            this.colDanhSachKhoThietBiMaKhoa.Width = 323;
            // 
            // colDanhSachKhoThietBiTenKhoa
            // 
            this.colDanhSachKhoThietBiTenKhoa.Caption = "Tên khoa";
            this.colDanhSachKhoThietBiTenKhoa.FieldName = "TenKhoa";
            this.colDanhSachKhoThietBiTenKhoa.Name = "colDanhSachKhoThietBiTenKhoa";
            this.colDanhSachKhoThietBiTenKhoa.Visible = true;
            this.colDanhSachKhoThietBiTenKhoa.VisibleIndex = 3;
            this.colDanhSachKhoThietBiTenKhoa.Width = 331;
            // 
            // colDanhSachKhoThietBi
            // 
            this.colDanhSachKhoThietBi.Caption = "Mã kho";
            this.colDanhSachKhoThietBi.FieldName = "KyHieu";
            this.colDanhSachKhoThietBi.Name = "colDanhSachKhoThietBi";
            this.colDanhSachKhoThietBi.Visible = true;
            this.colDanhSachKhoThietBi.VisibleIndex = 1;
            this.colDanhSachKhoThietBi.Width = 107;
            // 
            // colDanhSachKhoThietBiSTT
            // 
            this.colDanhSachKhoThietBiSTT.Caption = "STT";
            this.colDanhSachKhoThietBiSTT.FieldName = "STT";
            this.colDanhSachKhoThietBiSTT.Name = "colDanhSachKhoThietBiSTT";
            this.colDanhSachKhoThietBiSTT.Visible = true;
            this.colDanhSachKhoThietBiSTT.VisibleIndex = 0;
            this.colDanhSachKhoThietBiSTT.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên kho:";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(85, 293);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(291, 20);
            this.txtTenKho.TabIndex = 4;
            // 
            // btnMoi
            // 
            this.btnMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnMoi.Image")));
            this.btnMoi.Location = new System.Drawing.Point(85, 345);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(64, 23);
            this.btnMoi.TabIndex = 5;
            this.btnMoi.Text = "Mới";
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(155, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(281, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(382, 345);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã kho:";
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Enabled = false;
            this.txtKyHieu.Location = new System.Drawing.Point(438, 293);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(121, 20);
            this.txtKyHieu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(622, 293);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(52, 20);
            this.txtMaKho.TabIndex = 4;
            // 
            // selectKhoaPhong
            // 
            this.selectKhoaPhong.Location = new System.Drawing.Point(85, 320);
            this.selectKhoaPhong.Name = "selectKhoaPhong";
            this.selectKhoaPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectKhoaPhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhoa", "Mã khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoa", 80, "Tên khoa")});
            this.selectKhoaPhong.Size = new System.Drawing.Size(212, 20);
            this.selectKhoaPhong.TabIndex = 6;
            // 
            // FormKhoThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.selectKhoaPhong);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKyHieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcKhoThietBi);
            this.Name = "FormKhoThietBi";
            this.Text = "Danh mục kho thiết bị";
            this.Load += new System.EventHandler(this.FormKhoThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyHieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectKhoaPhong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcKhoThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBiMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBiTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBiMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBiTenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachKhoThietBiSTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.SimpleButton btnMoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtKyHieu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.LookUpEdit selectKhoaPhong;
    }
}
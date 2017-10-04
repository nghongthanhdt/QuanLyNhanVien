using DevExpress.XtraEditors;

namespace QuanLyNhanVien.App_Forms
{
    partial class FormPhieuNhapKhoThemThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhapKhoThemThietBi));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.linkTuyChon = new System.Windows.Forms.LinkLabel();
            this.gcDanhSachThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDanhSachThietBiMaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachThietBiTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachThietBiDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.linkTuyChon);
            this.layoutControl1.Controls.Add(this.gcDanhSachThietBi);
            this.layoutControl1.Controls.Add(this.btnDong);
            this.layoutControl1.Controls.Add(this.btnChon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(593, 418);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // linkTuyChon
            // 
            this.linkTuyChon.Location = new System.Drawing.Point(434, 64);
            this.linkTuyChon.Name = "linkTuyChon";
            this.linkTuyChon.Size = new System.Drawing.Size(147, 20);
            this.linkTuyChon.TabIndex = 9;
            this.linkTuyChon.TabStop = true;
            this.linkTuyChon.Text = "Tùy chọn";
            this.linkTuyChon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTuyChon_LinkClicked);
            // 
            // gcDanhSachThietBi
            // 
            this.gcDanhSachThietBi.Location = new System.Drawing.Point(12, 12);
            this.gcDanhSachThietBi.MainView = this.gvDanhSachThietBi;
            this.gcDanhSachThietBi.Name = "gcDanhSachThietBi";
            this.gcDanhSachThietBi.Size = new System.Drawing.Size(418, 394);
            this.gcDanhSachThietBi.TabIndex = 8;
            this.gcDanhSachThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachThietBi});
            this.gcDanhSachThietBi.Click += new System.EventHandler(this.gcDanhSachThietBi_Click);
            this.gcDanhSachThietBi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gcDanhSachThietBi_KeyUp);
            // 
            // gvDanhSachThietBi
            // 
            this.gvDanhSachThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDanhSachThietBiMaThietBi,
            this.colDanhSachThietBiTenThietBi,
            this.colDanhSachThietBiDonGia});
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
            this.colDanhSachThietBiMaThietBi.Caption = "Mã thiết bị";
            this.colDanhSachThietBiMaThietBi.Name = "colDanhSachThietBiMaThietBi";
            // 
            // colDanhSachThietBiTenThietBi
            // 
            this.colDanhSachThietBiTenThietBi.Caption = "Tên thiết bị";
            this.colDanhSachThietBiTenThietBi.FieldName = "TenThietBi";
            this.colDanhSachThietBiTenThietBi.Name = "colDanhSachThietBiTenThietBi";
            this.colDanhSachThietBiTenThietBi.Visible = true;
            this.colDanhSachThietBiTenThietBi.VisibleIndex = 0;
            this.colDanhSachThietBiTenThietBi.Width = 470;
            // 
            // colDanhSachThietBiDonGia
            // 
            this.colDanhSachThietBiDonGia.Caption = "Đơn vị";
            this.colDanhSachThietBiDonGia.FieldName = "DonVi";
            this.colDanhSachThietBiDonGia.Name = "colDanhSachThietBiDonGia";
            this.colDanhSachThietBiDonGia.Visible = true;
            this.colDanhSachThietBiDonGia.VisibleIndex = 1;
            this.colDanhSachThietBiDonGia.Width = 143;
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(434, 38);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(147, 22);
            this.btnDong.StyleController = this.layoutControl1;
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(434, 12);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(147, 22);
            this.btnChon.StyleController = this.layoutControl1;
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layout1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(593, 418);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnChon;
            this.layoutControlItem2.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(151, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDong;
            this.layoutControlItem3.Location = new System.Drawing.Point(422, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(151, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDanhSachThietBi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(422, 398);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layout1
            // 
            this.layout1.Control = this.linkTuyChon;
            this.layout1.Location = new System.Drawing.Point(422, 52);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(151, 346);
            this.layout1.TextSize = new System.Drawing.Size(0, 0);
            this.layout1.TextVisible = false;
            // 
            // FormPhieuNhapKhoThemThietBi
            // 
            this.AcceptButton = this.btnChon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(593, 418);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormPhieuNhapKhoThemThietBi";
            this.Text = "FormPhieuNhapKhoThemThietBi";
            this.Load += new System.EventHandler(this.FormPhieuNhapKhoThemThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private SimpleButton btnDong;
        private SimpleButton btnChon;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.LinkLabel linkTuyChon;
        private DevExpress.XtraGrid.GridControl gcDanhSachThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiMaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachThietBiDonGia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layout1;
    }
}
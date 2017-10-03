namespace QuanLyNhanVien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.menuNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.menuBaoCaoSucKhoe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuDanhSachKhoThietBi = new DevExpress.XtraBars.BarButtonItem();
            this.menudanhSachVanPhongPham = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.menuPhatVanPhongPham = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.menuNhanVien,
            this.barButtonItem3,
            this.menuBaoCaoSucKhoe,
            this.barButtonItem5,
            this.menuDanhSachKhoThietBi,
            this.menudanhSachVanPhongPham,
            this.menuNhapKho,
            this.menuPhatVanPhongPham});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Khoa phòng";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Caption = "Nhân viên";
            this.menuNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("menuNhanVien.Glyph")));
            this.menuNhanVien.Id = 2;
            this.menuNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuNhanVien.LargeGlyph")));
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuNhanVien_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // menuBaoCaoSucKhoe
            // 
            this.menuBaoCaoSucKhoe.Caption = "Báo cáo";
            this.menuBaoCaoSucKhoe.Glyph = ((System.Drawing.Image)(resources.GetObject("menuBaoCaoSucKhoe.Glyph")));
            this.menuBaoCaoSucKhoe.Id = 4;
            this.menuBaoCaoSucKhoe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuBaoCaoSucKhoe.LargeGlyph")));
            this.menuBaoCaoSucKhoe.Name = "menuBaoCaoSucKhoe";
            this.menuBaoCaoSucKhoe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBaoCaoSucKhoe_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Nhập liệu";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuBaoCaoSucKhoe);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Phòng tổ chức";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.menuDanhSachKhoThietBi);
            this.ribbonPageGroup2.ItemLinks.Add(this.menudanhSachVanPhongPham);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục";
            // 
            // menuDanhSachKhoThietBi
            // 
            this.menuDanhSachKhoThietBi.Caption = "Kho";
            this.menuDanhSachKhoThietBi.Glyph = ((System.Drawing.Image)(resources.GetObject("menuDanhSachKhoThietBi.Glyph")));
            this.menuDanhSachKhoThietBi.Id = 6;
            this.menuDanhSachKhoThietBi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuDanhSachKhoThietBi.LargeGlyph")));
            this.menuDanhSachKhoThietBi.Name = "menuDanhSachKhoThietBi";
            this.menuDanhSachKhoThietBi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuDanhSachKhoThietBi_ItemClick);
            // 
            // menudanhSachVanPhongPham
            // 
            this.menudanhSachVanPhongPham.Caption = "Văn phòng phẩm";
            this.menudanhSachVanPhongPham.Glyph = ((System.Drawing.Image)(resources.GetObject("menudanhSachVanPhongPham.Glyph")));
            this.menudanhSachVanPhongPham.Id = 7;
            this.menudanhSachVanPhongPham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menudanhSachVanPhongPham.LargeGlyph")));
            this.menudanhSachVanPhongPham.Name = "menudanhSachVanPhongPham";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.menuNhapKho);
            this.ribbonPageGroup3.ItemLinks.Add(this.menuPhatVanPhongPham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý văn phòng phẩm";
            // 
            // menuNhapKho
            // 
            this.menuNhapKho.Caption = "Nhập kho";
            this.menuNhapKho.Glyph = ((System.Drawing.Image)(resources.GetObject("menuNhapKho.Glyph")));
            this.menuNhapKho.Id = 8;
            this.menuNhapKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuNhapKho.LargeGlyph")));
            this.menuNhapKho.Name = "menuNhapKho";
            // 
            // menuPhatVanPhongPham
            // 
            this.menuPhatVanPhongPham.Caption = "Phát văn phòng phẩm";
            this.menuPhatVanPhongPham.Glyph = ((System.Drawing.Image)(resources.GetObject("menuPhatVanPhongPham.Glyph")));
            this.menuPhatVanPhongPham.Id = 9;
            this.menuPhatVanPhongPham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("menuPhatVanPhongPham.LargeGlyph")));
            this.menuPhatVanPhongPham.Name = "menuPhatVanPhongPham";
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BỆNH VIỆN PHỤC HỒI CHỨC NĂNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem menuNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem menuBaoCaoSucKhoe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem menuDanhSachKhoThietBi;
        private DevExpress.XtraBars.BarButtonItem menudanhSachVanPhongPham;
        private DevExpress.XtraBars.BarButtonItem menuNhapKho;
        private DevExpress.XtraBars.BarButtonItem menuPhatVanPhongPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}


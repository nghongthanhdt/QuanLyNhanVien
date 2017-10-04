using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyNhanVien.App_Forms
{
    partial class FormTocKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTocKy));
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnTocKyThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcTocKy = new DevExpress.XtraGrid.GridControl();
            this.gvTocKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSTT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcTocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(146, 296);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 29);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(223, 296);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(113, 29);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            // 
            // btnChon
            // 
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(13, 296);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(127, 29);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnTocKyThem
            // 
            this.btnTocKyThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTocKyThem.Image = ((System.Drawing.Image)(resources.GetObject("btnTocKyThem.Image")));
            this.btnTocKyThem.Location = new System.Drawing.Point(403, 208);
            this.btnTocKyThem.Name = "btnTocKyThem";
            this.btnTocKyThem.Size = new System.Drawing.Size(93, 29);
            this.btnTocKyThem.TabIndex = 10;
            this.btnTocKyThem.Text = "Thêm";
            this.btnTocKyThem.Click += new System.EventHandler(this.btnTocKyThem_Click);
            // 
            // gcTocKy
            // 
            this.gcTocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTocKy.Location = new System.Drawing.Point(12, 12);
            this.gcTocKy.MainView = this.gvTocKy;
            this.gcTocKy.Name = "gcTocKy";
            this.gcTocKy.Size = new System.Drawing.Size(385, 275);
            this.gcTocKy.TabIndex = 1;
            this.gcTocKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTocKy});
            this.gcTocKy.Click += new System.EventHandler(this.gcTocKy_Click);
            // 
            // gvTocKy
            // 
            this.gvTocKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKyHieu,
            this.colNoiDung,
            this.colSTT});
            this.gvTocKy.GridControl = this.gcTocKy;
            this.gvTocKy.Name = "gvTocKy";
            this.gvTocKy.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTocKy.OptionsView.ShowAutoFilterRow = true;
            this.gvTocKy.OptionsView.ShowGroupPanel = false;
            this.gvTocKy.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTocKy_RowUpdated);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Ký hiệu";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 2;
            this.colKyHieu.Width = 209;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội dung";
            this.colNoiDung.FieldName = "NoiDung";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 1;
            this.colNoiDung.Width = 849;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 94;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(403, 162);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ký hiệu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(403, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nội dung:";
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKyHieu.Location = new System.Drawing.Point(403, 181);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(137, 21);
            this.txtKyHieu.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Location = new System.Drawing.Point(403, 79);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(137, 77);
            this.txtNoiDung.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(403, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "STT:";
            // 
            // txtSTT
            // 
            this.txtSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTT.Location = new System.Drawing.Point(403, 32);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(65, 21);
            this.txtSTT.TabIndex = 7;
            // 
            // FormTocKy
            // 
            this.AcceptButton = this.btnChon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(552, 337);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtKyHieu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTocKy);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTocKyThem);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXoa);
            this.Name = "FormTocKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton btnXoa;
        private SimpleButton btnDong;
        private SimpleButton btnChon;
        private SimpleButton btnTocKyThem;
        private GridControl gcTocKy;
        private GridView gvTocKy;
        private GridColumn colID;
        private GridColumn colKyHieu;
        private GridColumn colNoiDung;
        private GridColumn colSTT;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.TextBox txtNoiDung;
        private LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtSTT;
    }
}
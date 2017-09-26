using QuanLyNhanVien.App_Forms;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void menuNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            bool IsOpen = false;
            foreach (Form myForm in Application.OpenForms)
            {
                if (myForm.Name == "FormNhanVien")
                {
                    IsOpen = true;
                    myForm.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FormNhanVien f = new FormNhanVien();
                f.Name = "FormNhanVien";
                f.Text = "Nhân viên";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void menuBaoCaoSucKhoe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form myForm in Application.OpenForms)
            {
                if (myForm.Name == "FormBaoCaoDanhSachSucKhoe")
                {
                    IsOpen = true;
                    myForm.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FormBaoCaoDanhSachSucKhoe f = new FormBaoCaoDanhSachSucKhoe();
                f.Name = "FormBaoCaoDanhSachSucKhoe";
                f.Text = "Chọn báo cáo";
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}

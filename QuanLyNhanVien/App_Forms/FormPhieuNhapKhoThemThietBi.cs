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

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormPhieuNhapKhoThemThietBi : DevExpress.XtraEditors.XtraForm
    {
        public string outMaThietBi = "0";
        public bool isSelected = false;
        public FormPhieuNhapKhoThemThietBi()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void linkTuyChon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tùy chọn");
        }

        private void FormPhieuNhapKhoThemThietBi_Load(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            gcDanhSachThietBi.DataSource = db.T_Lib_ThietBi.Where(x => x.IsEnable == true).OrderBy(x => x.TenThietBi).ToList();

        }

        private void gcDanhSachThietBi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (gvDanhSachThietBi.FocusedRowHandle >= 0)
            {
                outMaThietBi = gvDanhSachThietBi.GetFocusedRowCellValue("MaThietBi").ToString();
                isSelected = true;
            }
            else
            {
                outMaThietBi = "0";

            }
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            outMaThietBi = "0";
            this.Close();
        }

        private void gcDanhSachThietBi_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
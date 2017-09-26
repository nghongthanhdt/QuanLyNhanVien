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
using System.Data.Entity;

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormTocKy : DevExpress.XtraEditors.XtraForm
    {
        public int intLoai = 0;
        public string outText = "";
        QuanLyNhanVienEntities db;
        public FormTocKy()
        {
            InitializeComponent();
            
        }

        private void FormTocKy_Load(object sender, EventArgs e)
        {
            db = new QuanLyNhanVienEntities();
            loadDanhSachTocKy();
            btnChon.Focus();
        }
        private void loadDanhSachTocKy()
        {
            gcTocKy.DataSource = db.T_TocKy.Where(x => x.Loai == intLoai).OrderBy(x => x.STT).ToList();
        }

        private void gvTocKy_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            db.SaveChanges();
        }

        private void btnTocKyThem_Click(object sender, EventArgs e)
        {
            if (txtKyHieu.Text == "" || txtNoiDung.Text == "")
            {
                MessageBox.Show("Nhập ký hiệu và nội dung");
                return;
            }
            T_TocKy tocKy = new T_TocKy();
            tocKy.Loai = short.Parse(intLoai.ToString());
            tocKy.KyHieu = txtKyHieu.Text;
            tocKy.NoiDung = txtNoiDung.Text;
            int stt = 1;
            try
            {
                stt = int.Parse(txtSTT.Text);
            }
            catch { }
            tocKy.STT = stt;

            db.T_TocKy.Add(tocKy);
            db.SaveChanges();
            loadDanhSachTocKy();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(gvTocKy.GetFocusedRowCellValue("ID").ToString());
                var tocKy = db.T_TocKy.Find(id);
                db.T_TocKy.Remove(tocKy);
                db.SaveChanges();
                loadDanhSachTocKy();
            } catch
            {

            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                outText = gvTocKy.GetFocusedRowCellValue("NoiDung").ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnDong.PerformClick();           
        }
    }
}
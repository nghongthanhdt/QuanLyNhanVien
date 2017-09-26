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
    public partial class FormNgayKham : DevExpress.XtraEditors.XtraForm
    {
        public int maNhanVien = 0;
        public FormNgayKham()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay = dateNgay.DateTime;
                if (dateNgay.Text != "")
                {
                    QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
                    T_PhieuKham pk = new T_PhieuKham();
                    pk.MaNhanVien = maNhanVien;
                    pk.NgayKham = ngay;
                    db.T_PhieuKham.Add(pk);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa chọn ngày khám!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            
            
        }
    }
}
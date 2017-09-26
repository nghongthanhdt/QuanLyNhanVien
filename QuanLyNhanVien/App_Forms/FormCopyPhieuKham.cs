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
    public partial class FormCopyPhieuKham : DevExpress.XtraEditors.XtraForm
    {
        public int idPK = 0;
        QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
        T_PhieuKham pk;
        public FormCopyPhieuKham()
        {
            InitializeComponent();
        }

        private void FormCopyPhieuKham_Load(object sender, EventArgs e)
        {
            pk = new T_PhieuKham();
            pk = db.T_PhieuKham.Find(idPK);

            T_NhanVien nv = db.T_NhanVien.Find(pk.MaNhanVien);

            lblHoTen.Text = nv.TenNhanVien;
            dateNgayKham.DateTime = pk.NgayKham;                       

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (dateNgayKhamMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập ngày");
                return;
            }
            T_PhieuKham pkNew = new T_PhieuKham();
            pkNew = pk;
            pkNew.NgayKham = dateNgayKhamMoi.DateTime;
            db.T_PhieuKham.Add(pkNew);
            db.SaveChanges();
            this.Close();

        }
    }
}
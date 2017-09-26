﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.App_Forms
{
    public partial class FormBaoCaoDanhSachSucKhoe : DevExpress.XtraEditors.XtraForm
    {
        public FormBaoCaoDanhSachSucKhoe()
        {
            InitializeComponent();
        }

        private void FormBaoCaoDanhSachSucKhoe_Load(object sender, EventArgs e)
        {
            selectNam.Enabled = false;


            selectBaoCaoTheo.SelectedIndex = 0;
        }

        private void selectBaoCaoTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectBaoCaoTheo.SelectedIndex == 1)
            {
                selectNam.Enabled = true;
                selectNam.Items.Clear();
                for (int i = DateTime.Now.Year; i >= 1990; i--)
                {                    
                    selectNam.Items.Add(i.ToString());
                }
            }
            else
            {
                selectNam.Items.Clear();
                selectNam.Text = "";
                selectNam.Enabled = false;
                
            }

            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities db = new QuanLyNhanVienEntities();
            gcDanhSachSucKhoe.DataSource = db.P_DanhSachSucKhoeNhanVien("").ToList();
        }
    }
}
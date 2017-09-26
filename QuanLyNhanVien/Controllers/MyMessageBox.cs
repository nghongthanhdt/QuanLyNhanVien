using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien.Controllers
{
    public class MyMessageBox
    {
        public static bool ShowConfirm(string message)
        {
            DialogResult dr = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

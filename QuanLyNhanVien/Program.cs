using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using QuanLyNhanVien.App_Forms;
using System.Threading;

namespace QuanLyNhanVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();




            SplashScreenMain.ShowSplashScreen();
            FormDanhSachPhieuLanh mainForm = new FormDanhSachPhieuLanh(); //this takes ages
            Thread.Sleep(2000);
            SplashScreenMain.CloseForm();
            Thread.Sleep(500);
            Application.Run(mainForm);

            //Application.Run(new FormMain());
        }
    }
}

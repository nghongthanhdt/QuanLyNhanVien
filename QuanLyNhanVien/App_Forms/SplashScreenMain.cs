using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace QuanLyNhanVien.App_Forms
{
    public partial class SplashScreenMain : SplashScreen
    {

        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static SplashScreenMain splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(SplashScreenMain.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        static private void ShowForm()
        {
            splashForm = new SplashScreenMain();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(SplashScreenMain.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
        }


        public SplashScreenMain()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }


    }
}
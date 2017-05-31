using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace FAITool
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
            //Application.Run(new FORM__ScanSystem());
            //Application.Run(new FORM__CameraCapture("1S10HU0000USMJ03YKXR"));
            //Application.Run(new FORM__FileRenamePopup("1S10HU0000USMJ03YKXR"));
            Application.Run(new FORM__Clock());
            //Application.Run(new FORM__SystemDetails("1S10HU0000USMJ03YKXR"));
        }
    }
}

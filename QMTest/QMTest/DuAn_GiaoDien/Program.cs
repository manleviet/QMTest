﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace DuAn_GiaoDien
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

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");//DevExpress Style
            //
            DefaultLookAndFeel df = new DefaultLookAndFeel();
            df.LookAndFeel.SkinName = "Metropolis";

            //Application.Run(new  frm_DangNhap());
            Application.Run(new frm_DangNhap());
        }
    }
}

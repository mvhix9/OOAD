﻿using Demo.uiNhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiBacSi;
using uiNhanVien;
using uiQuanTriVien;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new NhanVienFRM());
            Application.Run(new MainFRM());
            //Application.Run(new TraCuuBenhNhan());
            //Application.Run(new BACSIFRM());
            //Application.Run(new QuanTriVienFRM());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}

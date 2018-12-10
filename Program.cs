using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

//
//  THIS IS THE .XML CODE YOU WILL NEED SERVER SIDE
//
// <? xml version="1.0" encoding="UTF-8"?>
// <item>
//    <version>1.0.0.0</version>
//    <url>http://localhost/updates/AutoUpdater.zip</url>
//    <changelog>https://localhost/AutoUpdater.html</changelog>
//    <mandatory>false</mandatory>
// </item>
//
//


namespace MPBSplashUpdate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("http://localhost/updates/AutoUpdater.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

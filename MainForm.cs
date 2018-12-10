using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBSplashUpdate.SplashScreen;

namespace MPBSplashUpdate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //DO NOT CHANGE - CAN ADD ON JUST KEEP WHATS HERE
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        // SPLASH SCREEN - DO NOT REMOVE
        public void SplashStart()
        {
            Application.Run(new SplashScreen1());
        }
        // END SPLASH SCREEN
    }
}

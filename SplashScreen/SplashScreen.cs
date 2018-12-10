using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBSplashUpdate.SplashScreen
{
    public partial class SplashScreen1 : Form
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        // SPALSH SCREEN DO NOT REMOVE
        private void timer1_tick(object sender, EventArgs e)
        {
            LoadingProgress.Increment(1);
            if (LoadingProgress.Value == 100)
                timer1.Stop();
        }
    }
}

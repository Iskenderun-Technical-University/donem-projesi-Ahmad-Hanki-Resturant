using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant
{
    public partial class Loading : Form
    {
        
        public Loading()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            string path = "C:\\Users\\ir4ve\\OneDrive\\Desktop\\donem-projesi-Ezaiia\\video\\Happy.mp4";
            axWindowsMediaPlayer1.URL = path;

            axWindowsMediaPlayer1.settings.setMode("loop", false);
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;


            Timer timer = new Timer();
            timer.Interval = 6000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            this.Close();

        }

    }
}

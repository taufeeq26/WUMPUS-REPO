using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class SplashScreenForm : Form
    {
        SplashScreen splashObject;
        public SplashScreenForm()
        {
            InitializeComponent();
            splashObject = new SplashScreen();
        }

        public void SetSplashScreen(SplashScreen splScreen)
        {
            splashObject.HintText = splScreen.HintText;
            splashObject.DisplayTimeSeconds = splScreen.DisplayTimeSeconds;
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            hintLabel.Text = splashObject.HintText;
            displayTimer.Interval = splashObject.DisplayTimeSeconds * 1000;

            hintLabel.Visible = true;
            displayTimer.Start();
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            hintLabel.Visible = false;
            displayTimer.Stop();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class HighScoreDisplayForm : Form
    {
        HighScore highScoreTracker = new HighScore();
        public HighScoreDisplayForm()
        {
            InitializeComponent();
        }

        private void HighScoreDisplayForm_Load(object sender, EventArgs e)
        {
            highScoreTracker.loadHighScores(@"tempscores.txt");

            string highScoreText = "";
            for (int i = 0; i < highScoreTracker.NumberOfScores; i++)
            {
                highScoreText += highScoreTracker.scores[i].ToString();
                highScoreText += "\r\n";
            }
            highScoreLabel.Text = highScoreText;
        }
    }
}

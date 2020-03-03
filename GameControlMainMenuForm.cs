using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class GameControlMainMenuForm : Form
    {
        GameControl gameController;
        SplashScreen splScreen;
        public GameControlMainMenuForm()
        {
            InitializeComponent();

            gameController = new GameControl(GameState.PlayingGame);
            splScreen = new SplashScreen("Did you know that Bats can see in the dark?", 5); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            SplashScreenForm splashForm = new SplashScreenForm();
            splashForm.SetSplashScreen(splScreen);
            splashForm.ShowDialog();

            GUIForm guiForm = new GUIForm();
            guiForm.ShowDialog();
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            HighScoreDisplayForm hsForm = new HighScoreDisplayForm();
            hsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

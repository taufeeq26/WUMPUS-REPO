using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class SplashScreen
    {
        string hintText;
        int displayTimeSeconds;

        public SplashScreen()
        {
            hintText = "";
            displayTimeSeconds = 10;
        }

        public SplashScreen(string hint, int time)
        {
            hintText = hint;
            displayTimeSeconds = time;
        }

        public string HintText { get => hintText; set => hintText = value; }
        public int DisplayTimeSeconds { get => displayTimeSeconds; set => displayTimeSeconds = value; }
    }
}

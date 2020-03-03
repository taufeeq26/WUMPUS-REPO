using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameControl
    {

        private GameState currentState;
        private String userInput;

        //Constructors
        public GameControl()
        {

        }

        public GameControl(GameState state)
        {
            currentState = state;
        }

        public GameState GetCurrentState()
        {
            return currentState;
        }

        public void SetCurrentState(GameState state)
        {
            currentState = state;
        }

        public void HandlePlayerCommand()
        {

        }

        public void HandleGameControlCommand()
        {

        }
    }

    public enum GameState : int
    {
        PlayingGame = 1,
        DisplayingSplashScreen = 2,
        DisplayingHighScores = 3
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WumpusTest
{
    class HighScore
    {
        public int NumberOfScores = 0;

        public PlayerScore[] scores = new PlayerScore[10];
        
        public void loadHighScores (string path)
        {
            if (File.Exists(path))
            {
                TextReader myReader = new StreamReader(path);
                String readStr = "";

                while (readStr != null && NumberOfScores < 10)
                {
                    readStr = myReader.ReadLine();
                    if (readStr != null)
                    {
                        PlayerScore plScore = new PlayerScore(readStr);
                        scores[NumberOfScores] = plScore;
                        NumberOfScores++;
                    }
                }

                myReader.Close();
            }
        }

        public void saveHighScores(string path)
        {
            TextWriter myWriter = new StreamWriter(path);

            for (int i = 0; i < NumberOfScores; i++)
            {
                myWriter.WriteLine(scores[i].GetString());
            }

            myWriter.Close();
        }
    }

    class PlayerScore
    {
        public int Score = 0;
        public string Name = "";
        public string caveName = "";
        public DateTime timeStamp = DateTime.MinValue;

        public PlayerScore(string readStr)
        {
            char[] charSeparators = new char[] { ',' };
            string[] sepStr = readStr.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            
            Name = sepStr[0];
            Score = int.Parse(sepStr[1]);
            caveName = sepStr[2];
            timeStamp = DateTime.Parse(sepStr[3]);
        }

        public string GetString()
        {
            return Name + "," + Score.ToString() + "," + caveName + "," + timeStamp.ToString("o");
        }

        public override string ToString()
        {
            return Name + "     " + Score.ToString() + "     " + caveName + "     " + timeStamp.ToString("o");
        }
    }
}

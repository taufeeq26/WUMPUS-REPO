using System;

/* update High Scores
 * Prajeet Pounraj and Taufeeq Ali
 * 12/17/19
 * Period 4
 */
namespace highscore
{

	public class HighScore
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public static void main(String[] args) throws IOException
		public static void Main(string[] args)
		{

			Scanner inputReader = new Scanner(Console.In);

			// Get the inputs
			Console.WriteLine("Player Name: ");
			string inputName = inputReader.next();
			Console.WriteLine("What is the new Score: ");
			int inputScore = inputReader.Next();

			File myFile = new File("newHighScore.txt");
			if (myFile.exists())
			{
				myFile.delete();
			}

			myFile.createNewFile();
			PrintStream stream = new PrintStream(myFile);

			File userFile = new File("HighScore.txt");

			if (userFile.exists())
			{
				int playerCount = 0;
			   Scanner fileReader = new Scanner(userFile);
			   while (fileReader.hasNext())
			   {
				  string playerName = fileReader.next();
				  int playerScore = fileReader.Next();
				  // Check if the new score is higher than this player score
				  if (inputScore > playerScore)
				  {
					   stream.println(inputName + " " + inputScore);
					   playerCount++;
					   // Set inputScore to 0 so that it will not come in here again
					   inputScore = 0;
				  }

				  // Check that we only write for 5 players
				  if (playerCount < 5)
				  {

					stream.println(playerName + " " + playerScore);
					playerCount++;
				  }
			   }
				stream.flush();
				stream.close();

				fileReader.close();
			}

			File backupFile = new File("backupHighScore.txt");
			if (backupFile.exists())
			{
				backupFile.delete();
			}

			userFile.renameTo(backupFile);

			myFile.renameTo(userFile);

			// verify content
			Scanner reader = new Scanner(userFile);
			while (reader.hasNextLine())
			{
				Console.WriteLine(reader.nextLine());
			}
			reader.close();
		}
	}


}
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        bool gameOn = true;
        bool validUserInput = false;
        bool validRandom = false;
        var rand = new Random();
        int playerRounds,
            computerRounds,
            computer,
            player;
        char userInput = ' ';
        playerRounds = computerRounds = computer = 0;

        Console.Clear();

        while (gameOn)
        {
            Console.Clear(); //Rense konsolen
            Graphics.ShotgunLogo(); //Spelets logga
            Console.WriteLine($"\nSpelarens har: {playerRounds} skott kvar");
            Console.WriteLine($"Datorn har :{computerRounds} skott kvar");

            Prompts.Choises(playerRounds);
            userInput = char.ToUpper(Console.ReadKey().KeyChar); //Spara valet av spelare i userInput
            player = Logics.PlayerChoice(userInput); // översätter S/L/B till 0,1,2. Kommer även 3 för shotgun senare

            while (!validRandom)
            {
                if (computerRounds == 0 && computer == 0)
                {
                    computer = rand.Next(1, 2); //Slumpa in 0 - 3.
                    break;
                }
                else if (computerRounds < 3)
                {
                    computer = rand.Next(0, 2); //Slumpa in 0 - 3.
                    break;
                }
                else if (computerRounds == 3)
                {
                    computer = 3;
                    break;
                }
            }
            Logics.Rounds(player, ref playerRounds); //Adderar/subtraherar till rounds(skott)
            Logics.Rounds(computer, ref computerRounds); //Adderar/subtraherar till rounds(skott)

            if (!Logics.ScoreBoard(player, computer))
            {
                Console.WriteLine("Vill du spela igen? J/N");
                char playAgain = char.ToUpper(Console.ReadKey().KeyChar);
                if (playAgain == 'N')
                {
                    gameOn = false;
                }
                else if (playAgain == 'J')
                {
                    playerRounds = 0;
                    computerRounds = 0;
                    gameOn = true;
                }
            }
        }
    }
}

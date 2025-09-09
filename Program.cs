class Program
{
    static void Main()
    {
        bool gameOn = true;
        bool correctUserInput = false;
        bool validRandom = false;
        Console.Clear();
        int playerRounds, computerRounds, computer;
        playerRounds = computerRounds = computer = 0;
        var rand = new Random();

        while (gameOn)
        {

            Graphics.ShotgunLogo(); //Spelets logga
            Console.WriteLine($"\nSpelarens har: {playerRounds} skott kvar");
            Console.WriteLine($"Datorn har :{computerRounds} skott kvar");

            Prompts.Choises(playerRounds);
            char userInput = char.ToUpper(Console.ReadKey().KeyChar); //Spara valet av spelare i userInput
            Console.Clear(); //Rense konsolen

            int player = Logics.PlayerChoice(userInput); // översätter S/L/B till 0,1,2. Kommer även 3 för shotgun senare

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

            gameOn = Logics.ScoreBoard(player, computer);
        }
    }
}

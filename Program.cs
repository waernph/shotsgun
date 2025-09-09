class Program
{
    static void Main()
    {
        bool gameOn = true;
        bool correctUserInput = true;
        Console.Clear();
        int playerRounds, computerRounds, computer;
        playerRounds = computerRounds = 0;
        var rand = new Random();

        while (gameOn)
        {

            Graphics.ShotgunLogo(); //Spelets logga

            Prompts.Choises(playerRounds);
            char userInput = char.ToUpper(Console.ReadKey().KeyChar); //Spara valet av spelare i userInput
            Console.Clear(); //Rense konsolen

            int player = Logics.PlayerChoice(userInput); // översätter S/L/B till 0,1,2. Kommer även 3 för shotgun senare

            Console.WriteLine($"Spelarens val: {player}");
            Console.WriteLine();

            computer = rand.Next(0, 3); //Slumpa in 0 - 3.
            gameOn = Logics.ScoreBoard(player, computer);

            Logics.Rounds(player, ref playerRounds); //Adderar/subtraherar till rounds(skott)
            Logics.Rounds(computer, ref computerRounds); //Adderar/subtraherar till rounds(skott)

            Console.WriteLine($"Spelarens har: {playerRounds} skott kvar");
            Console.WriteLine($"Datorn har :{computerRounds} skott kvar");

            
        }
    }
}

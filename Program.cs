class Program
{
    static void Main()
    {
        bool gameOn = true;
        bool correctUserInput = true;
        Console.Clear();
        var rand = new Random();
        int playerRounds, compouterRounds;
        playerRounds = compouterRounds = 0;
        while (gameOn)
        {
            int computerInput = rand.Next(0, 3); //Slumpa in 0 - 3.
            Graphics.ShotgunLogo();
            Console.WriteLine("\nVälj att (S)kjuta, (L)adda eller (B)lockera?");
            char userInput = char.ToUpper(Console.ReadKey().KeyChar); //Spara valet av spelare i userInput
            Console.Clear();
            Console.WriteLine($"Spelarens val: {Logics.PlayerChoice(userInput)}");
            Console.WriteLine($"Datorns val: {computerInput}");
            playerRounds += Logics.Rounds(Logics.PlayerChoice(userInput));
            Console.WriteLine(playerRounds);
        }
    }
}

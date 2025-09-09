class Logics
{
    
    public static bool CheckRounds(ref int check)
    {
        if (check > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void ComputerChoice(ref int computer)
    {
        var rand = new Random();
        computer = rand.Next(0, 3); //Slumpa in 0 - 3.
    }

    public static void Rounds(int Choice, ref int roundChange)
    {
        if (Choice == 0)
        {
            roundChange -= 1;
        }
        else if (Choice == 1)
        {
            roundChange += 1;
        }
        else
        {
            roundChange = 0;
        }
    }
    static void RoundsLeft(int player, int computer)
    {
        
    }

    public static int PlayerChoice(char input)
    {
        int returnValue;

        if (input == 'S')
        {
            returnValue = 0;
        }
        else if (input == 'L')
        {
            returnValue = 1;
        }
        else if (input == 'B')
        {
            returnValue = 2;
        }
        else
        {
            returnValue = 9;
        }
        return returnValue;
    }
}

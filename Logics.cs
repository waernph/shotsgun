class Logics
{
    public static int Rounds(int PlayerChoice)
    {
        if (PlayerChoice == 0)
        {
            return -1;
        }
        else if (PlayerChoice == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
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

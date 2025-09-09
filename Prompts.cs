using Microsoft.VisualBasic;

class Prompts
{
    public static void Choises(int roundsLeft)
    {
        if (roundsLeft > 0 && roundsLeft < 3)
        {
            Console.WriteLine("\nVälj (S)kjuta, (L)adda eller (B)lockera?"); //Om det finns 1-2 rounds
        }

        else if (roundsLeft >= 3)
        {
            Console.WriteLine("\nVälj (H)agelgevär, (S)kjuta, (L)adda eller (B)lockera?"); //Om det finns 3 eller fler rounds
        }
        else if (roundsLeft == 0)
        {
            Console.WriteLine("\nDu har inga skott kvar! Välj (L)adda eller (B)lockera?"); //Om det finns 0 rounds kvar.
        }

    }
}
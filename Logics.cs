class Logics
{
    public static bool CheckRounds(int check)
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

    public static void ComputerChoice(int computer)
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
        else if (input == 'H')
        {
            returnValue = 3;
        }
        else
        {
            returnValue = 9; //Används som felvärde
        }
        return returnValue;
    }

    public static bool ScoreBoard(int input, int ComputerChoice)
    {
        string[] alternativ = ["skjut", "ladda", "blocka", "hagelgevär"];

        if (input == 0 && ComputerChoice == 0) //Göra om till switch?
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 0 && ComputerChoice == 1) // Fixa grafik It's a Draw
        {
            Graphics.YouWin();
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return false;
        }
        else if (input == 0 && ComputerChoice == 2)
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 1 && ComputerChoice == 0)
        {
            Graphics.YouLost();
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return false;
        }
        else if (input == 1 && ComputerChoice == 1) // Fixa grafik Block
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 1 && ComputerChoice == 2) // Fixa grafik Block
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 2 && ComputerChoice == 0) // Fixa grafik Block
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 2 && ComputerChoice == 1) // Fixa grafik Block
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 2 && ComputerChoice == 2) // Fixa grafik Block
        {
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return true;
        }
        else if (input == 3) // Fixa grafik Block
        {
            Graphics.YouWin();
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return false;
        }
        else if (ComputerChoice == 3) // Fixa grafik Block
        {
            Graphics.YouLost();
            Console.WriteLine($"\nDu valde {alternativ[input]}");
            Console.WriteLine($"Datorn valde {alternativ[ComputerChoice]}");
            return false;
        }
        else
        {
            return true;
        }
    }


}

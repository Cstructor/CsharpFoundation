// File: if_ex6.cs
using System;

class ex6
{
    static void Main()
    {
        Console.Write("Enter a person's full name:");
        string str = Console.ReadLine();

        str = str.ToUpper();

        if (str.EndsWith(" SMITH"))
        {
            Console.WriteLine("You found a Smith!");
        }
        else
        {
            Console.WriteLine("You didn't find a Smith.");
        }

        Console.ReadLine();
    }
}
// File: Find a typed last name Smith
using System;

class Lastname
{
    static void Main()
    {
        while (true)
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
}
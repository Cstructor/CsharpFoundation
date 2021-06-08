//Better Version:

using System;

class Program
{
    static void Main()
    {
        bool validEntry = false;

        while (!validEntry)
        {
            Console.Write("Check Number: ");
            string checkNumber = Console.ReadLine();

            try
            {
                Console.WriteLine("You entered check #{0}", int.Parse(checkNumber));
                validEntry = true;
            } 
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        // WITHOUT Exception handling
        validEntry = false;
        while (!validEntry)
        {
            Console.Write("Check Number (again): ");
            string input = Console.ReadLine();

            int checkNumber;

            if (!int.TryParse(input, out checkNumber))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.WriteLine("You entered check #{0}", checkNumber);
            validEntry = true;
        }
        Console.ReadLine();
    }
}

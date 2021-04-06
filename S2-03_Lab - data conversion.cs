using System;

class Program
{
    static void Main()
    {
        // Display "Enter a price:" using Console.Write
        Console.Write("Enter a price:");

        // Define a string named "input"
        string input;

        // Assign "input" to Console.ReadLine() to allow the user to enter a price
        input = Console.ReadLine();

        // Define a double named price
        double price;

        // Convert the "input" into a double using Parse()
        price = double.Parse(input);

        // Display the price as currency ( {0:C} )
        Console.WriteLine("The price is {0:C}", price);

        Console.ReadLine();
    }
}
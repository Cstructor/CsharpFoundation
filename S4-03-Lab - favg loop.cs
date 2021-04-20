// Write a program that calculates the average of numbers given by the user.

using System;

class Average
{
    static void Main()
    {
        // define a float for sum
        float fsum = 0.0f;

        // define a float for average
        float favg;

        // sequentially add the numbers up from 0 to 10
        for (int x = 1; x<=10 ; x++) // here x is local to for loop
        {
            //ask the user to enter a number
            Console.Write("Please enter a number {0} of 10:", x);
            string str = Console.ReadLine();
            
            // convert the given string to a number of type float
            float n = float.Parse(str);

            //add the given number to the previous
            fsum = fsum + n;

        } // end of loop : finished with the summation of the given numbers

        // Finding the average
        favg = fsum / 10;

        // write the final result
        Console.WriteLine("The average of the given numbers is {0}", favg);
        Console.ReadLine();
    }

}
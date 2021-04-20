// Create an array of numbers and find the max and min values of your array

using System;

class Program
{
    static void Main()
    {

        // start with the given array
        int[] numbers = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };
        // define the max and min
        int min;
        int max;

        min = numbers[0]; // grab the first element for comparison
        max = numbers[0];

        foreach (int x in numbers)
        {
            if (x < min) // search for the min
            {
                // if x is lesser then swap
                min = x;
            }
            if (x > max) // search for the max
            {
                // if x is larger then swap
                max = x;
            }
        }

        Console.WriteLine("The Minimum value is {0}", min);
        Console.WriteLine("The Maximum value is {0}", max);

        Console.ReadLine();
    }
}
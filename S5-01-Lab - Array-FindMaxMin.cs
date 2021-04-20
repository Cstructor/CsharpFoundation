// File: array_ex1.cs
// Create an array of numbers and find the max and min values of your array

using System;

class aex1
{
    static void Main()
    {
        int[] aNum = new int[] {0,2,5,100,-1,4,8,-5};
        int Min;
        int Max;

        // Assume the first value in the
        // array is the Min and Max value
        // then work from there.
        Max=aNum[0];
        Min=aNum[0];

        foreach(int x in aNum)
        {
            if (x<Min)
            {
                Min=x;			
            }
            if (x>Max)
            {
                Max=x;			
            }
        }

        Console.WriteLine("The Minimum value is {0}",Min);
        Console.WriteLine("The Maximum value is {0}",Max);

        Console.ReadLine();
    }
}
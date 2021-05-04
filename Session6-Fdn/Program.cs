using System;

class Program
{
    static void Main()
    {
        var x = 11;
        var y = 22;

        // TODO... 
        // Call on Swap Method...
        Swap(ref x, ref y);

        Console.WriteLine("X={0} should be 22", x);
        Console.WriteLine("Y={0} should be 11", y);
        Console.ReadLine();
    }

    // Write the Swap method so that
    // the two values passed in are swapped.
    static void Swap(ref int first, ref int second )
    {
        //TODO
        // it takes 3 steps to swap
        var temp = first;
        first = second;
        second = temp;

    }
}
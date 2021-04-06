using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ID    Name       Price");
        Console.WriteLine("----- ---------- --------");
        Console.WriteLine("{0,5} {1,-10} {2,8:C}", 101, "apple", .25);
        Console.WriteLine("{0,5} {1,-10} {2,8:c}", 102, "pear", .26);
        Console.WriteLine("{0,5} {1,-10} {2,8:c}", 4, "pineapple", 1.20);
        Console.ReadLine();
    }
}
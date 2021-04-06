using System;

class Program
{
    static void Main()
    {
        // Declare a variable named "age" of type "int"
        int age;

        // Set the value of "age" to 21
        age = 21;

        Console.WriteLine("My age is {0}", age);

        age = age + 2; // increment age by 2

        Console.WriteLine("My real age is {0}", age);
        Console.ReadLine();
    }
}
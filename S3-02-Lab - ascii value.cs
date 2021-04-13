// Find the ascii value of a given character
using System;

class dex2
{
    static void Main()
    {
        // Ask the user to enter a character (in front of my request)
        Console.Write("Enter a character:");

        // Read and store the input from the user (from the console)
        string str;
        str = Console.ReadLine(); // I grab and store information as a string

        // make sure you grab the first character that they entered (regardless)
        char mychar = str[0];

        // grab or covert the character into a number (ascii number) 
        // I am going from 2 bytes to interger 4 bytes
        int myascii = (int)mychar;

        // show the interger or the result on the console (on my black screen)
        Console.WriteLine("Ascii value of {0} = {1}", mychar, myascii);

        Console.ReadLine(); // to hold the console so you can see the result
    }
}
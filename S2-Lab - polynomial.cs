//datatype in class exercise
//Calculate the polynomial
using System;

namespace S2_Lab1_CalculatePolynomial
{
    class Polynomial
    {
        static void Main()
        {
            while (true) // allows to keep trying
            {

                // Ask for an input 
                Console.Write("Please type an integer value for x: ");

                // Read the input and save it into a String Type
                string str = Console.ReadLine();

                //Convert the String Type into an Integer Type
                int x = int.Parse(str);  // convert a string into an integer type

                // Calculate the Polynomial and Save it into an Integer Type
                int iResult = (int)((3 * x * x * x) - (5 * x * x) + 6);

                // Show the result on the Console (on the screen)
                Console.WriteLine("The calculated value for (3x^3)-(5x^2)+6 is {0}", iResult);

                Console.WriteLine(); // an extra line

                // Hold the Console so we can see the result
                Console.ReadLine();

            }
        }
    }
}

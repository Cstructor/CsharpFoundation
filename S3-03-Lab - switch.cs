//Class Exercise: 
// Write a program that determines the number of days 
// for a month using a switch statement. 
// The program should accept the number of the month in question. 

// in class use the first three months 
// when you go home do the rest up to decemeber

using System;

class ex1
{
    static void Main()
    {
        // assign a string strName to store month number
        string strName;

        // for now we only do the first 3 months 1 to 3
        Console.Write("Please enter a month number (1 to 3): ");

        // store the month entered by the user
        strName = Console.ReadLine();

        // assign a string month to store month name
        string month;

        // assign an interger to demonstrate the number of days for a given month 
        int nDays = 0; // initialized to zero

        switch (strName) // switching based on a given string
        {
            case "1":
                month = "January";
                nDays = 31;
                break; // do not forget to put break under each case
            case "2":
                month = "February";
                nDays = 29;
                break;
            case "3":
                month = "March";
                nDays = 30;
                break;

            // code here ...
            // continue the code up to case "12", December

            default: // if none of above say unknown...
                month = "unknown";
                nDays = -1;
                break;
        }// end of switch statement

        // After the switch is done, demonstrate the selection and month name and days
        Console.WriteLine("The month {0} has {1} days", month, nDays);

        // Pause the Console to view the result
        Console.ReadLine();

    }// end of Main

}// end of class


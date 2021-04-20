//File: enum_ex1.cs
// write a program that determines the number of days for a month
// using a switch statement.  The program should accept the number of the month in question.
using System;

enum eMonthNames
{	
    January=1,
    February=2,
    March=3,
    April=4,
    May=5,
    June=6,
    July=7,
    August=8,
    September=9,
    October=10,
    November=11,
    December=12,
}
enum eMonthDays
{
    January=30,
    February=29,
    March=31,
    April=31,
    May=30,
    June=31,
    July=31,
    August=31,
    September=31,
    October=31,
    November=31,
    December=31,
	
}
class MonthSwitch
{
    
    static void Main()
    {
        while(true)
        {
            eMonthNames eName;
		
            Console.Write("Please enter a Month Number: ");
            string strName = Console.ReadLine();

            int nDays=0;
		
            switch (strName)
            {
                case "1":
                    eName=eMonthNames.January;
                    nDays=(int)eMonthDays.January;  
				
                    break;
                case "2":
                    eName=eMonthNames.February;
                    nDays=(int)eMonthDays.February;
				
                    break;
                case "3":
                    eName=eMonthNames.March;
                    nDays=(int)eMonthDays.March;
				
                    break;
                case "4":
                    eName=eMonthNames.April;
                    nDays=(int)eMonthDays.April;
				
                    break;
                default:
                    eName=eMonthNames.December;
                    nDays=(int)eMonthDays.December;
				
                    break;
            }
            Console.WriteLine("Month {0} has {1} days\n\n",eName,nDays); 
        }
    }
}     
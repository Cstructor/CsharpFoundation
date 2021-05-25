using System;

class Program
{
    public abstract class Transaction
    {
        public string Date;
        public double Amount;
        public string Payee; // add Payee

        public abstract void Print();// make it abstract
        public abstract void Input();// make it abstract
    }

    // Define a class for Deposit
    public class Deposit : Transaction
    {
        public string Source;

        public override void Print() // implement the Print
        {
            Console.WriteLine("Deposit:");
            Console.WriteLine("Date   : {0}", Date);
            Console.WriteLine("Source : {0}", Source);
            Console.WriteLine("Amount : {0}", Amount);
        }

        public override void Input() // implement the Input
        {
            Console.Write("Date   :");
            Date = Console.ReadLine();

            Console.Write("Source   :");
            Source = Console.ReadLine();

            Console.Write("Amount   :");
            string str = Console.ReadLine();
            Amount = double.Parse(str);
        }
    } // End of Class Deposit

    // Define a class for Withdrawal with no new fields
    public class Withdrawal : Transaction
    {
        public override void Print() // implement the Print
        {
            Console.WriteLine("Withdrawal:");
            Console.WriteLine("Date   : {0}", Date);
            Console.WriteLine("Amount : {0}", -Amount); // show amount as negative for withdrawal
        }

        public override void Input() // implement the Input
        {
            Console.Write("Date   :");
            Date = Console.ReadLine();

            Console.Write("Amount   :");
            string str = Console.ReadLine();
            Amount = -double.Parse(str); // amount is negative for withdrawal
        }
    } // End of class Withdrawal

    // Define a Class for writing checks
    public class Check : Transaction
    {
        public int CheckNumber;

        public override void Print() // implement the Print
        {
            Console.WriteLine("Check:");
            Console.WriteLine("Date   : {0}", Date);
            Console.WriteLine("Check#   : {0}", CheckNumber);
            Console.WriteLine("Payee   : {0}", Payee);
            Console.WriteLine("Amount : {0}", -Amount); // show amount as negative for withdrawal
        }

        public override void Input() // implement the Input
        {
            // TODO: ask the user for the information
            string str;

            Console.Write("Date   :");
            Date = Console.ReadLine();

            Console.Write("Check#  :");
            str = Console.ReadLine();
            CheckNumber = int.Parse(str);

            Console.Write("Payee   :");
            Payee = Console.ReadLine();

            Console.Write("Amount   :");
            str = Console.ReadLine();
            Amount = -double.Parse(str); // amount is negative for withdrawal
        }
    } // End of class Check

    static void Main()
    {
        Transaction[] transactions = new Transaction[100];
        int count = 0;

        while (true)
        {
            Console.Write("D)eposit W)ithdrawal C)heck L)ist Q)uit :");
            string option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "d": // Deposit
                    {
                        Deposit deposit = new Deposit();
                        deposit.Input();
                        transactions[count] = deposit;
                        count++;
                        break;
                    }
                case "w": // Withdraw
                    {
                        //To Do:
                        Withdrawal withdraw = new Withdrawal();
                        withdraw.Input();
                        transactions[count] = withdraw;
                        count++;
                        break;
                    }
                case "c": // Check
                    {
                        //To Do:
                        Check check = new Check();
                        check.Input();
                        transactions[count] = check;
                        count++;
                        break;
                    }
                case "l":// list all transactions
                    {
                        double dblBalance = 0.0;

                        for (int x = 0; x < count; x++)
                        {
                            transactions[x].Print();
                            Console.WriteLine();
                            dblBalance = dblBalance + transactions[x].Amount;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Balance is {0}", dblBalance);
                        break;
                    }
                case "q": // Quit
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
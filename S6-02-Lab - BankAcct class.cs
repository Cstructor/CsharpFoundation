// File: BankAccount.cs
using System;

class BankAccount
{
    // TODO: create the balance field
    private decimal balance; 

    public BankAccount() // open the account with zero amount
    {
        balance = 0;
    }
    // TODO: create the deposit function
    public void Deposit(decimal deci)
    {
        balance = balance + deci;
    }
    // TODO: create the withdrawal function
    public void Withdrawal(decimal deci)
    {
        balance = balance - deci;
    }
    // TODO: get the balance
    public decimal GetBalance()
    {
        return balance;
    }
}

class Test
{
    static void Main()
    {
        BankAccount acct = new BankAccount();

        acct.Deposit(200m);
        acct.Withdrawal(40m);

        Console.WriteLine("Balance {0:C}", acct.GetBalance());

        Console.ReadLine();
    }
}
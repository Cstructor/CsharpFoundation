using System;

struct Contact
{
    public int ContactId;
    public String Name;
    public String PhoneNumber;

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        ContactId = nextContactId++;
    }

    private static int nextContactId = 100;

    // TODO: Add static property CurrenctNextId
    public static int CurrentNextContactId
    {
        get
        {
            return nextContactId;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("CurrentNextContactId = {0} should be 100", Contact.CurrentNextContactId);
       
        var contact = new Contact("mike", "111-222-3333");
       
        // TODO: Why does is not compile? What does the compiler say?
        // It should say that you need to use the Contact type not the variable
        Console.WriteLine("CurrentNextContactId = {0} should be 101", 
		Contact.CurrentNextContactId);

        var contact2 = new Contact("steve", "222-333-4444");

        // TODO: Why does is not compile? What does the compiler say?
        // It should say that you need to use the Contact type not the variable
        Console.WriteLine("CurrentNextContactId = {0} should be 102", 
		Contact.CurrentNextContactId);

        Console.ReadLine();
    }
}
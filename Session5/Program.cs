using System;

// TODO: Define the Contact class to make this compile
// Create a Developer Class that allows the user to do the following
class Contact
{
    // Fields - all are set to be public
    // since user directly accessing them
    public string FirstName;
    public string LastName;
    public int Age;

    // Method - set to be public
    // It has to return a string for the user
    public string GetFullName()
    {
        //return $"{this.FirstName} {this.LastName}";
        return FirstName + " " + LastName;
    }
}
class Programc
{
    static void Main()
    {
        Contact contact = new Contact();

        contact.FirstName = "FirstName";
        contact.LastName = "LastName";
        contact.Age = 23;

        // GetFullName() returns "FirstName LastName"
        Console.WriteLine("Name: {0} Age: {1}", contact.GetFullName(), contact.Age);
    }
}
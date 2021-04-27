using System;


    class Contact
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public string GetFullName()
        {
            //return $"{this.FirstName} {this.LastName}";
			return FirstName + " " + LastName;
        }
    }
    class Program
    {
        static void Main()
        {
            Contact contact = new Contact();

            contact.FirstName = "FirstName";
            contact.LastName = "LastName";
            contact.Age = 23;

            // GetFullName() returns "FirstName LastName"
            Console.WriteLine("Name: {0} Age: {1}", contact.GetFullName(), contact.Age);
            Console.ReadLine();
        }
    }
}
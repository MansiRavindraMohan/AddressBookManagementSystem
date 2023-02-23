using System;

namespace AddressBookManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book Management System Program");

            NewContact contact1 = new NewContact();

            contact1.NewDetails();
            contact1.ListOfPeople();
        }
    }
}


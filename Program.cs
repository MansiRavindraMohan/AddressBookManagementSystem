using System;

namespace AddressBookManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book Management System Program");

            DeleteContact person = new DeleteContact();
            person.NewDetails();

            person.deleteContact();
            person.ListingPeople();
        }
    }
}


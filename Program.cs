using System;

namespace AddressBookManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book Management System Program");

            EditContact person = new EditContact();

            person.NewDetails();
           
            person.editContact();
            person.ListOfPeople();
        }
    }
}


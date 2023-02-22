using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    public class AddressProgram
    {
        public static void DataofPerson()
        {
            Console.WriteLine("Please Enter your Firstname:");
            string str1 = "Firstname";
            str1 = Console.ReadLine();
            string valueString1 = str1;

            Console.WriteLine("Please Enter your Lastname:");
            string str2 = "Lastname";
            str2 = Console.ReadLine();
            string valueString2 = str2;

            Console.WriteLine("Please Enter your Address:");
            string str3 = "Address";
            str3 = Console.ReadLine();
            string valueString3 = str3;

            Console.WriteLine("Please Enter your City:");
            string str4 = "City";
            str4 = Console.ReadLine();
            string valueString4 = str4;

            Console.WriteLine("Please Enter your State");
            string str5 = "State";
            str5 = Console.ReadLine();
            string valueString5 = str5;

            Console.WriteLine("Please Enter your Zipcode");
            string str6 = "Zipcode";
            str6 = Console.ReadLine();
            string valueString6 = str6;

            Console.WriteLine("Please Enter your Phone Number");
            string str7 = "PhoneNumber";
            str7 = Console.ReadLine();
            string valueString7 = str7;

            Console.WriteLine("Please Enter your Email");
            string str8 = "Email";
            str8 = Console.ReadLine();
            string valueString8 = str8;

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Firstname you entered: " + valueString1);
            Console.WriteLine("Lastname you entered: " + valueString2);
            Console.WriteLine("Address you entered: " + valueString3);
            Console.WriteLine("City you entered: " + valueString4);
            Console.WriteLine("State you entered: " + valueString5);
            Console.WriteLine("Zipcode you entered: " + valueString6);
            Console.WriteLine("Phone Number you entered: " + valueString7);
            Console.WriteLine("Email you entered: " + valueString8);

        }
    }
}




       
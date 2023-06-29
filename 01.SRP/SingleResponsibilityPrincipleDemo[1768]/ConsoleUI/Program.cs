
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}

// A class should only have one responsibility




//namespace ConsoleUI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to my application!");

//            Person user = new Person();

//            Console.WriteLine("What is your first name");
//            user.FirstName = Console.ReadLine();

//            Console.WriteLine("What is your last name");
//            user.LastName = Console.ReadLine();

//            if (string.IsNullOrWhiteSpace(user.FirstName))
//            {
//                Console.WriteLine("You did not give a valid first name");
//                Console.ReadLine();
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(user.LastName))
//            {
//                Console.WriteLine("You did not give a valid last name");
//                Console.ReadLine();
//                return;
//            }

//            Console.WriteLine("Your user name is: {0} {1}", user.FirstName, user.LastName);

//            Console.ReadLine();    
//        }
//    }
//}



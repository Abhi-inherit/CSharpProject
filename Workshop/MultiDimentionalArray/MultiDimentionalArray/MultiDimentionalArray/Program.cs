using System;
namespace TypeConvertionApplication
{
    class ExplicitConvertion
    {
        //static void Main()
        //{
        //    short a;
        //    int b;
        //    double c;
        //    a = 10;
        //    b = 20;
        //    c = a + b;
        //    Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    int number;

        //    Console.WriteLine("Please enter a number between 0 and 10:");
        //    number = int.Parse(Console.ReadLine());

        //    if (number > 10)
        //        Console.WriteLine("Hey! The number should be 10 or less!");
        //    else
        //        if (number < 0)
        //            Console.WriteLine("Hey! The number should be 0 or more!");
        //        else
        //            Console.WriteLine("Good job!");

        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            string myChoice;

            do
            {
                // Print A Menu
                Console.WriteLine("My Address Book\n");

                Console.WriteLine("A - Add New Address");
                Console.WriteLine("D - Delete Address");
                Console.WriteLine("M - Modify Address");
                Console.WriteLine("V - View Addresses");
                Console.WriteLine("Q - Quit\n");

                Console.WriteLine("Choice (A,D,M,V,or Q): ");

                // Retrieve the user's choice
                myChoice = Console.ReadLine();

                // Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("You wish to add an address.");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You wish to delete an address.");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("You wish to modify an address.");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("You wish to view the address list.");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }

                // Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // Keep going until the user wants to quit
        }
    }
}
using System;

namespace TestStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Welcome to GC SWAG shop!");
                Console.WriteLine("Please select an option from the menu.");
                Console.WriteLine("1: Mugs and drinkwware");
                Console.WriteLine("2: T-shirts");
                Console.WriteLine("3: Pens");
                Console.WriteLine("4: Exit");

                int input;
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("You selected option 1.");
                        break;
                    case 2:
                        Console.WriteLine("You selected option 2.");
                        break;
                    case 3:
                        Console.WriteLine("You selected option 3.");
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using our app.");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("You selected an invalid option!");
                        break;

                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# console calculator App"); //displays text
            Console.WriteLine("-------------------------\n"); // \n makes a new line

            decimal x = 0; // x has to be defined
            bool exit = false;
        
            while (exit == false)
            {
                bool validOne = false;
                while (validOne == false)
                {
                    Console.Write("Enter your first number: ");
                    //decimal x = Convert.ToDecimal(Console.ReadLine());

                    string inputString = Console.ReadLine();

                    bool parsed = decimal.TryParse(inputString, out x);

                    if (!parsed)
                    {
                        Console.WriteLine("int.tryparse could not parse '{0}' to an int.\n", inputString);
                    }
                    else
                    {
                        validOne = true;

                    }
                }
                decimal y = 0; // y has to be defined
                bool validTwo = false;
                while (validTwo == false)
                {
                    Console.Write("Enter your second number: ");

                    string inputString = Console.ReadLine();

                    bool parsed = decimal.TryParse(inputString, out y);

                    if (!parsed)
                    {
                        Console.WriteLine("int.tryparse could not parse '{0}' to an int.\n", inputString);
                    }
                    else
                    {
                        validTwo = true;
                    }
                }
                Console.WriteLine("\nEnter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4  for division");
                Console.WriteLine("");

                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine("\nAnwer:");
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x / y);
                        break;
                }

                Console.WriteLine("would you like to exit? Y/N: \n ");
                string exitApp = Console.ReadLine().ToUpper();

                if (exitApp == "N")
                {
                    Console.WriteLine("Press any key to continue... \n ");
                    Console.ReadKey();
                }
                else
                {
                    exit = true;
                }
                //Console.WriteLine("\nPress any key to restart..\n");
                //Console.ReadKey(); // this keeps it open
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            while (true)
            {
                Console.WriteLine("Enter an integer from 1 to 20");
                long userNumber;
                bool isInt = long.TryParse(Console.ReadLine(), out userNumber);
                if (isInt == false)
                {
                    Console.WriteLine("Please enter an integer");
                    continue;
                }
                else if (userNumber < 1 || userNumber > 20)
                {
                    Console.WriteLine("Please enter a value between 1 and 20");
                    continue;
                }
                else
                {
                    long factoralResult = CalculateFactoral(userNumber);
                    Console.WriteLine("The factorial of {0} is {1}", userNumber, factoralResult);
                    Console.WriteLine("Do you wish to continue? (y/n)");
                    
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "yes")
                    {
                        continue;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        Console.Write("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        
                    }

                }

            }
        }

        public static long CalculateFactoral(long number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactoral(number - 1);
            }
        }
    }
}

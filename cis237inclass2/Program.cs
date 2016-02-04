using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for factorials or 2 for Towers of Hanoi: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1" :
                    Factorial factorial = new Factorial();
                    break;

                case "2" :
                    Console.WriteLine("Enter number of disks on tower. Try 5 or lower");
                    userInput = Console.ReadLine();
                    try
                    {
                        // do hanoi here
                        Hanoi hanoi = new Hanoi();

                        hanoi.moveDisk(Int32.Parse(userInput), 'A', 'B', 'C');
                    }
                    catch
                    {
                        Console.WriteLine("You must enter an input");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;

                    
            }


            //Factorial factorial = new Factorial();
        }
    }
}

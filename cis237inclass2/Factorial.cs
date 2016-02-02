using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public Factorial()
        {
            // prompt the user for a number to compute
            Console.WriteLine("Input a number to calculate the facterial of: ");

            try
            {
                //get the number to perform factorial on from ther user
                int factorialInt = Convert.ToInt32(Console.ReadLine());

                // output what the problem to solve is
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");

                // solve the problem and put it in a answerInt
                int answerInt = Calculate(factorialInt);

                Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine("You did not enter a valid integer.");
            }
        }

        private int Calculate(int number)
        {
            // if the number is 1 we have reached the base case. we want our execution to change and start returning from the method calls.
            // If we did not have this base case we would continue to put calls on the call stack until a stack overflow were to happen
            if (number == 1)
            {
                return 1;
            }
            // since we are not at the basecase of number equalling 1 we want to call this method that we are in another time and send in the nubmer -1
            // as the parameter to the recursive call.
            return number * Calculate(number - 1);
        }
    }
}

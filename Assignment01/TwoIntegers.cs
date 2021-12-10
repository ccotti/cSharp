/*
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Assignment01
{
    class TwoIntegers
    {
        static void Main(string[] args)
        {
            string numString;
            int firstNum;
            int secondNum;
            int sum;
            int diff;
            int prod;
            int quotient;
            int mod;

            Console.Write("Chris Cottingham - Assignment 1");
            Console.WriteLine("\n");

            // Ask user to enter first integer
            Console.Write("Enter the first integer: ");
            numString = Console.ReadLine();
            firstNum = Convert.ToInt32(numString);

            // Ask user to enter second integer
            Console.Write("Enter the second integer: ");
            numString = Console.ReadLine();
            secondNum = Convert.ToInt32(numString);
            Console.WriteLine("\n");

            // display both numbers back to the user
            Console.WriteLine("The two numbers you entered are: " + firstNum + " and " + secondNum);

            // display the sum of the two numbers
            sum = firstNum + secondNum;
            Console.WriteLine("The sum of the two numbers is: " + sum);

            // display the difference between the two numbers
            if (firstNum > secondNum)
                diff = firstNum - secondNum;
            else
            {
                diff = secondNum - firstNum;
            }

            Console.WriteLine("The difference of the two numbers is: " + diff);

            // display the product of the two numbers
            prod = firstNum * secondNum;
            Console.WriteLine("The product of the two numbers is: " + prod);

            // display the quotient of the two numbers
            if (secondNum == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                quotient = firstNum / secondNum;
                Console.WriteLine("The quotient of the two numbers is: " + quotient);
            }

            // display the modulus of the two numbers
            mod = firstNum % secondNum;
            Console.WriteLine("The remainder of the two numbers is: " + mod);
            Console.WriteLine("\n");

            // determine the larger of the two numbers or are equal and display result. 
            if (firstNum > secondNum)
                Console.WriteLine("The larger of the two numbers is: " + firstNum);
            else if (secondNum > firstNum)
            {
                Console.WriteLine("The larger of the two numbers is: " + secondNum);
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press the [enter] key to close this window...");
            Console.ReadKey();

        }
    }
}
*/
/*  
 *  INSTRUCTOR FEEDBACK (05/31/2020)
 *  You did really good work. You just need to NOT use the goto statement in your code to control your looping.  
 *  This is an old programming practice and is considered bad coding practice now.
 * 
 */

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Salesperson
    {
        static void Main(string[] args)
        {
            //variable list
            int intItem;
            int intQuantity;
            double dblItemSales = 0.00;
            double dblTotalSales = 0.00;
            double item1 = 239.99;
            double item2 = 129.75;
            double item3 = 99.95;
            double item4 = 350.89;
            string strSalesPerson;

            Console.WriteLine("Chris Cottingham - Assignment 2");
            Console.WriteLine("\n");

            //Prompt user for salesperson name and store in variable
            Console.Write("Enter a salesperson's name: ");
            strSalesPerson = Convert.ToString(Console.ReadLine());
            Console.Write("\n");

            //Prompt user to enter an item number and quantity sold 
            //Store these two values in variables (intItem, intQuantity)
            //Use a DO-WHILE and loop until user enteres item number -1
            do
            {
                Console.Write("Enter an item number between 1 and 4 or -1 to quit: ");
                intItem = Convert.ToInt32(Console.ReadLine());

                if (intItem == -1)
                {
                    break;
                }
                else if (intItem <= 0 || intItem >= 5)
                {
                    //display error message if invalid entry and re-prompt
                    Console.WriteLine("Invalid Entry\n");
                    Console.Write("Enter an item number between 1 and 4 or -1 to quit: ");
                    intItem = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Enter the quantity sold: ");
                    intQuantity = Convert.ToInt32(Console.ReadLine());
                }

                //Use a Switch statement
                switch (intItem)
                {
                    case 1:
                        dblItemSales = item1 * intQuantity;
                        break;
                    case 2:
                        dblItemSales = item2 * intQuantity;
                        break;
                    case 3:
                        dblItemSales = item3 * intQuantity;
                        break;
                    case 4:
                        dblItemSales = item4 * intQuantity;
                        break;
                    case -1:
                        break;
                }

                //Calculate the amount of sales for item, store in dblItemSales
                dblTotalSales = dblItemSales + dblTotalSales;

                //Print screen with salesperson name "has sold " [intQuantity] “of item # [intItem]
                Console.WriteLine("Salesperson {0} has sold {1} of item #{2} at {3:c}\n", strSalesPerson, intQuantity, intItem, dblItemSales);
            } while (intItem != -1); //loops back to "do" if not -1

            //When -1 quit, print to the screen Salesperson [Salesperson’s name] sold a total of [ total sales ]
            Console.WriteLine("Salesperson {0} sold a total of {1:c}\n", strSalesPerson, dblTotalSales);
            Console.WriteLine("Press the [enter] key to close this window...");
            Console.ReadKey();
        }
    }
}
*/
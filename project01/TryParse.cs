using System;

namespace project01
{
    class TryParse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredNumber = int.TryParse(temperature, out number);

            if (userEnteredNumber)
            {
                numTemp = number;
            }
            else

            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number. 0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and a pullover should be fine");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It is super hot!");
            }
            else
            {
                Console.WriteLine("Shorts and t-shirt should be enough for today");
            }

            Console.ReadKey();
        }
    }
}

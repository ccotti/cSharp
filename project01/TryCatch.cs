using System;

namespace project01
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Fromat exception, please enter the corret type next time.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception, the value was empty (null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadLine();
        }

    }
}
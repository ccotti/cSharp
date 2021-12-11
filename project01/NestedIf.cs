using System;

namespace project01
{
   class NestedIf
   {
       static void Main(string[] args)
       {

           bool isAdmin = false;
           bool isRegistered = true;
           string username = "";

           Console.WriteLine("Please enter your username: ");
           username = Console.ReadLine();

           if (isRegistered && username != "" && username.Equals("admin"))
           {
               Console.WriteLine("Hi registered user");
               Console.WriteLine("Hi " + username);
               Console.WriteLine("Hello Admin");
           }

           if (isAdmin || isRegistered)
           {
               Console.WriteLine("You are logged in");
           }

           Console.ReadKey();
       }
   }
}

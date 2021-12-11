using System;

namespace project01
{
   class Operators
   {
       static void Main(string[] args)
       {
           int num1 = 5;
           int num2 = 3;
           int num3;

           // unary operators
           num3 = -num1;
           Console.WriteLine("num3 is {0}", num3);

           bool isSunny = true;
           Console.WriteLine("Is it sunny? {0}", isSunny);

           //increment operators
           int num = 0;
           num++;
           Console.WriteLine("num is {0}", num);
           //Post increment
           Console.WriteLine("num is {0}", num++);
           // pre increment
           Console.WriteLine("num is {0}", ++num);

           //decrement operators
           num--;
           Console.WriteLine("num is {0}", num);
           //Post decrement
           Console.WriteLine("num is {0}", num--);
           // pre decrement
           Console.WriteLine("num is {0}", --num);

           int result;
           result = num1 + num2;
           Console.WriteLine("result of num1 + num2 is {0}", result);
           result = num1 - num2;
           Console.WriteLine("result of num1 - num2 is {0}", result);
           result = num1 / num2;
           Console.WriteLine("result of num1 / num2 is {0}", result);
           result = num1 * num2;
           Console.WriteLine("result of num1 * num2 is {0}", result);
           result = num1 % num2;
           Console.WriteLine("result of num1 % num2 is {0}", result);

           // Relational and Type Operators
           bool isLower;
           isLower = num1 < num2;
           Console.WriteLine("result of num1 < num2 is {0}", isLower);

           bool isGreater;
           isGreater = num1 > num2;
           Console.WriteLine("result of num1 > num2 is {0}", isGreater);

           // equality operator
           bool isEqual;
           isEqual = num1 == num2;
           Console.WriteLine("result of num1 == num2 is {0}", isEqual);

           isEqual = num1 != num2;
           Console.WriteLine("result of num1 != num2 is {0}", isEqual);

           // conditional operators
           bool isLowerAndSunny;
           isLowerAndSunny = isLower && isSunny;
           Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny); // false cuz lower is false

           bool isGreaterAndSunny;
           isGreaterAndSunny = isGreater && isSunny;
           Console.WriteLine("result of isGreater && isSunny is {0}", isGreaterAndSunny); // false cuz lower is false

           isLowerAndSunny = isLower || isSunny;
           Console.WriteLine("result of isGreater || isSunny is {0}", isGreaterAndSunny);

           Console.ReadKey();
       }
   }
}


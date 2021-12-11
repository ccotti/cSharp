// Extended If Statement & Ternary Operator
/* 
 * [syntax] > condition ? first_expression : second_expression;
 * condition has to be either true or false
 * The conditional operator is right - associative.
 * The expression a ? b : c ? d : e
 * is evaluated as a ? b : (c ? d : e), 
 * not as (a ? b : c) ? d : e.
 * The conditional operator cannot be overloaded.
 */

using System;

namespace project01
{
   class EnhancedIfTernary
   {
       static void Main(string[] args)
       {
           int temperature = -5;
           string stateOfMatter;

           if (temperature < 0)
               stateOfMatter = "solid";
           else
               stateOfMatter = "liquid";
           Console.WriteLine("State of matter is {0}", stateOfMatter);

           // If statement in short
           temperature += 30;
           stateOfMatter = temperature < 0 ? "solid" : "liquid";
           Console.WriteLine("State of matter is {0}", stateOfMatter);

           // challenge - add the gas state of matter to the options
           temperature = 120;
           stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
           Console.WriteLine("State of matter is {0}", stateOfMatter);
            
           Console.ReadKey(); 
       }
   }
}

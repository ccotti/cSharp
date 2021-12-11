using System;

namespace project01
{
   class EnhancedIfChallenge
   {
       // My Version
       static void Main(string[] args)
       {
           Console.WriteLine("What is the temperature? ");
           string temperature = Console.ReadLine();
           int number;
           bool isValidNumber = int.TryParse(temperature, out number);

           string result = isValidNumber == false ? "Not a valid temp" : number <= 15 ? "It is too cold in here" : number >= 16 && number <= 28 ? "It is Ok" : "It is too stinking HOT!! Where is the AC?";
           Console.WriteLine(result);
           Console.ReadKey();
       }
   }
}


//Instructor's version
//        static void Main(string[] args)
//        {
//            int inputTemperature = 0;
//            string temperatureMessage = string.Empty;
//            string inputValue = string.Empty;

//            Console.Write("Enter the current temperature : ");
//            inputValue = Console.ReadLine();

//            bool validInteger = int.TryParse(inputValue, out inputTemperature);

//            if (validInteger)
//            {
//                temperatureMessage = inputTemperature <= 15 ? "It is too cold here" : (inputTemperature >= 16 && inputTemperature <= 28) ? "It is Ok" : inputTemperature > 28 ? "It is too stinking HOT!! Where is the AC?" : "";
//                Console.WriteLine(temperatureMessage);         
//            }

//            Console.ReadKey();
//        }
//    }
// }
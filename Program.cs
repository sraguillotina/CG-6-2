using System;

namespace Class6_UpperCaseAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, type a sentence: ");
            //The user's entry is assigned to string 'userInput'
            string userInput = Console.ReadLine();

            //'TurnToUpper' is invoked with 'userInput' string. 
            //The method and its resulting value is interpolated in the WriteLine. 
            Console.WriteLine($"Your sentence in upper case: {TurnToUpper(userInput)}");
          
            Console.ReadLine();
        }

        //Created local method 'TurnToUpper' to pass user's entry through method code
        private static string TurnToUpper(string message)
        {
            //method code converts the user's string to all upper case
            return (message.ToUpper());
        }
    }
}

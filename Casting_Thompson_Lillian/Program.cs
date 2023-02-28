using System;

namespace Casting_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Ask user to enter a whole number and assigns input to integer
            Console.WriteLine("Please eneter a whole number!");
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // Prints favorite number to console
            Console.WriteLine("Your favorite number is" + myFavNum);

            // Asks user a true/false question and assigns response to boolean
            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false') ");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Print the result of question asked
            Console.WriteLine($"It is {isTrue} that i like video games!");




          

        }
    }
}

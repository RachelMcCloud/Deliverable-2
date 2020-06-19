using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            string message = "";
            int checksum = 0;

            Console.WriteLine("What is your message?");

            input = Console.ReadLine().ToUpper();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    char letter = input[i];
            //}


            foreach(char letter in input)
            {
                int letterValue = (int)letter;
                checksum += letterValue;

                int alphabetNumber = letterValue - 65 + 1;
                message = message + alphabetNumber + "-";

            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
            

        }
    }
}

using System;

namespace RevStringSpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with special character");
            string userString = Console.ReadLine();
            ReverseString(userString);

            Console.ReadLine();
        }

        private static void ReverseString(string userString)
        {
            int length = userString.Length - 1;
            string reverString = "";

            char[] userCharString = userString.ToCharArray();

            while (length >= 0)
            {
                if (char.IsLetterOrDigit(userCharString[length]) == true)
                {
                    reverString = reverString + userString[length];
                    
                }
                length = length - 1;
            }

            length = userString.Length - 1;
            int currentPosition = 0;
            while (currentPosition <= length)
            {
                if (char.IsLetterOrDigit(userCharString[currentPosition]) == false)
                {
                    reverString.Insert(currentPosition, userCharString[currentPosition].ToString());
                }
                currentPosition = currentPosition + 1;

            }

            Console.WriteLine(reverString);
        }

     
    }
}

using System;
using System.Collections.Generic;

namespace Exam1p2
{
    internal class Program
    {
        //Method to check if a string is a palindrome
        public static bool IsPalindrome(string input)
        {
            //Clean string by removing punct, whitespace, and converting to lowercase
            string cleanedInput = CleanString(input);

            Console.WriteLine("checked palindrome: " + cleanedInput); //display cleaned palindrome

            //Initialize a stack and a queue
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            //Add each character of the cleaned string to the stack and queue
            foreach (char c in cleanedInput)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            //Compare characters from the stack and queue to determine if it's a palindrome (palidrome = samewords backwards and forwards!)
            while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            }

            return true;
        }

        //Method to clean the input string by removing punctuation, whitespace, and converting to lowercase
        private static string CleanString(string input)
        {
            input = input.ToLower();//lowercase conversion

            //all the things that need to be removed below!!!
            input = input.Replace(" ", "");
            input = input.Replace(",", "");
            input = input.Replace("'", "");
            input = input.Replace(".", "");
            input = input.Replace("!", "");
            input = input.Replace("?", "");
            input = input.Replace(";", "");
            input = input.Replace(":", "");
            input = input.Replace("-", "");

            return input;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase: ");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine("The text entered is a palindrome.");
            }
            else
            {
                Console.WriteLine("The text entered is not a palindrome.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        //Method where palindrome is tested
        public static bool IsPalindrome(string phrase)
        {
            //First, a new string is created with all spaces removed and the length is identified.
            var tester = phrase.Replace(" ", String.Empty);
            var len = tester.Length;
            //The half length is next found in order to test each char at opposite ends of the string.
            var halfLength = len % 2 == 0 ? len / 2 : (len - 1) / 2;

            //For loop tests the two characters that mirror each other within the array.
            for (int i = 0; i < halfLength; i++)
            {
                if (tester[i] != tester[len - 1 - i]) return false;
            }

            //If full loop executes, returns true.
            return true;

        }
        static void Main(string[] args)
        {
            //User inputs phrase/word to test
            Console.WriteLine("Test for palindrome.\nInput phrase/word wihtout any punctuation: ");
            var testerstring = Console.ReadLine();

            //String is tested using the IsPalindrome method
            //returns true or false to the user
            Console.WriteLine($"This phrase is a palindrome: '{IsPalindrome(testerstring)}'");
            Console.ReadLine();
        }
    }
}

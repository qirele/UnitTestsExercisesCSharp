using System;
using System.Collections.Generic;
using System.Linq;

namespace testsZad
{
    public class Program
    {

        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }

        public static string Longest(string s1, string s2)
        {
            //string sortedS1 = SortString(s1);
            //string sortedS2 = SortString(s2);
            string distinctOutOfTwo = SortString(s1 + s2);
            return distinctOutOfTwo;


        }

        // https://stackoverflow.com/questions/6441583/is-there-a-simple-way-that-i-can-sort-characters-in-a-string-in-alphabetical-ord
        private static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new String(characters.Distinct().ToArray());
        }


        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            bool ready = true;
            foreach (var item in gunners.Values)
            {
                if (item == "nay")
                {
                    ready = false;
                    break;
                }
            }
            return ready ? "Fire!" : "Shiver me timbers!";
        }

        public static string Battle(string x, string y)
        {
            char[] charsX = x.ToUpper().ToCharArray();
            char[] charsY = y.ToUpper().ToCharArray();
            int sumX = sumOfChars(charsX);
            int sumY = sumOfChars(charsY);

            if (sumX > sumY)
                return x;
            else if (sumX < sumY)
                return y;
            else
                return "Tie!";

        }
        private static int sumOfChars(char[] arr)
        {
            int sum = 0;
            foreach (var znak in arr)
            {
                sum += ((int)znak - 64);
            }
            return sum;
        }




        static void Main(string[] args)
        {
            
            
        }
    }
}

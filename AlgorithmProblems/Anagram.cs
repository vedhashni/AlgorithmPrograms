﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Anagram
    {
        public static void FindingTheAnagram()
        {
            Console.WriteLine("Enter the String 1 :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the String 2 :");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToUpper().ToCharArray();
            char[] ch2 = str2.ToUpper().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);
            if (newString1 == newString2)
            {
                Console.WriteLine("Both the strings are anagrams!");

            }
            else
            {
                Console.WriteLine("Both the strings are not anagrams!");
            }
        }
    }
}

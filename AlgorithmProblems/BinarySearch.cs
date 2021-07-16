using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BinarySearch
    {
        public static void BinarySearching(List<string> Listofwords)
        {
            
            int middle, first = 0;
            int last = Listofwords.Count - 1;
            bool isFound = false;
            Console.WriteLine("Enter the word to be searched in list");
            string key = Console.ReadLine();

            while (first <= last)
            {
                middle = (first + last) / 2;
                int result = key.CompareTo(Listofwords[middle]);
                if (result == 0)
                {
                    Console.WriteLine("Word is Present");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    first = middle + 1;
                }
                else
                {
                    last = middle - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Word does not present in the Text File!");
            }

        }
    }
}

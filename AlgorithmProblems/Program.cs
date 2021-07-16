using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Permutation");
            switch(option)
            {
                case 1:
                    String str = Console.ReadLine();
                    int len = str.Length;
                    Permutation.permutation(str, 0, len - 1);
                    break;

                case 2:
                    string filepath = File.ReadAllText(@"C:\Users\ven\source\repos\AlgorithmProblems\ListOfWordsFile.txt");
                    List<string> words = new List<string>(filepath.Split(" "));
                    words.Sort();
                    BinarySearch.BinarySearching(words);
                    break;

                case 3:
                    
                    InsertionSort obj = new InsertionSort();
                    int[] arr = { 56, 32, 78, 2, 1, 5 };
                    obj.sort(arr);
                    obj.printArray(arr);
                    break;

                default:
                    break;

            }
        }
    }
    }
}

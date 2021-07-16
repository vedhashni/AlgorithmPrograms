using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                default:
                    break;

            }
        }
    }
    }
}

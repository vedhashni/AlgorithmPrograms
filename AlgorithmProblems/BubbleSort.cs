using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BubbleSort
    {
        public void BubbleSorting(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        public void printArray(int[] arr)
        {
            Console.WriteLine("Sorted:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Read();
        }
    }
}

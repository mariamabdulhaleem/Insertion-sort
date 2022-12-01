using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the first element");
            arr[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second element");
            arr[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third element");
            arr[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth element");
            arr[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth element");
            arr[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sixth element");
            arr[5] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n**array**");
            printArray(arr);
            IS(arr);
            Console.WriteLine("\n**Sorted array**");
            printArray(arr);
            Console.WriteLine("\nTime complexty = O(N^2)");
            Console.ReadKey();
        }
        static void printArray(int[] arr)
        {

            for (int i = 0; i < 6; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        static void IS(int[] arr)
        {
            for (int j = 1; j <= 5; j++)
            {
                int key = arr[j];
                int i = j - 1;
                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
        }
    }
}

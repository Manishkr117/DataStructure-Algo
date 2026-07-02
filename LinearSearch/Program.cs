using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 18, 23, 45, 67, 89, 101, 150, 200 };


            Console.WriteLine(string.Join(", ",numbers));

            Console.WriteLine("Enter a number to search for:");
            int target = Convert.ToInt32(Console.ReadLine());

          int index=  performLinearSearch(numbers, target);
            if(index ==-1)
                Console.WriteLine("The item was not found in the array.");
            else
            Console.WriteLine($"The item was found at index: {index}");

            Console.ReadKey();

        }
        static int performLinearSearch(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
            }
           
                return -1;
        }
    }
}

using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 18, 23, 45, 67, 89, 101, 150, 200 };


            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("Enter a number to search for:");
            int target = Convert.ToInt32(Console.ReadLine());

            int index = performBinarySearch(numbers, target, 0, numbers.Length-1);
            if (index == -1)
                Console.WriteLine("The item was not found in the array.");
            else
            Console.WriteLine($"The item was found at index: {index}");

            Console.ReadKey();
        }

        static int performBinarySearch(int[] numbers, int target, int startIndex , int endIndex)
        {
            if(startIndex> endIndex)
                return -1;
            int mid = startIndex + (endIndex - startIndex) / 2;

            if (numbers[mid] == target)
                return mid;

            if (target < numbers[mid])
                return performBinarySearch(numbers, target, startIndex, mid - 1);
            else
                return performBinarySearch(numbers, target, mid+1, endIndex);

        }
    }
}

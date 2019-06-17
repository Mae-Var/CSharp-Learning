using System;

namespace exercise_z0___highest_numb
{
    class Program
    {
        public static int MaxNumber(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (temp < arr[i + 1])
                {
                    temp = arr[i + 1];
                }
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9000, 1, 2, 3, 4, 5, 67, 7, 12, 31, 2321, 543, 654, 6534, 423 };
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 67, 7, 12, 31, 2321, 543, 654, 6534, 423 };
            Console.WriteLine(MaxNumber(numbers2));
            Console.WriteLine(MaxNumber(numbers));
        }
    }
}

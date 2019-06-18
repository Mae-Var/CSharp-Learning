using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            var numbers2 = new[] { 3, 7, 9, 2, 14, 6 }; // another way to create an Array;

            // Lenght
            Console.WriteLine("Lenght of the array is: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("The index of '9' is: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2); //Clear accepts 3 parameters, 1st is the Array, 2nd is the "starting index", 3rd is the number of elements you wish to be cleared;
            Console.WriteLine("Effect of Clear(): ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n); // if it's an array of boolean, it will set them to false; if it's an array of strings, it will set them to null;
            };

            //Copy()
            int[] anotherArr = new int[3];
            Array.Copy(numbers2, anotherArr, 3); // 1st param source array, 2nd is destination, 3rd is number of elements to be copied;
            Console.WriteLine("Effect of Copy(): ");
            foreach (var m in anotherArr)
            {
                Console.WriteLine(m);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort(): ");
            foreach (var z in numbers)
            {
                Console.WriteLine(z);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse(): ");
            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}

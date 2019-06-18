using System;

namespace Matrix_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[3, 5];

            var ma3x = new int[3, 6] { // Rectangular Array;
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 }
            };

            var array = new int[3][]; // Jagged Array; in the first [] we specify the number of elements in top-level array i.e. 3 arrays with [] sub-arrays;
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];



        }
    }
}

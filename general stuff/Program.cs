using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general_stuff
{
    class Program
    {
        const int kuyr = 5;
        static void Main(string[] args)
        {
            //byte == 1 byte in the memory || 0-255
            //sbyte == 1 byte -128 // 127
            //short == 2 bytes (negative & positive) ~~(-32k // +32k) || System.Int16
            //ushort == 2 bytes, but only positive numbers (~~0-64k) || System.UInt16 (U stands for unsigned)
            //int == 4 bytes (32 bits)
            //uint == =//= (!negatives)  the difference between positives and non-negatives is that the non-negatives include 0.
            //long == 8 bytes || System.Int64
            //ulong == same as above, but non-negative.

            //int32 == int
            //int64 == long

            //char == 2 bytes || 16 bits; 
            char neshtoSi = 'a'; // 97
            int result = 100 - neshtoSi;
            Console.WriteLine(result);

            //bool == 1 bit;

            //float == System.Int64 (4 bytes)

            //double == double the float precision (basically) // ALSO: double.Infinity || double.NaN
            //decimal == in few words, very precise double (sort of) // extremely slow to work with || not optimal.

            float kur = 0f;

            for (int i = 0; i < 100; i++)
            {
                kur += 0.01f;
            }
            Console.WriteLine(kur); // floating point error; output: 0.9999993
            Console.ReadLine();

            int s1;

            if (true)
            {
                int s2;
                if (true)
                {
                    int s4;
                }
            }
            {
                int s3;
                int s4;
            }

            byte b = 232;
            int inl = b;
            long d = inl;
            int kurii = (int)d;

            float mlp = 0.6f;
            int plm = (int)mlp; // 0

            try
            {

            }
            catch (Exception)
            {
                Console.WriteLine("ima greshka, nup");
            }

            int neshtoNeshto = 102 % 10; // % == modulus != module
            float kurchi = 102 / 10f; // 10.2
            Console.WriteLine(kurchi);

            int test1 = neshtoNeshto++; // Output: 2
            int test2 = ++neshtoNeshto; // 

            Console.WriteLine("Test1: " + test1);
            Console.WriteLine("Test2: " + test2);
        }
    }
}

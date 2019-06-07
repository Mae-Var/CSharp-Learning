using System;

namespace Const_and_Vars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
          //int b = i; // wont compile, possible data loss;

            float f = 1.0f;
            int a = (int)f; // this will make the conversion;

            string s = "1";
          //int c = (int)s; // this wont convert & compile;
            int d = Convert.ToInt32(s);
            int e = int.Parse(s);

            /*You can use the below to convert X to number":
            ToByte();
            ToInt16();
            ToInt32();
            ToInt64();
            */
        }
    }
}

using System;

namespace Ref_and_Value_types_v2
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1; // this "number" value is in a different location in Memory.
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 }; // in this case, since Person is a class, it's in the same Memory location thus it will be changed.
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number) // and this "number" value is in completely different location in Memory. Different scope.
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

}

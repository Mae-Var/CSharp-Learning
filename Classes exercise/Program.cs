using System;

namespace Classes_exercise
{
    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }

        public Person(string inputName, int inputAge)
        {
            name = inputName;
            age = inputAge;
        }

        public static bool CompareAge(Person p1, Person p2)
        {
            if (p1.age > p2.age)
            {
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person koki = new Person("Koki", 23);
            Person kolio = new Person("Nikolio", 31);
            Console.WriteLine(Person.CompareAge(koki, kolio));
        }
    }
}

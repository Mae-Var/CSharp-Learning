using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemberg___13_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Декларирайте няколко променливи, като изберете за всяка една най-подходящия от типовете sbyte, byte, short, ushort, int, uint, long и ulong, 
            // за да им присвоите следните стойности: 52130, -115, 4825932, 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990; 123456789123456789.

            ushort kuk = 52130;
            sbyte kek = -115;
            uint zal = 4825932;
            byte kik = 97;
            short d = -10000;
            ushort kqk = 20000;
            byte kak = 224;
            uint kvk = 970700000;
            byte hkx = 112;
            sbyte kzl = -44;
            int kbk = -1000000;
            ushort xkl = 1990;
            ulong kzk = 123456789123456789;

            // 2. Кои от следните стойности може да се присвоят на променливи от тип float, double и decimal: 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 ?

            double kzd = 34.567839023d;
            float klz = 12.345f;
            double asd = 8923.1234857d;
            decimal kap = 3456.091124875956542151256683467m;

            // 3.Напишете програма, която изчислява вярно променливи с плаваща запетая с точност до 0.000001.

            decimal klue = 0.0000013m;
            Console.WriteLine("some numbers to follow: " + klue); // не съм сигурен какво точно се изисква от мен в задачата... 

            // 4. Инициализирайте променлива от тип int със стойност 256 в шестна­десетичен формат (256 е 100 в бройна система с основа 16).

            ushort lel = 256; // ??
            int kel = Convert.ToInt16(256); // ??

            // 5. Декларирайте променлива от тип char и присвоете като стойност символа който има 
            // Unicode код 72 (използвайте калкулатора на Windows за да намерите шестнайсетичното представяне на 72).

            // не съм сигурен какво точно се изисква от мен в задачата... 
            char asdkf = (char)72;
            Console.WriteLine("\nThe char representing decimal (unicode) num. 72 is: " + asdkf + "\nAlso, the hexadecimal equivalent for 72 is 48.\n");

            // 6.Декларирайте променлива isMale от тип bool и присвоете стойност на последната в зависимост от вашия пол.

            bool isMale = true;

            // 7. Декларирайте две променливи от тип string със стойности "Hello" и "World". Декларирайте променлива от тип object. Присвоете на тази променлива стойността, 
            // която се получава от конкатенацията на двете стрингови променливи (добавете интервал, ако е необходимо). Отпе­чатайте променливата от тип object.

            string hell = "Hello";
            string word = "World";
            
            object conct = hell + " " + word; // not sure if that's how you declare an object (no google used for these exercises, of course)
            Console.WriteLine(conct);

            // 8.Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World".Декларирайте променлива от тип object и ѝ присвоете стойността на конкатенацията
            // на двете променливи от тип string(не изпускайте интервала по средата).Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object(трябва да използвате type casting).

            string hellx = "Hello";
            string wordx = "World";

            object conctx = hell + " " + word; // not sure if that's how you declare an object (no google used for these exercises, of course)
            string whole = (string)conctx;
            Console.WriteLine("Whole sentence test: " + whole + "\n");

            // 9. Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." (без първите и последни кавички). 
            // В едната променлива използвайте quoted string, а в другата не го използвайте.

            // 12.   Фирма, занимаваща се с маркетинг, иска да пази запис с данни на нейните служители. Всеки запис трябва да има следната характе­ристика – първо име, фамилия, възраст, 
            // пол (‘м’ или ‘ж’) и уникален номер на служителя (27560000 до 27569999). Декларирайте необходи­мите променливи, нужни за да се запази информацията за един служи­тел, като използвате подходящи типове данни и описателни имена.

            string firstName;
            string lastName;
            byte age;
            bool sex;
            short uniqueNum;

            // 13. Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10. Разменете стойностите им и ги отпечатайте.

            int a1 = 5;
            int b1 = 10;

            int temp1 = a1;
            a1 = b1;
            b1 = temp1;

            Console.WriteLine("\nPrinting 1st number, then 2nd: {0}, {1}", a1, b1);
        }
    }
}

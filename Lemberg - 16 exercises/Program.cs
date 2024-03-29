﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lemberg___16_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercise 1
            int numbr = 7;
            if (numbr % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // exercise 2
            int intgr1 = int.Parse(Console.ReadLine());

            if (intgr1 % 5 == 0 && intgr1 % 7 == 0)
            {
                Console.WriteLine("You can divide this by both 5 and 7.");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 & 7.");
            }

            // exercise 3 // Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.
            Console.WriteLine("Please, input a number and we'll check if the 3rd digit from right to left is the number 7: \n");
            string ingr2 = Console.ReadLine();

            //Char.IsDigit is a possible solution, but incorrect.

            if (ingr2.Length < 3)
            {
                Console.WriteLine("The input is less than 3 digits.");
            }
            else
            {
                if (Int32.TryParse(ingr2, out int result))
                {
                    if (ingr2[ingr2.Length - 3] == '7')
                    {
                        Console.WriteLine("The third digit from right to left is 7 indeed.");
                    }
                    else
                    {
                        Console.WriteLine("Nope, it's {0}.", ingr2[ingr2.Length - 3]);
                    }
                }
                else
                {
                    Console.WriteLine("The input is not a valid integer.");
                }
            }


            // exercise 4 - Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.

            int valueX = 89;
            string resultX = Convert.ToString(valueX, 2);

            Console.WriteLine(resultX);

            if (resultX[resultX.Length - 3] == '1')
            {
                Console.WriteLine("The third bit from right to left is 1.");
            }
            else
            {
                Console.WriteLine("The third bit from right to left is 0.");
            }

            // exercise 5


            // exercise 6


            // exercise 7


            // exercise 8


            // exercise 9


            // exercise 10


            // exercise 11


            // exercise 12


            // exercise 13


            // exercise 14


            // exercise 15


            // exercise 16



            Console.ReadLine();
        }
    }
}


//1.      Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

//2.      Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

//3.      Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.

//4.      Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.

//5.      Напишете израз, който изчислява площта на трапец по дадени a, b и h.

//6.      Напишете програма, която за подадени от потребителя дължина и височина на право­ъгълник, пресмята и отпечатва на конзолата неговия периметър и лице.

//7.      Силата на гравитационното поле на Луната е приблизително 17% от това на Земята.Напишете програма, която да изчислява тежестта на човек на Луната, по дадената тежест на Земята.

//8.      Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). Пояснение: точката(0,0) е център на окръжността, а радиусът й е 5.

//9.      Напишете програма, която проверява дали дадена точка О(x, y) е вътре в окръжността К((0,0), 5) и едновременно с това извън право­ъгълника((-1, 1), (5, 5). Пояснение: правоъгълникът е зададен чрез координатите на горния си ляв и долния си десен ъгъл.
//10.   Напишете програма, която приема за вход четирицифрено число във формат abcd  (например числото 2011) и след това извършва следните действия върху него:

//-     Пресмята сбора от цифрите на числото(за нашия пример 2+0+1+1 = 4).

//-     Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия пример резултатът е 1102).

//-     Поставя последната цифра, на първо място: dabc(за нашия пример резултатът е 1201).

//-     Разменя мястото на втората и третата цифра: acbd(за нашия пример резултатът е 2101).

//11.   Дадено е число n и позиция p.Напишете поредица от операции, които да отпечатат стойността на бита на позиция p от числото n(0 или 1). Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.

//12.   Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1. Пример v = 5, p = 1-> false.

//13.   Дадено е число n, стойност v(v = 0 или 1) и позиция p.Напишете поредица от операции, които да променят стойността на n, така че битът на позиция p да има стойност v.Пример n= 35, p= 5, v= 0->n = 3.Още един пример: n= 35, p= 2, v= 1->n = 39.

//14.   Напишете програма, която проверява дали дадено число n (1 < n< 100) е просто(т.е.се дели без остатък само на себе си и на единица).

//15.   * Напишете програма, която разменя стойностите на битовете на позиции 3, 4 и 5 с битовете на позиции 24, 25 и 26 на дадено цяло положително число.

//16.   * Напишете програма, която разменя битовете на позиции {p, p+1, …, p+k-1) с битовете на позиции { q, q+1, …, q+k-1}
//на дадено цяло положително число.
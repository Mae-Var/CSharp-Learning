﻿using System;

namespace ifElseSwitchV2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            float price = (isGoldCustomer) ? 19.95f : 29.95f; // shortcut for writing if else statement (same as in JS).

            Console.WriteLine(price);
        }
    }
}

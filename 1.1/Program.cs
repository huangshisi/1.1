﻿using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "bugs bunny";
            var age = 25;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            Console.WriteLine("name is type" + nameType.ToString());
            Console.WriteLine("age is type" + ageType.ToString());
            Console.WriteLine("isRabbit is true" + isRabbitType.ToString());
        }
    }
}

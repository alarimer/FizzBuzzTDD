﻿using System;

namespace FizzBuzz
{
    public class Evaluator
    {
        public static object Evaluate(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number;
        }
    }
}

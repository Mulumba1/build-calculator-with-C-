﻿
using System.Dynamic;
using System;

namespace buildCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter Operator");
          string op = Console.ReadLine();

          Console.WriteLine("Enter a number");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
             else if (op == "*")
            {
                Console.WriteLine(num1 * num2);

            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);

            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);

            }
            else
             {
                 Console.WriteLine("Invalid Operator");
             }

           
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Lab_2_Exercise_VK_4_21_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            float length = 1.5f;
            float width = 1.5f; 

            Console.WriteLine("Welcome to the Grand Circus Classroom Detail Generator!");
            Console.WriteLine("Enter Length");
            Console.ReadLine();

            Console.WriteLine("Enter Width");
            Console.ReadLine();

            float floatnumber1 = 2*(length + width);
            double perimeter = floatnumber1;
            float floatnumber2 = (length * width);
            double area = floatnumber2;

            Console.WriteLine("Perimeter = " + perimeter);

            Console.WriteLine("Area = " + area);

            Console.WriteLine("Continue?");
        }
    }

} 
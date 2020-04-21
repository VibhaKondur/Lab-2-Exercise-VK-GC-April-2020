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
            string runAgain = "yes";
            float length;
            float width;
            float height; 

            Console.WriteLine("Welcome to the Grand Circus Classroom Detail Generator!");
            while (runAgain == "yes")
            {
                runAgain = "no";

                Console.WriteLine("Enter Length");
                length = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                width = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height");
                height = float.Parse(Console.ReadLine());

                double perimeter = 2 * (length + width);
                double area = (length * width);
                double volume = (area * height);

                Console.WriteLine("Perimeter = " + perimeter);

                Console.WriteLine("Area = " + area);

                Console.WriteLine("Volume = " + volume);

                Console.WriteLine("Continue - yes or no?");
                runAgain = Console.ReadLine();
            }
        }
    }

} 
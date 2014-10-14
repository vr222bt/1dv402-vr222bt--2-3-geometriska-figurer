﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rekt = new Rectangle(20, 5);
            Console.WriteLine(rekt.ToString());

            rekt.Width = ReadDoubleGreaterThanZero("Ange längd:");
            Console.WriteLine(rekt.ToString());
            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    double number = double.Parse(input);
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} måste vara större än 0!", number);
                        Console.ResetColor();
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! {0} är inte i önskat format, du måste ange ett tal större än noll.", input);
                    Console.ResetColor();
                } 
            }
        }

        private static void ViewMenu()
        {

        }

        private static void ViewShapeDetail(Shape shape)
        {

        }

    /*  public static Shape CreateShape(ShapeType shapeType)
        {
            return null;
        }
        */
    }
}

using System;
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
            ViewMenu();
            rekt.Width = ReadDoubleGreaterThanZero("Ange bredd:");
            rekt.Length = ReadDoubleGreaterThanZero("Ange längd:");
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
                    Console.WriteLine("'{0}' är av fel format! Ange ett flyttal!", input);
                    Console.ResetColor();
                } 
            }
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-                           -");
            Console.WriteLine("-    Geometriska Figurer    -");
            Console.WriteLine("-                           -");
            Console.WriteLine("-----------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Rektangel");
            Console.WriteLine("2. Ellips");
            Console.WriteLine();
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

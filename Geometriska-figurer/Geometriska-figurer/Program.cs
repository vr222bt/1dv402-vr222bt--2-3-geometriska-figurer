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
            //Rectangle rekt = new Rectangle(20, 5);
            //ViewMenu();
            //rekt.Width = ReadDoubleGreaterThanZero("Ange bredd:");
            //rekt.Length = ReadDoubleGreaterThanZero("Ange längd:");
            //Console.WriteLine(rekt.ToString());
            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && (value > 0))
                {
                    return value;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste ange ett flyttal större än 0!");
                Console.ResetColor();
                
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
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ange menyval [0-2]");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-                           -");
            Console.WriteLine("-          Detaljer         -");
            Console.WriteLine("-                           -");
            Console.WriteLine("-----------------------------");
            Console.ResetColor();
        }

        public static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("-           Ellips          -");
                    Console.WriteLine("-----------------------------");
                    Console.ResetColor();
                    Ellipse myEllipse = new Ellipse(ReadDoubleGreaterThanZero("Ange längd: "), ReadDoubleGreaterThanZero("Ange bredd: "));
                    ViewShapeDetail(myEllipse);
                    return myEllipse;

                case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("-         Rektangel         -");
                    Console.WriteLine("-----------------------------");
                    Console.ResetColor();
                    Rectangle myRectangle = new Rectangle(ReadDoubleGreaterThanZero("Ange längd:"), ReadDoubleGreaterThanZero("Ange bredd:"));
                    ViewShapeDetail(myRectangle);
                    return myRectangle;

                default:
                    throw new NotImplementedException();
            }
        }
        
    }
}

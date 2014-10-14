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
            int index;

            
            do
	        {
                Console.Clear();
                ViewMenu();
                if (int.TryParse(Console.ReadLine(), out index) && (index >= 0) && (2 >= index))
	            {
                    switch (index)
                    {
                        case 0:
                            return;
                        case 1:
                            CreateShape(ShapeType.Ellipse);
                            break;
                        case 2:
                            CreateShape(ShapeType.Rectangle);
                            break;

                    }
	            }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange ett nummer mellan 0 och 2!");
                    Console.ResetColor(); 
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n Tryck tangent för att fortsätta ");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;
	        } while (true);      
            
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
            Console.WriteLine("1. Ellips");
            Console.WriteLine("2. Rektangel");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.Write("Ange menyval [0-2]:");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-          Detaljer         -");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
        }

        public static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("-           Ellips          -");
                    Console.WriteLine("-----------------------------");                   
                    Console.ResetColor();
                    Console.WriteLine();
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

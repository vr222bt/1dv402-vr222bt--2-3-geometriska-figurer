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
            ShapeType shapeType = ShapeType.E;

            //loop som går tills man skriver in 0 i menyn
            do
	        {
                Console.Clear();
                ViewMenu();
                //If-sats som undersöker att det inmatade värdet stämmer med menualternativen
                if (int.TryParse(Console.ReadLine(), out index) && (index >= 0) && (2 >= index))
	            {
                    //Switch sats som agerar som en meny
                    switch (index)
                    {
                        case 0:
                            return;
                        case 1:
                            shapeType = ShapeType.Ellipse;
                            break;
                        case 2:
                            shapeType = ShapeType.Rectangle;
                            break;
                    }

                    Shape shape = CreateShape(shapeType);
                    ViewShapeDetail(shape);
	            }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange ett nummer mellan 0 och 2!");
                    Console.ResetColor(); 
                }
                //Skriver ut ledtext och börjar om från början när en tangent trycks in
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine();
                Console.WriteLine("Tryck tangent för att fortsätta ");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;
	        } while (true);      
            
        }

        //Läser in värden samtidigt som det undersöks om det är ett godkänt värde och skriver ut en ledtext
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
                Console.WriteLine("Du måste ange ett tal större än 0!");
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

        //Skapar en Ellipse eller en Rektangel beroende på vilken som angavs i menyn och anropar ViewShaoeDetail
        public static Shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Console.WriteLine("-           Ellips          -");
                    break;

                case ShapeType.Rectangle:
                    Console.WriteLine("-         Rektangel         -");
                    break;

                default:
                    throw new NotImplementedException();
            }

            Console.WriteLine("-----------------------------");
            Console.ResetColor();
            Console.WriteLine();
            double length = ReadDoubleGreaterThanZero("Ange längd:");
            double width = ReadDoubleGreaterThanZero("Ange bredd:");

            if (shapeType == ShapeType.Ellipse)
            {
                return new Ellipse(length, width);
            }
            else
            {
                return new Rectangle(length, width);
            }
        }
        
    }
}

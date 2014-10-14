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
            Console.WriteLine(rekt.ToString());

            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            throw new NotImplementedException();
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

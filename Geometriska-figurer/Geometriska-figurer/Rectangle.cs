using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Rectangle : Shape
    {
        public override double Area
        {
            get { return  Math.Round(Length * Width, 2); }
        }

        public override double Perimeter
        {
            get { return Math.Round(2 * Length + 2 * Width, 2); }
        }

        public Rectangle(double length, double width) : base(length, width)
        {

        }
    }
}

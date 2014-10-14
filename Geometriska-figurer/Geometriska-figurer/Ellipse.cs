using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Ellipse : Shape
    {
        public override double Area
        {
            get { return Math.PI * Width * Length; }
        }

        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2 * Width * Width + 2 * Length * Length); }
        }

        public Ellipse(double length, double width) : base(length , width)
        {

        }
    }   
}

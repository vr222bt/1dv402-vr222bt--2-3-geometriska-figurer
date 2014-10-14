using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    abstract class  Shape
    {

        //Fields
        private double _length;
        private double _width;

        //Properties
        abstract public double Area
        {
            get { return Area; }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }
        abstract public double Perimeter
        {
            get { return Perimeter; }
        }

        public double Width
        {
            get { return _width; }
            set 
            {
                _width = value;
            }
        }

        //Methods
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
 

        public override string ToString()
        {
            return String.Format("Till Sträng!");
        }
    }
}

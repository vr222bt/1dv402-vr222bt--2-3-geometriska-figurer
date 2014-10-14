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
        public double Width
        {
            get { return _width; }
            set 
            {
                _width = value;
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }

        public abstract double Area
        {
            get;
        }

        public abstract double Perimeter
        {
            get;
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

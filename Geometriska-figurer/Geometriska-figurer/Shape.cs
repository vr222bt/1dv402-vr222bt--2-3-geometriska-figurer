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
        public double Area
        {
            get { return Area; }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                _length = Length;
            }
        }
        public double Perimeter
        {
            get { return Perimeter; }
        }

        public double Width
        {
            get { return _width; }
            set 
            {
                _width = Width;
            }
        }

 
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public enum ShapeType { Ellipse, Rectangle, E };


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
                if (_width < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (_length < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        public abstract double Area{get;}

        public abstract double Perimeter {get;}

        //Methods
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
 
        public override string ToString()
        {
            return String.Format("Längd  :{0,9} \nBredd  :{1,9} \nArea   :{2,9} \nOmkrets:{3,9}", Length, Width, Area, Perimeter);
        }
    }
}

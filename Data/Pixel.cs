using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    
    public class Pixel
    {
        double Red;
        double Green;
        double Blue;

        private double check(double val)
        {
                if ((val < 0) && (val > 1)) { throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", val)); } 
                else return val;     
        }

        public double red
        {
            get { return Red; }
            set {  Red = check(value);}
        }
        public double green
        {
            get { return Green; }
            set { Green = check(value); }
        }

        public double blue
        {
            get { return Blue; }
            set { Blue = check(value); }
        }
    }
}

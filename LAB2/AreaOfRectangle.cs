using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class AreaOfRectangle
    {
        double length;
        double width;
        public AreaOfRectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double CalculateArea()
        {
            return length * width;
        }
    }
}

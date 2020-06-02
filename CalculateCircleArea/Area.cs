using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCircleArea
{
    public class Area
    {
        public static double GetArea(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateCircleArea
{
    public class Diameter
    {
        public static double GetDiameter(double r)
        {
            double diameter = Math.PI * r * 2;
            return diameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ShapeEx.Model.Enums;

namespace ShapeEx.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
             return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle Color: " + Color + ", Width =" + Width.ToString("F2",CultureInfo.InvariantCulture) + ", Height= " + Height.ToString("F2",CultureInfo.InvariantCulture) + ", Area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
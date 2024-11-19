using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FigurasEx.Entities.Enums;

namespace FigurasEx.Entities
{
    class Reactangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Reactangle(double width, double height, Color color) : base(color){
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
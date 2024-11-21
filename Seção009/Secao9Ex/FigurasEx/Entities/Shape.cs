using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FigurasEx.Entities.Enums;

namespace FigurasEx.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color){
            Color = Color;
        }
        public abstract double Area();

    }
}
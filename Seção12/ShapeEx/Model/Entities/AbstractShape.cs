using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeEx.Model.Enums;

namespace ShapeEx.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color {get;set;}

        public abstract double Area();
    }
}
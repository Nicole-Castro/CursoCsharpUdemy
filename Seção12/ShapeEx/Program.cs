using ShapeEx.Model.Entities;

namespace ShapeEx;

class Program
{
    static void Main(string[] args)
    {
        IShape shape= new Circle() {
            Radius = 2.0,
            Color = Model.Enums.Color.White
        };

        IShape shape1= new Rectangle() {
            Width = 3.5,
            Height = 4.2,
            Color = Model.Enums.Color.Black
        };

        System.Console.WriteLine(shape);
        System.Console.WriteLine(shape1);
    }
}

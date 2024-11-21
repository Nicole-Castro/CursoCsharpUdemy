using System.Globalization;
using FigurasEx.Entities;
using FigurasEx.Entities.Enums;

namespace FigurasEx;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        Console.WriteLine("Enter the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <=n; i++){
            System.Console.WriteLine($"Shape #{i} data: ");
            System.Console.Write("Rectangle or Circle? (r/c)");
            char ch = char.Parse(Console.ReadLine());
            System.Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());
            if (ch == 'r'){
                System.Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                System.Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Reactangle(width,height,color));
            }else{
                System.Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Circle(radius,color));
            }
        }
        Console.WriteLine();
        System.Console.WriteLine("SHAPE AREAS");
        foreach (Shape shape in list){
            Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

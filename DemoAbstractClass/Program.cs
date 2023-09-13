using System.Collections.Generic;
using System.Globalization;
using DemoAbstractClass.Entities;
using DemoAbstractClass.Entities.Enums;

namespace DemoAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("Shape #"+i+" data: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                } 
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }

            foreach(Shape shape in shapes)
            {
                if(shape is Rectangle)
                {
                    Console.WriteLine("Rectangle Area: "+shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Circle Area: " + shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
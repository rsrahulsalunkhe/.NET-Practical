using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

        public void Draw(string color)
        {
            Console.WriteLine($"Drawing a shape with color {color}");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a circle.");
        }
    }

    public class Square : Shape
    {
        public void Draw(int sideLength)
        {
            Console.WriteLine($"Drawing a square with side length {sideLength}");
        }
    }

    class overloading_overriding
    {
        static void Main()
        {
            Shape genericShape = new Shape();
            Circle circle = new Circle();
            Square square = new Square();

            genericShape.Draw();
            genericShape.Draw("Red");
            square.Draw(10);

            Console.WriteLine();

            genericShape.DisplayInfo();
            circle.DisplayInfo();
            Console.ReadLine();
        }
    }
}

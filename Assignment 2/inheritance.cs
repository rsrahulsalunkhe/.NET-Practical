using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public interface IDrawable
    {
        void Draw();
    }

    public abstract class Shape : IDrawable
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract void Draw();

        public void DisplayColor()
        {
            Console.WriteLine($"Color: {Color}");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Circle with Radius {Radius}");
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle with Length {Length} and Width {Width}");
        }
    }

    class inheritance
    {
        static void Main()
        {
            var shapes = new Shape[]
            {
            new Circle { Color = "Red", Radius = 5 },
            new Rectangle { Color = "Blue", Length = 4, Width = 6 }
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.DisplayColor();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

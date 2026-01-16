using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana06
{
    internal class Rectangle : Shape
    {
        private double width {  get; set; }
        private double height { get; set; }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
        public override void GetInfo()
        {
            Console.WriteLine("Прямокутник");
            Console.WriteLine($"Ширина: {width}");
            Console.WriteLine($"Висота: {height}");
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
        }
    }
}

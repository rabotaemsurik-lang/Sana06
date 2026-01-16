using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana06
{
    internal class Triangle : Shape
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double CalculateArea()
        {
            double HalfOfPerimeter = (A + B + C) / 2;

            return  Math.Sqrt(HalfOfPerimeter * (HalfOfPerimeter - A) * (HalfOfPerimeter - B) * (HalfOfPerimeter - C));
        }
        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Трикутник");
            Console.WriteLine($"Сторона один: {A}");
            Console.WriteLine($"Сторона два: {B}");
            Console.WriteLine($"Сторона три: {C}");
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
        }
    }
}

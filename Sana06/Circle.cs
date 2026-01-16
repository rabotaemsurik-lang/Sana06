using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana06
{
    internal class Circle : Shape
    {
        private double Radius {  get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Коло");
            Console.WriteLine($"Радіус: {Radius}");
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
        }

    }
}

using Sana06;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape[] shapes =
        {
            new Circle(5),
            new Rectangle(10, 20),
            new Triangle(6,8,10),
            new Circle(10),
            new Rectangle(5, 6)
        };
        foreach (var shape in shapes)
        {
            shape.GetInfo();
            Console.WriteLine("_________________________________________________________________");
        }
        Shape maxArea = shapes[0];
        foreach (var shape in shapes) { 
        if (shape.CalculateArea() > maxArea.CalculateArea())
                maxArea = shape;
        }
        Console.WriteLine("Фігура з найбільшою площею:");
        maxArea.GetInfo();
    }
}
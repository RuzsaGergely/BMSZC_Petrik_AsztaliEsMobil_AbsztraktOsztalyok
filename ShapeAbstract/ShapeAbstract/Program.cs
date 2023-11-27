namespace ShapeAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(2.1);
            circle1.PrintData();

            Triangle triangle1 = new Triangle(21.2, 10.1, 12.5);
            triangle1.PrintData();
        }
    }
}
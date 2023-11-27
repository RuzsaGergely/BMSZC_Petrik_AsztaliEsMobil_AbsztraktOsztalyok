namespace ShapeAbstract
{
    public abstract class Shape
    {
        private string shapeName;

        public string ShapeName { get { return shapeName; } set { shapeName = value; } }

        protected Shape(string shapeName)
        {
            this.shapeName = shapeName;
        }

        abstract public double Area();
        abstract public double Circumference();

        public void PrintData()
        {
            Console.WriteLine($"{shapeName} - Kerülete: {Circumference()} - Területe: {Area()}");
        }

    }
}

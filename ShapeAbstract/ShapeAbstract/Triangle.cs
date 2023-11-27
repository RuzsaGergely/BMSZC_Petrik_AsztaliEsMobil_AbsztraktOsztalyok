namespace ShapeAbstract
{
    public class Triangle : Shape
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c) : base("Triangle")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public override double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double Circumference()
        {
            return a + b + c;
        }
    }
}

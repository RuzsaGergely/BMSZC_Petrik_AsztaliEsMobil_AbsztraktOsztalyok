namespace ShapeAbstract
{
    public class Circle : Shape
    {
        double r;
        public double R { get { return r; } set { r = value; } }

        public Circle(double r) : base("Circle")
        {
            this.r = r;
        }

        public override double Area()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public override double Circumference()
        {
            return 2 * r * Math.PI;
        }
    }
}

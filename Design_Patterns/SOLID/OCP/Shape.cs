namespace Design_Patterns.SOLID.OCP
{
    //Rather than single creation of shape class we splitted that class in 
    //IShape and IPerimeterfor future extension of the logics to implicate the logic of OCP
    public interface IShape
    {
        double Area { get; }
    }

    public interface IPerimeter
    { 
    double Perimeter { get; }

    }

    public class Square : IShape , IPerimeter
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        public double Area => Side * Side;

        public double Perimeter => 4*Side;
    }

    public class Circle : IShape, IPerimeter
    {
        public double Radius { get; }
        private double pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => pi * Radius * Radius;

        public double Perimeter => 2*pi*Radius;
    }


}

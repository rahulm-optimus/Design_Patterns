namespace Design_Patterns.SOLID.Liskov
{
    public class Shape
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public override int Width { get; set; }
        public override int Height { get; set; }
    }

    // Derived class Square
    public class Square : Shape
    {
        private int _size;

        public override int Width
        {
            get { return _size; }
            set { _size = value; } // Make setter private
        }

        public override int Height
        {
            get { return _size; }
            set { _size = value; } // Make setter private
        }

        public Square(int size) // Add constructor to set size
        {
            _size = size;
        }
    }

}

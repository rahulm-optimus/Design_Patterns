namespace Design_Patterns.SOLID.DIP
{
    public interface IMethod
    {
        int Perform(int x, int y);
    }

    public class Addition : IMethod
    {
        public int Perform(int x, int y)
        {
            return x + y;
        }
    }

    public class Subtraction : IMethod
    {
        public int Perform(int x, int y)
        {
            return x - y;
        }
    }
}

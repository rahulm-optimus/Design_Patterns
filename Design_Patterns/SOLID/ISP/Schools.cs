namespace Design_Patterns.SOLID.ISP
{
    public interface IActivity_One
    {
        public void Sports();

    }

    public interface IActivity_Two
    {
        public void HorseRiding();
        public void Pool();
        public void Swimming();
    }

    public class PremiumSchools : IActivity_Two
    {
        public void HorseRiding()
        {
            Console.WriteLine("Horse riding is available");
        }

        public void Pool()
        {
            Console.WriteLine("Pool is available");
        }

        public void Swimming()
        {
            Console.WriteLine("Swimming is available");
        }
    }

    public class NonPremiumSchool : IActivity_One
    {
        public void Sports()
        {
            Console.WriteLine("Only basic sports available");
        }
    }
}

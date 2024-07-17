using Design_Patterns.SOLID.DIP;
using Design_Patterns.SOLID.ISP;
using Design_Patterns.SOLID.OCP;
using Design_Patterns.SOLID.SRP;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SOLID Principle concepts");

        #region SRP example 

        Console.WriteLine("--------SRP Implementation--------");
        //creation of file is done in differnet class 
        FileCreation createfile = new FileCreation();
        createfile.CreateFile();
        //reading of file functionality done in different class 
        FileReader readfile = new();
        readfile.ReadFile();

        #endregion

        #region OCP

        Console.WriteLine("--------OCP Implementation--------");
        Console.WriteLine("Enter the side of square to get the Area and Perimeter :");
        var side = Convert.ToInt32(Console.ReadLine());
        Square squareArea = new(side);
        Console.WriteLine($"Area of the square of side {side} : {squareArea.Area}");
        Console.WriteLine($"Perimeter of the square of side {side} : {squareArea.Perimeter}");

        #endregion

        #region Liskov

        //Defining different subclasses from single superclass Shape base class
        //and having same method area in accordance with the implementation of LISKOV principle

        Console.WriteLine("--------Liskov Implementation--------");
        Design_Patterns.SOLID.Liskov.Square sqrArea = new(12);
        Console.WriteLine(sqrArea.Area());

        Design_Patterns.SOLID.Liskov.Rectangle rectangle = new();
        rectangle.Width = 12;
        rectangle.Height = 14;
        Console.WriteLine(rectangle.Area());


        #endregion

        #region ISP

        Console.WriteLine("--------ISP Implementation--------");
        // for different concerns we must provide different interfaces
        // where different results are required 
        PremiumSchools premiumSchool = new();
        Console.WriteLine("For Premium school");
        premiumSchool.HorseRiding();
        premiumSchool.Pool();
        premiumSchool.Swimming();

        NonPremiumSchool nonPremiumSchool = new();
        Console.WriteLine("For Non-Premium school");
        nonPremiumSchool.Sports();

        #endregion

        #region DIP

        //we can add different logger dependency to change the behavious of derived class
        Console.WriteLine("--------DIP Implementation--------");
        Addition add = new();
        Console.WriteLine("Calling Add method with different injection method");
        Console.WriteLine(add.Perform(1, 2));
        Console.WriteLine("Calling subtract method with different injection method");
        Subtraction subtraction = new();
        Console.WriteLine(subtraction.Perform(4, 2));

        #endregion

    }
}
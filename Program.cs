using System;

namespace LiskovSubPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape myRectangle = new Rectangle(2,3);
            Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");

            IShape mySquare = new Square(3);
            Console.WriteLine($"Square area: {mySquare.GetArea()}");
        }
    }
}

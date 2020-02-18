using System;

namespace LiskovSubPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calculator = new AreaCalculator();

            var myRectangle = new Rectangle() {Height = 2, Width = 3};
            var result = calculator.CalculateArea(myRectangle);
            Console.WriteLine($"Rectangle area: {result}");

            var mySquare = new Square() {Width = 3};
            var result2 = calculator.CalculateArea(mySquare);
            Console.WriteLine($"Square area: {result2}");

            Rectangle mySecondRectangle = new Square(){Height = 2, Width = 9};
            var result3 = calculator.CalculateArea(mySecondRectangle);
            Console.WriteLine($"2nd Rectangle area: {result3}");
        }
    }
}

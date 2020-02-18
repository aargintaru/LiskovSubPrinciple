namespace LiskovSubPrinciple
{
    public class AreaCalculator
    {
        public int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public int CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    }
}
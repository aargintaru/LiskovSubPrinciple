namespace LiskovSubPrinciple
{
    public class Square : IShape
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }
        public int GetArea()
        {
            return side * side;
        }
    }
}
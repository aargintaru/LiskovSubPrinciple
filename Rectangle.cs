namespace LiskovSubPrinciple
{
    public class Rectangle : IShape
    {
        private int width;
        private int height;

        public Rectangle(int height, int width)
        {
            this.width = width;
            this.height = height;
        }
        public int GetArea()
        {
            return height * width;
        }
    }
}
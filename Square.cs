namespace LiskovSubPrinciple
{
    public class Square : Rectangle
    {
        private int height;
        private int width;

        public override int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                width = value;
            }
        }

        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                height = value;
            }
        }
    }
}
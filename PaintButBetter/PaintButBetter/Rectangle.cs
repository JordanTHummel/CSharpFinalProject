namespace PaintButBetter
{
    public class Rectangle : Shape
    {
        protected int height;
        protected int width;
        public Rectangle(bool fill, Color color, int height, int width) : base(4, fill, color)
        {
            // Checking
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }
            if(width < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }
            // Setting
            this.height = height;
            this.width = width;
        }
    }
}

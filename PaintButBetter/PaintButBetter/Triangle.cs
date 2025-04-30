namespace PaintButBetter
{
    public class Triangle : Shape
    {
        private int baseLen;
        private int height;
        public Triangle(bool fill, Color color, int baseLen, int height) : base(3, fill, color)
        {
            // Checking
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }
            if (baseLen < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(baseLen));
            }
            // Setting
            this.height = height;
            this.baseLen = baseLen;
        }
    }
}
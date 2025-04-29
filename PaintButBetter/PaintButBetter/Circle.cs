namespace PaintButBetter
{
    public class Circle : Shape
    {
        int radius;
        public Circle(bool fill, Color color, int radius) : base(1, fill, color)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }
            this.radius = radius;
        }
    }
}

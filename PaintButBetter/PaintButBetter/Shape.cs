namespace PaintButBetter
{
    public abstract class Shape
    {
        protected int sides;
        protected bool fill;
        protected Color color;
        public Shape(int sides, bool fill, Color color)
        {
            // Chesking
            if(sides <= 1 && sides >= 8)
            {
                throw new ArgumentOutOfRangeException(nameof(sides));
            }
            if(Color.Empty == color)
            {
                throw new Exception("Color cannot be empty");
            }
            // Setting
            this.sides = sides;
            this.fill = fill;
            this.color = color;
        }
    }
}
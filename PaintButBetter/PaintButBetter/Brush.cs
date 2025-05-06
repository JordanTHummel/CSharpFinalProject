namespace PaintButBetter
{
    abstract class Brush
    {
        private float width;
        private Color color;
        private Pen pen;
        public float Width
        {
            get => width;
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
            }
        }
        public Color Color
        {
            get => color;
            set
            {
                color = value;
            }
        }

        public Pen Pen
        {
            get => pen;
        }
        public Brush(float width, Color color)
        {
            Width = width;
            Color = color;
            pen = new Pen(color, width);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }
}

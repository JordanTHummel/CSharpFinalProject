namespace PaintButBetter
{
    public class Square : Rectangle
    {
        private int sideLength;
        public Square(bool fill, Color color, int sideLength) : base(fill, color, sideLength, sideLength)
        {
            
        }
    }
}

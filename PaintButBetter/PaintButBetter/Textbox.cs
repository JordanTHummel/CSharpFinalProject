using System.CodeDom;

namespace PaintButBetter
{
    public class Textbox
    {
        private int height;
        private int width;
        private string text;
        public Textbox(int height, int width, string text)
        {
            // Checking
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }
            if (width < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }
            if(string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }
            // Setting
            this.height = height;
            this.width = width;
            this.text = text;
        }
    }
}

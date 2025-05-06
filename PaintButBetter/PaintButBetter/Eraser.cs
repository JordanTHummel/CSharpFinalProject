using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintButBetter
{
    class Eraser : Brush
    {
        public Eraser(float width) : base(width*4, Color.White)
        {
        }
        
    }
}

using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace sec006_32_COMP123_04
{
    public class Primitive
    {
        protected Color color;
        protected bool filled;
        protected Rectangle boundingRectangle;

        public Primitive(Color color, bool filled,
            Rectangle rectangle)
        {
            this.color = color;
            this.filled = filled;
            boundingRectangle = rectangle;
        }
    }
}

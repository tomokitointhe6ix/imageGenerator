using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace sec006_32_COMP123_04
{
    class DrawableRectangle : Primitive, IDrawable, IWritable
    {
        public DrawableRectangle(Color color, bool filled,
            Rectangle rectangle) : base(color, filled, rectangle)
        {
            //this.color = color;
            //this.filled = filled;
            //boundingRectangle = rectangle;
        }

        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush newDraw = new SolidBrush(color);
                g.FillRectangle(newDraw, boundingRectangle);
            }
            else
            {
                Pen newDraw = new Pen(color);
                g.DrawRectangle(newDraw, boundingRectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine("{0}, {1}, {2}",
                color, filled, boundingRectangle);
        }

        public double Area()
        {
            return boundingRectangle.Width * boundingRectangle.Height;
        }
    }
}

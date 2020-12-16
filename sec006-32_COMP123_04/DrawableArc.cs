using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace sec006_32_COMP123_04
{
    class DrawableArc :
        Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled,
            Rectangle rectangle, float start, float end)
            : base(color, filled, rectangle)
        {
            //this.color = color;
            //this.filled = filled;
            //boundingRectangle = rectangle;
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen newDraw = new Pen(color);
            g.DrawArc(newDraw, boundingRectangle,
                start, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine("{0}, {1}, {2}, {3}, {4}",
                color, filled, boundingRectangle, start, end);
        }
    }
}

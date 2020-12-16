using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace sec006_32_COMP123_04
{
    class DrawableLine : IDrawable,IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            lineStart = start;
            lineEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen newDraw = new Pen(color);
            g.DrawLine(newDraw, lineStart, lineEnd);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine("{0}, {1}, {2}",
                color, lineStart, lineEnd);
        }
    }
}

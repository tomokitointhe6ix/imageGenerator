using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace sec006_32_COMP123_04
{
    class DrawableBezier : IDrawable,IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start,
            Point first, Point second, Point end)
        {
            this.color = color;
            curveStart = start;
            controlFirst = first;
            controlSecond = second;
            curveEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen newDraw = new Pen(color);
            g.DrawBezier(newDraw, curveStart, controlFirst,
                controlSecond, curveEnd);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine("{0}, {1}, {2}, {3}, {4}", color,
                curveStart, controlFirst, controlSecond, curveEnd);
        }
    }
}

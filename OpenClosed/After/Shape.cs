using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    internal interface IShape
    {
        void Draw();
    }
    internal class Rectangle: IShape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public void Draw()
        {
            // draw rectangle
        }
    }
    internal class Square: IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public void Draw()
        {
            // draw square
        }
    }
    internal class ShapeDrawer
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }// in this way we can add new shapes without changing the existing code by implementing the IShape interface
    }
}

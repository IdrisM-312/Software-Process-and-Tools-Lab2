using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int length, int width,string id) : base(id)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return length * width;
            }
        }
    }
}

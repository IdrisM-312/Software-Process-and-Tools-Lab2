using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id) : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return Math.PI * radius * radius;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Square : Shape
    {
        private int mySide;

        public Square(int side, string id) : base(id)
        {
            mySide = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return mySide * mySide;
            }
        }
    }
}

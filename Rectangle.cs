using System;
using System.Collections.Generic;
using System.Text;

namespace hinh
{
    class Rectangle : Shape
    {
        public double height;
        public double width;


        public override double Area() {
            return width * height;
        }

        public void getHeight()
        {
            Console.WriteLine("height{0}", height);
        }
        public void getWidth()
        {
            Console.WriteLine("width{0}", width);
        }
        public override double perimeter()
        {
            return (width + height) + 2;
        }
        public  Rectangle(string Point , double width, double height)

        {
            this.Point = Point;
            this.width = width;
            this.height = height;

        }

        public Rectangle()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace hinh
{
    public abstract class  Shape
    {

        public string Color;
        public string Point;
        public abstract double Area();
        public abstract double perimeter();


        public void getColor()
        {

            Console.WriteLine("Color{0}", Color);
        }
         public void getOrigin()
        {
            Console.WriteLine("Point{0}", Point);
        }
    

        public void setColor( string Col)
        {
              Col = Color;

        }

        public void setOrigin ( string Org)
        {
            Org = Point;

        }
        public Shape(string Color, string Point) 
        {
            this.Color = Color;
            this.Point = Point;
        }
        public Shape()
        {

        }
       
        public  Shape(string Point) 
        {
            this.Point = Point;
        }

        

    }


}


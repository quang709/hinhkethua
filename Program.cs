using System;
using System.Text;

namespace hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập width :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập height :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập bán kính :");
            double r = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle("", a, b);
            Console.WriteLine("Diện tích HCN là : {0}", rectangle.Area());
            Console.WriteLine("Chu vi HCN là : {0}", rectangle.perimeter());
            Circle circle = new Circle("", r);
            Console.WriteLine("Diện tích tròn là : {0}", Math.Round(circle.Area()));
            Console.WriteLine("Chu vi tròn là : {0}", Math.Round(circle.perimeter()));
        }
    }
}

using System;

namespace PolyMorphTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape re = new Rectangle(20.0, 10.0);
            Console.WriteLine("Area:"+re.calculateArea());         
            Console.WriteLine("Circumference:"+re.calculateCircumference());
            Shape sq = new Square(20.0);
            Console.WriteLine("Square Area:"+sq.calculateArea());         
            Console.WriteLine("Square Circumference:"+sq.calculateCircumference());
        }
    }
}

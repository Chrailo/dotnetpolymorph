using System;
using System.Collections.Generic;

namespace PolyMorphTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Shape re = new Rectangle(20.0, 10.0);
            shapes.Add(re);                
            Shape sq = new Square(20.0);
            shapes.Add(sq);
            
            shapes.ForEach( sh => {
                Console.WriteLine("Type:"+sh.getInfo());
                Console.WriteLine("Area:"+sh.calculateArea());
                Console.WriteLine("Circumference:"+sh.calculateCircumference());
            });
        }
    }
}

using Library;
using Library.Shapes.Lines;
using System;
using static System.Console;

namespace TestCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDraw line1 = new HorizontalLine(2, 10, 2),
            //    line2 = new VerticalLine(3, 2, 6);
            //line1.Draw();
            //line2.Draw();

            //if (line1 is Shape shape1 && line2 is Shape shape2)
            //{
            //    WriteLine();
            //    WriteLine(shape2.IsHit(shape1));
            //}
            Shape line1 = new HorizontalLine(2, 10, 2),
                line2 = new VerticalLine(3, 2, 6);
            line1.Draw();
            line2.Draw();

            WriteLine();
            WriteLine(line1.IsHit(line2));
            ReadKey();
        }
    }
}

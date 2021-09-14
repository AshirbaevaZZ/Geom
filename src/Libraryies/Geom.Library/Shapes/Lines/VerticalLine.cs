using System;

namespace Library.Shapes.Lines
{
    public class VerticalLine : Line
    {
        /// <summary>
        /// инициализирует вертикальные линию
        /// </summary>
        /// <param name="x">координата x(х>=0)<param>
        /// <param name="y1">начальная координата y1(y1>=0)</param>
        /// <param name="y2">конечная координата y2(y2>=у1)</param>
        public VerticalLine(int x, int y1,int y2)
        {
            if (y1 < 0 || x < 0 || y2 < y1)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = y1; i <= y2; i++) Locus.Add(new(x, i));
        }
    }
}

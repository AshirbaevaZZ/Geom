using static System.Console;

namespace Library
{
    public struct Point
    {
        private const char Symbol = 'X';
        public int X, Y;

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(Symbol);
        }

        internal bool IsHit(Point point) => X == point.X && Y == point.Y;
    }
}

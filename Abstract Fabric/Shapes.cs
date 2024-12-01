namespace AbstractFabricLibrary
{
    public interface Shape
    {
        void Draw(Graphics g);
        int X { get; }
        int Y { get; }
    }
    public class Circle : Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;
        public Circle(Brush brush, int x, int y)
        {
            _brush = brush;
            X = x;
            Y = y;
        }
        public void Draw(Graphics g)
        {
            g.FillEllipse(_brush, X, Y, 40, 40);
        }
    }
    public class Square : Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;
        public Square(Brush brush, int x, int y)
        {
            _brush = brush;
            X = x;
            Y = y;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(_brush, X, Y, 40, 40);
        }
    }
    public class Triangle : Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;

        public Triangle(Brush brush, int x, int y)
        {
            _brush = brush;
            X = x;
            Y = y;
        }
        public void Draw(Graphics g)
        {
            Point[] points = {
            new Point(X + 40 / 2, Y),
            new Point(X + 40, Y + 40),
            new Point(X, Y + 40)
            };

            g.FillPolygon(_brush, points);
        }
    }
}
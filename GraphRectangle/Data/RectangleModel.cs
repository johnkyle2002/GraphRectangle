namespace GraphRectangle.Data
{
    public class RectangleModel
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Conflict { get; set; } = false;

    }
}

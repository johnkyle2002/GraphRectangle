namespace GraphRectangle.Service
{
    public interface IGraphService
    {
        void AddRectangle(int pointX, int pointY, int width, int height);
        void Dispose();
        void GenerateGrid(int x, int y);
        bool isValid();
        void ValidateRectangles();
    }
}
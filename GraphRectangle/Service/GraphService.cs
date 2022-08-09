using GraphRectangle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphRectangle.Service
{
    public class GraphService : IDisposable
    {
        private const int spacer = 20;
        private const int startingPoint = 20;
        private readonly Graphics _graphics;
        private readonly int _height;
        private readonly int _width;
        private readonly TextBox _errorMessage;
        private bool _disposedValue;
        private List<RectangleModel> RectangleList = new List<RectangleModel>();


        public GraphService(Graphics graphics, int width, int height, TextBox errorMessage)
        {
            _graphics = graphics;
            _height = height;
            _width = width;
            _errorMessage = errorMessage;
            GenerateGraph(width, height);
        }

        public bool isValid()
        {
            return !(_width < 5 || _width > 25 || _height < 5 || _height > 25);            
        }

        /// <summary>
        /// Generate X and Y axis line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        public void GenerateGraph(int x, int y)
        {
            if (!isValid())
            {                
                _errorMessage.Text += _errorMessage.Text + "X and Y axis should be greater than 5 and less than 25 points" + Environment.NewLine;
                return;
            }

            DrawXAxisGraph(x, y);
            DrawYAxisGraph(x, y);
        }

        /// <summary>
        /// Draw a x axis line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="maxHeight">max width</param>
        private void DrawXAxisGraph(int x, int maxHeight)
        {
            if (x < 5 || x > 20)
                _errorMessage.Text += _errorMessage.Text + "X axis should be greater than 5 and less than 25 points" + Environment.NewLine;

            for (int count = 1; count <= x; count++)
            {
                var pointX = count * spacer + startingPoint;
                var endOfX = maxHeight * spacer;
                _graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, 12), Brushes.Black, new Point(pointX - 5, 0));
                _graphics.DrawLine(new Pen(Color.Red, 1), new Point(pointX, 20), new Point(pointX, endOfX));
            }
        }

        /// <summary>
        /// Draw a y axis line graph
        /// </summary>
        /// <param name="maxWidth">max width</param>
        /// <param name="y">y axis</param>
        private void DrawYAxisGraph(int maxWidth, int y)
        {
            if (y < 5 || y > 25)
                _errorMessage.Text += _errorMessage.Text + "Y axis should be greater than 5 and less than 25 points" + Environment.NewLine;

            for (int count = 1; count <= y; count++)
            {
                var pointY = count * spacer;
                var endOfY = maxWidth * spacer + startingPoint;
                _graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, 12), Brushes.Black, new Point(15, pointY - 10));
                _graphics.DrawLine(new Pen(Color.Red, 1), new Point(40, pointY), new Point(endOfY, pointY));
            }
        }


        /// <summary>
        /// Add rectangle 
        /// </summary>
        /// <param name="pointX">X axis starting point</param>
        /// <param name="pointY">Y Axis ending point</param>
        /// <param name="width">rectangle width</param>
        /// <param name="height">rectangle height</param>
        public void AddRectangle(int pointX, int pointY, int width, int height)
        {
            if (ValidateRectangle(pointX, pointY, width, height))
            { 
                return;
            }

            RectangleList.Add(new RectangleModel { PointX = pointX, PointY = pointY });

            pointX = pointX * spacer + startingPoint;
            pointY = pointY * spacer;
            width = width * spacer;
            height = height * spacer;

            DrawRectangle(pointX, pointY, width, height);
        }

        private bool ValidateRectangle(int pointX, int pointY, int width, int height)
        {
            var invalid = false;
            
            if(pointX == 0 || pointY == 0)
            {
                _errorMessage.Text += _errorMessage.Text + "X and Y should not be equal to zero." + Environment.NewLine;
                invalid = true;
            }
            
            if (RectangleList.Any(a => a.PointX == pointX && a.PointY == pointY && a.Width == width && a.Height == height))
            {
                _errorMessage.Text += _errorMessage.Text + "Rectangle already exists." + Environment.NewLine;
                invalid = true;
            }

            
            return invalid;
            //if(pointX == pointY )

        }

        /// <summary>
        /// Draw rectangle 
        /// </summary>
        /// <param name="pointX">X axis starting point</param>
        /// <param name="pointY">Y Axis ending point</param>
        /// <param name="width">rectangle width</param>
        /// <param name="height">rectangle height</param>
        private void DrawRectangle(int pointX, int pointY, int width, int height)
        {
            Pen blackPen = new Pen(GetRandomColor(), 3);
            Rectangle rect = new Rectangle(pointX, pointY, width, height);
            _graphics.DrawRectangle(blackPen, rect);
        }

        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (_graphics != null)
                    {
                        _graphics.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~GraphService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

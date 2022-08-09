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

        public GraphService(Graphics graphics, int height, int width, TextBox errorMessage)
        {
            _graphics = graphics;
            _height = height;
            _width = width;
            _errorMessage = errorMessage;
            GenerateGraph(width, height);
        }

        /// <summary>
        /// Generate X and Y axis line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        public void GenerateGraph(int x, int y)
        {
            DrawXAxisGraph(x, y);
            DrawYAxisGraph(x, y);
        }

        /// <summary>
        /// Draw a x axis line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="maxHeight">max width</param>
        public void DrawXAxisGraph(int x, int maxHeight)
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

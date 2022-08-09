using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphRectangle.Service
{
    public class GraphService:IDisposable
    {
        private readonly Graphics _graphics;
        private readonly int _height;
        private readonly int _width;
        private string _errorMessage;
        private bool _disposedValue;

        public GraphService(Graphics graphics, int height, int width)
        {
            _graphics = graphics;
            _height = height;
            _width = width;
        }

        /// <summary>
        /// Generate X and Y axis line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        public void GenerateGraph(int x, int y)
        {

        }

        /// <summary>
        /// Draw a line graph
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="maxWidth">max width</param>
        public void DrawXAxisGraph(int x, int maxWidth)
        {
            if ((x < 5 || x > 2) && maxWidth <= x - 5 || maxWidth > 5)
                _errorMessage = "X axis should be greater than 5 and less than 25 points" + Environment.NewLine;

            for (int count = 1; count < x; count++)
            {
                var pointX = count * 20 + 20;
                var endOfX = count * 20;
                _graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, 12), Brushes.Black, new Point(pointX - 5, 0));
                _graphics.DrawLine(new Pen(Color.Red, 1), new Point(pointX, 20), new Point(pointX, endOfX));
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

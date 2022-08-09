using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphRectangle.Service
{
    public class GraphService
    {
        private readonly Graphics _graphics;
        private readonly int _height;
        private readonly int _width;

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
    }
}

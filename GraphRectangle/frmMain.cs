using GraphRectangle.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphRectangle
{
    public partial class frmMain : Form
    {
        GraphService graph;
        public frmMain()
        {
            InitializeComponent();            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private async void btn_BuildGrap_Click(object sender, EventArgs e)
        {
            if(graph is not null)
            {
                graph.Dispose();
                pnl_DrawingBoard.Invalidate();
                await Task.Delay(300);
            }

            pnl_Command.Enabled = true;
            graph = new GraphService(pnl_DrawingBoard.CreateGraphics(), Convert.ToInt32(nud_PointX.Value), Convert.ToInt32(nud_PointY.Value), txtErrorMessage);
        }
    }
}

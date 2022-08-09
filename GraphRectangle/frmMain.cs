using GraphRectangle.Data;
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
        public List<RectangleModel> RectangleList = new List<RectangleModel>();
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

            graph = new GraphService(pnl_DrawingBoard.CreateGraphics(), Convert.ToInt32(nud_PointX.Value), Convert.ToInt32(nud_PointY.Value), txtErrorMessage);            
            pnl_Command.Enabled = graph.isValid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.AddRectangle((int)nud_RecX.Value, (int)nud_RecY.Value, (int)nud_RecX2.Value, (int)nud_RecY2.Value);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            graph.ValidateRectangles();
        }
    }
}

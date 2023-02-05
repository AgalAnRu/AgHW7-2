using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgHW7_2
{
    public enum PanelGrid
    {
        On,
        Off
    }
    public partial class FormTables : Form
    {
        private PanelGrid Grid = PanelGrid.On;
        private PanelGrid Tabl = PanelGrid.Off;
        private int GlobalScale = 2;
        private int GraphicScale = 10;
        private Point CoordinateOriginPoint;
        public FormTables()
        {
            InitializeComponent();
        }
        private void panelTables_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = e.Graphics)
            {
                if (Grid == PanelGrid.On)
                {
                    DrawGrideOnPanel(panelTables, gr);
                }
                if (Tabl == PanelGrid.On)
                {
                    DrawTables(gr);
                }
            }

        }
        private void DrawTables(Graphics gr)
        {
            Pen pen = new Pen(Color.Red, 2);
            Point fromPoint = new Point(0, 0);
            Point toPoint = new Point(100, 100);
            gr.DrawLine(pen, fromPoint, toPoint);

        }
        private void DrawGrideOnPanel(Panel panel, Graphics gr)
        {
            Pen pen = new Pen(Color.Gray, 1);
            int grideSize = GlobalScale * GraphicScale;
            int numberVerticalLine = panel.Width / grideSize;
            int numberGorizontalLine = panel.Height / grideSize;
            Point fromPoint = new Point(0, 0);
            Point toPoint = new Point(panel.Width, 0);
            for (int i = 0; i < panel.Height; i += grideSize)
            {
                fromPoint.Y += grideSize;
                toPoint.Y += grideSize;
                gr.DrawLine(pen, fromPoint, toPoint);
            }
            fromPoint.Y = 0;
            toPoint.X = 0;
            for (int i = 0; i < panel.Width; i += grideSize)
            {
                fromPoint.X += grideSize;
                toPoint.X += grideSize;
                gr.DrawLine(pen, fromPoint, toPoint);
            }
        }
        private void buttonAddNewTable_Click(object sender, EventArgs e)
        {
            if (Tabl == PanelGrid.Off)
                Tabl = PanelGrid.On;
            else
                Tabl = PanelGrid.Off;
            panelTables.Invalidate();
        }
        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrid.Checked)
            {
                Grid = PanelGrid.On;
            }
            else
            {
                Grid = PanelGrid.Off;
            }
            panelTables.Invalidate();
        }

        private void radioButtonScale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScale05.Checked)
            {
                GraphicScale = 5;
            }
            if (radioButtonScale1.Checked)
            {
                GraphicScale = 10;
            }
            if (radioButtonScale2.Checked)
            {
                GraphicScale = 20;
            }
            panelTables.Invalidate();
        }
        
        private Point ConvertCoordinateToCell(Point point)
        {

        }
    }
    public class CellPoint
    {
        public int X;
        public int Y;
        public int OriginX;
        public int OriginY;
    }

}

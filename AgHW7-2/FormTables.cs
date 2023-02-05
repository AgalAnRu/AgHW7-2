using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AgHW7_2
{
    public enum Visibility
    {
        On,
        Off
    }
    public partial class FormTables : Form
    {
        private Visibility Grid = Visibility.On;
        private Visibility Axis = Visibility.On;
        private Visibility Tabl= Visibility.On;
        private int GlobalScale = 2;
        private int GraphicScale = 10;
        private int XOffset = 5;
        public Point OriginXY;
        public Point OriginGridXY = new Point(3, 5);
        //private Point CoordinateOriginPoint;
        public FormTables()
        {
            InitializeComponent();
        }
        private void panelTables_Paint(object sender, PaintEventArgs e)
        {
            //OriginXY = 
            using (Graphics gr = e.Graphics)
            {
                if (Grid == Visibility.On)
                {
                    DrawGrideOnPanel(panelTables, gr);
                }
                if (Axis == Visibility.On)
                {
                    DrawAxis(panelTables, gr);
                }
                if (Tabl == Visibility.On)
                {
                    DrawTables(gr);
                }
            }

        }
        private void DrawTables(Graphics gr)
        {
            Pen pen = new Pen(Color.Red, 2);
            DrawLineOnGraphic(gr, pen, 1, 1, 3, 2);            
        }
        private void DrawLineOnGraphic(Graphics gr, Pen pen, int fromX, int fromY, int toX, int toY)
        {
            int scale = GlobalScale * GraphicScale;
            CellPoint fromCellPoint = new CellPoint(panelTables, scale, XOffset);
            CellPoint toCellPoint = new CellPoint(panelTables, scale, XOffset);
            fromCellPoint.SetXY(fromX, fromY);
            toCellPoint.SetXY(toX, toY);
            Point fromPoint = fromCellPoint.ToOriginPoint();
            Point toPoint = toCellPoint.ToOriginPoint();
            gr.DrawLine(pen, fromPoint, toPoint);
        }
        private void DrawLineOnGraphic(Graphics gr, Pen pen, Point from, Point to)
        {
            int scale = GlobalScale * GraphicScale;
            CellPoint fromCellPoint = new CellPoint(panelTables, scale, XOffset);
            CellPoint toCellPoint = new CellPoint(panelTables, scale, XOffset);
            fromCellPoint.SetXY(from.X, from.Y);
            toCellPoint.SetXY(to.X, to.Y);
            Point fromPoint = fromCellPoint.ToOriginPoint();
            Point toPoint = toCellPoint.ToOriginPoint();
            gr.DrawLine(pen, fromPoint, toPoint);
        }
        private void DrawAxis (Panel panel, Graphics gr)
        {
            Pen pen = new Pen(Color.Blue, 1);
            Point fromPoint = new Point(0, panel.Height/2);
            Point toPoint = new Point(panel.Width, panel.Height / 2);
            gr.DrawLine(pen, fromPoint, toPoint);
            fromPoint.X = XOffset*GlobalScale*GraphicScale;
            fromPoint.Y = 0;
            toPoint.X = fromPoint.X;
            toPoint.Y = panel.Height;
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
            //DrawAxis (panel, gr);
        }
        private void buttonAddNewTable_Click(object sender, EventArgs e)
        {
            if (Tabl == Visibility.Off)
                Tabl = Visibility.On;
            else
                Tabl = Visibility.Off;
            panelTables.Invalidate();
        }
        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrid.Checked)
            {
                Grid = Visibility.On;
            }
            else
            {
                Grid = Visibility.Off;
            }
            panelTables.Invalidate();
        }
        private void checkBoxAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAxis.Checked)
            {
                Axis = Visibility.On;
            }
            else
            {
                Axis = Visibility.Off;
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

        private void ConvertCoordinateToCell(Point point)
        {

        }
    }
    public class CellPoint
    {
        public int X;
        public int Y;
        public int OriginX;
        public int OriginY;
        private int Scale;
        private int StartX;
        private int StartY;
        public CellPoint(Panel panel, int scale=20, int startX=5, int x=0, int y=0 )
        {
            X = x;
            Y = y;
            Scale = scale;
            StartX = startX;
            StartY = (panel.Height / 2) / Scale;
            OriginX = Scale * (X + StartX);
            OriginY = Scale * (StartY - Y);
        }
        public Point ToOriginPoint()
        {
            Point originPoint= new Point();
            originPoint.X = OriginX;
            originPoint.Y = OriginY;
            return originPoint;
        }
        public void SetXY (int x, int y)
        {
            X = x;
            Y = y;
            OriginX = Scale * (X + StartX);
            OriginY = Scale * (StartY - Y);
        }
    }

}

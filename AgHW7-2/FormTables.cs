using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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
        private readonly int GlobalScale = 2;
        private readonly int XOffset = 5;
        private int GraphicScale = 10;
        public Point OriginXY;
        public FormTables()
        {
            InitializeComponent();
        }
        private void panelTables_Paint(object sender, PaintEventArgs e)
        {
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
                if (ListTables.Tables.Count > 0)
                {
                    foreach (Table table in ListTables.Tables)
                    {
                        DrawTable(gr, table);
                    }
                }
            }
        }
        private void DrawTable(Graphics gr, Table table)
        {
            Point[] corners = table.GetCorners();
            int scale = GlobalScale * GraphicScale;
            CellPoint cellPoints = new CellPoint(panelTables, scale);
            Point[] polygonCornes = new Point[corners.Length];
            for (int i = 0; i < corners.Length; i++)
            {
                cellPoints.SetXY(corners[i].X, corners[i].Y);
                polygonCornes[i] = cellPoints.ToOriginPoint();
            }
            Color penColor = (table.Selection == Selection.Selected) ? Color.Red : Color.White;
            Pen pen = new Pen(penColor, 2);
            gr.DrawPolygon(pen, polygonCornes);
        }
        private void DrawAxis(Panel panel, Graphics gr)
        {
            Pen pen = new Pen(Color.Blue, 1);
            int yAxis = panel.Height / 2;
            int scale = GlobalScale * GraphicScale;
            yAxis -= yAxis % scale;
            Point fromPoint = new Point(0, yAxis);
            Point toPoint = new Point(panel.Width, yAxis);
            gr.DrawLine(pen, fromPoint, toPoint);
            fromPoint.X = XOffset * scale;
            fromPoint.Y = 0;
            toPoint.X = fromPoint.X;
            toPoint.Y = panel.Height;
            gr.DrawLine(pen, fromPoint, toPoint);
        }
        private void DrawGrideOnPanel(Panel panel, Graphics gr)
        {
            Pen pen = new Pen(Color.Gray, 1);
            int grideSize = GlobalScale * GraphicScale;
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
        //== Controls
        private void ButtonAddNewTable_Click(object sender, EventArgs e)
        {
            ListTables.Add();
            SetControlsVisibility(true);
            listBoxTables.Items.Add(ListTables.TableNames[ListTables.TableNames.Count - 1]);
            panelTables.Invalidate();
        }
        private void ButtonDeleteSelectedTable_Click(object sender, EventArgs e)
        {
            for (int i = ListTables.Tables.Count - 1; i >= 0; i--)
            {
                if (ListTables.Tables[i].Selection == Selection.Selected)
                {
                    ListTables.Delete(i);
                    listBoxTables.Items.RemoveAt(i);
                }
            }
            SetControlsEnabled(false);
            if (ListTables.Tables.Count == 0)
            {
                SetControlsVisibility(false);
            }
            panelTables.Invalidate();
        }
        private void ButtonRotateLeft_Click(object sender, EventArgs e)
        {
            foreach (Table table in ListTables.Tables)
            {
                if (table.Selection == Selection.Selected)
                {
                    table.TurnLeft();
                }
            }
            panelTables.Invalidate();
        }
        private void ButtonRotateRight_Click(object sender, EventArgs e)
        {
            foreach (Table table in ListTables.Tables)
            {
                if (table.Selection == Selection.Selected)
                {
                    table.TurnRight();
                }
            }
            panelTables.Invalidate();
        }
        private void SetControlsVisibility(bool visibility)
        {
            buttonDeleteSelectedTable.Visible = visibility;
            buttonSelectAll.Visible = visibility;
            buttonRotateLeft.Visible = visibility;
            buttonRotateRight.Visible = visibility;
            listBoxTables.Visible = visibility;
        }
        private void SetControlsEnabled(bool enablity)
        {
            buttonDeleteSelectedTable.Enabled = enablity;
            buttonRotateLeft.Enabled = enablity;
            buttonRotateRight.Enabled = enablity;
        }
        private void CheckBoxGrid_CheckedChanged(object sender, EventArgs e)
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
        private void CheckBoxAxis_CheckedChanged(object sender, EventArgs e)
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
        private void RadioButtonScale_CheckedChanged(object sender, EventArgs e)
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
        private void PanelTables_Resize(object sender, EventArgs e)
        {
            panelTables.Invalidate();
        }
        // == Не используются
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
        private void ConvertCoordinateToCell(Point point)
        {

        }

        private void ListBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxTables.Items.Count; i++)
            {
                ListTables.Tables[i].Selection = (listBoxTables.GetSelected(i)) ? Selection.Selected : Selection.Deselected;
            }
            if (listBoxTables.SelectedIndex != -1)
            {
                SetControlsEnabled(true);
            }
            if (listBoxTables.SelectedIndex == -1)
            {
                SetControlsEnabled(false);
            }
            panelTables.Invalidate();
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            if (buttonSelectAll.Text == "Select All")
            {
                for (int i = 0; i < listBoxTables.Items.Count; i++)
                {
                    listBoxTables.SetSelected(i, true);
                }
                buttonSelectAll.Text = "Deselect All";
                return;
            }
            if (buttonSelectAll.Text == "Deselect All")
            {
                for (int i = 0; i < listBoxTables.Items.Count; i++)
                {
                    listBoxTables.SetSelected(i, false);
                }
                buttonSelectAll.Text = "Select All";
            }
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
        public CellPoint(Panel panel, int scale = 20, int startX = 5, int x = 0, int y = 0)
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
            Point originPoint = new Point();
            originPoint.X = OriginX;
            originPoint.Y = OriginY;
            return originPoint;
        }
        public void SetXY(int x, int y)
        {
            X = x;
            Y = y;
            OriginX = Scale * (X + StartX);
            OriginY = Scale * (StartY - Y);
        }
    }
}

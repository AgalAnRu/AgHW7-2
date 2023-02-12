using System;
using System.Drawing;
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
        private readonly int XOffsetInCells = 6;
        private int CellSize = 20;
        public FormTables()
        {
            InitializeComponent();
        }
        private void PanelTables_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = e.Graphics)
            {
                Coordinate.SetScale(CellSize);
                Coordinate.SetOrigin(new Point(XOffsetInCells * CellSize, (int)gr.VisibleClipBounds.Height / 2));
                if (Grid == Visibility.On)
                {
                    DrawGrideOnPanel(gr);
                }
                if (Axis == Visibility.On)
                {
                    DrawAxis(gr);
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
            Point[] polygonCornes = new Point[corners.Length];
            for (int i = 0; i < corners.Length; i++)
            {
                polygonCornes[i] = Coordinate.ConvertToViewportXY(corners[i]);
            }
            Color penColor = (table.Selection == Selection.Selected) ? Color.Blue : Color.White;
            Pen pen = new Pen(penColor, 2);
            gr.DrawPolygon(pen, polygonCornes);
            pen.Color = Color.Magenta;
            //pen.Width = 1;
            gr.DrawEllipse(pen, polygonCornes[0].X - 2, polygonCornes[0].Y - 2, 4, 4);
        }
        private void DrawAxis(Graphics gr)
        {
            Pen pen = new Pen(Color.DarkGreen, 1);
            gr.DrawLine(pen, new Point(0, Coordinate.Origin.Y), new Point((int)gr.VisibleClipBounds.Width, Coordinate.Origin.Y));
            gr.DrawLine(pen, new Point(Coordinate.Origin.X, 0), new Point(Coordinate.Origin.X, (int)gr.VisibleClipBounds.Height));
        }
        private void DrawGrideOnPanel(Graphics gr)
        {
            Pen pen = new Pen(Color.Gray, 1);
            int y = Coordinate.Origin.Y % Coordinate.Scale;
            while (y < (int)gr.VisibleClipBounds.Height)
            {
                gr.DrawLine(pen, new Point(0, y), new Point((int)gr.VisibleClipBounds.Width, y));
                y += Coordinate.Scale;
            }
            int x = Coordinate.Origin.X % Coordinate.Scale;
            while (x < (int)gr.VisibleClipBounds.Width)
            {
                gr.DrawLine(pen, new Point(x, 0), new Point(x, (int)gr.VisibleClipBounds.Height));
                x += Coordinate.Scale;
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
                CellSize = 10;
            }
            if (radioButtonScale1.Checked)
            {
                CellSize = 20;
            }
            if (radioButtonScale2.Checked)
            {
                CellSize = 40;
            }
            panelTables.Invalidate();
        }
        private void PanelTables_Resize(object sender, EventArgs e)
        {
            panelTables.Invalidate();
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
                buttonSelectAll.Text = "Deselect All";
            }
            if (listBoxTables.SelectedIndex == -1)
            {
                SetControlsEnabled(false);
                buttonSelectAll.Text = "Select All";
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
        private void PanelTables_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListTables.Tables.Count > 0)
            {
                for (int i = 0; i < ListTables.Tables.Count; i++)
                {
                    if (IsPointInsidePoligon(e.Location, ListTables.Tables[i]))
                    {
                        ListTables.Tables[i].ChangeSelection();
                        listBoxTables.SetSelected(i, !listBoxTables.GetSelected(i));
                    }
                }
            }
        }
        private bool IsPointInsidePoligon(Point point, Table table)
        {
            Point[] corners = table.GetCorners();
            for (int i = 0; i < corners.Length; i++)
            {
                corners[i] = Coordinate.ConvertToViewportXY(corners[i]);
            }
            Point start = corners[corners.Length - 1];
            Point end = corners[0];
            int sign = Math.Sign((end.X - start.X) * (point.Y - start.Y) - (end.Y - start.Y) * (point.X - start.X));
            int signNext;
            for (int i = 0; i < corners.Length - 1; i++)
            {
                start = corners[i];
                end = corners[i + 1];
                signNext = Math.Sign((end.X - start.X) * (point.Y - start.Y) - (end.Y - start.Y) * (point.X - start.X));
                if (sign != signNext)
                    return false;
                sign = signNext;
            }
            return true;
        }
    }
}

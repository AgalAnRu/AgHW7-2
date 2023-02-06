using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

public enum FixedCorner
{
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight
}
namespace AgHW7_2
{

    internal class Table
    {
        internal FixedCorner FixedCorner = FixedCorner.BottomLeft;
        internal Point TopLeft;
        internal Point TopRight;
        internal Point BottomLeft;
        internal Point BottomRight;
        internal int AngleDegrees = 0;
        private double AngleRadians;
        internal int Width;
        internal int Height;
        private static int MaxSideSize = 3;
        private static int MinSideSize = 2;
        private static int MaxTableArea = 6;
        private static Random Rnd = new Random();
        internal Table()
        {
            FixedCorner = FixedCorner.BottomLeft;
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
            //Corner BL = new Corner ()
            BottomLeft.X = 0;
            BottomLeft.Y = 0;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
        }
        internal Table(Point pointFixedCorner)
        {
            FixedCorner = FixedCorner.BottomLeft;
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
            BottomLeft.X = pointFixedCorner.X;
            BottomLeft.Y = pointFixedCorner.Y;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
        }
        internal Table(Point pointFixedCorner, FixedCorner fixedCorner)
        {
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
            FixedCorner = fixedCorner;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
            //Дописать перегрузку
        }
        internal Point[] GetCorners()
        {
            Point[] corners = new Point[4];
            corners[0] = GetBottomLeft();
            corners[1] = GetBottomRight();
            corners[2] = GetTopRight();
            corners[3] = GetTopLeft();
            return corners;
        }
        internal Point GetBottomLeft()
        {
            if (FixedCorner == FixedCorner.BottomLeft) { }
            return BottomLeft;
        }
        internal Point GetBottomRight()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                BottomRight.X = (int)(BottomLeft.X + Width * Math.Round( Math.Cos(AngleRadians)));
                BottomRight.Y = (int)(BottomLeft.Y + Width * Math.Round(Math.Sin(AngleRadians)));
            }
            return BottomRight;
        }
        internal Point GetTopLeft()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                TopLeft.X = (int)(BottomLeft.X - Height * Math.Round(Math.Sin(AngleRadians)));
                TopLeft.Y = (int)(BottomLeft.Y + Height * Math.Round(Math.Cos(AngleRadians)));
            }
            return TopLeft;
        }
        internal Point GetTopRight()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                TopRight.X = (int)(BottomLeft.X + Width * Math.Round(Math.Cos(AngleRadians)) - Height * Math.Round(Math.Sin(AngleRadians)));
                TopRight.Y = (int)(BottomLeft.Y + Width * Math.Round(Math.Sin(AngleRadians)) + Height * Math.Round(Math.Cos(AngleRadians)));
            }
            return TopRight;
        }
        private void Turn(int angle)
        {
            AngleDegrees += angle;
            if (AngleDegrees >= 360)
                AngleDegrees -= 360;
            if (AngleDegrees < 0)
                AngleDegrees += 360;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
        }
        internal void TurnLeft()
        {
            AngleDegrees += 90;
            if (AngleDegrees >= 360)
                AngleDegrees -= 360;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
        }
        internal void TurnRight()
        {
            AngleDegrees -= 90;
            if (AngleDegrees < 0)
                AngleDegrees += 360;
            AngleRadians = AngleDegrees * Math.PI / 180.0;
        }
    }
    internal class ListTables
    {
        internal static List<Table> Tables;
        static int Counter = 0;
        static int ID = 1;
        internal static List<string> TableNames;
        static int TableOffset = 5;
        static ListTables()
        {
            Tables = new List<Table>();
            TableNames = new List<string>();
        }
        internal static void Add()
        {
            Tables.Add(new Table(new Point(Counter * TableOffset, 0)));
            TableNames.Add($"Table #{ID}");
            ID++;
            Counter++;
        }
        internal static void Delete(int index)
        {
            Tables.RemoveAt(index);
            TableNames.RemoveAt(index);
            Counter--;
            for (int i = 0; i < TableNames.Count; i++)
            {
                MoveTable(Tables[i], new Point(i * TableOffset, 0));
            }
        }
        private static void MoveTable(Table table, Point point)
        {
            table.BottomLeft = point;
        }
    }
}

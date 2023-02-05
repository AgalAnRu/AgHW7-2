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
        internal int Angle = 0;
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

        }
        internal Table(Point pointFixedCorner)
        {
            FixedCorner = FixedCorner.BottomLeft;
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
            BottomLeft.X = pointFixedCorner.X;
            BottomLeft.Y = pointFixedCorner.Y;
        }
        internal Table(Point pointFixedCorner, FixedCorner fixedCorner)
        {
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
            FixedCorner = fixedCorner;
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
                BottomRight.X = (int)(BottomLeft.X + Width * Math.Cos(Angle));
                BottomRight.Y = (int)(BottomLeft.Y + Width * Math.Sin(Angle));
            }
            return BottomRight;
        }
        internal Point GetTopLeft()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                TopLeft.X = (int)(BottomLeft.X - Height * Math.Sin(Angle));
                TopLeft.Y = (int)(BottomLeft.Y + Height * Math.Cos(Angle));
            }
            return TopLeft;
        }
        internal Point GetTopRight()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                TopRight.X = (int)(BottomLeft.X + Width * Math.Cos(Angle) - Height * Math.Sin(Angle));
                TopRight.Y = (int)(BottomLeft.Y + Width * Math.Sin(Angle) + Height * Math.Cos(Angle));
            }
            return TopRight;
        }
        private void Turn(int angle)
        {

        }
        internal void TurnLeft()
        {

        }
        internal void TurnRight()
        {

        }
       // private void MoveLeft
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
            for (int i = 0; i < TableNames.Count;i++)
            {
                MoveTable(Tables[i], new Point(i * TableOffset, 0));
            }
        }
        private static void MoveTable(Table table, Point point)
        {
            table.BottomLeft = point;
        }
    }
    internal class Corner
    {
        internal int X;
        internal int Y;
        internal static int X0;
        internal static int Y0;
        internal int DeltaX;
        internal int DeltaY;
        internal Corner(Point startPoint, int deltaX, int deltaY, int angle)
        {
            X = startPoint.X + deltaX;
            Y = startPoint.Y + deltaY;
        }
    }
}

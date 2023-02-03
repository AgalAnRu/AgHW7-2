using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        internal int Angle;
        internal int Width;
        internal int Height;
        private static int MaxSideSize = 3;
        private static int MinSideSize = 2;
        private static int MaxTableArea = 6;
        private static Random Rnd = new Random();
        internal Table()
        {
            Width = Rnd.Next(MinSideSize, MaxSideSize + 1);
            Height = MaxTableArea / Width;
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
        internal void CalculateTableCoordinates(Table table)
        {
            //TopLeft.X = BottomLeft;
        }
        internal Point GetBottomLeft(Table table)
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
                TopLeft.X = (int)(BottomLeft.X + Height * Math.Sin(Angle));
                TopLeft.Y = (int)(BottomLeft.Y + Height * Math.Cos(Angle));
            }
            return BottomRight;
        }
        internal Point GetTopRight()
        {
            if (FixedCorner == FixedCorner.BottomLeft)
            {
                TopRight.X = (int)(BottomLeft.X + Width * Math.Cos(Angle));
                TopRight.Y = (int)(BottomLeft.Y + Height * Math.Cos(Angle));
            }
            return BottomRight;
        }
        private void Turn (int angle)
        {

        }
        internal void TurnLeft()
        {

        }
    }
}

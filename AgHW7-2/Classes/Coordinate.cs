using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgHW7_2
{
    public static class Coordinate
    {
        public static Point Origin { get; private set; }
        public static int Scale { get; private set; }
        private static Point ViewportPoint;
        private static Point ScreenPoint;
        private static Point CartesianPoint;
        private static Point FormPoint;
        static Coordinate() { }
        public static void SetOrigin(Point origin)
        {
            Origin = origin;
        }
        public static void SetScale(int scale)
        {
            Scale = scale;
        }
        public static Point ConvertToViewportXY(Point cartesianPoint)
        {
            CartesianPoint = cartesianPoint;
            ViewportPoint.X = Origin.X + CartesianPoint.X * Scale;
            ViewportPoint.Y = Origin.Y - CartesianPoint.Y * Scale;
            return ViewportPoint;
        }
        public static Point ConvertToCartesianXY(Point viewportPoint)
        {
            ViewportPoint = viewportPoint;
            CartesianPoint.X = (ViewportPoint.X - Origin.X) / Scale;
            CartesianPoint.Y = (Origin.Y - ViewportPoint.Y) / Scale;
            return CartesianPoint;
        }
    }
}

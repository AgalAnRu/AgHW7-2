using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgHW7.Clases
{
    internal class Area
    {
        internal double Width;
        internal double Length;
        internal int Owners;
        internal int Id { get; set; }
        internal double Squareness { get ; private set; }
        private static double WidthMin = 1;
        private static double LengthMin = 1;
        private static double WidthMax = 1000;
        private static double LengthMax = 1000;
        private static int OwnersMin = 1;
        private static int OwnersMax = 10;
        private static Random Rnd = new Random();

        internal Area()
        {
            Width = WidthMin + (WidthMax - WidthMin) * (1 - Rnd.NextDouble());
            Length = LengthMin + (LengthMax - LengthMin) * (1 - Rnd.NextDouble());
            Owners = Rnd.Next(OwnersMin, OwnersMax + 1);
            SetSquareness(Width, Length);
        }
        private void SetSquareness(double width, double length)
        {
            if (width > length)
            {
                (width, _) = (length, width);
            }
            Squareness = 1 - width / length;
        }
    }
    internal static class AreasList
    {
        internal static int AreasTotal;
        internal static List<Area> Areas = new List<Area>();
        static int AreasMin = 1;
        static int AreasMax = 1000;
        static Random Rnd = new Random();
        static AreasList()
        {
            AreasTotal = Rnd.Next(AreasMin, AreasMax + 1);
            for (int i = 0; i < AreasTotal; i++)
            {
                Areas.Add(new Area());
            }
        }
        internal static Area GetMoreSquareness()
        {
            Area area = new Area();
            double squareness = 0;
            for (int i = 0; i < Areas.Count; i++)
            {
                if (Areas[i].Squareness > squareness)
                {
                    squareness= Areas[i].Squareness;
                    area = Areas[i];
                }
            }
            return area;
        }
    }
}

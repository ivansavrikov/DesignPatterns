using System;

namespace Patterns.Core
{
    [Serializable]
    class Point3d
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3d(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            base.ToString();
            return $"({X}, {Y}, {Z})";
        }
    }
}

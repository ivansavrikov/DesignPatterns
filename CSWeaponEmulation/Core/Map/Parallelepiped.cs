using System;
using System.Drawing;

namespace Patterns.Core
{
    [Serializable]
    class Parallelepiped : Object3D
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        public Parallelepiped(int width, int height, int depth, Color color) : base(color)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }
    }
}

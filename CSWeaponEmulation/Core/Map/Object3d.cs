using System;
using System.Drawing;

namespace Patterns.Core
{
    [Serializable]
    abstract internal class Object3D
    {
        public Color Color { get; set; }
        public Object3D(Color color)
        {
            Color = color;
        }
    }
}

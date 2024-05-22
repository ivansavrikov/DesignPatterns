using System;
using System.Collections.Generic;

namespace Patterns.Core
{
    [Serializable]
    internal class Map
    {
        public string Name { get; set; }

        private List<Tuple<Object3D, Point3d>> _objectPositions;
        public List<Tuple<Point3d, string>> PositionDesignations { get; set; }

        public Map(string name, List<Tuple<Object3D, Point3d>> object3Ds)
        {
            Name = name;
            _objectPositions = object3Ds;
            foreach(var item in _objectPositions)
            {
                Draw(item.Item1, item.Item2);
            }
        }

        private void Draw(Object3D obj, Point3d point)
        {
            Logger.Instance.AddLog($"{obj.GetType().Name} помещен на карту в точку {point}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Patterns.Core.Prototype
{
    internal class MapFactory
    {
        private static List<Tuple<Object3D, Point3d>> _mirageObjects = new List<Tuple<Object3D, Point3d>>()
        {
            new Tuple<Object3D, Point3d>(new Parallelepiped(100, 400, 200, Color.Red), new Point3d(10, 200, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(300, 50, 60, Color.Black), new Point3d(900, 200, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(550, 500, 500, Color.Blue), new Point3d(400, 10, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(10, 200, 100, Color.Green), new Point3d(1200, 140, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(200, 400, 200, Color.Yellow), new Point3d(4400, 10, 100)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(700, 100, 300, Color.Red), new Point3d(200, 1500, 50)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(600, 200, 550, Color.Red), new Point3d(100, 256, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(900, 200, 60, Color.Red), new Point3d(700, 143, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(100, 55, 30, Color.Red), new Point3d(105, 1153, 0)),
            new Tuple<Object3D, Point3d>(new Parallelepiped(55, 100, 20, Color.Red), new Point3d(26, 1265, 500)),
        };

        private static readonly Map _miragePrototype = new Map("Mirage", _mirageObjects);

        public static Map CreateMap(string mapName)
        {
            switch (mapName)
            {
                case "Mirage":
                    Logger.Instance.AddLog("Новая карта Mirage создана методом клонирования");
                    return _miragePrototype.DeepCopy();

                default:
                    throw new ArgumentException($"Карта {mapName} не существует");
            }
        }
    }
}
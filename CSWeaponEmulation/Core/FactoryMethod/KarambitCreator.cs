using System;
using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class KarambitCreator : WeaponCreator
    {
        internal override Core.Weapon.Weapon Create()
        {
            Logger.Instance.AddLog($"Создан новый керамбит");
            return new Karambit();
        }
    }
}

using Patterns.Core.Weapon;
using System;

namespace Patterns.Core.FactoryMethod
{
    internal class TKnifeCreator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new TerroristKnife();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}
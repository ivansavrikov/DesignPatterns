using Patterns.Core.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Core.FactoryMethod
{
    internal class CTKnifeCreator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new CounterTerroristKnife();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}

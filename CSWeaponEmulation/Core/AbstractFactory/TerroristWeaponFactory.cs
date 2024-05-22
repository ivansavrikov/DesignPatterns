
using Patterns.Core.Weapon;

namespace Patterns.Core.AbstractFactory
{
    internal class TerroristWeaponFactory : WeaponAbstractFactory
    {
        internal override Knife CreateKnife()
        {
            Logger.Instance.AddLog("Создан новый нож террориста");
            return new TerroristKnife();
        }

        internal override Pistol CreatePistol()
        {
            Logger.Instance.AddLog("Создан новый Glock-18");
            return new Glock18();
        }

        internal override Rifle CreateRiffle()
        {
            Logger.Instance.AddLog("Создан новый АК-47");
            return new AK47();
        }
    }
}

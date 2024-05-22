using Patterns.Core.Weapon;

namespace Patterns.Core.AbstractFactory
{
    internal class CounterTerroristWeaponFactory : WeaponAbstractFactory
    {
        internal override Knife CreateKnife()
        {
            Logger.Instance.AddLog("Создан новый нож спецназовца");
            return new CounterTerroristKnife();
        }

        internal override Pistol CreatePistol()
        {
            Logger.Instance.AddLog("Создан новый USP-S");
            return new USPS();
        }

        internal override Rifle CreateRiffle()
        {
            Logger.Instance.AddLog("Создана новая M4A4");
            return new M4A4();
        }
    }
}
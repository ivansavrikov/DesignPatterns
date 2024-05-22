using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class M4A4Creator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new M4A4();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}
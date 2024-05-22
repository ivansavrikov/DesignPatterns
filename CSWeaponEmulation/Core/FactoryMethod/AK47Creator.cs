using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class AK47Creator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new AK47();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}
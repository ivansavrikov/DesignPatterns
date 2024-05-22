using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class DesertEagleCreator : WeaponCreator
    {
        internal override Core.Weapon.Weapon Create()
        {
            Logger.Instance.AddLog($"Создан новый Deagle");
            return new DesertEagle();
        }
    }
}

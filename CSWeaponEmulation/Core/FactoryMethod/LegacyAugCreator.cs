using Patterns.Core.Adapter;

namespace Patterns.Core.FactoryMethod
{
    internal class LegacyAugCreator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new Aug(); //раньше здесь был LegacyAugCreator
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}

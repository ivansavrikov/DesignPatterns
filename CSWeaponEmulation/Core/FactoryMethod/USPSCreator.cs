using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class USPSCreator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new USPS();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}

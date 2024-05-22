using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class AWPCreator : WeaponCreator
    {
        internal override Core.Weapon.Weapon Create()
        {
            Logger.Instance.AddLog($"Создано новое AWP");
            return new AWP();
        }
    }
}
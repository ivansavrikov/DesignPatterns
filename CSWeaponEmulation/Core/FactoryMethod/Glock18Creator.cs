using Patterns.Core.Weapon;

namespace Patterns.Core.FactoryMethod
{
    internal class Glock18Creator : WeaponCreator
    {
        internal override Weapon.Weapon Create()
        {
            var weapon = new Glock18();
            Logger.Instance.AddLog($"Создан новый {weapon.GetType().Name}");
            return weapon;
        }
    }
}

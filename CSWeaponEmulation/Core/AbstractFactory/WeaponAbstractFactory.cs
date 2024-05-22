using Patterns.Core.Weapon;

namespace Patterns.Core.AbstractFactory
{
    internal abstract class WeaponAbstractFactory
    {
        abstract internal Rifle CreateRiffle();
        abstract internal Pistol CreatePistol();
        abstract internal Knife CreateKnife();
    }
}
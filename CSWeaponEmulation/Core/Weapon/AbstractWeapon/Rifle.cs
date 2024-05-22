
namespace Patterns.Core.Weapon
{
    internal abstract class Rifle : FirearmWeapon
    {
        protected Rifle(int damage, int bulletsCapacity, int magazineCapacity) : base(damage, bulletsCapacity, magazineCapacity)
        {

        }
    }
}

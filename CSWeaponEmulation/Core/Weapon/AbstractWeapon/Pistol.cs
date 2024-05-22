
namespace Patterns.Core.Weapon
{
    internal abstract class Pistol : FirearmWeapon
    {
        protected Pistol(int damage, int bulletsCapacity, int magazineCapacity) : base(damage, bulletsCapacity, magazineCapacity)
        {
            
        }
    }
}

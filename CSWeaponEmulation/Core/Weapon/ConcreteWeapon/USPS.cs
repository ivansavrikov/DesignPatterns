
namespace Patterns.Core.Weapon
{
    internal class USPS : Pistol
    {
        public USPS() : base(damage: 30, bulletsCapacity: 12*3, magazineCapacity: 12)
        {

        }

        internal override void Attack()
        {
            Fire();
        }
    }
}

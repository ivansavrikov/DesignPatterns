
namespace Patterns.Core.Weapon
{
    internal class DesertEagle : Pistol
    {
        public DesertEagle() : base(damage: 30, bulletsCapacity: 7*5, magazineCapacity: 7)
        {

        }

        internal override void Attack()
        {
            Fire();
        }
    }
}

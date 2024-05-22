
namespace Patterns.Core.Weapon
{
    internal class M4A4 : Rifle
    {
        public M4A4() : base(damage: 30, bulletsCapacity: 120, magazineCapacity: 30)
        {

        }

        internal override void Attack()
        {
            Fire();
        }
    }
}
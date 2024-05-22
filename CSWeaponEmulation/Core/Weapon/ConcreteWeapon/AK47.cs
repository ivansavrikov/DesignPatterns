

namespace Patterns.Core.Weapon
{
    internal class AK47 : Rifle
    {
        public AK47() : base(damage: 30, bulletsCapacity: 120, magazineCapacity: 30)
        {
            
        }

        internal override void Attack()
        {
            Fire();
        }
    }
}
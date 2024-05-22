
namespace Patterns.Core.Weapon
{
    internal class Glock18 : Pistol
    {
        public Glock18() : base(damage: 30, bulletsCapacity: 20*4, magazineCapacity: 20)
        {

        }

        internal override void Attack()
        {
            Fire();
        }
    }
}

namespace Patterns.Core.Weapon
{
    internal abstract class Weapon
    {
        protected int _damage;

        public Weapon(int damage)
        {
            _damage = damage;
        }

        internal abstract void Attack();
    }
}
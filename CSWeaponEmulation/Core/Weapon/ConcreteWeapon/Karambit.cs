
namespace Patterns.Core.Weapon
{
    internal class Karambit : Knife
    {
        public Karambit() : base(damage: 30)
        {
            
        }

        internal override void Attack()
        {
            Logger.Instance.AddLog($"Удар ножом {GetType().Name}");
        }
    }
}
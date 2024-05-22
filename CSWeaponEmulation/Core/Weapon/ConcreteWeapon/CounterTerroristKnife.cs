
namespace Patterns.Core.Weapon
{
    internal class CounterTerroristKnife : Knife
    {
        public CounterTerroristKnife() : base(damage: 30)
        {

        }
        internal override void Attack()
        {
            Logger.Instance.AddLog($"Удар ножом {GetType().Name}");
        }
    }
}

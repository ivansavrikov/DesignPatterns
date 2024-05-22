
namespace Patterns.Core.Weapon
{
    internal class TerroristKnife : Knife
    {
        public TerroristKnife() : base(damage: 30)
        {

        }

        internal override void Attack()
        {
            Logger.Instance.AddLog($"Удар ножом {GetType().Name}");
        }
    }
}

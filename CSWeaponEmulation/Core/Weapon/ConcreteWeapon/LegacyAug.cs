using Patterns.Core.Weapon;

namespace Patterns.Core.Adapter
{
    internal class LegacyAug : Rifle
    {
        private int _scopeIndex = 0;
        public LegacyAug() : base(damage: 40, bulletsCapacity: 25*4, magazineCapacity: 25)
        {
            
        }

        internal override void Attack()
        {
            Fire();
        }

        internal void OpenScope()
        {
            if (_scopeIndex % 2 == 0)
                Logger.Instance.AddLog($"Вы вошли в прицел {GetType().Name}");
            else if (_scopeIndex % 2 == 1)
                Logger.Instance.AddLog($"Вы вышли из прицела {GetType().Name}");
            _scopeIndex++;
        }
    }
}
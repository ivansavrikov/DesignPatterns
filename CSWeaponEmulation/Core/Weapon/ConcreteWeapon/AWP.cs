
using Patterns.Core.Interfaces;

namespace Patterns.Core.Weapon
{
    internal class AWP : Rifle, IScopable
    {
        private int _scopeIndex;
        public AWP() : base(damage: 100, bulletsCapacity: 30, magazineCapacity: 5)
        {

        }

        public void Scope()
        {
            if (_scopeIndex % 3 == 0)
                Logger.Instance.AddLog($"Вы вошли в прицел {GetType().Name} (Масштаб 1)");
            else if (_scopeIndex % 3 == 1)
                Logger.Instance.AddLog($"Увеличение прицела {GetType().Name} (Масштаб 2)");
            else if (_scopeIndex % 3 == 2)
                Logger.Instance.AddLog($"Вы вышли из прицела {GetType().Name}");
            _scopeIndex++;
        }

        internal override void Attack()
        {
            Fire();
        }
    }
}
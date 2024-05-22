
namespace Patterns.Core.Weapon
{
    internal abstract class FirearmWeapon : Weapon
    {
        protected readonly int _bulletsCapacity;
        protected readonly int _magazineCapacity;

        protected int _bulletsNow;
        protected int _bulletsInMagazineNow;

        public FirearmWeapon(int damage, int bulletsCapacity, int magazineCapacity) : base(damage)
        {
            _bulletsCapacity = bulletsCapacity;
            _magazineCapacity = magazineCapacity;
            _bulletsNow = bulletsCapacity;
            _bulletsInMagazineNow = magazineCapacity;

        }

        public void Fire()
        {
            if (_bulletsInMagazineNow > 0)
            {
                _bulletsInMagazineNow--;
                _bulletsNow--;
                Logger.Instance.AddLog($"Выстрел из {GetType().Name}: (обойма {_bulletsInMagazineNow}/{_magazineCapacity}) (всего {_bulletsNow}/{_bulletsCapacity})");
            }
            else
            {
                Logger.Instance.AddLog($"Патроны в обойме {GetType().Name} закончились");
            }
        }

        public void Reload()
        {
            if (_bulletsNow == 0)
            {
                Logger.Instance.AddLog($"Патроны в {GetType().Name} закончились");
                return;
            }

            _bulletsInMagazineNow = (_bulletsNow >= _magazineCapacity) ? _magazineCapacity : _bulletsNow;
            Logger.Instance.AddLog($"{GetType().Name} перезаряжен, в обойме {_bulletsInMagazineNow}/{_magazineCapacity} патрон");
        }
    }
}
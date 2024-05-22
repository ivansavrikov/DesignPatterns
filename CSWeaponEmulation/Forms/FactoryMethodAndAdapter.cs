using Patterns.Core;
using Patterns.Core.Adapter;
using Patterns.Core.FactoryMethod;
using Patterns.Core.Interfaces;
using Patterns.Core.Weapon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patterns.Forms
{
    public partial class FactoryMethodAndAdapter : Form
    {
        private Weapon _currentWeapon;

        private List<Button> _shopWeaponButtons;

        public FactoryMethodAndAdapter()
        {
            InitializeComponent();

            _shopWeaponButtons = new List<Button>() { 
                btnGetAwp, 
                btnGetLegacyAug, 
                btnTempGetLegacyAug, 
                btnGetAK47, 
                btnGetTerroristKnife,
                btnGetDeagle,
                btnGetKarambit,
                btnGetUSPS
            };
        }

        private void CreateWeapon(WeaponCreator creator)
        {
            _currentWeapon = creator.Create();
        }

        private void BtnGetAwp_Click(object sender, EventArgs e)
        {
            CreateWeapon(new AWPCreator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void BtnGetLegacyAug_Click(object sender, EventArgs e)
        {
            CreateWeapon(new LegacyAugCreator()); //Обратите внимание, что мы используем именно LegacyAugCreator, потому что это было здесь изначально (по задумке)
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void TempForExample_Click(object sender, EventArgs e)
        {
            /*
                в реальной ситуации предполагается, что у нас на кнопку Aug (LegacyAug) изначально создавался LegacyAug и программа работала с ним,
                через какое-то время стала необходимость заменить LegacyAug на адаптер к нему - Aug, поэтому благодаря Фабричному методу мы
                изменили создаваемый объект в LegacyAugCreator с new LegacyAug() на new Aug() 
                и нам не пришлось исправлять кучу кода где фигурировал устаревший LegacyAug
                (То-есть к клиентскому коду мы не изменяли, но все осталось рабоать)

                На данной форме есть две кнопки для покупки Aug и LegacyAug,
                Они обе помещены здесь для того, чтобы показать работу паттерна адаптер,
                с LegacyAug нельзя прицеливаться, с Aug (который является адаптером для LegacyAug) прицеливаться
                через интерфейс IScopable можно
                
             */

            //CreateWeapon(new LegacyAugCreator());
            _currentWeapon = new LegacyAug(); //для примера (если так делать, то смысла в фабричном методе не будет)
            Logger.Instance.AddLog($"Создан новый {_currentWeapon.GetType().Name}");

            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void btnGetAK47_Click(object sender, EventArgs e)
        {
            CreateWeapon(new AK47Creator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void btnGetTerroristKnife_Click(object sender, EventArgs e)
        {
            CreateWeapon(new TKnifeCreator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void BtnFire_Click(object sender, EventArgs e)
        {
            if (_currentWeapon == null) return;

            if (_currentWeapon is FirearmWeapon)
                (_currentWeapon as FirearmWeapon).Fire();
            else
            {
                Logger.Instance.AddLog($"{_currentWeapon.GetType().Name} не огнестрельное оружие");
                _currentWeapon.Attack();
            }
        }

        private void BtnScope_Click(object sender, EventArgs e)
        {
            if (_currentWeapon == null) return;

            if (_currentWeapon is IScopable)
                (_currentWeapon as IScopable)?.Scope();
            else
                Logger.Instance.AddLog($"У {_currentWeapon.GetType().Name} нет оптического прицела");
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            if (_currentWeapon == null) return;

            if (_currentWeapon is FirearmWeapon)
                (_currentWeapon as FirearmWeapon).Reload();
            else
            {
                Logger.Instance.AddLog($"{_currentWeapon.GetType().Name} не требует перезарядки");
            }
        }

        private void BtnGetDeagle_Click(object sender, EventArgs e)
        {
            CreateWeapon(new DesertEagleCreator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void BtnGetKarambit_Click(object sender, EventArgs e)
        {
            CreateWeapon(new KarambitCreator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }

        private void BtnGetUSPS_Click(object sender, EventArgs e)
        {
            CreateWeapon(new USPSCreator());
            HelperUI.ToggleEmulation(_shopWeaponButtons, sender as Button);
        }
    }
}
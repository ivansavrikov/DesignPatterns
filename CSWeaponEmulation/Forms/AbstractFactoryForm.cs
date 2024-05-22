using Patterns.Core.Weapon;
using Patterns.Core;
using Patterns.Core.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Patterns.Forms;

namespace Patterns
{
    public partial class AbstractFactoryForm : Form
    {
        private WeaponAbstractFactory _currentFactory;
        private Weapon _currentWeapon;

        private readonly WeaponAbstractFactory _terorristWeaponFactory;
        private readonly WeaponAbstractFactory _counterTerorristWeaponFactory;

        private readonly List<Button> _teamButtons;
        private readonly List<Button> _weaponShopButtons;
        public AbstractFactoryForm()
        {
            InitializeComponent();
            _terorristWeaponFactory = new TerroristWeaponFactory();
            _counterTerorristWeaponFactory = new CounterTerroristWeaponFactory();

            _teamButtons = new List<Button> { btnTerroristTeam, btnCounterTerroristTeam };
            _weaponShopButtons = new List<Button> { btnBuyRiffle, btnBuyPistol, btnBuyKnife };
        }

        private void BtnTerroristTeam_Click(object sender, EventArgs e)
        {
            _currentFactory = _terorristWeaponFactory;
            Logger.Instance.AddLog("Вы выбрали команду террористов");
            HelperUI.ToggleEmulation(_teamButtons, sender as Button);
            HelperUI.ButtonsColorReset(_weaponShopButtons);
        }

        private void BtnCounterTerroristTeam_Click(object sender, EventArgs e)
        {
            _currentFactory = _counterTerorristWeaponFactory;
            Logger.Instance.AddLog("Вы выбрали команду спецназовцев");
            HelperUI.ToggleEmulation(_teamButtons, sender as Button);
            HelperUI.ButtonsColorReset(_weaponShopButtons);
        }

        private void BtnBuyRiffle_Click(object sender, EventArgs e)
        {
            if (_currentFactory == null)
            {
                Logger.Instance.AddLog("Вы не выбрали команду");
                return;
            }

            _currentWeapon = _currentFactory.CreateRiffle();
            HelperUI.ToggleEmulation(_weaponShopButtons, sender as Button);
        }

        private void BtnBuyPistol_Click(object sender, EventArgs e)
        {
            if (_currentFactory == null)
            {
                Logger.Instance.AddLog("Вы не выбрали команду");
                return;
            }

            _currentWeapon = _currentFactory.CreatePistol();
            HelperUI.ToggleEmulation(_weaponShopButtons, sender as Button);
        }

        private void BtnBuyKnife_Click(object sender, EventArgs e)
        {
            if (_currentFactory == null)
            {
                Logger.Instance.AddLog("Вы не выбрали команду");
                return;
            }

            _currentWeapon = _currentFactory.CreateKnife();
            HelperUI.ToggleEmulation(_weaponShopButtons, sender as Button);
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (_currentWeapon == null) return;

            if (_currentWeapon is FirearmWeapon)
                (_currentWeapon as FirearmWeapon).Fire();
            else
            {
                Logger.Instance.AddLog($"{_currentWeapon?.GetType().Name} не огнестрельное оружие");
                _currentWeapon?.Attack();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (_currentWeapon == null) return;

            if (_currentWeapon is FirearmWeapon)
                (_currentWeapon as FirearmWeapon).Reload();
            else
            {
                Logger.Instance.AddLog($"{_currentWeapon?.GetType().Name} не требует перезарядки");
            }
        }
    }
}
using System.Collections.Generic;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace EquipBestItem
{
    class FilterViewModel : ViewModel
    {
        public BetterCharacterSettings CharacterSettings;

        public static int CurrentSlot = 0;

        private enum FilterItemState { None, Armor, Weapon, Mount }
        private FilterItemState _filterItemState = FilterItemState.None;

        private FilterArmorSettings _clipboardFilterArmorSettings;
        private FilterWeaponSettings _clipboardFilterWeaponSettings;
        private FilterMountSettings _clipboardFilterMountSettings;
        private BetterCharacterSettings _clipboardCharacterSettings;

        private bool _pastedCharacterSettings = false;
        private bool _isCivilian;

        private List<BetterCharacterSettings> _characterSettingsStore;

        #region DataSourcePropertys
        private bool _isHelmFilterSelected;

        [DataSourceProperty]
        public bool IsHelmFilterSelected
        {
            get => _isHelmFilterSelected;
            set
            {
                if (_isHelmFilterSelected != value)
                {
                    _isHelmFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isHelmFilterLocked;

        [DataSourceProperty]
        public bool IsHelmFilterLocked
        {
            get => _isHelmFilterLocked;
            set
            {
                if (_isHelmFilterLocked != value)
                {
                    _isHelmFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isCloakFilterSelected;

        [DataSourceProperty]
        public bool IsCloakFilterSelected
        {
            get => _isCloakFilterSelected;
            set
            {
                if (_isCloakFilterSelected != value)
                {
                    _isCloakFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isCloakFilterLocked;

        [DataSourceProperty]
        public bool IsCloakFilterLocked
        {
            get => _isCloakFilterLocked;
            set
            {
                if (_isCloakFilterLocked != value)
                {
                    _isCloakFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }



        private bool _isArmorFilterSelected;

        [DataSourceProperty]
        public bool IsArmorFilterSelected
        {
            get => _isArmorFilterSelected;
            set
            {
                if (_isArmorFilterSelected != value)
                {
                    _isArmorFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isArmorFilterLocked;

        [DataSourceProperty]
        public bool IsArmorFilterLocked
        {
            get => _isArmorFilterLocked;
            set
            {
                if (_isArmorFilterLocked != value)
                {
                    _isArmorFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }



        private bool _isGloveFilterSelected;

        [DataSourceProperty]
        public bool IsGloveFilterSelected
        {
            get => _isGloveFilterSelected;
            set
            {
                if (_isGloveFilterSelected != value)
                {
                    _isGloveFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isGloveFilterLocked;

        [DataSourceProperty]
        public bool IsGloveFilterLocked
        {
            get => _isGloveFilterLocked;
            set
            {
                if (_isGloveFilterLocked != value)
                {
                    _isGloveFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isBootFilterSelected;

        [DataSourceProperty]
        public bool IsBootFilterSelected
        {
            get => _isBootFilterSelected;
            set
            {
                if (_isBootFilterSelected != value)
                {
                    _isBootFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isBootFilterLocked;

        [DataSourceProperty]
        public bool IsBootFilterLocked
        {
            get => _isBootFilterLocked;
            set
            {
                if (_isBootFilterLocked != value)
                {
                    _isBootFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isMountFilterSelected;

        [DataSourceProperty]
        public bool IsMountFilterSelected
        {
            get => _isMountFilterSelected;
            set
            {
                if (_isMountFilterSelected != value)
                {
                    _isMountFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isMountFilterLocked;

        [DataSourceProperty]
        public bool IsMountFilterLocked
        {
            get => _isMountFilterLocked;
            set
            {
                if (_isMountFilterLocked != value)
                {
                    _isMountFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isHarnessFilterSelected;

        [DataSourceProperty]
        public bool IsHarnessFilterSelected
        {
            get => _isHarnessFilterSelected;
            set
            {
                if (_isHarnessFilterSelected != value)
                {
                    _isHarnessFilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isHarnessFilterLocked;

        [DataSourceProperty]
        public bool IsHarnessFilterLocked
        {
            get => _isHarnessFilterLocked;
            set
            {
                if (_isHarnessFilterLocked != value)
                {
                    _isHarnessFilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon1FilterSelected;

        [DataSourceProperty]
        public bool IsWeapon1FilterSelected
        {
            get => _isWeapon1FilterSelected;
            set
            {
                if (_isWeapon1FilterSelected != value)
                {
                    _isWeapon1FilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon1FilterLocked;

        [DataSourceProperty]
        public bool IsWeapon1FilterLocked
        {
            get => _isWeapon1FilterLocked;
            set
            {
                if (_isWeapon1FilterLocked != value)
                {
                    _isWeapon1FilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon2FilterSelected;

        [DataSourceProperty]
        public bool IsWeapon2FilterSelected
        {
            get => _isWeapon2FilterSelected;
            set
            {
                if (_isWeapon2FilterSelected != value)
                {
                    _isWeapon2FilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon2FilterLocked;

        [DataSourceProperty]
        public bool IsWeapon2FilterLocked
        {
            get => _isWeapon2FilterLocked;
            set
            {
                if (_isWeapon2FilterLocked != value)
                {
                    _isWeapon2FilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon3FilterSelected;

        [DataSourceProperty]
        public bool IsWeapon3FilterSelected
        {
            get => _isWeapon3FilterSelected;
            set
            {
                if (_isWeapon3FilterSelected != value)
                {
                    _isWeapon3FilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon3FilterLocked;

        [DataSourceProperty]
        public bool IsWeapon3FilterLocked
        {
            get => _isWeapon3FilterLocked;
            set
            {
                if (_isWeapon3FilterLocked != value)
                {
                    _isWeapon3FilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon4FilterSelected;

        [DataSourceProperty]
        public bool IsWeapon4FilterSelected
        {
            get => _isWeapon4FilterSelected;
            set
            {
                if (_isWeapon4FilterSelected != value)
                {
                    _isWeapon4FilterSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeapon4FilterLocked;

        [DataSourceProperty]
        public bool IsWeapon4FilterLocked
        {
            get => _isWeapon4FilterLocked;
            set
            {
                if (_isWeapon4FilterLocked != value)
                {
                    _isWeapon4FilterLocked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isLayerHidden;

        [DataSourceProperty]
        public bool IsLayerHidden
        {
            get => _isLayerHidden;
            set
            {
                if (_isLayerHidden != value)
                {
                    _isLayerHidden = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isMountSlotHidden = true;

        [DataSourceProperty]
        public bool IsMountSlotHidden
        {
            get => _isMountSlotHidden;
            set
            {
                if (_isMountSlotHidden != value)
                {
                    _isMountSlotHidden = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isArmorSlotHidden = true;

        [DataSourceProperty]
        public bool IsArmorSlotHidden
        {
            get => _isArmorSlotHidden;
            set
            {
                if (_isArmorSlotHidden != value)
                {
                    _isArmorSlotHidden = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isWeaponSlotHidden = true;

        [DataSourceProperty]
        public bool IsWeaponSlotHidden
        {
            get => _isWeaponSlotHidden;
            set
            {
                if (_isWeaponSlotHidden != value)
                {
                    _isWeaponSlotHidden = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _title;

        [DataSourceProperty]
        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isHiddenFilterLayer = true;

        [DataSourceProperty]
        public bool IsHiddenFilterLayer
        {
            get => _isHiddenFilterLayer;
            set
            {
                if (_isHiddenFilterLayer != value)
                {
                    _isHiddenFilterLayer = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _clipboardFilterArmorSettingsCopied;

        [DataSourceProperty]
        public bool IsFilterArmorSettingsCopied
        {
            get => _clipboardFilterArmorSettingsCopied;
            private set
            {
                _clipboardFilterArmorSettingsCopied = value;
                OnPropertyChanged();
            }
        }

        private bool _clipboardFilterWeaponSettingsCopied;
        [DataSourceProperty]
        public bool IsFilterWeaponSettingsCopied
        {
            get => _clipboardFilterWeaponSettingsCopied;
            private set
            {
                _clipboardFilterWeaponSettingsCopied = value;
                OnPropertyChanged();
            }
        }

        private bool _clipboardFilterMountSettingsCopied;
        [DataSourceProperty]
        public bool IsFilterMountSettingsCopied
        {
            get => _clipboardFilterMountSettingsCopied;
            private set
            {
                _clipboardFilterMountSettingsCopied = value;
                OnPropertyChanged();
            }
        }

        private bool _clipboardCharacterSettingsCopied;
        [DataSourceProperty]
        public bool IsCharacterSettingsCopied
        {
            get => _clipboardCharacterSettingsCopied;
            private set
            {
                _clipboardCharacterSettingsCopied = value;
                OnPropertyChanged();
            }
        }

        private string _swingDamage;
        [DataSourceProperty]
        public string SwingDamage
        {
            get => _swingDamage;
            set
            {
                if (_swingDamage != value)
                {
                    _swingDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _swingSpeed;
        [DataSourceProperty]
        public string SwingSpeed
        {
            get => _swingSpeed;
            set
            {
                if (_swingSpeed != value)
                {
                    _swingSpeed = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _thrustDamage;
        [DataSourceProperty]
        public string ThrustDamage
        {
            get => _thrustDamage;
            set
            {
                if (_thrustDamage != value)
                {
                    _thrustDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _thrustSpeed;
        [DataSourceProperty]
        public string ThrustSpeed
        {
            get => _thrustSpeed;
            set
            {
                if (_thrustSpeed != value)
                {
                    _thrustSpeed = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _weaponLength;
        [DataSourceProperty]
        public string WeaponLength
        {
            get => _weaponLength;
            set
            {
                if (_weaponLength != value)
                {
                    _weaponLength = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _handling;
        [DataSourceProperty]
        public string Handling
        {
            get => _handling;
            set
            {
                if (_handling != value)
                {
                    _handling = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _weaponWeight;
        [DataSourceProperty]
        public string WeaponWeight
        {
            get => _weaponWeight;
            set
            {
                if (_weaponWeight != value)
                {
                    _weaponWeight = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _accuracy;
        [DataSourceProperty]
        public string Accuracy
        {
            get => _accuracy;
            set
            {
                if (_accuracy != value)
                {
                    _accuracy = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _missileSpeed;
        [DataSourceProperty]
        public string MissileSpeed
        {
            get => _missileSpeed;
            set
            {
                if (_missileSpeed != value)
                {
                    _missileSpeed = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _weaponBodyArmor;
        [DataSourceProperty]
        public string WeaponBodyArmor
        {
            get => _weaponBodyArmor;
            set
            {
                if (_weaponBodyArmor != value)
                {
                    _weaponBodyArmor = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _maxDataValue;
        [DataSourceProperty]
        public string MaxDataValue
        {
            get => _maxDataValue;
            set
            {
                if (_maxDataValue != value)
                {
                    _maxDataValue = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _headArmor;
        [DataSourceProperty]
        public string HeadArmor
        {
            get => _headArmor;
            set
            {
                if (_headArmor != value)
                {
                    _headArmor = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _armorBodyArmor;
        [DataSourceProperty]
        public string ArmorBodyArmor
        {
            get => _armorBodyArmor;
            set
            {
                if (_armorBodyArmor != value)
                {
                    _armorBodyArmor = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _legArmor;
        [DataSourceProperty]
        public string LegArmor
        {
            get => _legArmor;
            set
            {
                if (_legArmor != value)
                {
                    _legArmor = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _armArmor;
        [DataSourceProperty]
        public string ArmArmor
        {
            get => _armArmor;
            set
            {
                if (_armArmor != value)
                {
                    _armArmor = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _maneuverBonus;
        [DataSourceProperty]
        public string ManeuverBonus
        {
            get => _maneuverBonus;
            set
            {
                if (_maneuverBonus != value)
                {
                    _maneuverBonus = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _speedBonus;
        [DataSourceProperty]
        public string SpeedBonus
        {
            get => _speedBonus;
            set
            {
                if (_speedBonus != value)
                {
                    _speedBonus = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _chargeBonus;
        [DataSourceProperty]
        public string ChargeBonus
        {
            get => _chargeBonus;
            set
            {
                if (_chargeBonus != value)
                {
                    _chargeBonus = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _armorWeight;
        [DataSourceProperty]
        public string ArmorWeight
        {
            get => _armorWeight;
            set
            {
                if (_armorWeight != value)
                {
                    _armorWeight = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _chargeDamage;
        [DataSourceProperty]
        public string ChargeDamage
        {
            get => _chargeDamage;
            set
            {
                if (_chargeDamage != value)
                {
                    _chargeDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _hitPoints;
        [DataSourceProperty]
        public string HitPoints
        {
            get => _hitPoints;
            set
            {
                if (_hitPoints != value)
                {
                    _hitPoints = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _maneuver;
        [DataSourceProperty]
        public string Maneuver
        {
            get => _maneuver;
            set
            {
                if (_maneuver != value)
                {
                    _maneuver = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _speed;
        [DataSourceProperty]
        public string Speed
        {
            get => _speed;
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion DataSourceProperties

        public FilterViewModel(List<BetterCharacterSettings> characterSettings)
        {
            _characterSettingsStore = characterSettings;
        }

        public override void RefreshValues()
        {
            base.RefreshValues();
            try
            {
                string tempName = InventoryBehavior.Inventory.CurrentCharacterName;
                if (!_pastedCharacterSettings)
                {
                    this.CharacterSettings = BetterCharacterSettings.GetCharacterSettingsByName(_characterSettingsStore, tempName);
                }
                else
                {
                    //SettingsLoader.Instance.SetCharacterSettingsByName(CharacterSettings, InventoryBehavior.Inventory.CurrentCharacterName);
                    BetterCharacterSettings.SetCharacterSettingsByName(_characterSettingsStore, CharacterSettings, tempName);
                    _pastedCharacterSettings = false;
                }
            }
            catch (MBException e)
            {
                InformationManager.DisplayMessage(new InformationMessage(e.Message));
                throw;
            }

            // Updates the title whether we are looking at weapon, armor, or mount filter settings window
            if (!IsWeaponSlotHidden)
                this.Title = "Weapon " + (CurrentSlot + 1) + " filter";
            if (!IsArmorSlotHidden)
                switch (CurrentSlot)
                {
                    case 0:
                        this.Title = "Helm filter";
                        break;
                    case 1:
                        this.Title = "Cloak filter";
                        break;
                    case 2:
                        this.Title = "Armor filter";
                        break;
                    case 3:
                        this.Title = "Glove filter";
                        break;
                    case 4:
                        this.Title = "Boot filter";
                        break;
                    case 5:
                        this.Title = "Harness filter";
                        break;
                    default:
                        this.Title = "Default";
                        break;
                }
            if (!IsMountSlotHidden)
                this.Title = "Mount " + "filter";

            // Allows us to get items depending on the civilian or war set
            _isCivilian = !InventoryBehavior.Inventory.IsInWarSet;
            var isCivilian = _isCivilian;

            if (!IsWeaponSlotHidden)
            {
                var filterWeapon = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, isCivilian);

                this.Accuracy = filterWeapon.Accuracy.ToString();
                this.WeaponBodyArmor = filterWeapon.WeaponBodyArmor.ToString();
                this.Handling = filterWeapon.Handling.ToString();
                this.MaxDataValue = filterWeapon.MaxDataValue.ToString();
                this.MissileSpeed = filterWeapon.MissileSpeed.ToString();
                this.SwingDamage = filterWeapon.SwingDamage.ToString();
                this.SwingSpeed = filterWeapon.SwingSpeed.ToString();
                this.ThrustDamage = filterWeapon.ThrustDamage.ToString();
                this.ThrustSpeed = filterWeapon.ThrustSpeed.ToString();
                this.WeaponLength = filterWeapon.WeaponLength.ToString();
                this.WeaponWeight = filterWeapon.WeaponWeight.ToString();
            }

            if (!IsArmorSlotHidden)
            {
                var filterArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, isCivilian);

                this.HeadArmor = filterArmor.HeadArmor.ToString();
                this.ArmorBodyArmor = filterArmor.ArmorBodyArmor.ToString();
                this.LegArmor = filterArmor.LegArmor.ToString();
                this.ArmArmor = filterArmor.ArmArmor.ToString();
                this.ManeuverBonus = filterArmor.ManeuverBonus.ToString();
                this.SpeedBonus = filterArmor.SpeedBonus.ToString();
                this.ChargeBonus = filterArmor.ChargeBonus.ToString();
                this.ArmorWeight = filterArmor.ArmorWeight.ToString();
            }

            if (!IsMountSlotHidden)
            {
                var filterMount = CharacterSettings.GetMountSettings(isCivilian);

                this.ChargeDamage = filterMount.ChargeDamage.ToString();
                this.HitPoints = filterMount.HitPoints.ToString();
                this.Maneuver = filterMount.Maneuver.ToString();
                this.Speed = filterMount.Speed.ToString();
            }

            var helmArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Helm, isCivilian);
            var cloakArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Cloak, isCivilian);
            var bodyArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Armor, isCivilian);
            var gloveArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Glove, isCivilian);
            var bootArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Boot, isCivilian);
            var mount = CharacterSettings.GetMountSettings(isCivilian);
            var mountArmor = CharacterSettings.GetArmorSettings(ArmorSlot.Harness);
            var weapon1 = CharacterSettings.GetWeaponSettings(WeaponSlot.Weapon1, isCivilian);
            var weapon2 = CharacterSettings.GetWeaponSettings(WeaponSlot.Weapon2, isCivilian);
            var weapon3 = CharacterSettings.GetWeaponSettings(WeaponSlot.Weapon3, isCivilian);
            var weapon4 = CharacterSettings.GetWeaponSettings(WeaponSlot.Weapon4, isCivilian);

            //Helmet icon state
            if (helmArmor.ThisFilterNotDefault())
                this.IsHelmFilterSelected = true;
            else
                this.IsHelmFilterSelected = false;

            if (helmArmor.ThisFilterLocked())
                this.IsHelmFilterLocked = true;
            else
                this.IsHelmFilterLocked = false;

            //Cloak icon state
            if (cloakArmor.ThisFilterNotDefault())
                this.IsCloakFilterSelected = true;
            else
                this.IsCloakFilterSelected = false;

            if (cloakArmor.ThisFilterLocked())
                this.IsCloakFilterLocked = true;
            else
                this.IsCloakFilterLocked = false;

            //Armor icon state
            if (bodyArmor.ThisFilterNotDefault())
                this.IsArmorFilterSelected = true;
            else
                this.IsArmorFilterSelected = false;

            if (bodyArmor.ThisFilterLocked())
                this.IsArmorFilterLocked = true;
            else
                this.IsArmorFilterLocked = false;

            //Gloves icon state
            if (gloveArmor.ThisFilterNotDefault())
                this.IsGloveFilterSelected = true;
            else
                this.IsGloveFilterSelected = false;

            if (gloveArmor.ThisFilterLocked())
                this.IsGloveFilterLocked = true;
            else
                this.IsGloveFilterLocked = false;

            //Boots icon state
            if (bootArmor.ThisFilterNotDefault())
                this.IsBootFilterSelected = true;
            else
                this.IsBootFilterSelected = false;

            if (bootArmor.ThisFilterLocked())
                this.IsBootFilterLocked = true;
            else
                this.IsBootFilterLocked = false;

            //Mount icon state
            if (mount.ThisFilterNotDefault())
                this.IsMountFilterSelected = true;
            else
                this.IsMountFilterSelected = false;

            if (mount.ThisFilterLocked())
                this.IsMountFilterLocked = true;
            else
                this.IsMountFilterLocked = false;

            //Harness icon state
            if (mountArmor.ThisFilterNotDefault())
                this.IsHarnessFilterSelected = true;
            else
                this.IsHarnessFilterSelected = false;

            if (mountArmor.ThisFilterLocked())
                this.IsHarnessFilterLocked = true;
            else
                this.IsHarnessFilterLocked = false;

            //Weapon1 icon state
            if (weapon1.ThisFilterNotDefault())
                this.IsWeapon1FilterSelected = true;
            else
                this.IsWeapon1FilterSelected = false;

            if (weapon1.ThisFilterLocked())
                this.IsWeapon1FilterLocked = true;
            else
                this.IsWeapon1FilterLocked = false;

            //Weapon2 icon state
            if (weapon2.ThisFilterNotDefault())
                this.IsWeapon2FilterSelected = true;
            else
                this.IsWeapon2FilterSelected = false;

            if (weapon2.ThisFilterLocked())
                this.IsWeapon2FilterLocked = true;
            else
                this.IsWeapon2FilterLocked = false;

            //Weapon3 icon state
            if (weapon3.ThisFilterNotDefault())
                this.IsWeapon3FilterSelected = true;
            else
                this.IsWeapon3FilterSelected = false;

            if (weapon3.ThisFilterLocked())
                this.IsWeapon3FilterLocked = true;
            else
                this.IsWeapon3FilterLocked = false;

            //Weapon4 icon state
            if (weapon4.ThisFilterNotDefault())
                this.IsWeapon4FilterSelected = true;
            else
                this.IsWeapon4FilterSelected = false;

            if (weapon4.ThisFilterLocked())
                this.IsWeapon4FilterLocked = true;
            else
                this.IsWeapon4FilterLocked = false;
#if DEBUG
            InformationManager.DisplayMessage(new InformationMessage("FilterVMRefreshValue")); 
#endif
        }

        #region ExecuteMethods
        public void ExecuteSwingDamagePrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingDamage -= 1f;
            SwingDamage = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingDamage.ToString();
            this.RefreshValues();
        }
        public void ExecuteSwingDamageNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingDamage += 1f;
            SwingDamage = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingDamage.ToString();
            this.RefreshValues();
        }

        public void ExecuteSwingSpeedPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingSpeed -= 1f;
            SwingSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingSpeed.ToString();
            this.RefreshValues();
        }
        public void ExecuteSwingSpeedNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingSpeed += 1f;
            SwingSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).SwingSpeed.ToString();
            this.RefreshValues();
        }

        public void ExecuteThrustDamagePrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustDamage -= 1f;
            ThrustDamage = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustDamage.ToString();
            this.RefreshValues();
        }
        public void ExecuteThrustDamageNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustDamage += 1f;
            ThrustDamage = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustDamage.ToString();
            this.RefreshValues();
        }

        public void ExecuteThrustSpeedPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustSpeed -= 1f;
            ThrustSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustSpeed.ToString();
            this.RefreshValues();
        }
        public void ExecuteThrustSpeedNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustSpeed += 1f;
            ThrustSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).ThrustSpeed.ToString();
            this.RefreshValues();
        }

        public void ExecuteWeaponLengthPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponLength -= 1f;
            WeaponLength = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponLength.ToString();
            this.RefreshValues();
        }
        public void ExecuteWeaponLengthNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponLength += 1f;
            WeaponLength = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponLength.ToString();
            this.RefreshValues();
        }

        public void ExecuteHandlingPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Handling -= 1f;
            Handling = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Handling.ToString();
            this.RefreshValues();
        }
        public void ExecuteHandlingNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Handling += 1f;
            Handling = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Handling.ToString();
            this.RefreshValues();
        }

        public void ExecuteWeaponWeightPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponWeight -= 1f;
            WeaponWeight = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponWeight.ToString();
            this.RefreshValues();
        }
        public void ExecuteWeaponWeightNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponWeight += 1f;
            WeaponWeight = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponWeight.ToString();
            this.RefreshValues();
        }

        public void ExecuteMissileSpeedPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MissileSpeed -= 1f;
            MissileSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MissileSpeed.ToString();
            this.RefreshValues();
        }
        public void ExecuteMissileSpeedNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MissileSpeed += 1f;
            MissileSpeed = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MissileSpeed.ToString();
            this.RefreshValues();
        }

        public void ExecuteAccuracyPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Accuracy -= 1f;
            Accuracy = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Accuracy.ToString();
            this.RefreshValues();
        }
        public void ExecuteAccuracyNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Accuracy += 1f;
            Accuracy = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).Accuracy.ToString();
            this.RefreshValues();
        }

        public void ExecuteWeaponBodyArmorPrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponBodyArmor -= 1f;
            WeaponBodyArmor = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponBodyArmor.ToString();
            this.RefreshValues();
        }
        public void ExecuteWeaponBodyArmorNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponBodyArmor += 1f;
            WeaponBodyArmor = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).WeaponBodyArmor.ToString();
            this.RefreshValues();
        }

        public void ExecuteMaxDataValuePrev()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MaxDataValue -= 1f;
            MaxDataValue = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MaxDataValue.ToString();
            this.RefreshValues();
        }
        public void ExecuteMaxDataValueNext()
        {
            CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MaxDataValue += 1f;
            MaxDataValue = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian).MaxDataValue.ToString();
            this.RefreshValues();
        }


        public void ExecuteHeadArmorPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).HeadArmor -= 1f;
            HeadArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).HeadArmor.ToString();
            this.RefreshValues();
        }
        public void ExecuteHeadArmorNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).HeadArmor += 1f;
            HeadArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).HeadArmor.ToString();
            this.RefreshValues();
        }

        public void ExecuteArmorBodyArmorPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorBodyArmor -= 1f;
            ArmorBodyArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorBodyArmor.ToString();
            this.RefreshValues();
        }
        public void ExecuteArmorBodyArmorNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorBodyArmor += 1f;
            ArmorBodyArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorBodyArmor.ToString();
            this.RefreshValues();
        }

        public void ExecuteLegArmorPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).LegArmor -= 1f;
            LegArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).LegArmor.ToString();
            this.RefreshValues();
        }
        public void ExecuteLegArmorNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).LegArmor += 1f;
            LegArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).LegArmor.ToString();
            this.RefreshValues();
        }

        public void ExecuteArmArmorPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmArmor -= 1f;
            ArmArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmArmor.ToString();
            this.RefreshValues();
        }
        public void ExecuteArmArmorNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmArmor += 1f;
            ArmArmor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmArmor.ToString();
            this.RefreshValues();
        }

        public void ExecuteManeuverBonusPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ManeuverBonus -= 1f;
            ManeuverBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ManeuverBonus.ToString();
            this.RefreshValues();
        }
        public void ExecuteManeuverBonusNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ManeuverBonus += 1f;
            ManeuverBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ManeuverBonus.ToString();
            this.RefreshValues();
        }

        public void ExecuteSpeedBonusPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).SpeedBonus -= 1f;
            SpeedBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).SpeedBonus.ToString();
            this.RefreshValues();
        }
        public void ExecuteSpeedBonusNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).SpeedBonus += 1f;
            SpeedBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).SpeedBonus.ToString();
            this.RefreshValues();
        }

        public void ExecuteChargeBonusPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ChargeBonus -= 1f;
            ChargeBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ChargeBonus.ToString();
            this.RefreshValues();
        }
        public void ExecuteChargeBonusNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ChargeBonus += 1f;
            ChargeBonus = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ChargeBonus.ToString();
            this.RefreshValues();
        }

        public void ExecuteArmorWeightPrev()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorWeight -= 1f;
            ArmorWeight = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorWeight.ToString();
            this.RefreshValues();
        }
        public void ExecuteArmorWeightNext()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorWeight += 1f;
            ArmorWeight = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorWeight.ToString();
            this.RefreshValues();
        }

        public void ExecuteChargeDamagePrev()
        {
            CharacterSettings.GetMountSettings(_isCivilian).ChargeDamage -= 1f;
            ChargeDamage = CharacterSettings.GetMountSettings(_isCivilian).ChargeDamage.ToString();
            this.RefreshValues();
        }
        public void ExecuteChargeDamageNext()
        {
            CharacterSettings.GetMountSettings(_isCivilian).ChargeDamage += 1f;
            ChargeDamage = CharacterSettings.GetMountSettings(_isCivilian).ChargeDamage.ToString();
            this.RefreshValues();
        }

        public void ExecuteHitPointsPrev()
        {
            CharacterSettings.GetMountSettings(_isCivilian).HitPoints -= 1f;
            HitPoints = CharacterSettings.GetMountSettings(_isCivilian).HitPoints.ToString();
            this.RefreshValues();
        }
        public void ExecuteHitPointsNext()
        {
            CharacterSettings.GetMountSettings(_isCivilian).HitPoints += 1f;
            HitPoints = CharacterSettings.GetMountSettings(_isCivilian).HitPoints.ToString();
            this.RefreshValues();
        }

        public void ExecuteManeuverPrev()
        {
            CharacterSettings.GetMountSettings(_isCivilian).Maneuver -= 1f;
            Maneuver = CharacterSettings.GetMountSettings(_isCivilian).Maneuver.ToString();
            this.RefreshValues();
        }
        public void ExecuteManeuverNext()
        {
            CharacterSettings.GetMountSettings(_isCivilian).Maneuver += 1f;
            Maneuver = CharacterSettings.GetMountSettings(_isCivilian).Maneuver.ToString();
            this.RefreshValues();
        }

        public void ExecuteSpeedPrev()
        {
            CharacterSettings.GetMountSettings(_isCivilian).Speed -= 1f;
            Speed = CharacterSettings.GetMountSettings(_isCivilian).Speed.ToString();
            this.RefreshValues();
        }
        public void ExecuteSpeedNext()
        {
            CharacterSettings.GetMountSettings(_isCivilian).Speed += 1f;
            Speed = CharacterSettings.GetMountSettings(_isCivilian).Speed.ToString();
            this.RefreshValues();
        }


        public void ExecuteShowHideWeapon1Filter()
        {
            if (CurrentSlot != 0 || this.IsWeaponSlotHidden)
            {
                CurrentSlot = 0;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;
            this.IsWeaponSlotHidden = false;
            this.IsArmorSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Weapon;
            this.RefreshValues();
        }

        public void ExecuteShowHideWeapon2Filter()
        {
            if (CurrentSlot != 1 || this.IsWeaponSlotHidden)
            {
                CurrentSlot = 1;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;
            this.IsWeaponSlotHidden = false;
            this.IsArmorSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Weapon;
            this.RefreshValues();
        }

        public void ExecuteShowHideWeapon3Filter()
        {
            if (CurrentSlot != 2 || this.IsWeaponSlotHidden)
            {
                CurrentSlot = 2;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;
            this.IsWeaponSlotHidden = false;
            this.IsArmorSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Weapon;
            this.RefreshValues();
        }

        public void ExecuteShowHideWeapon4Filter()
        {
            if (CurrentSlot != 3 || this.IsWeaponSlotHidden)
            {
                CurrentSlot = 3;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;
            this.IsWeaponSlotHidden = false;
            this.IsArmorSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Weapon;
            this.RefreshValues();
        }

        public void ExecuteShowHideHelmFilter()
        {
            if (CurrentSlot != 0 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 0;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteShowHideCloakFilter()
        {
            if (CurrentSlot != 1 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 1;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteShowHideArmorFilter()
        {
            if (CurrentSlot != 2 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 2;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteShowHideGloveFilter()
        {
            if (CurrentSlot != 3 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 3;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteShowHideBootFilter()
        {
            if (CurrentSlot != 4 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 4;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            
            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteShowHideMountFilter()
        {
            if (this.IsMountSlotHidden)
                this.IsHiddenFilterLayer = false;
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = true;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = false;
            _filterItemState = FilterItemState.Mount;
            this.RefreshValues();
        }

        public void ExecuteShowHideHarnessFilter()
        {
            if (CurrentSlot != 5 || this.IsArmorSlotHidden)
            {
                CurrentSlot = 5;
                this.IsHiddenFilterLayer = false;
            }
            else
                this.IsHiddenFilterLayer = !IsHiddenFilterLayer;

            this.IsArmorSlotHidden = false;
            this.IsWeaponSlotHidden = true;
            this.IsMountSlotHidden = true;
            _filterItemState = FilterItemState.Armor;
            this.RefreshValues();
        }

        public void ExecuteWeaponClose()
        {
            IsHiddenFilterLayer = true;
            this.RefreshValues();
        }

        public void ExecuteMountClear()
        {
            var mount = CharacterSettings.GetMountSettings(_isCivilian);
            mount.ChargeDamage = 1f;
            mount.HitPoints = 1f;
            mount.Maneuver = 1f;
            mount.Speed = 1f;
            this.RefreshValues();
        }

        public void ExecuteArmorClear()
        {
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmArmor = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorBodyArmor = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ChargeBonus = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).HeadArmor = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).LegArmor = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ManeuverBonus = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).SpeedBonus = 1f;
            CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian).ArmorWeight = 0;
            this.RefreshValues();
        }

        public void ExecuteWeaponClear()
        {
            var weapon = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian);
            weapon.Accuracy = 1f;
            weapon.WeaponBodyArmor = 1f;
            weapon.Handling = 1f;
            weapon.MaxDataValue = 1f;
            weapon.MissileSpeed = 1f;
            weapon.SwingDamage = 1f;
            weapon.SwingSpeed = 1f;
            weapon.ThrustDamage = 1f;
            weapon.ThrustSpeed = 1f;
            weapon.WeaponLength = 1f;
            weapon.WeaponWeight = 0;
            this.RefreshValues();
        }

        public void ExecuteItemClear()
        {
            switch (_filterItemState)
            {
                case FilterItemState.Armor:
                    ExecuteArmorClear();
                    break;
                case FilterItemState.Weapon:
                    ExecuteWeaponClear();
                    break;
                case FilterItemState.Mount:
                    ExecuteMountClear();
                    break;
            }
        }

        public void ExecuteMountLock()
        {
            var mount = CharacterSettings.GetMountSettings(_isCivilian);
            mount.ChargeDamage = 0;
            mount.HitPoints = 0;
            mount.Maneuver = 0;
            mount.Speed = 0;
            this.RefreshValues();
        }

        public void ExecuteArmorLock()
        {
            var armor = CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian);
            armor.ArmArmor = 0;
            armor.ArmorBodyArmor = 0;
            armor.ChargeBonus = 0;
            armor.HeadArmor = 0;
            armor.LegArmor = 0;
            armor.ManeuverBonus = 0;
            armor.SpeedBonus = 0;
            armor.ArmorWeight = 0;
            this.RefreshValues();
        }

        public void ExecuteWeaponLock()
        {
            var weapon = CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian);
            weapon.Accuracy = 0;
            weapon.WeaponBodyArmor = 0;
            weapon.Handling = 0;
            weapon.MaxDataValue = 0;
            weapon.MissileSpeed = 0;
            weapon.SwingDamage = 0;
            weapon.SwingSpeed = 0;
            weapon.ThrustDamage = 0;
            weapon.ThrustSpeed = 0;
            weapon.WeaponLength = 0;
            weapon.WeaponWeight = 0;
            this.RefreshValues();
        }

        public void ExecuteItemLock()
        {
            switch (_filterItemState)
            {
                case FilterItemState.Armor:
                    ExecuteArmorLock();
                    break;
                case FilterItemState.Weapon:
                    ExecuteWeaponLock();
                    break;
                case FilterItemState.Mount:
                    ExecuteMountLock();
                    break;
            }
        }

        public void ExecuteCopyFilterSettings()
        {
            switch (_filterItemState)
            {
                case FilterItemState.Armor:
                    _clipboardFilterArmorSettings = new FilterArmorSettings(CharacterSettings.GetArmorSettings((ArmorSlot) CurrentSlot, _isCivilian));
                    IsFilterArmorSettingsCopied = true;
                    InformationManager.DisplayMessage(new InformationMessage("Armor settings copied"));
                    break;
                case FilterItemState.Weapon:
                    _clipboardFilterWeaponSettings = new FilterWeaponSettings(CharacterSettings.GetWeaponSettings((WeaponSlot) CurrentSlot, _isCivilian));
                    IsFilterWeaponSettingsCopied = true;
                    InformationManager.DisplayMessage(new InformationMessage("Weapon settings copied"));
                    break;
                case FilterItemState.Mount:
                    _clipboardFilterMountSettings = new FilterMountSettings(CharacterSettings.GetMountSettings(_isCivilian));
                    IsFilterMountSettingsCopied = true;
                    InformationManager.DisplayMessage(new InformationMessage("Mount settings copied"));
                    break;
            }
        }

        public void ExecutePasteFilterSettings()
        {
            switch (_filterItemState)
            {
                case FilterItemState.Armor:
                    CharacterSettings.SetArmorSettings(new FilterArmorSettings(_clipboardFilterArmorSettings), (ArmorSlot)CurrentSlot, _isCivilian);
                    InformationManager.DisplayMessage(new InformationMessage("Armor settings pasted"));
                    break;
                case FilterItemState.Weapon:
                    CharacterSettings.SetWeaponSettings(new FilterWeaponSettings(_clipboardFilterWeaponSettings), (WeaponSlot)CurrentSlot, _isCivilian);
                    InformationManager.DisplayMessage(new InformationMessage("Weapon settings pasted"));
                    break;
                case FilterItemState.Mount:
                    CharacterSettings.SetMountSettings(new FilterMountSettings(_clipboardFilterMountSettings));
                    InformationManager.DisplayMessage(new InformationMessage("Mount settings pasted"));
                    break;
            }
            RefreshValues();
        }

        public void ExecuteCopyCharacterSettings()
        {
            _clipboardCharacterSettings = new BetterCharacterSettings(CharacterSettings);
            IsCharacterSettingsCopied = true;
            InformationManager.DisplayMessage(new InformationMessage("Character settings copied"));
        }

        public void ExecutePasteCharacterSettings()
        {
            var tempName = CharacterSettings.Name;
            CharacterSettings = new BetterCharacterSettings(_clipboardCharacterSettings);
            CharacterSettings.Name = tempName;
            _pastedCharacterSettings = true;
            InformationManager.DisplayMessage(new InformationMessage("Character settings pasted"));
            RefreshValues();
        }

        #endregion ExecuteMethods

        //private string _weaponClass = "Choose weapon class";


        //[DataSourceProperty]
        //public string WeaponClass
        //{
        //    get => _weaponClass;
        //    set
        //    {
        //        if (_weaponClass != value)
        //        {
        //            _weaponClass = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}


        //private string _weaponUsage = "Choose weapon type item usage";
        //[DataSourceProperty]
        //public string WeaponUsage
        //{
        //    get => _weaponUsage;
        //    set
        //    {
        //        if (_weaponUsage != value)
        //        {
        //            _weaponUsage = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //private List<string> _ItemUsageList = new List<string>()
        //{
        //    "arrow_right",
        //    "arrow_top",
        //    "bow",
        //    "crossbow",
        //    "hand_shield",
        //    "long_bow",
        //    "shield"
        //};


        //private List<string> _weaponFlagsList;
        //private int _weaponFlagsCurrentIndex = 0;

        //public void ExecuteWeaponTypeSelectNextItem()
        //{
        //    if (this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponClass == (WeaponClass)28)
        //        this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponClass = (WeaponClass)0;
        //    else
        //        this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponClass += 1;

        //    this.WeaponClass = this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponClass.ToString();
        //}

        //public void ExecuteWeaponUsageSelectPreviousItem()
        //{




        //    //////// НЕ УДАЛЯТЬ МОЖЕТ ПРИГОДИТЬСЯ В БУДУЩЕМ
        //    //_weaponFlagsCurrentIndex -= 1;
        //    //if (_weaponFlagsCurrentIndex < 0)
        //    //    _weaponFlagsCurrentIndex = _weaponFlagsList.Count - 1;


        //    //if (_weaponFlagsList[_weaponFlagsCurrentIndex] == "None")
        //    //    this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponFlags = (WeaponFlags)0;
        //    //else
        //    //    this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponFlags = (WeaponFlags)Enum.Parse(typeof(WeaponFlags), _weaponFlagsList[_weaponFlagsCurrentIndex]);

        //    //this.WeaponUsage = _weaponFlagsList[_weaponFlagsCurrentIndex];
        //}

        //public void ExecuteWeaponUsageSelectNextItem()
        //{




        //    //////// НЕ УДАЛЯТЬ МОЖЕТ ПРИГОДИТЬСЯ В БУДУЩЕМ
        //    ///
        //    //_weaponFlagsCurrentIndex += 1;
        //    //if (_weaponFlagsCurrentIndex > _weaponFlagsList.Count - 1)
        //    //    _weaponFlagsCurrentIndex = 0;

        //    //if (_weaponFlagsList[_weaponFlagsCurrentIndex] == "None")
        //    //    this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponFlags = (WeaponFlags)0;
        //    //else
        //    //    this.CharacterSettings.FilterWeapon[CurrentWeaponSlot].WeaponFlags = (WeaponFlags)Enum.Parse(typeof(WeaponFlags), _weaponFlagsList[_weaponFlagsCurrentIndex]);

        //    //this.WeaponUsage = _weaponFlagsList[_weaponFlagsCurrentIndex];
        //}
    }
}

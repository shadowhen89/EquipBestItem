using System;
using System.Collections.Generic;
using TaleWorlds.SaveSystem;

namespace EquipBestItem
{
    [SaveableClass(0)]
    public class BetterCharacterSettings
    {
        [SaveableProperty(1)]
        public string Name { get; set; }

        [SaveableField(2)] private List<FilterWeaponSettings> _warFilterWeapon = new List<FilterWeaponSettings>();
        [SaveableField(3)] private List<FilterWeaponSettings> _civFilterWeapon = new List<FilterWeaponSettings>();
        [SaveableField(4)] private List<FilterArmorSettings> _warFilterArmor = new List<FilterArmorSettings>();
        [SaveableField(5)] private List<FilterArmorSettings> _civFilterArmor = new List<FilterArmorSettings>();
        [SaveableField(6)] private FilterMountSettings _warFilterMount;
        [SaveableField(7)] private FilterMountSettings _civFilterMount;

        public BetterCharacterSettings()
        {
            Name = "";
            _warFilterMount = new FilterMountSettings();
            _civFilterMount = new FilterMountSettings();
        }

        public BetterCharacterSettings(string name)
        {
            Name = name;

            int armorSize = Enum.GetNames(typeof(ArmorSlot)).Length;
            int weaponSize = Enum.GetNames(typeof(WeaponSlot)).Length;

            for (int i = 0; i < armorSize; i++)
            {
                _civFilterArmor.Add(new FilterArmorSettings());
                _warFilterArmor.Add(new FilterArmorSettings());
            }

            for (int i = 0; i < weaponSize; i++)
            {
                _civFilterWeapon.Add(new FilterWeaponSettings());
                _warFilterWeapon.Add(new FilterWeaponSettings());
            }
            _civFilterMount = new FilterMountSettings();
            _warFilterMount = new FilterMountSettings();
        }

        public BetterCharacterSettings(BetterCharacterSettings other)
        {
            Name = other.Name;

            int armorSize = Enum.GetNames(typeof(ArmorSlot)).Length;
            int weaponSize = Enum.GetNames(typeof(WeaponSlot)).Length;

            for (int i = 0; i < armorSize; i++)
            {
                _civFilterArmor.Add(new FilterArmorSettings(other._civFilterArmor[i]));
                _warFilterArmor.Add(new FilterArmorSettings(other._warFilterArmor[i]));
            }

            for (int i = 0; i < weaponSize; i++)
            {
                _civFilterWeapon.Add(new FilterWeaponSettings(other._civFilterWeapon[i]));
                _warFilterWeapon.Add(new FilterWeaponSettings(other._warFilterWeapon[i]));
            }
            _civFilterMount = new FilterMountSettings(_civFilterMount);
            _warFilterMount = new FilterMountSettings(_warFilterMount);
        }

        public FilterWeaponSettings GetWeaponSettings(WeaponSlot slot, bool civilian = false)
        {
            int slotIndex = (int)slot;
            return civilian ? _civFilterWeapon[slotIndex] : _warFilterWeapon[slotIndex];
        }

        public void SetWeaponSettings(FilterWeaponSettings weaponSettings, WeaponSlot slot, bool civilian = false)
        {
            int slotIndex = (int)slot;
            if (civilian)
            {
                _civFilterWeapon[slotIndex] = weaponSettings;
            }
            else
            {
                _warFilterWeapon[slotIndex] = weaponSettings;
            }
        }

        public FilterArmorSettings GetArmorSettings(ArmorSlot slot, bool civilian = false)
        {
            int slotIndex = (int)slot;
            return civilian ? _civFilterArmor[slotIndex] : _warFilterArmor[slotIndex];
        }

        public void SetArmorSettings(FilterArmorSettings armorSettings, ArmorSlot slot, bool civilian = false)
        {
            int slotIndex = (int)slot;
            if (civilian)
            {
                _civFilterArmor[slotIndex] = armorSettings;
            }
            else
            {
                _warFilterArmor[slotIndex] = armorSettings;
            }
        }

        public FilterMountSettings GetMountSettings(bool civilian = false)
        {
            return civilian ? _civFilterMount : _warFilterMount;
        }

        public void SetMountSettings(FilterMountSettings mountSettings,  bool civilian = false)
        {
            if (civilian)
            {
                _civFilterMount = mountSettings;
            }
            else
            {
                _warFilterMount = mountSettings;
            }
        }

        public static BetterCharacterSettings GetCharacterSettingsByName(List<BetterCharacterSettings> list, string name)
        {
            // TODO: Implement a better way to find character names in a faster rate
            foreach (var temp in list)
            {
                if (temp.Name == name)
                {
                    return temp;
                }
            }

            var newCharacterSettings = new BetterCharacterSettings(name);
            list.Add(newCharacterSettings);
            return newCharacterSettings;
        }

        public static bool SetCharacterSettingsByName(List<BetterCharacterSettings> list,
            BetterCharacterSettings characterSettings, string name)
        {
            for (int i = 0; i < list.Capacity; i++)
            {
                if (list[i].Name == name)
                {
                    list[i] = characterSettings;
                    return true;
                }
            }

            return false;
        }
    }
}

﻿using System;
using TaleWorlds.SaveSystem;

namespace EquipBestItem
{
    [Serializable]
    [SaveableClass(0)]
    public class FilterArmorSettings
    {
        [SaveableProperty(0)]
        public float HeadArmor { get; set; } = 1f;
        [SaveableProperty(0)]
        public float ArmorBodyArmor { get; set; } = 1f;
        [SaveableProperty(0)]
        public float LegArmor { get; set; } = 1f;
        [SaveableProperty(0)]
        public float ArmArmor { get; set; } = 1f;

        [SaveableProperty(0)]
        public float ManeuverBonus { get; set; } = 1f;
        [SaveableProperty(0)]
        public float SpeedBonus { get; set; } = 1f;
        [SaveableProperty(0)]
        public float ChargeBonus { get; set; } = 1f;
        [SaveableProperty(0)]
        public float ArmorWeight { get; set; } = 0;

        public FilterArmorSettings()
        {

        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">armor settings</param>
        public FilterArmorSettings(FilterArmorSettings other)
        {
            if (other == null) return;

            HeadArmor = other.HeadArmor;
            ArmorBodyArmor = other.ArmorBodyArmor;
            LegArmor = other.LegArmor;
            ArmArmor = other.ArmArmor;
            ManeuverBonus = other.ManeuverBonus;
            SpeedBonus = other.SpeedBonus;
            ChargeBonus = other.ChargeBonus;
            ArmorWeight = other.ArmorWeight;
        }

        public bool ThisFilterNotDefault()
        {
            if (this.HeadArmor != 1f) return true;
            if (this.ArmorBodyArmor != 1f) return true;
            if (this.LegArmor != 1f) return true;
            if (this.ArmArmor != 1f) return true;
            if (this.ManeuverBonus != 1f) return true;
            if (this.SpeedBonus != 1f) return true;
            if (this.ChargeBonus != 1f) return true;
            if (this.ArmorWeight != 0f) return true;
            return false;
        }

        public bool ThisFilterLocked()
        {
            if (this.HeadArmor == 0f &&
                this.ArmorBodyArmor == 0f &&
                this.LegArmor == 0f &&
                this.ArmArmor == 0f &&
                this.ManeuverBonus == 0f &&
                this.SpeedBonus == 0f &&
                this.ChargeBonus == 0f &&
                this.ArmorWeight == 0f)
                return true;
            return false;
        }
    }
}

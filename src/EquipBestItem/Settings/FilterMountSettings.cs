﻿using System;
using TaleWorlds.SaveSystem;

namespace EquipBestItem
{
    [Serializable]
    [SaveableClass(0)]
    public class FilterMountSettings
    {
        [SaveableProperty(0)]
        public float ChargeDamage { get; set; } = 1f;
        [SaveableProperty(0)]
        public float HitPoints { get; set; } = 1f;
        [SaveableProperty(0)]
        public float Maneuver { get; set; } = 1f;
        [SaveableProperty(0)]
        public float Speed { get; set; } = 1f;

        public FilterMountSettings()
        {

        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">mount settings</param>
        public FilterMountSettings(FilterMountSettings other)
        {
            if (other == null) return;

            ChargeDamage = other.ChargeDamage;
            HitPoints = other.HitPoints;
            Maneuver = other.Maneuver;
            Speed = other.Speed;
        }

        public bool ThisFilterNotDefault()
        {
            if (this.ChargeDamage != 1f) return true;
            if (this.HitPoints != 1f) return true;
            if (this.Maneuver != 1f) return true;
            if (this.Speed != 1f) return true;
            return false;
        }

        public bool ThisFilterLocked()
        {
            if (this.ChargeDamage == 0f &&
                this.HitPoints == 0f &&
                this.Maneuver == 0f &&
                this.Speed == 0f)
                return true;
            return false;
        }
    }
}

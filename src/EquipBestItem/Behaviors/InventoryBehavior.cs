using EquipBestItem.Layers;
using SandBox.GauntletUI;
using System;
using System.Collections.Generic;
using Bannerlord.ButterLib.SaveSystem.Extensions;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.Core;
using TaleWorlds.Engine.Screens;
using TaleWorlds.Library;
using TaleWorlds.SaveSystem;

namespace EquipBestItem
{
    class InventoryBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            Game.Current.EventManager.RegisterEvent(new Action<TutorialContextChangedEvent>(this.AddNewInventoryLayer));
        }

        public static SPInventoryVM Inventory;
        private InventoryGauntletScreen _inventoryScreen;
        private MainLayer _mainLayer;
        private FilterLayer _filterLayer;

        [SaveableField(8)]
        private List<BetterCharacterSettings> _characterSettingsStore;

        private void AddNewInventoryLayer(TutorialContextChangedEvent tutorialContextChangedEvent)
        {
            try
            {
                if (tutorialContextChangedEvent.NewContext == TutorialContexts.InventoryScreen)
                {
                    if (ScreenManager.TopScreen is InventoryGauntletScreen)
                    {
                        _inventoryScreen = ScreenManager.TopScreen as InventoryGauntletScreen;
                        Inventory = _inventoryScreen.GetField("_dataSource") as SPInventoryVM;

                        _mainLayer = new MainLayer(1000, _characterSettingsStore, "GauntletLayer");
                        _inventoryScreen.AddLayer(_mainLayer);
                        _mainLayer.InputRestrictions.SetInputRestrictions(true, InputUsageMask.All);

                        _filterLayer = new FilterLayer(1001, _characterSettingsStore, "GauntletLayer");
                        _inventoryScreen.AddLayer(_filterLayer);
                        _filterLayer.InputRestrictions.SetInputRestrictions(true, InputUsageMask.All);
                    }

                    //Temporarily disabled clearing settings file for characters
                    //foreach (CharacterSettings charSettings in SettingsLoader.Instance.CharacterSettings.ToList())
                    //{
                    //    bool flag = false;
                    //    foreach (TroopRosterElement element in EquipBestItemViewModel._inventory.TroopRoster)
                    //    {
                    //        if (charSettings.Name == element.Character.Name.ToString())
                    //        {
                    //            flag = true;
                    //            break;
                    //        }
                    //    }
                    //    if (!flag)
                    //    {
                    //        SettingsLoader.Instance.CharacterSettings.Remove(charSettings);
                    //    }
                    //}
                }
                else if (tutorialContextChangedEvent.NewContext == TutorialContexts.None)
                {
                    if (_inventoryScreen != null && _mainLayer != null)
                    {

                        _inventoryScreen.RemoveLayer(this._mainLayer);
                        _mainLayer = null;
                        
                        // Temporary
                        SettingsLoader.Instance.SaveSettings();
                        //SettingsLoader.Instance.SaveCharacterSettings();
                    }

                    if (_inventoryScreen != null && _filterLayer != null)
                    {
                        _inventoryScreen.RemoveLayer(_filterLayer);
                        _filterLayer = null;
                    }
                }
            }
            catch (MBException e)
            {
                InformationManager.DisplayMessage(new InformationMessage(e.Message));
            }
        }

        public override void SyncData(IDataStore dataStore)
        {
#if DEBUG
            InformationManager.DisplayMessage(new InformationMessage("Synced Data...", new Color(0f, 1f, 0f)));
#endif
            dataStore.SyncDataAsJson("EquipBestItemData", ref _characterSettingsStore);

            if (_characterSettingsStore == null)
            {
                _characterSettingsStore = new List<BetterCharacterSettings>();
            }
        }
    }
}

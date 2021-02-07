using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace EquipBestItem
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            try
            {
                base.OnGameStart(game, gameStarterObject);
                
                // Temporary
                SettingsLoader.Instance.LoadSettings();
                //SettingsLoader.Instance.LoadCharacterSettings();

                AddBehaviors(gameStarterObject as CampaignGameStarter);
            }
            catch (MBException e)
            {
                InformationManager.DisplayMessage(new InformationMessage("SubModule " + e.Message));
            }
        }

        private void AddBehaviors(CampaignGameStarter gameStarterObject)
        {
            gameStarterObject?.AddBehavior(new InventoryBehavior());
        }
    }
}

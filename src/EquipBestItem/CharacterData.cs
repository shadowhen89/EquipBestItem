using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace EquipBestItem
{
    class CharacterData
    {
        private CharacterObject _characterObject;
        private BetterCharacterSettings _characterSettings;


        public CharacterData(CharacterObject characterObject, BetterCharacterSettings characterSettings)
        {
            _characterObject = characterObject;
            _characterSettings = characterSettings;

        }

        public CharacterObject GetCharacterObject()
        {
            return _characterObject;
        }

        public BetterCharacterSettings GetCharacterSettings()
        {
            return _characterSettings;
        }

        public Equipment GetBattleEquipment()
        {
            return _characterObject.FirstBattleEquipment;
        }

        public Equipment GetCivilianEquipment()
        {
            return _characterObject.FirstCivilianEquipment;
        }
    }
}

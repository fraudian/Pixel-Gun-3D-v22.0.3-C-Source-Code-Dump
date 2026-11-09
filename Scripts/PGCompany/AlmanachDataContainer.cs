using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class AlmanachDataContainer
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.AlmanachDataContainer.丏专丒丘三丗丏丝业> WeaponSetsDataList;
        internal System.Collections.Generic.Dictionary<ItemRarity, PGCompany.AlmanachDataContainer.PriceContainer> PriceContainers;
        internal System.Collections.Generic.List<PGCompany.AlmanachDataContainer.CollectWeaponsStepData> CollectWeaponsStepDataList;
        internal System.Collections.Generic.List<AlmanachMigrationSettings> MigrationSettings;
        
        // Methods
        public AlmanachDataContainer()
        {
        
        }
    
    }

}

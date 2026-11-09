using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanStoreBuffsConfig
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.BuffData> Buffs;
        internal System.Collections.Generic.List<PGCompany.ClanStoreBuffSetting> ClanStoreBuffSettings;
        internal PGCompany.ClanMiniBuffConfig ClanMiniBuffConfig;
        
        // Methods
        public ClanStoreBuffsConfig()
        {
        
        }
    
    }

}

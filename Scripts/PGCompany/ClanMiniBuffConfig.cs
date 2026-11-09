using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanMiniBuffConfig
    {
        // Fields
        internal System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> ChanceCapture;
        internal System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> ChanceReCapture;
        private Rilisoft.丝丑丂丛万丐丈丘且 _cooldownSeconds;
        private Rilisoft.丝丑丂丛万丐丈丘且 _promotionClanLootBoxChance;
        private Rilisoft.丝丑丂丛万丐丈丘且 _promotionClanLootBoxTimeUntilEnd;
        internal System.Collections.Generic.List<PGCompany.上丈丞丗且三丏丅上> MiniBuffSettings;
        
        // Properties
        internal int CooldownSeconds { get; }
        internal int PromotionClanLootBoxChance { get; }
        internal int PromotionClanLootBoxTimeUntilEnd { get; }
        internal System.Collections.Generic.Dictionary<int, int> MiniBuffsByWeights { get; }
        
        // Methods
        internal int get_CooldownSeconds()
        {
        
        }
        internal int get_PromotionClanLootBoxChance()
        {
        
        }
        internal int get_PromotionClanLootBoxTimeUntilEnd()
        {
        
        }
        internal System.Collections.Generic.Dictionary<int, int> get_MiniBuffsByWeights()
        {
            var val_3;
            System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32> val_5;
            System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32> val_7;
            val_3 = null;
            val_3 = null;
            val_5 = ClanMiniBuffConfig.<>c.<>9__13_0;
            if(val_5 == null)
            {
                    System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32>(object:  ClanMiniBuffConfig.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMiniBuffConfig.<>c::且丝丆业丄丞丟丌丕(PGCompany.上丈丞丗且三丏丅上 与丄丄不丁丅丐丄丕));
                val_3 = null;
                ClanMiniBuffConfig.<>c.<>9__13_0 = val_5;
            }
            
            val_3 = null;
            val_7 = ClanMiniBuffConfig.<>c.<>9__13_1;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToDictionary<PGCompany.上丈丞丗且三丏丅上, System.Int32, System.Int32>(source:  this.MiniBuffSettings, keySelector:  val_1, elementSelector:  System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32> val_2 = null);
            }
            
            val_7 = val_2;
            val_2 = new System.Func<PGCompany.上丈丞丗且三丏丅上, System.Int32>(object:  ClanMiniBuffConfig.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMiniBuffConfig.<>c::丁且丆上丒丂丌丏且(PGCompany.上丈丞丗且三丏丅上 丐丏东世不丅丌且万));
            ClanMiniBuffConfig.<>c.<>9__13_1 = val_7;
            return System.Linq.Enumerable.ToDictionary<PGCompany.上丈丞丗且三丏丅上, System.Int32, System.Int32>(source:  this.MiniBuffSettings, keySelector:  val_1, elementSelector:  val_2);
        }
        public ClanMiniBuffConfig()
        {
            this.ChanceCapture = new System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>();
            this.ChanceReCapture = new System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>();
            this.MiniBuffSettings = new System.Collections.Generic.List<PGCompany.上丈丞丗且三丏丅上>();
        }
    
    }

}

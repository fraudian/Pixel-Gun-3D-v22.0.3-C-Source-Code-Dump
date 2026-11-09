using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class LobbyBundleReward
    {
        // Fields
        private int _coinsCount;
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> _coinsRewardBase;
        private int _gemsCount;
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> _gemsRewardBase;
        private System.Collections.Generic.List<string> _weaponPrefabNames;
        
        // Properties
        public int GemsRewardBase { get; }
        public int CoinsRewardBase { get; }
        public System.Collections.Generic.List<string> WeaponPrefabNames { get; }
        
        // Methods
        public int get_GemsRewardBase()
        {
            if(this._gemsRewardBase.HasValue == true)
            {
                    return -196348144;
            }
            
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            mem2[0] = 0;
            mem2[0] = 0;
            return -196348144;
        }
        public int get_CoinsRewardBase()
        {
            if(this._coinsRewardBase.HasValue == true)
            {
                    return -196236144;
            }
            
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            mem2[0] = 0;
            mem2[0] = 0;
            return -196236144;
        }
        public System.Collections.Generic.List<string> get_WeaponPrefabNames()
        {
            return (System.Collections.Generic.List<System.String>)this._weaponPrefabNames;
        }
        public LobbyBundleReward()
        {
        
        }
    
    }

}

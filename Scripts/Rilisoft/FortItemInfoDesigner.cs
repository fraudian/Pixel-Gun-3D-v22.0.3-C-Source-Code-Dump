using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class FortItemInfoDesigner : MonoBehaviour
    {
        // Fields
        public 丞东丌丟与丅丅万丝.FortItemBuff[] Buffs;
        public string DescKey;
        public bool Disable;
        public string EffectLocKey;
        public bool IsHidedItem;
        public 丞东丌丟与丅丅万丝.FortItemLockInfo[] Lockers;
        public UnityEngine.Material[] materials;
        public string NameKey;
        public bool NoDropParts;
        public ItemRarity Rarity;
        public System.Collections.Generic.List<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐> slot;
        public int SortOrder;
        
        // Methods
        public FortItemInfoDesigner()
        {
            this.Buffs = new FortItemBuff[0];
            this.Lockers = new FortItemLockInfo[0];
            this.slot = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
            this.SortOrder = 999;
        }
    
    }

}

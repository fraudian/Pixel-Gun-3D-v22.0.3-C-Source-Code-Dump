using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanCommonData
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业> Products;
        internal System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Collections.Generic.List<PGCompany.StoreItemSettings>> TabStoreItems;
        internal PGCompany.下七业丄丐世丘丘不 Offers;
        internal PGCompany.ClanStoreData ClanStoreData;
        internal System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Collections.Generic.List<PGCompany.StorePromotionSettings>> TabStorePromotions;
        internal System.Collections.Generic.Dictionary<string, int> ClanTimeRestrictions;
        
        // Methods
        public ClanCommonData()
        {
            this.TabStoreItems = new System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Collections.Generic.List<PGCompany.StoreItemSettings>>();
            this.Offers = new PGCompany.下七业丄丐世丘丘不();
            this.ClanStoreData = new PGCompany.ClanStoreData();
            this.TabStorePromotions = new System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Collections.Generic.List<PGCompany.StorePromotionSettings>>();
        }
    
    }

}

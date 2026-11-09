using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanStoreData
    {
        // Fields
        internal System.Collections.Generic.List<string> KitRefreshSchedule;
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> KitRefreshPrices;
        internal System.Collections.Generic.List<string> GiftRefreshSchedule;
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> GiftRefreshPrices;
        internal Rilisoft.丝丑丂丛万丐丈丘且 RetentionChestRefreshInterval;
        internal bool CanGiveGadget;
        
        // Methods
        internal System.Collections.Generic.List<string> 丛不丂且丈丆丑丅丐(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            System.Collections.Generic.List<System.String> val_1;
            if(丐丅丒专丛丏上与业 != 6)
            {
                    if(丐丅丒专丛丏上与业 != 2)
            {
                    return 0;
            }
            
                val_1 = this.KitRefreshSchedule;
                return (System.Collections.Generic.List<System.String>)this.GiftRefreshSchedule.SyncRoot;
            }
            
            val_1 = this.GiftRefreshSchedule;
            return (System.Collections.Generic.List<System.String>)this.GiftRefreshSchedule.SyncRoot;
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丒丈且业世丕三丑丌(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            if(丐丅丒专丛丏上与业 != 2)
            {
                    return 0;
            }
            
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.KitRefreshPrices;
        }
        internal Progress.与丄东丄丘丐丙丅业 万丏万万丞丕不且丒(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            if(丐丅丒专丛丏上与业 != 2)
            {
                    return (Progress.与丄东丄丘丐丙丅业)(丐丅丒专丛丏上与业 != 6) ? 0 : 83;
            }
            
            return 82;
        }
        internal Progress.与丄东丄丘丐丙丅业 不东丐丅业丅丈七丆(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            if(丐丅丒专丛丏上与业 != 2)
            {
                    return (Progress.与丄东丄丘丐丙丅业)(丐丅丒专丛丏上与业 != 6) ? 0 : 85;
            }
            
            return 84;
        }
        public ClanStoreData()
        {
        
        }
    
    }

}

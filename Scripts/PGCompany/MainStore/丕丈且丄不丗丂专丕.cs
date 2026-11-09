using UnityEngine;

namespace PGCompany.MainStore
{
    internal static class 丕丈且丄不丗丂专丕
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.MainStore.丙丟下万丅一与丑不 丞专业一与丑三丒上(string 丄丐丑丛不七不七丌)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if((PGCompany.MainStore.丕丈且丄不丗丂专丕.世丂上丌丞且丁七丏.ContainsKey(key:  丄丐丑丛不七不七丌)) != false)
            {
                    val_6 = null;
                val_6 = null;
                if((System.Activator.CreateInstance(type:  PGCompany.MainStore.丕丈且丄不丗丂专丕.世丂上丌丞且丁七丏.Item[丄丐丑丛不七不七丌], nonPublic:  true)) == null)
            {
                    return (PGCompany.MainStore.丙丟下万丅一与丑不)val_7;
            }
            
            }
            
            val_7 = 0;
            return (PGCompany.MainStore.丙丟下万丅一与丑不)val_7;
        }
        private static 丕丈且丄不丗丂专丕()
        {
            System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Type>();
            val_1.Add(key:  "Subscription", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Bonuses", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Coins", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Gems", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Advert", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Silver", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Event", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersAdaptive", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersLobby", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersModules", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersNovice", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersDailyTier", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersStarterpack", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersTierBundles", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersConstructable", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "FreeRewards", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersManual", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersDouble", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Vip20", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "OffersNoviceDouble", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "GameOffer", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "PixelPass", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "ShopCompetition", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "Subscription20", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.MainStore.丕丈且丄不丗丂专丕.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}

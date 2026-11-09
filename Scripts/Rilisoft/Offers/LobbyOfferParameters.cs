using UnityEngine;

namespace Rilisoft.Offers
{
    [Serializable]
    internal class LobbyOfferParameters
    {
        // Fields
        internal string Id;
        internal string NameLocKey;
        internal System.Collections.Generic.List<string> ItemIds;
        internal int CurrencyPercent;
        internal int Price;
        
        // Methods
        public LobbyOfferParameters()
        {
        
        }
    
    }

}

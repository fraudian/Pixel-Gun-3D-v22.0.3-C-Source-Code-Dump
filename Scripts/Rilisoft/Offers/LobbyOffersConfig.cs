using UnityEngine;

namespace Rilisoft.Offers
{
    [Serializable]
    internal class LobbyOffersConfig
    {
        // Fields
        internal int Version;
        internal int SeasonId;
        internal int StartLevel;
        internal int SeasonTimeRepeat;
        internal System.DateTime TimeStart;
        internal System.DateTime TimeEnd;
        internal int LifeTime;
        internal System.Collections.Generic.List<Rilisoft.Offers.LobbyOfferParameters> Offers;
        
        // Methods
        public LobbyOffersConfig()
        {
            this.Offers = new System.Collections.Generic.List<Rilisoft.Offers.LobbyOfferParameters>();
        }
    
    }

}

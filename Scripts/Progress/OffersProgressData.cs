using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class OffersProgressData
    {
        // Fields
        internal System.Collections.Generic.Dictionary<string, Progress.OfferProgress> Offers;
        internal Progress.AdaptiveProgress Adaptive;
        internal Progress.DailyTierProgress DailyTier;
        internal Progress.StarterPackProgress StarterPack;
        internal Progress.LobbyProgress Lobby;
        internal Progress.CommonProgress Common;
        
        // Methods
        public OffersProgressData()
        {
            this.Offers = new System.Collections.Generic.Dictionary<System.String, Progress.OfferProgress>();
            this.Adaptive = new Progress.AdaptiveProgress();
            this.DailyTier = new Progress.DailyTierProgress();
            this.StarterPack = new Progress.StarterPackProgress();
            this.Lobby = new Progress.LobbyProgress();
            this.Common = new Progress.CommonProgress();
        }
    
    }

}

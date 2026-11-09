using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPPlayerProgress : BPPlayerProgressBase
    {
        // Fields
        public int LastViewedLevelUp;
        public System.Collections.Generic.List<PGCompany.BattlePass.BPReward> RewardsForDrop;
        public bool SeasonEndBannerViewed;
        public bool SeasonWasActive;
        public bool SeasonCompleted;
        
        // Methods
        public BPPlayerProgress()
        {
            this.LastViewedLevelUp = 1;
            this.RewardsForDrop = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
            this = new System.Object();
        }
    
    }

}

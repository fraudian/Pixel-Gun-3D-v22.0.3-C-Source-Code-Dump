using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal class LiderboardsMinigamesGameModeData
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> BestPlayers;
        public System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> Friends;
        public Rilisoft.七丕丟丏三丈一丄世 GameMode;
        
        // Methods
        public LiderboardsMinigamesGameModeData()
        {
            this.BestPlayers = new System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>();
            this.Friends = new System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>();
        }
    
    }

}

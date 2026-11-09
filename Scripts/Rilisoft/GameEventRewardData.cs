using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventRewardData
    {
        // Fields
        internal Rilisoft.七丕丟丏三丈一丄世 GameMode;
        private System.Nullable<bool> _isMiniGame;
        public int MinimumPoints;
        public System.Collections.Generic.Dictionary<int, int> RankRewards;
        public System.Collections.Generic.Dictionary<int, string> RankRewardItems;
        
        // Properties
        public bool IsMiniGame { get; set; }
        
        // Methods
        public bool get_IsMiniGame()
        {
            var val_2;
            if((this._isMiniGame & 1) == 0)
            {
                    val_2 = null;
                val_2 = null;
                Rilisoft.七丕丟丏三丈一丄世 val_2 = this.GameMode;
                val_2 = System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, value:  val_2);
                this._isMiniGame = 0;
            }
            
            System.Nullable<System.Boolean> val_3 = this._isMiniGame;
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        public void set_IsMiniGame(bool 丙业与丙丗丝不丈东)
        {
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            this._isMiniGame = 0;
        }
        public GameEventRewardData()
        {
        
        }
    
    }

}

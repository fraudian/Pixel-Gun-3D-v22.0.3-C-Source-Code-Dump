using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventData
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.GameEventChestData> Chests;
        public System.Nullable<System.DateTime> EndDate;
        public string EventId;
        public int MinimumLevel;
        public System.Collections.Generic.List<Rilisoft.GameEventRewardData> Rewards;
        public int StartCurrency;
        public System.Nullable<System.DateTime> StartDate;
        public Rilisoft.GameEventType Type;
        public int UniqueId;
        public System.Collections.Generic.List<Rilisoft.GameCurrencyData> СurrencyPrices;
        internal 丈丞丕丘丕丗与上一 BloggerReward;
        
        // Properties
        public Rilisoft.GameEventChestData FirstChest { get; }
        
        // Methods
        public GameEventData()
        {
            this.СurrencyPrices = new System.Collections.Generic.List<Rilisoft.GameCurrencyData>();
            this.Chests = new System.Collections.Generic.List<Rilisoft.GameEventChestData>();
        }
        public Rilisoft.GameEventChestData get_FirstChest()
        {
            if(this.Chests != null)
            {
                    return this.Chests.Item[0];
            }
            
            return this.Chests.Item[0];
        }
    
    }

}

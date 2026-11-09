using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventChestData
    {
        // Fields
        public System.Collections.Generic.List<int> generateChestsIntervals;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _excludeItemsAmount;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _gemsBet;
        public string BindedItem;
        public int ChestId;
        private System.Nullable<int> _configChestId;
        public string DefaultItemColor;
        public System.Nullable<System.DateTime> End;
        public string EventId;
        internal Rilisoft.丝丑丂丛万丐丈丘且 FreeSpinIntervalInt;
        public int FullDropQueueLength;
        public System.Collections.Generic.List<Rilisoft.GameEventItemContainerData> ItemContainers;
        public int LapSize;
        public Rilisoft.GameEventItemData LastLapReward;
        internal 丈丞丕丘丕丗与上一 OpenPrice;
        public System.Collections.Generic.List<Rilisoft.GameEventChestPriceContainer> OpenPrices;
        public System.Collections.Generic.List<int> ResetIntervals;
        public Rilisoft.GameEventChestPriceContainer ResetPrice;
        public Rilisoft.上专业三丟丁丞专下.SpinRule SpinRule;
        public System.Nullable<System.DateTime> Start;
        public int ToOpenSpins;
        public int ToSuperChestPoints;
        public string ViewType;
        internal 丈丞丕丘丕丗与上一 Bet;
        
        // Properties
        public int ConfigChestId { get; set; }
        public System.Nullable<System.TimeSpan> FreeSpinInterval { get; }
        public int GemsBet { get; set; }
        public int ExcludeItemsAmount { get; set; }
        
        // Methods
        public Rilisoft.GameEventChestData 专丒业丘七丞不丗丛(int 一丑不东丒下丂丞丙)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3;
            string val_5;
            丈丞丕丘丕丗与上一 val_6;
            Rilisoft.GameEventChestData val_1 = new Rilisoft.GameEventChestData();
            int val_2 = this.ConfigChestId;
            if(val_1 != null)
            {
                    val_1.ConfigChestId = val_2;
                .ChestId = 一丑不东丒下丂丞丙;
                .generateChestsIntervals = this.generateChestsIntervals;
                val_3 = this._excludeItemsAmount;
            }
            else
            {
                    val_1.ConfigChestId = val_2;
                mem[64] = 一丑不东丒下丂丞丙;
                .generateChestsIntervals = this.generateChestsIntervals;
                val_3 = this._excludeItemsAmount;
            }
            
            ._excludeItemsAmount = val_3;
            mem[1152921542103847344] = val_2;
            if(val_1 != null)
            {
                    ._gemsBet = this._gemsBet;
                mem[1152921542103847360] = val_3;
                .BindedItem = this.BindedItem;
                .DefaultItemColor = this.DefaultItemColor;
                .End = this.End;
                mem[1152921542103847408] = ???;
                .EventId = this.EventId;
                .DefaultItemColor = this.DefaultItemColor;
                .FreeSpinIntervalInt = this.FreeSpinIntervalInt;
                mem[1152921542103847432] = ???;
                .FullDropQueueLength = this.FullDropQueueLength;
                .ItemContainers = this.ItemContainers;
                .LapSize = this.LapSize;
                .LastLapReward = this.LastLapReward;
                .OpenPrice = this.OpenPrice;
                .OpenPrices = this.OpenPrices;
                .ResetIntervals = this.ResetIntervals;
                .ResetPrice = this.ResetPrice;
                .SpinRule = this.SpinRule;
                .Start = this.Start;
                mem[1152921542103847520] = ???;
                .ToOpenSpins = this.ToOpenSpins;
                .ToSuperChestPoints = this.ToSuperChestPoints;
                .ViewType = this.ViewType;
                val_6 = this.Bet;
            }
            else
            {
                    mem[40] = this._gemsBet;
                mem[48] = val_3;
                mem[56] = this.BindedItem;
                .DefaultItemColor = this.DefaultItemColor;
                mem[88] = this.End;
                mem[96] = this._gemsBet;
                mem[104] = this.EventId;
                .DefaultItemColor = this.DefaultItemColor;
                mem[112] = this.FreeSpinIntervalInt;
                mem[120] = this._gemsBet;
                mem[128] = this.FullDropQueueLength;
                mem[136] = this.ItemContainers;
                mem[144] = this.LapSize;
                mem[152] = this.LastLapReward;
                mem[160] = this.OpenPrice;
                mem[168] = this.OpenPrices;
                mem[176] = this.ResetIntervals;
                mem[184] = this.ResetPrice;
                .SpinRule = this.SpinRule;
                mem[200] = this.Start;
                mem[208] = this._gemsBet;
                mem[216] = this.ToOpenSpins;
                .ToSuperChestPoints = this.ToSuperChestPoints;
                val_5 = this.ViewType;
                mem[224] = val_5;
                val_6 = this.Bet;
            }
            
            .Bet = val_6;
            return val_1;
        }
        public int get_ConfigChestId()
        {
            if((this._configChestId & 1) == 0)
            {
                    return (int)val_5 + 64;
            }
            
            this = ???;
            return (int)val_5 + 64;
        }
        public void set_ConfigChestId(int 丙业与丙丗丝不丈东)
        {
            this._configChestId = 0;
        }
        public System.Nullable<System.TimeSpan> get_FreeSpinInterval()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_4;
            var val_5;
            val_4 = this.FreeSpinIntervalInt;
            val_5 = 0;
            if(val_4 == 0)
            {
                    return 0;
            }
            
            val_4 = val_4;
            System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)(Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88)) + val_4);
            val_5 = val_3._ticks;
            return 0;
        }
        public GameEventChestData()
        {
            this.generateChestsIntervals = new System.Collections.Generic.List<System.Int32>();
            this.ResetIntervals = new System.Collections.Generic.List<System.Int32>();
            this.ItemContainers = new System.Collections.Generic.List<Rilisoft.GameEventItemContainerData>();
        }
        public int get_GemsBet()
        {
        
        }
        public void set_GemsBet(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._gemsBet = 0;
            mem[1152921542104631744] = 0;
        }
        public int get_ExcludeItemsAmount()
        {
        
        }
        public void set_ExcludeItemsAmount(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._excludeItemsAmount = 0;
            mem[1152921542104855728] = 0;
        }
    
    }

}

using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPData
    {
        // Fields
        public int Id;
        private Rilisoft.丝丑丂丛万丐丈丘且 _levelPrice;
        private Rilisoft.丝丑丂丛万丐丈丘且 _dailyExp;
        private Rilisoft.丝丑丂丛万丐丈丘且 _blockPointForViewNewDailyChallenges;
        private Rilisoft.丝丑丂丛万丐丈丘且 _blockPointForViewNewCommonChallenges;
        private Rilisoft.丝丑丂丛万丐丈丘且 _premiumLevelsCount;
        private Rilisoft.丝丑丂丛万丐丈丘且 _premiumPrice;
        private Rilisoft.丝丑丂丛万丐丈丘且 _premiumPriceWithLevels;
        private Rilisoft.丝丑丂丛万丐丈丘且 _premiumPriceWithLevelsOld;
        public System.Collections.Generic.List<Rilisoft.GameCurrencyData> CurrencyPrices;
        internal System.Collections.Generic.List<PGCompany.BattlePass.BPData.专三且丄下世上下下> DiscountSettings;
        public System.DateTime EndDate;
        public string GuiType;
        public System.Collections.Generic.List<Rilisoft.GameEventRewardData> GameRewards;
        public System.Collections.Generic.List<PGCompany.BattlePass.BPData.Content> Leveling;
        public int MaxVideoDailyCount;
        public int MinPlayerLevel;
        public System.Collections.Generic.List<Rilisoft.OfferItem> PresettedCharacterItems;
        public string PresettedChallangesAvatar;
        public System.DateTime StartDate;
        
        // Properties
        public int PremiumPrice { get; set; }
        public int LevelPrice { get; set; }
        public int PremiumPriceWithLevels { get; set; }
        public int PremiumPriceWithLevelsOld { get; set; }
        public int PremiumLevelsCount { get; set; }
        public int DailyExp { get; set; }
        public int BlockPointForViewNewDailyChallenges { get; set; }
        public int BlockPointForViewNewCommonChallenges { get; set; }
        
        // Methods
        public int get_PremiumPrice()
        {
        
        }
        public void set_PremiumPrice(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._premiumPrice = 0;
            mem[1152921559946128352] = 0;
        }
        public int get_LevelPrice()
        {
        
        }
        public void set_LevelPrice(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._levelPrice = 0;
            mem[1152921559946352272] = 0;
        }
        public int get_PremiumPriceWithLevels()
        {
        
        }
        public void set_PremiumPriceWithLevels(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._premiumPriceWithLevels = 0;
            mem[1152921559946576368] = 0;
        }
        public int get_PremiumPriceWithLevelsOld()
        {
        
        }
        public void set_PremiumPriceWithLevelsOld(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._premiumPriceWithLevelsOld = 0;
            mem[1152921559946800384] = 0;
        }
        public int get_PremiumLevelsCount()
        {
        
        }
        public void set_PremiumLevelsCount(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._premiumLevelsCount = 0;
            mem[1152921559947024336] = 0;
        }
        public int get_DailyExp()
        {
        
        }
        public void set_DailyExp(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._dailyExp = 0;
            mem[1152921559947248288] = 0;
        }
        public int get_BlockPointForViewNewDailyChallenges()
        {
        
        }
        public void set_BlockPointForViewNewDailyChallenges(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._blockPointForViewNewDailyChallenges = 0;
            mem[1152921559947472304] = 0;
        }
        public int get_BlockPointForViewNewCommonChallenges()
        {
        
        }
        public void set_BlockPointForViewNewCommonChallenges(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._blockPointForViewNewCommonChallenges = 0;
            mem[1152921559947696320] = 0;
        }
        public System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 且业上丞丄丁专不丙()
        {
            var val_4;
            var val_25;
            System.Collections.Generic.List<T> val_26;
            var val_27;
            var val_28;
            int val_29;
            int val_30;
            System.Collections.Generic.List<System.String> val_31;
            int val_32;
            System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_1 = null;
            val_26 = val_1;
            val_1 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
            if(this.Leveling == null)
            {
                    return (System.Collections.Generic.List<PGCompany.BattlePass.BPReward>)val_26;
            }
            
            List.Enumerator<T> val_2 = this.Leveling.GetEnumerator();
            val_27 = 1152921559947793456;
            val_28 = 1152921504691564544;
            val_25 = 1152921516107644960;
            goto label_26;
            label_46:
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((X21 + 16) == 0)
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
            val_29 = 0;
            goto label_6;
            label_24:
            if((null.Contains(item:  X23 + 16.Item[0])) != true)
            {
                    Rilisoft.OfferItem val_10 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_7.m_stringLength.Item[0]);
                if(val_10 != null)
            {
                    new PGCompany.BattlePass.BPReward() = new PGCompany.BattlePass.BPReward(上丌丆丁丟上下专丁:  0, 丏世丞丅丁丄丁万丑:  val_5.m_firstChar, 下丅丙一丂丗丅丝七:  val_10, 专丞不万丄业下丞三:  (val_27 != 0) ? 1 : 0);
                val_26 = val_26;
                .<Index>k__BackingField = val_29;
                val_1.Add(item:  new PGCompany.BattlePass.BPReward());
                val_27 = val_27;
                val_28 = val_28;
                val_25 = 1152921516107644960;
                null.Add(item:  (PGCompany.BattlePass.BPReward)[1152921559947938544]._firstItemToCurrency.Item[0]);
            }
            
            }
            
            val_29 = 1;
            label_6:
            val_30 = val_13.m_stringLength;
            if(val_29 < val_30.Count)
            {
                goto label_24;
            }
            
            label_5:
            if((public System.Int32 System.Collections.Generic.List<System.String>::get_Count()) == 0)
            {
                goto label_26;
            }
            
            val_31 = null;
            val_31 = new System.Collections.Generic.List<System.String>();
            val_32 = 0;
            goto label_27;
            label_45:
            string val_16 = val_13.m_stringLength + 24.Item[0];
            if((null.Contains(item:  val_16)) != true)
            {
                    Rilisoft.OfferItem val_19 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_16.Item[0]);
                if(val_19 != null)
            {
                    new PGCompany.BattlePass.BPReward() = new PGCompany.BattlePass.BPReward(上丌丆丁丟上下专丁:  100, 丏世丞丅丁丄丁万丑:  val_5.m_firstChar, 下丅丙一丂丗丅丝七:  val_19, 专丞不万丄业下丞三:  (val_27 != 0) ? 1 : 0);
                val_26 = val_26;
                .<Index>k__BackingField = val_32;
                val_1.Add(item:  new PGCompany.BattlePass.BPReward());
                string val_22 = (PGCompany.BattlePass.BPReward)[1152921559947967216]._forLevel.Item[0];
                val_27 = val_27;
                val_28 = val_28;
                val_25 = 1152921516107644960;
                null.Add(item:  val_22);
            }
            
            }
            
            val_32 = 1;
            label_27:
            if(val_32 < val_22.Count)
            {
                goto label_45;
            }
            
            label_26:
            if(((-493556080) & 1) != 0)
            {
                goto label_46;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<PGCompany.BattlePass.BPReward>)val_26;
        }
        public BPData()
        {
            this.DiscountSettings = new System.Collections.Generic.List<专三且丄下世上下下>();
            this.MaxVideoDailyCount = 12884901891;
            this.MinPlayerLevel = 3;
        }
    
    }

}

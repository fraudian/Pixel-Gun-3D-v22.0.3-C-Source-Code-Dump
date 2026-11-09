using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanWarConfig
    {
        // Fields
        public System.DateTime StartDate;
        public System.DateTime EndDate;
        internal string StartStamp;
        internal string EndStamp;
        internal Rilisoft.丝丑丂丛万丐丈丘且 TributeRewardTime;
        internal Rilisoft.丝丑丂丛万丐丈丘且 TimeToRegistrationClose;
        private Rilisoft.丝丑丂丛万丐丈丘且 _delayRefreshGoblin;
        private Rilisoft.丝丑丂丛万丐丈丘且 _repeatTimeRefreshGoblin;
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> CaptureRewards;
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> TributeRewards;
        internal System.Collections.Generic.List<PGCompany.ClanWarMapCellConfig> MapCells;
        internal System.Collections.Generic.List<PGCompany.ClanWarEventConfig> Events;
        internal System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>> DivisionRewards;
        internal System.Collections.Generic.List<System.Collections.Generic.List<int>> DivisionUps;
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<PGCompany.ClanWarMapCellConfig.TaskConfig>> Tasks;
        internal System.Collections.Generic.Dictionary<int, int> RaidsCompexity;
        internal System.Collections.Generic.Dictionary<int, PGCompany.ClanWarRaidSetting> RaidSettings;
        internal bool WarV2WorkInProgress;
        internal bool WarUpdate;
        
        // Properties
        internal int DelayRefreshGoblin { get; set; }
        internal int RepeatTimeRefreshGoblin { get; set; }
        
        // Methods
        internal int get_DelayRefreshGoblin()
        {
        
        }
        internal void set_DelayRefreshGoblin(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._delayRefreshGoblin = val_1;
            mem[1152921554166227608] = val_1.上万三丆专丏丒丗业;
        }
        internal int get_RepeatTimeRefreshGoblin()
        {
        
        }
        internal void set_RepeatTimeRefreshGoblin(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._repeatTimeRefreshGoblin = val_1;
            mem[1152921554166451624] = val_1.上万三丆专丏丒丗业;
        }
        public ClanWarConfig()
        {
        
        }
    
    }

}

using UnityEngine;

namespace PGCompany
{
    internal sealed class 丟丒且且一丛丝丐丞
    {
        // Fields
        internal PGCompany.七且丕丆丘丙下丟丟 BuildingData;
        private Rilisoft.丝丑丂丛万丐丈丘且 _taskTimeRefresh;
        private readonly PGCompany.三东丏不丗世丅丌丄 <不丙丅专业丘丗上丄>k__BackingField;
        private Rilisoft.丂上丐丄丛一一丒七 _refreshTaskFactor;
        internal PGCompany.且丟一七万东丁三上<PGCompany.丒且丌丑丆上一丘丆<ItemRarity>> RarityWeights;
        internal System.Collections.Generic.List<PGCompany.丟丒且且一丛丝丐丞.上丂且万丌业丑丈丞> RewardSettings;
        internal System.Collections.Generic.List<PGCompany.丟丒且且一丛丝丐丞.丂丅上与丑丁与丕丝> TaskSettings;
        internal System.Collections.Generic.List<PGCompany.丟丒且且一丛丝丐丞.且上丅丌丕丌丌下专> CommonSettings;
        
        // Properties
        internal int 丈丟丑三专且丈一世 { get; set; }
        internal PGCompany.三东丏不丗世丅丌丄 RefreshTaskPrice { get; }
        internal decimal 世丑丅丌丙丘三且丟 { get; set; }
        
        // Methods
        internal int 七丛丈丐一三丌专与()
        {
        
        }
        internal void 一东且丁丛专万丑丕(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._taskTimeRefresh = val_1;
            mem[1152921554035051840] = val_1.上万三丆专丏丒丗业;
        }
        internal PGCompany.三东丏不丗世丅丌丄 丝丞丙丑且七丘丌丆()
        {
            return (PGCompany.三东丏不丗世丅丌丄)this.<不丙丅专业丘丗上丄>k__BackingField;
        }
        internal decimal 丑七丕丞丌三丛一丁()
        {
        
        }
        internal void 丏丘业丞丂业丑与丆(decimal 丙业与丙丗丝不丈东)
        {
            var val_2;
            Rilisoft.丂上丐丄丛一一丒七 val_3;
            Rilisoft.丂上丐丄丛一一丒七 val_1 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
            mem[1152921554035400112] = val_2;
            this._refreshTaskFactor = val_3;
        }
        public 丟丒且且一丛丝丐丞()
        {
            var val_4;
            Rilisoft.丂上丐丄丛一一丒七 val_5;
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  86400);
            this._taskTimeRefresh = val_1;
            mem[1152921554035524272] = val_1.上万三丆专丏丒丗业;
            this.<不丙丅专业丘丗上丄>k__BackingField = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  223, 丂丕丂丏专丂丄丕且:  20);
            Rilisoft.丂上丐丄丛一一丒七 val_3 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal());
            mem[1152921554035524304] = val_4;
            this._refreshTaskFactor = val_5;
        }
    
    }

}

using UnityEngine;

namespace Progress
{
    internal sealed class 丌丞与丝丙丕丟三上 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.BM.丛专下与丟丑与丐丁 丈丄丂下丒专丌丛丄;
        
        // Properties
        internal PGCompany.BM.丛专下与丟丑与丐丁 不丆丟与丙丏业丛丗 { get; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal PGCompany.BM.丛专下与丟丑与丐丁 业丑丁丆丕丆丂丅万()
        {
            return (PGCompany.BM.丛专下与丟丑与丐丁)this.丈丄丂下丒专丌丛丄;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丌丞与丝丙丕丟三上.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丌丞与丝丙丕丟三上.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 46;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.丈丄丂下丒专丌丛丄 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "s", value:  this.丈丄丂下丒专丌丛丄.SeasonId);
            if(this.丈丄丂下丒专丌丛丄.ClanWarSeasonId >= 1)
            {
                    val_1.Add(key:  "ws", value:  this.丈丄丂下丒专丌丛丄.ClanWarSeasonId);
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丈丄丂下丒专丌丛丄.Cells.GetEnumerator();
            label_12:
            if((2052391512 & 1) == 0)
            {
                goto label_9;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            val_2.Add(key:  val_4._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  val_4._value._obj.丁丕上三丕丌丟丗丙());
            goto label_12;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_8 = 1152921504622075904;
            val_1.Add(key:  "c", value:  val_2);
            val_1.Add(key:  "rc", value:  this.丈丄丂下丒专丌丛丄.RefreshConter);
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丈丄丂下丒专丌丛丄 = new PGCompany.BM.丛专下与丟丑与丐丁();
        }
        internal void 丐丑丁丑丟丒不三丅(PGCompany.BM.丛专下与丟丑与丐丁 上丕丈丞丌丘丅不与)
        {
            PGCompany.BM.丛专下与丟丑与丐丁 val_4;
            if(上丕丈丞丌丘丅不与.Clone() != null)
            {
                    val_4 = 0;
            }
            
            this.丈丄丂下丒专丌丛丄 = val_4;
        }
        internal void 不丟丈丗丅专专丁丒(int 丝丌不东丕丒与丒丅)
        {
            丟业丛丘一丘丗上七 val_1 = this.丈丄丂下丒专丌丛丄.Cells.Item[丝丌不东丕丒与丒丅];
            val_1.Opened = true;
        }
        internal void 东专丑七与丟丁上丗(PGCompany.BM.丛专下与丟丑与丐丁.丟业丛丘一丘丗上七 上丕丈丞丌丘丅不与)
        {
            if(上丕丈丞丌丘丅不与 == null)
            {
                    return;
            }
            
            bool val_1 = this.丈丄丂下丒专丌丛丄.Cells.ContainsKey(key:  上丕丈丞丌丘丅不与.CellId);
            if(this.丈丄丂下丒专丌丛丄.Cells == null)
            {
                goto label_5;
            }
            
            if(val_1 == false)
            {
                goto label_6;
            }
            
            label_7:
            this.丈丄丂下丒专丌丛丄.Cells.set_Item(key:  上丕丈丞丌丘丅不与.CellId, value:  上丕丈丞丌丘丅不与);
            return;
            label_5:
            if(val_1 == true)
            {
                goto label_7;
            }
            
            label_6:
            this.丈丄丂下丒专丌丛丄.Cells.Add(key:  上丕丈丞丌丘丅不与.CellId, value:  上丕丈丞丌丘丅不与);
        }
        internal void 下且世七丐七一丙丞(int 丛七东丝且丏丅东且)
        {
            if((this.丈丄丂下丒专丌丛丄.Cells.ContainsKey(key:  丛七东丝且丏丅东且)) == false)
            {
                    return;
            }
            
            bool val_2 = this.丈丄丂下丒专丌丛丄.Cells.Remove(key:  丛七东丝且丏丅东且);
        }
        internal PGCompany.BM.丛专下与丟丑与丐丁.丟业丛丘一丘丗上七 丌与七七且世一丂丁(int 丝丌不东丕丒与丒丅)
        {
            var val_3;
            if((this.丈丄丂下丒专丌丛丄.Cells.ContainsKey(key:  丝丌不东丕丒与丒丅)) != false)
            {
                    丟业丛丘一丘丗上七 val_2 = this.丈丄丂下丒专丌丛丄.Cells.Item[丝丌不东丕丒与丒丅];
                return (丟业丛丘一丘丗上七)val_3;
            }
            
            val_3 = 0;
            return (丟业丛丘一丘丗上七)val_3;
        }
        internal void 丗业上丆下丈丘丕世(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丙业与丙丗丝不丈东);
            this.丈丄丂下丒专丌丛丄.RefreshConter = val_1;
            mem2[0] = val_1.上万三丆专丏丒丗业;
        }
        internal void 丁上丟丌万东且丕丅(int 世不下丟世一丝丐丗)
        {
            this.丈丄丂下丒专丌丛丄.ClanWarSeasonId = 世不下丟世一丝丐丗;
        }
        public 丌丞与丝丙丕丟三上()
        {
            this.丈丄丂下丒专丌丛丄 = new PGCompany.BM.丛专下与丟丑与丐丁();
        }
        private static 丌丞与丝丙丕丟三上()
        {
            Progress.丌丞与丝丙丕丟三上.丕丟一七丑丙丂丆丙 = "BlackMarket_slot";
            Progress.丌丞与丝丙丕丟三上.丐丌丞上世丛丐丏丛 = "BlackMarket_slot";
        }
    
    }

}

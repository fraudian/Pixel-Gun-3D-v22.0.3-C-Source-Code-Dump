using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanLootBoxData
    {
        // Fields
        internal string Id;
        private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
        internal 丌不丞世丛丆一三下 Type;
        internal System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, int> Slots;
        internal System.Collections.Generic.Dictionary<int, PGCompany.ClanLootBoxData.DivisionConfig> Divisions;
        
        // Properties
        internal int Index { get; set; }
        
        // Methods
        internal int get_Index()
        {
        
        }
        internal void set_Index(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._indexContainer = val_1;
            mem[1152921554084819472] = val_1.上万三丆专丏丒丗业;
        }
        internal PGCompany.ClanLootBoxData.DivisionConfig 丒不丝丒丑丕丌不丛(int 丅丅下丟丑专下与一)
        {
            System.Collections.Generic.Dictionary<System.Int32, DivisionConfig> val_8;
            var val_9;
            val_8 = this;
            int val_5 = UnityEngine.Mathf.Clamp(value:  丅丅下丟丑专下与一, min:  System.Linq.Enumerable.Min(source:  this.Divisions.Keys), max:  System.Linq.Enumerable.Max(source:  this.Divisions.Keys));
            if((this.Divisions.ContainsKey(key:  val_5)) != false)
            {
                    val_8 = this.Divisions;
                DivisionConfig val_7 = val_8.Item[val_5];
                return (DivisionConfig)val_9;
            }
            
            val_9 = 0;
            return (DivisionConfig)val_9;
        }
        public ClanLootBoxData()
        {
        
        }
    
    }

}

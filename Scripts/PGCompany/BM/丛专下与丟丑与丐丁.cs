using UnityEngine;

namespace PGCompany.BM
{
    internal class 丛专下与丟丑与丐丁 : ICloneable
    {
        // Fields
        internal int SeasonId;
        internal int ClanWarSeasonId;
        internal System.Collections.Generic.Dictionary<int, PGCompany.BM.丛专下与丟丑与丐丁.丟业丛丘一丘丗上七> Cells;
        internal Rilisoft.丝丑丂丛万丐丈丘且 RefreshConter;
        
        // Methods
        public object Clone()
        {
            var val_6;
            int val_11;
            System.Collections.Generic.Dictionary<System.Int32, 丟业丛丘一丘丗上七> val_12;
            丟业丛丘一丘丗上七 val_13;
            PGCompany.BM.丛专下与丟丑与丐丁 val_1 = new PGCompany.BM.丛专下与丟丑与丐丁();
            if(val_1 != null)
            {
                    .SeasonId = this.SeasonId;
                val_11 = this.ClanWarSeasonId;
            }
            else
            {
                    mem[16] = this.SeasonId;
                val_11 = this.ClanWarSeasonId;
            }
            
            .ClanWarSeasonId = val_11;
            System.Collections.Generic.Dictionary<System.Int32, 丟业丛丘一丘丗上七> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.Int32, 丟业丛丘一丘丗上七>();
            .Cells = val_12;
            Dictionary.Enumerator<TKey, TValue> val_3 = this.Cells.GetEnumerator();
            label_11:
            if((95245392 & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_13 = val_7._value._obj.Clone();
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            (PGCompany.BM.丛专下与丟丑与丐丁)[1152921560536711360].Cells.Add(key:  val_7._value._obj.丙东专丂世丈丏丁丂(), value:  val_13);
            goto label_11;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_1;
        }
        public 丛专下与丟丑与丐丁()
        {
            this.Cells = new System.Collections.Generic.Dictionary<System.Int32, 丟业丛丘一丘丗上七>();
        }
    
    }

}

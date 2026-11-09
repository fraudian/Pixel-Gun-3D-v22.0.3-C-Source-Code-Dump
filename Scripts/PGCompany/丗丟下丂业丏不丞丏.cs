using UnityEngine;

namespace PGCompany
{
    internal sealed class 丗丟下丂业丏不丞丏
    {
        // Fields
        private int <上丒世丘丗下丌七不>k__BackingField;
        private string <与丕丕丙丐丂丟丒世>k__BackingField;
        private bool <世丒七丌业丞丄业下>k__BackingField;
        private bool <丑丗丘丕七丅丝世丞>k__BackingField;
        private Rilisoft.丝丑丂丛万丐丈丘且 一丏丑东丞下不上丝;
        private Rilisoft.丝丑丂丛万丐丈丘且 丐丙丌丄丏丆丒不丙;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 丄上丄七丐业丄三且;
        
        // Properties
        internal int 丌丛丒丏上业丟丞不 { get; set; }
        internal string 一东丒世下一丝丆世 { get; set; }
        internal bool 丈丒丐丌丒丂丒丕丂 { get; set; }
        internal bool 东丏丟不丒世且业世 { get; set; }
        internal int 丈七一三丝丁丟丈世 { get; set; }
        internal int 万丙丂东丌专丐丛世 { get; set; }
        internal int 且且世业丟丆与丄业 { get; }
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 下丟丝世丕七丆丄丄 { get; }
        
        // Methods
        internal int 丅东丄丛上丁丐万丏()
        {
            return (int)this.<上丒世丘丗下丌七不>k__BackingField;
        }
        private void 丐与丗上丈丏上丕上(int 丙业与丙丗丝不丈东)
        {
            this.<上丒世丘丗下丌七不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 三丂万丞丅万三丘东()
        {
            return (string)this.<与丕丕丙丐丂丟丒世>k__BackingField;
        }
        private void 丆丐丄丑丞东丂丛丞(string 丙业与丙丗丝不丈东)
        {
            this.<与丕丕丙丐丂丟丒世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丕丟万丛丂业三且世()
        {
            return (bool)this.<世丒七丌业丞丄业下>k__BackingField;
        }
        private void 丂丏丌丗丛丗丄一丏(bool 丙业与丙丗丝不丈东)
        {
            this.<世丒七丌业丞丄业下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丈丗东丏专丐丅专丄()
        {
            return (bool)this.<丑丗丘丕七丅丝世丞>k__BackingField;
        }
        private void 丅丕丕世丒七丘丐丝(bool 丙业与丙丗丝不丈东)
        {
            this.<丑丗丘丕七丅丝世丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 业不丂丈丝东丛丑丅()
        {
        
        }
        internal void 丗不丆与丆丗丒丕丟(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.一丏丑东丞下不上丝 = 0;
            mem[1152921554160237136] = 0;
        }
        internal int 且三一丌丕丟丙万丛()
        {
        
        }
        internal void 丛业丑丝丆丅丏下丄(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.丐丙丌丄丏丆丒不丙 = 0;
            mem[1152921554160461152] = 0;
        }
        internal 丗丟下丂业丏不丞丏(int 丟丟丄专上丟丁丐丝)
        {
            this.丄上丄七丐业丄三且 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            this.<上丒世丘丗下丌七不>k__BackingField = 丟丟丄专上丟丁丐丝;
        }
        internal int 丑丞丝丘丏丁丕不丌()
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_8;
            string val_1 = PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛();
            val_8 = this.丄上丄七丐业丄三且;
            if((val_8.ContainsKey(key:  val_1)) == false)
            {
                    return 0;
            }
            
            val_8 = this.丄上丄七丐业丄三且.Item[val_1];
            if((val_8.ContainsKey(key:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                    return 0;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_6 = this.丄上丄七丐业丄三且.Item[val_1];
            if(val_6 != null)
            {
                    return val_6.Item[专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()];
            }
            
            return val_6.Item[专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()];
        }
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 丅丙丅丒丂丟丄业丗()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>)this.丄上丄七丐业丄三且;
        }
        internal 丗丟下丂业丏不丞丏(int 丟丟丄专上丟丁丐丝, string 丆丘不丌丁丈丆丟丘, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 丕丞且丂丒丄东不丘, bool 丅丕丛丆三丂丈下丄)
        {
            var val_6;
            var val_18;
            var val_19;
            var val_21;
            var val_23;
            this.丄上丄七丐业丄三且 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            val_2 = new System.Object();
            this.<上丒世丘丗下丌七不>k__BackingField = 丟丟丄专上丟丁丐丝;
            this.<与丕丕丙丐丂丟丒世>k__BackingField = val_2;
            Dictionary.Enumerator<TKey, TValue> val_3 = 丕丞且丂丒丄东不丘.GetEnumerator();
            val_18 = 0;
            val_19 = 0;
            var val_18 = 0;
            label_23:
            if(((-1985446000) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            Dictionary.Enumerator<TKey, TValue> val_8 = val_7._value._obj.GetEnumerator();
            goto label_8;
            label_10:
            ConfiguredValueTaskAwaiter val_9 = val_6.GetAwaiter();
            if((System.String.op_Equality(a:  val_7._value._obj.丐丏七丌丕丗业且上(), b:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛())) == true)
            {
                goto label_7;
            }
            
            if((System.String.op_Equality(a:  val_7._value._obj.丐丏七丌丕丗业且上(), b:  this.<与丕丕丙丐丂丟丒世>k__BackingField)) == false)
            {
                goto label_8;
            }
            
            val_21 = 0;
            goto label_9;
            label_7:
            val_21 = 0;
            label_9:
            label_8:
            if(((-1985446064) & 1) != 0)
            {
                goto label_10;
            }
            
            val_18 = val_18 + 1;
            mem2[0] = 163;
            val_23 = val_19;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_18 == 1) || ((1152921554161008368 + ((0 + 1)) << 2) != 163))
            {
                goto label_20;
            }
            
            var val_19 = 0;
            val_19 = val_19 ^ (val_18 >> 31);
            val_18 = val_18 + val_19;
            goto label_23;
            label_20:
            if( == 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_2:
            val_18 = val_18 + 1;
            mem2[0] = 188;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_18 == 1)
            {
                goto label_29;
            }
            
            if(( == 0) || ((1152921554161008368 + ((0 + 1)) << 2) == 188))
            {
                goto label_33;
            }
            
            label_32:
            label_33:
            int val_15 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.一丏丑东丞下不上丝 = 0;
            mem[1152921554161020752] = 0;
            int val_16 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.<丑丗丘丕七丅丝世丞>k__BackingField = true;
            this.<世丒七丌业丞丄业下>k__BackingField = 丅丕丛丆三丂丈下丄;
            this.丐丙丌丄丏丆丒不丙 = 0;
            mem[1152921554161020768] = 0;
            this.丄上丄七丐业丄三且 = 丕丞且丂丒丄东不丘;
            return;
            label_29:
            if( != 0)
            {
                goto label_32;
            }
            
            goto label_33;
        }
    
    }

}

using UnityEngine;

namespace PGCompany
{
    internal class 丒且专三三丄丙丞丞
    {
        // Fields
        private int <丒丒丈丑一丝下丏丏>k__BackingField;
        private DiscreteVector2 <丁丅丁丁丑且丄丌世>k__BackingField;
        private string <丄丝三三业东专丈万>k__BackingField;
        private int <一专丞上专丌丐丐七>k__BackingField;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 与丌丙丟丘七丛丂丒;
        private System.Collections.Generic.Dictionary<string, int> 丟万丂七丁一世丂丕;
        
        // Properties
        internal int 丏与丄丄万七丞世丘 { get; set; }
        internal DiscreteVector2 丛丄世七万丗三三且 { get; set; }
        internal string 丈丟丏七丘丂丒丗世 { get; set; }
        internal int 与丈下业下丑丕丞丂 { get; set; }
        internal bool 丈一丞丗丟七丒东丌 { get; }
        internal System.Collections.Generic.Dictionary<string, int> 一丁丕丝七丕丅专与 { get; }
        
        // Methods
        internal int 上万不丗丟万一七丐()
        {
            return (int)this.<丒丒丈丑一丝下丏丏>k__BackingField;
        }
        private void 万丗不丁丞丌东与丁(int 丙业与丙丗丝不丈东)
        {
            this.<丒丒丈丑一丝下丏丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal DiscreteVector2 丝专与下丗丐东丛丐()
        {
            return new DiscreteVector2() {_x = this.<丁丅丁丁丑且丄丌世>k__BackingField, _y = this.<丁丅丁丁丑且丄丌世>k__BackingField};
        }
        private void 丈丒不丑三丄丏丅丌(DiscreteVector2 丙业与丙丗丝不丈东)
        {
            this.<丁丅丁丁丑且丄丌世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 丙丗丏丂业且不东丞()
        {
            return (string)this.<丄丝三三业东专丈万>k__BackingField;
        }
        private void 万丐业丑下丆万不七(string 丙业与丙丗丝不丈东)
        {
            this.<丄丝三三业东专丈万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 上与丌与上下丙丟业()
        {
            return (int)this.<一专丞上专丌丐丐七>k__BackingField;
        }
        private void 丛丌丁丁三丗丑丘且(int 丙业与丙丗丝不丈东)
        {
            this.<一专丞上专丌丐丐七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 东丛丌且丐与万三丐()
        {
            return 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.<丄丝三三业东专丈万>k__BackingField);
        }
        internal System.Collections.Generic.Dictionary<string, int> 专丄丘丑丏丞上丟丏()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this.丟万丂七丁一世丂丕;
        }
        internal 丒且专三三丄丙丞丞(int 丝丌不东丕丒与丒丅)
        {
            this.与丌丙丟丘七丛丂丒 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            this.丟万丂七丁一世丂丕 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丘上丐世丆丑且丞丒(丝丌不东丕丒与丒丅:  丝丌不东丕丒与丒丅);
        }
        internal 丒且专三三丄丙丞丞(int 丝丌不东丕丒与丒丅, int 丐丌丌丈下丁丝丅万, int 丏丗丐下丝丐丐丏丑, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 三丒不不一七东丕业)
        {
            int val_5;
            this.与丌丙丟丘七丛丂丒 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            this.丟万丂七丁一世丂丕 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_3 = new System.Object();
            this.丘上丐世丆丑且丞丒(丝丌不东丕丒与丒丅:  丝丌不东丕丒与丒丅);
            if(丐丌丌丈下丁丝丅万 > 0)
            {
                    string val_4 = 丐丌丌丈下丁丝丅万.ToString();
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            this.<丄丝三三业东专丈万>k__BackingField = val_5;
            this.<一专丞上专丌丐丐七>k__BackingField = 丏丗丐下丝丐丐丏丑;
            this.与丌丙丟丘七丛丂丒 = val_3;
            this.专七七不丂丐丂下下();
        }
        internal void 七下不与丁丏丒且三(int 丈万丞丘丛丐不三丝)
        {
            string val_16;
            var val_17;
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 != null)
            {
                    val_16 = val_2.业丐丐三丕一丗丛丁();
            }
            else
            {
                    val_16 = 0;
            }
            
            if((this.与丌丙丟丘七丛丂丒.ContainsKey(key:  val_16)) != true)
            {
                    this.与丌丙丟丘七丛丂丒.set_Item(key:  val_16, value:  new System.Collections.Generic.Dictionary<System.String, System.Int32>());
            }
            
            if((this.与丌丙丟丘七丛丂丒.Item[val_16].ContainsKey(key:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != true)
            {
                    this.与丌丙丟丘七丛丂丒.Item[val_16].set_Item(key:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), value:  0);
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_11 = this.与丌丙丟丘七丛丂丒.Item[val_16];
            string val_12 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(val_11 != null)
            {
                    val_17 = val_11.Item[val_12];
            }
            else
            {
                    val_17 = 0.Item[val_12];
            }
            
            val_11.set_Item(key:  val_12, value:  val_17 + 丈万丞丘丛丐不三丝);
            this.专七七不丂丐丂下下();
        }
        internal int 七丘丅丆三不上七丆(string 丄丒下业一不丈丝丘)
        {
            if(丄丒下业一不丈丝丘 == null)
            {
                    return 0;
            }
            
            if((this.丟万丂七丁一世丂丕.ContainsKey(key:  丄丒下业一不丈丝丘)) == false)
            {
                    return 0;
            }
            
            if(this.丟万丂七丁一世丂丕 != null)
            {
                    return this.丟万丂七丁一世丂丕.Item[丄丒下业一不丈丝丘];
            }
            
            return this.丟万丂七丁一世丂丕.Item[丄丒下业一不丈丝丘];
        }
        internal int 专丌丛丞上一业丆丕()
        {
            string val_10;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_11;
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 != null)
            {
                    val_10 = val_2.业丐丐三丕一丗丛丁();
            }
            else
            {
                    val_10 = 0;
            }
            
            val_11 = this.与丌丙丟丘七丛丂丒;
            if((val_11.ContainsKey(key:  val_10)) == false)
            {
                    return 0;
            }
            
            val_11 = this.与丌丙丟丘七丛丂丒.Item[val_10];
            if((val_11.ContainsKey(key:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                    return 0;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_8 = this.与丌丙丟丘七丛丂丒.Item[val_10];
            if(val_8 != null)
            {
                    return val_8.Item[专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()];
            }
            
            return val_8.Item[专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()];
        }
        private void 专七七不丂丐丂下下()
        {
            var val_4;
            var val_12;
            var val_13;
            var val_14;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.与丌丙丟丘七丛丂丒.GetEnumerator();
            val_12 = 0;
            val_13 = 0;
            var val_12 = 0;
            label_19:
            if(((-1940672400) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            this.丟万丂七丁一世丂丕.set_Item(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  0);
            Dictionary.Enumerator<TKey, TValue> val_7 = val_5._value._obj.GetEnumerator();
            label_8:
            if(((-1940672464) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_4.GetAwaiter();
            string val_9 = val_5._value._obj.丐丏七丌丕丗业且上();
            this.丟万丂七丁一世丂丕.set_Item(key:  val_9, value:   + this.丟万丂七丁一世丂丕.Item[val_9]);
            goto label_8;
            label_5:
            val_12 = val_12 + 1;
            val_14 = val_13;
            mem2[0] = 132;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_12 == 1) || ((-1940672544 + ((0 + 1)) << 2) != 132))
            {
                goto label_16;
            }
            
            var val_13 = 0;
            val_13 = val_13 ^ (val_12 >> 31);
            val_12 = val_12 + val_13;
            goto label_19;
            label_16:
            if( == 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_2:
            val_12 = val_12 + 1;
            mem2[0] = 157;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_12 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((-1940672544 + ((0 + 1)) << 2) == 157)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private void 丘上丐世丆丑且丞丒(int 丝丌不东丕丒与丒丅)
        {
            this.<丒丒丈丑一丝下丏丏>k__BackingField = 丝丌不东丕丒与丒丅;
            this.<丄丝三三业东专丈万>k__BackingField = System.String.alignConst;
            bool val_2 = PGCompany.丂丘丞丂丏七丁丄不.丟万丕一专丄且万与(丞丅上丏丂且下丅与:  丝丌不东丕丒与丒丅, 与丌丛丑丕下丘丞丆: out  0, 丝丌不东丕丒与丒丅: out  new DiscreteVector2());
            this.<丁丅丁丁丑且丄丌世>k__BackingField = 0;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "[coord={0} owner={1} capture={2}]", arg0:  this.<丁丅丁丁丑且丄丌世>k__BackingField, arg1:  this.<丄丝三三业东专丈万>k__BackingField, arg2:  this.<一专丞上专丌丐丐七>k__BackingField);
        }
    
    }

}

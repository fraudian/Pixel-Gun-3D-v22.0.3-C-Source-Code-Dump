using UnityEngine;

namespace Progress
{
    internal sealed class 一丟不下丆丗丝丟丛 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private System.Collections.Generic.Dictionary<int, PGCompany.丒丑丄丗丄丈丑专专> 丟丆东丒业专丅业不;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal PGCompany.丒丑丄丗丄丈丑专专 上丄不万东丙东丞丝(int 丗丟丁丐与下丙丕丛)
        {
            var val_3;
            if((this.丟丆东丒业专丅业不.ContainsKey(key:  丗丟丁丐与下丙丕丛)) != false)
            {
                    PGCompany.丒丑丄丗丄丈丑专专 val_2 = this.丟丆东丒业专丅业不.Item[丗丟丁丐与下丙丕丛];
                return (PGCompany.丒丑丄丗丄丈丑专专)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.丒丑丄丗丄丈丑专专)val_3;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丟丆东丒业专丅业不.Clear();
        }
        internal void 上与丏丛丞丏丏丏一(int 丗丟丁丐与下丙丕丛)
        {
            this.丟丆东丒业专丅业不.set_Item(key:  丗丟丁丐与下丙丕丛, value:  new PGCompany.丒丑丄丗丄丈丑专专(丗丟丁丐与下丙丕丛:  丗丟丁丐与下丙丕丛));
        }
        internal void 丙三丛丗业丗丝一丂(int 丗丟丁丐与下丙丕丛, int 与丕丌丒丗丄丘丙东)
        {
            if((this.丟丆东丒业专丅业不.ContainsKey(key:  丗丟丁丐与下丙丕丛)) == false)
            {
                    return;
            }
            
            this.丟丆东丒业专丅业不.Item[丗丟丁丐与下丙丕丛].丅丈东上丑丅一东与(丙业与丙丗丝不丈东:  与丕丌丒丗丄丘丙东);
        }
        internal void 世丂丁丈上不丆东下(int 丗丟丁丐与下丙丕丛, int 丘东丏丆丑丐与丆丝)
        {
            if((this.丟丆东丒业专丅业不.ContainsKey(key:  丗丟丁丐与下丙丕丛)) == false)
            {
                    return;
            }
            
            this.丟丆东丒业专丅业不.Item[丗丟丁丐与下丙丕丛].世丂丟下不东丙丑专(丙业与丙丗丝不丈东:  丘东丏丆丑丐与丆丝);
        }
        internal void 丌丗七丘丈丁丘丅丝(int 丗丟丁丐与下丙丕丛)
        {
            if((this.丟丆东丒业专丅业不.ContainsKey(key:  丗丟丁丐与下丙丕丛)) == false)
            {
                    return;
            }
            
            this.丟丆东丒业专丅业不.Item[丗丟丁丐与下丙丕丛].丒三丏丂不下丁世丘(丙业与丙丗丝不丈东:  true);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_11:
            if((2091060248 & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if((System.Int32.TryParse(s:  val_3._value._obj.丐丏七丌丕丗业且上(), result: out  0)) == false)
            {
                goto label_11;
            }
            
            if(val_3._value._obj == 0)
            {
                goto label_11;
            }
            
            new PGCompany.丒丑丄丗丄丈丑专专() = new PGCompany.丒丑丄丗丄丈丑专专(万丝且丘不丑丝下丑:  val_3._value._obj);
            this.丟丆东丒业专丅业不.set_Item(key:  0, value:  new PGCompany.丒丑丄丗丄丈丑专专());
            goto label_11;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            .万丝且丘不丑丝下丑 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.丒丑丄丗丄丈丑专专>>(丌丛丏业世丄丞三丌:  this.丟丆东丒业专丅业不, 七丐丅专且专七三丆:  new System.Action<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.丒丑丄丗丄丈丑专专>>(object:  new 一丟不下丆丗丝丟丛.下丌丛三下专丘丐丕(), method:  System.Void 一丟不下丆丗丝丟丛.下丌丛三下专丘丐丕::与世丌丏三专丐丞丕(System.Collections.Generic.KeyValuePair<int, PGCompany.丒丑丄丗丄丈丑专专> 丐丏东世不丅丌且万)));
            return (object)(一丟不下丆丗丝丟丛.下丌丛三下专丘丐丕)[1152921541057841664].万丝且丘不丑丝下丑;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 70;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.一丟不下丆丗丝丟丛.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.一丟不下丆丗丝丟丛.丐丌丞上世丛丐丏丛;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        public 一丟不下丆丗丝丟丛()
        {
            this.丟丆东丒业专丅业不 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.丒丑丄丗丄丈丑专专>();
        }
        private static 一丟不下丆丗丝丟丛()
        {
            Progress.一丟不下丆丗丝丟丛.丕丟一七丑丙丂丆丙 = "Novice_Double_Offers_Slot";
            Progress.一丟不下丆丗丝丟丛.丐丌丞上世丛丐丏丛 = "Novice_Double_Offers_Slot_Key_APR_2021";
        }
    
    }

}

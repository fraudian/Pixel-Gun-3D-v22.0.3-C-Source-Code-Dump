using UnityEngine;

namespace Progress
{
    internal sealed class 丙丌丏丅丙不专丛丝 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal const string 下与丞丂丝丆丈丑丌 = "1";
        private System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> <世世且丁与丙丈丘丙>k__BackingField;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        internal System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> 丅不万丏下下一丝丑 { get; set; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            return "clan_item_slot";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            return "clan_item_slot_key";
        }
        internal System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> 丅丁丂不丂丏丝不丄()
        {
            return (System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>)this.<世世且丁与丙丈丘丙>k__BackingField;
        }
        private void 丝丁丕世丂与丐丟丈(System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> 丙业与丙丗丝不丈东)
        {
            this.<世世且丁与丙丈丘丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 38;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            var val_10;
            System.Func<PGCompany.一不丆三丛与上上下, PGCompany.一不丆三丛与上上下> val_12;
            var val_15;
            var val_17;
            var val_18;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_10 = null;
            val_10 = null;
            val_12 = 丙丌丏丅丙不专丛丝.<>c.<>9__11_0;
            if(val_12 == null)
            {
                    System.Func<PGCompany.一不丆三丛与上上下, PGCompany.一不丆三丛与上上下> val_2 = null;
                val_12 = val_2;
                val_2 = new System.Func<PGCompany.一不丆三丛与上上下, PGCompany.一不丆三丛与上上下>(object:  丙丌丏丅丙不专丛丝.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.一不丆三丛与上上下 丙丌丏丅丙不专丛丝.<>c::丌丒丂丁丌丑丈丏丗(PGCompany.一不丆三丛与上上下 三丟东丕丄丄下下丑));
                丙丌丏丅丙不专丛丝.<>c.<>9__11_0 = val_12;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.OrderBy<PGCompany.一不丆三丛与上上下, PGCompany.一不丆三丛与上上下>(source:  this.<世世且丁与丙丈丘丙>k__BackingField, keySelector:  val_2).GetEnumerator();
            label_24:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_5.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Text.StringBuilder val_11 = val_1.Append(value:  val_5.Current.丟丑丐丈丄丁丛丑世());
            goto label_24;
            label_16:
            val_17 = 0;
            val_18 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_15 = public System.Void System.IDisposable::Dispose();
                val_5.Dispose();
            }
            
            if(( == 1) && ( != false))
            {
                    val_15 = 0;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            this.<世世且丁与丙丈丘丙>k__BackingField = new System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>();
            UnityEngine.Debug.LogError(message:  "[" + this.GetType() + "] Cannot apply data of type " + 一丐丗丁丞丆丅丟丄.GetType());
        }
        private void 丄丆丝丌丄不丂丘业(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = 一丐丗丁丞丆丅丟丄;
            if(val_7.Count == 0)
            {
                    return;
            }
            
            object val_2 = val_7.Item["1"];
            val_8 = 0;
            val_7 = 0;
            goto label_7;
            label_14:
            if(Item[0] != null)
            {
                    val_9 = 0;
            }
            
            this.<世世且丁与丙丈丘丙>k__BackingField.Add(item:  PGCompany.一不丆三丛与上上下.且丘万丙丝丈丆专与(丏丂万业丙专丏丒丒:  null));
            val_7 = 1;
            label_7:
            if(val_7 < Count)
            {
                goto label_14;
            }
        
        }
        private void 丘一七且丘业丑丌丌(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>> 一丐丗丁丞丆丅丟丄)
        {
            var val_5 = this;
            if(一丐丗丁丞丆丅丟丄.Count == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = 一丐丗丁丞丆丅丟丄.Item["1"].GetEnumerator();
            label_7:
            if(((-2051564264) & 1) == 0)
            {
                goto label_5;
            }
            
            this.<世世且丁与丙丈丘丙>k__BackingField.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_7;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_5;
            System.Func<PGCompany.一不丆三丛与上上下, System.Collections.Generic.Dictionary<System.String, System.Object>> val_7;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>(capacity:  3);
            val_5 = null;
            val_5 = null;
            val_7 = 丙丌丏丅丙不专丛丝.<>c.<>9__15_0;
            if(val_7 == null)
            {
                    System.Func<PGCompany.一不丆三丛与上上下, System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<PGCompany.一不丆三丛与上上下, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  丙丌丏丅丙不专丛丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> 丙丌丏丅丙不专丛丝.<>c::一丆丒丆丂丛七丄丛(PGCompany.一不丆三丛与上上下 三丟东丕丄丄下下丑));
                丙丌丏丅丙不专丛丝.<>c.<>9__15_0 = val_7;
            }
            
            val_1.set_Item(key:  "1", value:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<PGCompany.一不丆三丛与上上下, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.<世世且丁与丙丈丘丙>k__BackingField, selector:  val_2)));
            return (object)val_1;
        }
        private object 丛丄丝万七丝上万万()
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>(capacity:  3);
            val_1.set_Item(key:  "1", value:  this.<世世且丁与丙丈丘丙>k__BackingField);
            return (object)val_1;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.<世世且丁与丙丈丘丙>k__BackingField.Clear();
        }
        internal override void Load()
        {
            if(this != null)
            {
                    return;
            }
            
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "data == null", args:  this);
        }
        internal override void 丂且不业丂专丛丆东()
        {
            if((System.String.IsNullOrEmpty(value:  this)) != false)
            {
                    this = System.Array.Empty<System.Object>();
                UnityEngine.Debug.LogErrorFormat(format:  "save slot dataDict == null", args:  this);
                return;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  this);
        }
        internal override string 丁丑一丁丗业丒丗不()
        {
            object val_1 = this.丛丄丝万七丝上万万();
            if(val_1 == null)
            {
                    return (string)System.String.alignConst;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1);
        }
        internal override string 业丝丛丒丄专丕万丒()
        {
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  this)) == true)
            {
                    return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this);
            }
            
            0 = "{}";
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  0);
            return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this);
        }
        internal override object 丟丗丞丕七丝世丌丞(string 丙七且丄丝丌丒万丘)
        {
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof(public System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>>>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        public 丙丌丏丅丙不专丛丝()
        {
            val_1 = new System.Object();
            goto typeof(Progress.丙丌丏丅丙不专丛丝).__il2cppRuntimeField_238;
        }
    
    }

}

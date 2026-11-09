using UnityEngine;

namespace Progress
{
    internal sealed class 与丁业丘丁丈丙丝丕 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal static readonly string 七丐丐下不丘专丗丛;
        internal static readonly string 丘且丄且丟丝万丝丞;
        private PGCompany.且丟一七万东丁三上<Subscription20.与丘丂三丂丁丏丈上> 七丄丄与世东丗丙丐;
        private System.Collections.Generic.Dictionary<int, long> 丘丘丄丗下丁三业丁;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.与丁业丘丁丈丙丝丕.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.与丁业丘丁丈丙丝丕.丐丌丞上世丛丐丏丛;
        }
        internal Subscription20.与丘丂三丂丁丏丈上 丐丛丏丌丝一丘丐丌(int 丞世不丒下上上丝丑)
        {
            var val_3;
            if((this.七丄丄与世东丗丙丐.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) != false)
            {
                    Subscription20.与丘丂三丂丁丏丈上 val_2 = this.七丄丄与世东丗丙丐.Item[丞世不丒下上上丝丑];
                return (Subscription20.与丘丂三丂丁丏丈上)val_3;
            }
            
            val_3 = 0;
            return (Subscription20.与丘丂三丂丁丏丈上)val_3;
        }
        internal long 丆三上丄丈业丕丗丛(int 丞世不丒下上上丝丑)
        {
            if((this.丘丘丄丗下丁三业丁.ContainsKey(key:  丞世不丒下上上丝丑)) == false)
            {
                    return 0;
            }
            
            if(this.丘丘丄丗下丁三业丁 != null)
            {
                    return this.丘丘丄丗下丁三业丁.Item[丞世不丒下上上丝丑];
            }
            
            return this.丘丘丄丗下丁三业丁.Item[丞世不丒下上上丝丑];
        }
        internal void 下丌业业丐丘丐丘三(int 丞世不丒下上上丝丑, long 专丌万丑三丙丕丙丝, System.Nullable<long> 丈丝丛丈丐丝七丌业)
        {
            int val_6 = 丞世不丒下上上丝丑;
            if((this.七丄丄与世东丗丙丐.ContainsKey(下上丐丆丝丟丝丒不:  val_6 = 丞世不丒下上上丝丑)) != true)
            {
                    this.七丄丄与世东丗丙丐.set_Item(下上丐丆丝丟丝丒不:  val_6, 丙业与丙丗丝不丈东:  new Subscription20.与丘丂三丂丁丏丈上());
            }
            
            this.七丄丄与世东丗丙丐.Item[val_6].丒上七丐三业丅丈一(丙业与丙丗丝不丈东:  专丌万丑三丙丕丙丝);
            this.七丄丄与世东丗丙丐.Item[val_6].一不丟三世丛丌下丝(丙业与丙丗丝不丈东:  false);
            if(( & 1) == 0)
            {
                    return;
            }
            
            val_6 = this.七丄丄与世东丗丙丐.Item[val_6];
            val_6.丈丕上丄业丏万东丟(丙业与丙丗丝不丈东:  null);
        }
        internal void 丒丆丞丛丟万丟与丘(int 丞世不丒下上上丝丑, long 丞丏一丏丝且三丝丛)
        {
            if((this.七丄丄与世东丗丙丐.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            this.七丄丄与世东丗丙丐.Item[丞世不丒下上上丝丑].不东丛丘丟丙丆丆下(丙业与丙丗丝不丈东:  丞丏一丏丝且三丝丛);
        }
        internal void 丈丒丟丟万丗丌丗丘(int 丞世不丒下上上丝丑, long 丝丙一丝丈丂不丙一)
        {
            this.丘丘丄丗下丁三业丁.set_Item(key:  丞世不丒下上上丝丑, value:  丝丙一丝丈丂不丙一);
        }
        internal void 七丁丝下丏与丒丅丈(int 丞世不丒下上上丝丑)
        {
            if((this.七丄丄与世东丗丙丐.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            this.七丄丄与世东丗丙丐.Item[丞世不丒下上上丝丑].一不丟三世丛丌下丝(丙业与丙丗丝不丈东:  true);
        }
        internal void 与丕丈上一上丏丅万(int 丞世不丒下上上丝丑)
        {
            if((this.七丄丄与世东丗丙丐.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            bool val_2 = this.七丄丄与世东丗丙丐.Remove(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            string val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_26 = this;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_27 = 1152921504689381376;
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0;
            val_28 = null;
            val_28 = null;
            val_29 = 1152921516630043280;
            if((val_1.ContainsKey(key:  Progress.与丁业丘丁丈丙丝丕.七丐丐下不丘专丗丛)) == false)
            {
                goto label_33;
            }
            
            val_30 = null;
            val_30 = null;
            object val_3 = val_1.Item[Progress.与丁业丘丁丈丙丝丕.七丐丐下不丘专丗丛];
            if(val_3 == null)
            {
                goto label_33;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = val_3.GetEnumerator();
            label_24:
            if(((-1853107184) & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
            System.ValueTuple<System.Int32, System.Boolean> val_10 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8._value._obj.丐丏七丌丕丗业且上());
            if(((ulong)(val_10.Item2 >> 32) & 255) == 0)
            {
                goto label_24;
            }
            
            if(val_8._value._obj == 0)
            {
                goto label_24;
            }
            
            System.ValueTuple<System.Int32, System.Boolean> val_12 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8._value._obj.丐丏七丌丕丗业且上());
            new Subscription20.与丘丂三丂丁丏丈上() = new Subscription20.与丘丂三丂丁丏丈上(万丝且丘不丑丝下丑:  val_8._value._obj);
            this.七丄丄与世东丗丙丐.set_Item(下上丐丆丝丟丝丒不:  val_12.Item2, 丙业与丙丗丝不丈东:  new Subscription20.与丘丂三丂丁丏丈上());
            goto label_24;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_33:
            val_31 = null;
            val_31 = null;
            val_25 = Progress.与丁业丘丁丈丙丝丕.丘且丄且丟丝万丝丞;
            if((val_1.ContainsKey(key:  val_25)) == false)
            {
                    return;
            }
            
            val_32 = null;
            val_32 = null;
            val_25 = Progress.与丁业丘丁丈丙丝丕.丘且丄且丟丝万丝丞;
            object val_15 = val_1.Item[val_25];
            if(val_15 == null)
            {
                    return;
            }
            
            val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
            Dictionary.Enumerator<TKey, TValue> val_16 = val_1.GetEnumerator();
            val_27 = 1152921516595686816;
            val_29 = 1152921516595685792;
            label_55:
            if(((-1853107184) & 1) == 0)
            {
                goto label_45;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_7.GetAwaiter();
            System.ValueTuple<System.Int32, System.Boolean> val_19 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_17._value._obj.丐丏七丌丕丗业且上());
            if(((ulong)(val_19.Item2 >> 32) & 255) == 0)
            {
                goto label_55;
            }
            
            System.ValueTuple<System.Int64, System.Boolean> val_20 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丗三丆东不丟丄三业(万且万且丑丗且丌丆:  val_17._value._obj);
            if(0 == 0)
            {
                goto label_55;
            }
            
            System.ValueTuple<System.Int32, System.Boolean> val_22 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_17._value._obj.丐丏七丌丕丗业且上());
            System.ValueTuple<System.Int64, System.Boolean> val_23 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丗三丆东不丟丄三业(万且万且丑丗且丌丆:  val_17._value._obj);
            this.丘丘丄丗下丁三业丁.set_Item(key:  val_22.Item2, value:  val_23.Item2);
            goto label_55;
            label_45:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Int64> val_7;
            var val_8;
            System.Collections.Generic.Dictionary<System.Int32, System.Int64> val_9;
            var val_10;
            val_7 = this;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            .三七一丑丄丐且东丌 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(this.七丄丄与世东丗丙丐.Count >= 1)
            {
                    丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.Int32, Subscription20.与丘丂三丂丁丏丈上>>(丌丛丏业世丄丞三丌:  this.七丄丄与世东丗丙丐, 七丐丅专且专七三丆:  new System.Action<System.Collections.Generic.KeyValuePair<System.Int32, Subscription20.与丘丂三丂丁丏丈上>>(object:  new 与丁业丘丁丈丙丝丕.与丟业一丈上丅上不(), method:  System.Void 与丁业丘丁丈丙丝丕.与丟业一丈上丅上不::与世丌丏三专丐丞丕(System.Collections.Generic.KeyValuePair<int, Subscription20.与丘丂三丂丁丏丈上> 丐丏东世不丅丌且万)));
            }
            
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  Progress.与丁业丘丁丈丙丝丕.七丐丐下不丘专丗丛, value:  (与丁业丘丁丈丙丝丕.与丟业一丈上丅上不)[1152921541408684544].三七一丑丄丐且东丌);
            val_9 = this.丘丘丄丗下丁三业丁;
            if(val_9.Count < 1)
            {
                    return (object)val_2;
            }
            
            val_10 = null;
            val_10 = null;
            val_7 = this.丘丘丄丗下丁三业丁;
            val_9 = Progress.与丁业丘丁丈丙丝丕.丘且丄且丟丝万丝丞;
            val_2.set_Item(key:  val_9, value:  val_7);
            return (object)val_2;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.七丄丄与世东丗丙丐.Clear();
            this.丘丘丄丗下丁三业丁.Clear();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 78;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        public 与丁业丘丁丈丙丝丕()
        {
            this.七丄丄与世东丗丙丐 = new PGCompany.且丟一七万东丁三上<丙东丕丌下丄不丐不>();
            this.丘丘丄丗下丁三业丁 = new System.Collections.Generic.Dictionary<System.Int32, System.Int64>();
        }
        private static 与丁业丘丁丈丙丝丕()
        {
            Progress.与丁业丘丁丈丙丝丕.丕丟一七丑丙丂丆丙 = "Subscription_20_Slot";
            Progress.与丁业丘丁丈丙丝丕.丐丌丞上世丛丐丏丛 = "Subscription_20__Slot_Key_NOV_2021";
            Progress.与丁业丘丁丈丙丝丕.七丐丐下不丘专丗丛 = "s";
            Progress.与丁业丘丁丈丙丝丕.丘且丄且丟丝万丝丞 = "bv";
        }
    
    }

}

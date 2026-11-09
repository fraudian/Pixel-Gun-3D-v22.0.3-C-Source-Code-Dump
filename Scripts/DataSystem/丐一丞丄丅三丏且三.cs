using UnityEngine;

namespace DataSystem
{
    internal sealed class 丐一丞丄丅三丏且三 : 丌丈丕丑丛丕世丒世
    {
        // Fields
        private readonly System.Type 丈丂与丐不且丑一下;
        
        // Methods
        public string 丙业不丝丗丌丗世下(object 万且万且丑丗且丌丆)
        {
            var val_6;
            object val_15;
            var val_16;
            var val_17;
            val_15 = 万且万且丑丗且丌丆;
            val_16 = 0;
            return (string)val_16;
            label_14:
            if(((-1261449072) & 1) == 0)
            {
                goto label_10;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_6.GetAwaiter();
            System.Globalization.CultureInfo val_10 = System.Globalization.CultureInfo.InvariantCulture;
            Add(key:  val_8._value._obj.丐丏七丌丕丗业且上(), value:  null);
            goto label_14;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_17 = 0;
            val_16 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  null);
            PGCompany.七丑一上且三世丝三<K, V> val_14 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
            return (string)val_16;
        }
        public T 丂东专丙丒丏且丛丁<T>(string 丞丕丒专一下丙业上)
        {
            var val_5;
            var val_6;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = 0;
            if((System.Type.op_Inequality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), right:  this.丈丂与丐不且丑一下)) == true)
            {
                    return (object)val_6;
            }
            
            object val_3 = this.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  丞丕丒专一下丙业上, 丁丅丈丌丟世丗丗丟:  this.丈丂与丐不且丑一下);
            val_5 = mem[__RuntimeMethodHiddenParam + 48 + 8];
            val_5 = __RuntimeMethodHiddenParam + 48 + 8;
            if(val_3 != null)
            {
                    val_6 = val_3;
                if(val_6 != null)
            {
                    return (object)val_6;
            }
            
            }
            
            val_6 = 0;
            return (object)val_6;
        }
        public object 丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上, System.Type 丁丅丈丌丟世丗丗丟)
        {
            System.Type val_9;
            var val_10;
            val_9 = this.丈丂与丐不且丑一下;
            val_10 = 0;
            if((System.Type.op_Inequality(left:  丁丅丈丌丟世丗丗丟, right:  val_9)) == true)
            {
                    return (object)val_10;
            }
            
            DataSystem.丈且丈上不下且丝丒 val_2 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            val_9 = public System.Collections.Generic.Dictionary<System.String, System.String> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.Dictionary<System.String, System.String>>(string 丞丕丒专一下丙业上);
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_2 == null)
            {
                goto label_11;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.DateTime> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.String, System.DateTime>();
            Dictionary.Enumerator<TKey, TValue> val_5 = val_2.GetEnumerator();
            label_16:
            if(((-1261129816) & 1) == 0)
            {
                goto label_12;
            }
            
            ConfiguredValueTaskAwaiter val_6 = 0.GetAwaiter();
            System.DateTime val_8 = System.Convert.ToDateTime(value:  val_6._value._obj);
            val_4.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  new System.DateTime() {dateData = val_8.dateData});
            goto label_16;
            label_11:
            val_10 = 0;
            return (object)val_10;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_10;
        }
        public 丐一丞丄丅三丏且三()
        {
            this.丈丂与丐不且丑一下 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}

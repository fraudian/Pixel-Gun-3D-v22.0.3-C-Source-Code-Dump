using UnityEngine;

namespace Progress
{
    internal sealed class 丏丛七专丐不丅丐丆
    {
        // Fields
        internal static readonly string 丕东丝丈丙上丌东丝;
        internal static readonly string 丝万丂万丏一丂丈三;
        internal static readonly string 不七丘丈丅丞丐业万;
        internal static readonly string 丘丄与丟丄丙丏且丏;
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑 专丞丙一丟专丞与丗)
        {
            object val_18;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(专丞丙一丟专丞与丗.与三丌专丒下丏丏丏() != 0)
            {
                    val_1.set_Item(key:  "ls", value:  专丞丙一丟专丞与丗.与三丌专丒下丏丏丏());
            }
            
            if(专丞丙一丟专丞与丗.世万丅丞下丌丐不丈() != 0)
            {
                    val_1.set_Item(key:  "cs", value:  专丞丙一丟专丞与丗.世万丅丞下丌丐不丈());
            }
            
            if(专丞丙一丟专丞与丗.且丛丈丝丘丈一丙丟() != false)
            {
                    val_1.set_Item(key:  "ms", value:  1);
            }
            
            if(专丞丙一丟专丞与丗.七丝丁丗七丆下丈丌() != false)
            {
                    val_1.set_Item(key:  "as", value:  1);
            }
            
            if((专丞丙一丟专丞与丗.丞丞丘业东丙丏七丌() & 2147483648) == 0)
            {
                    int val_9 = 专丞丙一丟专丞与丗.丞丞丘业东丙丏七丌();
                val_1.set_Item(key:  "lg", value:  val_9);
            }
            
            val_18 = 专丞丙一丟专丞与丗.下丙三丗丗丕丂丁丞();
            if(val_18.Count == 0)
            {
                    return val_1;
            }
            
            System.Collections.Generic.List<System.Int32> val_12 = null;
            val_18 = val_12;
            val_12 = new System.Collections.Generic.List<System.Int32>();
            List.Enumerator<T> val_14 = 专丞丙一丟专丞与丗.下丙三丗丗丕丂丁丞().GetEnumerator();
            label_26:
            if((2118147120 & 1) == 0)
            {
                goto label_24;
            }
            
            ConfiguredValueTaskAwaiter val_16 = val_9.GetAwaiter();
            val_12.Add(item:  2118147104);
            goto label_26;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_1.set_Item(key:  "rr", value:  val_12);
            return val_1;
        }
        internal Progress.专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_25;
            专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑 val_1 = new 专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑();
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "ls")) != false)
            {
                    val_1.丝世且丏丂丂且丈与(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["ls"], provider:  System.Globalization.CultureInfo.InvariantCulture));
            }
            
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "ms")) != false)
            {
                    System.IFormatProvider val_32 = System.Globalization.CultureInfo.InvariantCulture;
                val_32 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item["ms"], provider:  val_32);
                val_1.不东丗丏七丈且丁一(丙业与丙丗丝不丈东:  val_32);
            }
            
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "cs")) != false)
            {
                    val_1.丝一丈丟丏专一丑丐(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["cs"], provider:  System.Globalization.CultureInfo.InvariantCulture));
            }
            
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "as")) != false)
            {
                    System.IFormatProvider val_33 = System.Globalization.CultureInfo.InvariantCulture;
                val_33 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item["as"], provider:  val_33);
                val_1.三东上东丝业丂世丆(丙业与丙丗丝不丈东:  val_33);
            }
            
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "lg")) != false)
            {
                    val_1.丁三丛三丙丄丆世丑(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["lg"], provider:  System.Globalization.CultureInfo.InvariantCulture));
            }
            
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "rr")) == false)
            {
                    return (丕三丁东东丈丕三丑)val_1;
            }
            
            if(一丐丗丁丞丆丅丟丄.Item["rr"] == null)
            {
                    return (丕三丁东东丈丕三丑)val_1;
            }
            
            return (丕三丁东东丈丕三丑)val_1;
            label_53:
            if((2118361504 & 1) == 0)
            {
                goto label_47;
            }
            
            bool val_31 = val_1.丄丝下丙丅且丘丞丏(丈丘丝一丗下丈丐不:  System.Convert.ToInt32(value:  val_25.丐丏七丌丕丗业且上(), provider:  System.Globalization.CultureInfo.InvariantCulture));
            goto label_53;
            label_47:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (丕三丁东东丈丕三丑)val_1;
        }
        public 丏丛七专丐不丅丐丆()
        {
        
        }
        private static 丏丛七专丐不丅丐丆()
        {
            Progress.丏丛七专丐不丅丐丆.丕东丝丈丙上丌东丝 = "l";
            Progress.丏丛七专丐不丅丐丆.丝万丂万丏一丂丈三 = "t";
            Progress.丏丛七专丐不丅丐丆.不七丘丈丅丞丐业万 = "cs";
            Progress.丏丛七专丐不丅丐丆.丘丄与丟丄丙丏且丏 = "ms";
        }
    
    }

}

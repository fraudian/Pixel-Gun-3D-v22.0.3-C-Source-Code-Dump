using UnityEngine;

namespace Progress
{
    internal static class 丗东丞丆丆丝丒丌专
    {
        // Fields
        private static System.Security.Cryptography.HashAlgorithm 与丕丑丛丕下丟丗丄;
        
        // Properties
        private static System.Security.Cryptography.HashAlgorithm 万业业丛下丏丛丄丆 { get; }
        
        // Methods
        private static System.Security.Cryptography.HashAlgorithm 下丘丑丆丅丈丂三万()
        {
            System.Security.Cryptography.HashAlgorithm val_2 = Progress.丗东丞丆丆丝丒丌专.与丕丑丛丕下丟丗丄;
            if(val_2 != null)
            {
                    return (System.Security.Cryptography.HashAlgorithm)val_2;
            }
            
            Progress.丗东丞丆丆丝丒丌专.与丕丑丛丕下丟丗丄 = System.Security.Cryptography.MD5.Create();
            val_2 = Progress.丗东丞丆丆丝丒丌专.与丕丑丛丕下丟丗丄;
            return (System.Security.Cryptography.HashAlgorithm)val_2;
        }
        internal static string 且丁上一丞丅丐丞丘(string 丑东与丅丐丅丂丞业)
        {
            string val_5 = System.BitConverter.ToString(value:  Progress.丗东丞丆丆丝丒丌专.下丘丑丆丅丈丂三万().ComputeHash(buffer:  System.Text.Encoding.UTF8)).Replace(oldValue:  "-", newValue:  "");
            if(val_5 != null)
            {
                    return val_5.ToLowerInvariant();
            }
            
            return val_5.ToLowerInvariant();
        }
        internal static string 丒丟丟一万丅三丑丛(object 下下丏一丙不丘丌丞)
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            Progress.丗东丞丆丆丝丒丌专.丒丐东且专丏业丝丙(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞, 丑万丕丝三且一丝丄: ref  val_1);
            if(val_1 != 0)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        private static void 丒丐东且专丏业丝丙(object 下下丏一丙不丘丌丞, ref System.Text.StringBuilder 丑万丕丝三且一丝丄)
        {
            var val_14;
            object val_27;
            System.IFormatProvider val_28;
            var val_30;
            var val_34;
            var val_35;
            var val_38;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_46;
            val_27 = 下下丏一丙不丘丌丞;
            val_28 = val_27;
            if(val_28 == null)
            {
                goto label_1;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_5;
            label_1:
            val_30 = 0;
            goto label_55;
            label_5:
            System.Collections.Generic.List<System.Object> val_3 = new System.Collections.Generic.List<System.Object>();
            var val_34 = 0;
            val_34 = val_34 + 1;
            System.Collections.IEnumerator val_5 = val_28.Keys.GetEnumerator();
            label_24:
            var val_35 = 0;
            val_35 = val_35 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_3.Add(item:  val_5.Current);
            goto label_24;
            label_17:
            val_34 = 0;
            val_35 = 0;
            if(val_5 != null)
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_5.Dispose();
            }
            
            if(( != 1) && (77 == 77))
            {
                    val_34 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_35 = 0;
            }
            
            }
            
            System.Comparison<System.Object> val_11 = new System.Comparison<System.Object>(object:  0, method:  public static System.Int32 Progress.丗东丞丆丆丝丒丌专::丟东三世业不丄丛三(object 且丄东东丒丁丙丄丝, object 业不丈丝丗丙丛东丄));
            if(val_3 != null)
            {
                    val_3.Sort(comparison:  val_11);
            }
            else
            {
                    val_3.Sort(comparison:  val_11);
            }
            
            List.Enumerator<T> val_12 = val_3.GetEnumerator();
            label_47:
            if(((-1917215968) & 1) == 0)
            {
                goto label_40;
            }
            
            string val_15 = val_14.丐丏七丌丕丗业且上();
            val_38 = 0;
            System.Text.StringBuilder val_16 = 丑万丕丝三且一丝丄.Append(value:  val_15);
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_38 = 0;
            object val_18 = val_28.Item[val_15];
            goto label_47;
            label_40:
            val_30 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_30 != 1)
            {
                    if(347 == 347)
            {
                    return;
            }
            
            }
            
            label_55:
            val_40 = null;
            if(val_27 == null)
            {
                goto label_93;
            }
            
            if(val_27 == null)
            {
                goto label_57;
            }
            
            val_41 = null;
            val_40 = null;
            val_42 = val_27;
            if(val_42 != null)
            {
                goto label_59;
            }
            
            val_40 = 0;
            goto label_60;
            label_57:
            val_41 = null;
            label_60:
            val_42 = 0;
            label_59:
            if(mem[282584257676957] == 0)
            {
                goto label_61;
            }
            
            var val_39 = mem[282584257676847];
            var val_40 = 0;
            val_39 = val_39 + 8;
            label_63:
            if(((mem[282584257676847] + 8) + -8) == val_41)
            {
                goto label_62;
            }
            
            val_40 = val_40 + 1;
            val_39 = val_39 + 16;
            if(val_40 < mem[282584257676957])
            {
                goto label_63;
            }
            
            label_61:
            val_40 = val_41;
            goto label_64;
            label_62:
            val_42 = val_42 + (((mem[282584257676847] + 8)) << 4);
            val_43 = val_42 + 296;
            label_64:
            System.Collections.IEnumerator val_19 = val_42.GetEnumerator();
            label_77:
            var val_41 = 0;
            val_41 = val_41 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_70;
            }
            
            var val_42 = 0;
            val_42 = val_42 + 1;
            object val_23 = val_19.Current;
            goto label_77;
            label_70:
            val_46 = 0;
            val_35 = 1152921504621703168;
            val_28 = val_19;
            if(val_28 != null)
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_28.Dispose();
            }
            
            if(2 != 1)
            {
                    if(347 == 347)
            {
                    return;
            }
            
            }
            
            label_93:
            if(val_27 != null)
            {
                    if(null == null)
            {
                goto label_97;
            }
            
            }
            
            val_28 = System.Globalization.CultureInfo.InvariantCulture;
            val_27 = System.Convert.ToString(value:  val_27, provider:  val_28);
            label_106:
            System.Text.StringBuilder val_28 = 丑万丕丝三且一丝丄.Append(value:  val_27);
            return;
            label_97:
            string val_30 = null.ToString(format:  "F2", provider:  System.Globalization.CultureInfo.InvariantCulture);
            if(丑万丕丝三且一丝丄 != null)
            {
                goto label_106;
            }
            
            goto label_106;
        }
        public static int 丟东三世业不丄丛三(object 且丄东东丒丁丙丄丝, object 业不丈丝丗丙丛东丄)
        {
            return System.String.CompareOrdinal(strA:  System.Convert.ToString(value:  且丄东东丒丁丙丄丝, provider:  System.Globalization.CultureInfo.InvariantCulture), strB:  System.Convert.ToString(value:  业不丈丝丗丙丛东丄, provider:  System.Globalization.CultureInfo.InvariantCulture));
        }
    
    }

}

using UnityEngine;

namespace PGCompany.AttributeSystem
{
    public static class 与丝丁万下丞三与丗
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>> 丆丘七丒丁丐丛东丐;
        
        // Methods
        internal static bool 丙下一丆下丄丟丁且(string 丈丘丗与丒丌丁且三, PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 一丗与世且丂三专专, ref System.Collections.Generic.List<int> 专丂丕丗丗东世丞下)
        {
            var val_6;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>> val_24;
            System.Collections.Generic.List<System.Int32> val_25;
            var val_26;
            val_19 = 丈丘丗与丒丌丁且三;
            val_20 = null;
            val_20 = null;
            if((PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐.ContainsKey(key:  val_19)) == false)
            {
                goto label_4;
            }
            
            val_21 = null;
            val_21 = null;
            if(PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐.Item[val_19] == null)
            {
                goto label_8;
            }
            
            label_21:
            if(一丗与世且丂三专专 != 99)
            {
                goto label_26;
            }
            
            val_22 = null;
            val_22 = null;
            List.Enumerator<T> val_4 = PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐.Item[val_19].GetEnumerator();
            val_23 = 1152921560574250576;
            label_17:
            if((132866224 & 1) == 0)
            {
                goto label_31;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_6.丐丏七丌丕丗业且上().丘上丁丈专丛丝丏丕());
            goto label_17;
            label_4:
            System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业> val_9 = new System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>();
            bool val_10 = PGCompany.AttributeSystem.与丝丁万下丞三与丗.三七丏丕一丟下东业(不丝世不丈丏专万丅:  val_19, 丌丌且三丒东专丒东: ref  val_9);
            val_24 = PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐;
            val_24.Add(key:  val_19, value:  val_9);
            if(val_9 != null)
            {
                goto label_21;
            }
            
            label_8:
            val_25 = 0;
            return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  val_25 = 专丂丕丗丗东世丞下);
            label_26:
            val_26 = null;
            val_26 = null;
            val_19 = PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐.Item[val_19];
            List.Enumerator<T> val_12 = val_19.GetEnumerator();
            val_24 = 1152921560574250576;
            val_23 = 1152921516995548064;
            label_36:
            if((132866224 & 1) == 0)
            {
                goto label_31;
            }
            
            string val_13 = val_6.丐丏七丌丕丗业且上();
            if(val_13.不业丙丒丂丞下丆丙() != 一丗与世且丂三专专)
            {
                goto label_36;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_13.丘上丁丈专丛丝丏丕());
            goto label_36;
            label_31:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  val_25);
        }
        internal static void 丗丝丗丒七上丘上丘()
        {
            null = null;
            PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐.Clear();
        }
        internal static bool 三七丏丕一丟下东业(string 不丝世不丈丏专万丅, ref System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业> 丌丌且三丒东专丒东)
        {
            var val_16;
            char val_17;
            var val_18;
            val_16 = 0;
            goto label_1;
            label_18:
            val_17 = 不丝世不丈丏专万丅.Chars[0];
            if((System.Char.IsDigit(c:  val_17)) != false)
            {
                
            }
            else
            {
                    if(0 >= 4)
            {
                    string val_3 = 不丝世不丈丏专万丅.Substring(startIndex:  0, length:  0);
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_3, 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    if(val_3 != null)
            {
                    val_18 = val_3.IndexOf(value:  "201", comparisonType:  4);
            }
            else
            {
                    val_18 = 0.IndexOf(value:  "201", comparisonType:  4);
            }
            
                PGCompany.AttributeSystem.东丙七一丑丙丝丞业 val_11 = new PGCompany.AttributeSystem.东丙七一丑丙丝丞业(丁丅丈丌丟世丗丗丟:  (val_18 != (val_3.Length - 3)) ? (1 + 1) : 1, 业三丝丌七丑三丏丛:  0);
                val_17 = 丌丌且三丒东专丒东;
                if((val_17.Contains(item:  val_11)) != true)
            {
                    val_17 = 丌丌且三丒东专丒东;
                val_17.Add(item:  val_11);
            }
            
            }
            
            }
            
            }
            
            val_16 = 1;
            label_1:
            if(val_16 < 不丝世不丈丏专万丅.Length)
            {
                goto label_18;
            }
            
            return (bool)System.Linq.Enumerable.Any<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>(source:  丌丌且三丒东专丒东);
        }
        internal static bool 东丕丑丌丟七一三且(string 丈丘丗与丒丌丁且三, int 丆且丁丒丒丆丁三丆, PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 一丗与世且丂三专专)
        {
            var val_6;
            PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 val_10;
            var val_12;
            val_10 = 一丗与世且丂三专专;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((PGCompany.AttributeSystem.与丝丁万下丞三与丗.丙下一丆下丄丟丁且(丈丘丗与丒丌丁且三:  丈丘丗与丒丌丁且三, 一丗与世且丂三专专:  val_10, 专丂丕丗丗东世丞下: ref  val_1)) == false)
            {
                goto label_6;
            }
            
            List.Enumerator<T> val_4 = val_1.GetEnumerator();
            label_9:
            if((133296320 & 1) == 0)
            {
                goto label_8;
            }
            
            if(val_6.丙东专丂世丈丏丁丂() != 丆且丁丒丒丆丁三丆)
            {
                goto label_9;
            }
            
            val_12 = 1;
            goto label_10;
            label_6:
            val_12 = 0;
            return (bool);
            label_8:
            val_12 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_10 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            return (bool);
        }
        internal static PGCompany.丁丑丘下丒丟丆丝三<byte> 丘万丒七丝业丈七丕(System.Collections.Generic.IReadOnlyList<PGCompany.Attributes.丙丗丗丌丗丞丑丒专> 丅丙丛丙丗丌丈丕丞)
        {
            var val_16;
            var val_27;
            var val_31;
            var val_32;
            var val_34;
            var val_35;
            var val_36;
            string val_37;
            var val_38;
            System.Func<System.Int32, System.String> val_40;
            var val_41;
            System.Func<System.String, System.String, System.String> val_43;
            var val_44;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            PGCompany.东丑丒丗一丞下丙丙<T> val_2 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_27 = 0;
            System.Collections.Generic.IEnumerator<T> val_4 = 丅丙丛丙丗丌丈丕丞.GetEnumerator();
            label_28:
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_27 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            T val_8 = val_4.Current;
            if(((val_8 + 16) == 0) || ((val_8 + 24) == 0))
            {
                goto label_28;
            }
            
            bool val_10 = PGCompany.AttributeSystem.与丝丁万下丞三与丗.丙下一丆下丄丟丁且(丈丘丗与丒丌丁且三:  val_8 + 16, 一丗与世且丂三专专:  99, 专丂丕丗丗东世丞下: ref  val_1);
            val_2.Add(item:  (val_8 + 24) + 16);
            goto label_28;
            label_15:
            val_31 = 0;
            val_32 = 0;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                val_27 = 0;
                val_4.Dispose();
            }
            
            if(( != 1) && (132 == 132))
            {
                    val_31 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_27 = 0;
                val_32 = 0;
            }
            
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_13 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            List.Enumerator<T> val_14 = val_2.GetEnumerator();
            label_57:
            if((133477216 & 1) == 0)
            {
                goto label_51;
            }
            
            int val_17 = val_16.丙东专丂世丈丏丁丂();
            if(((val_1.Contains(item:  val_17)) == false) || ((val_13.Contains(item:  val_17)) == true))
            {
                goto label_57;
            }
            
            val_13.Add(item:  val_17);
            goto label_57;
            label_51:
            val_35 = 1152921505630273536;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(1 == 1)
            {
                goto label_63;
            }
            
            if(( == 0) || (217 == 217))
            {
                goto label_86;
            }
            
            label_85:
            val_34 = 0;
            label_86:
            val_36 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            PGCompany.东丑丒丗一丞下丙丙<T> val_21 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((System.Linq.Enumerable.Any<System.Int32>(source:  val_13)) != false)
            {
                    val_38 = null;
                val_38 = null;
                val_40 = 与丝丁万下丞三与丗.<>c.<>9__5_0;
                if(val_40 == null)
            {
                    System.Func<System.Int32, System.String> val_23 = null;
                val_40 = val_23;
                val_23 = new System.Func<System.Int32, System.String>(object:  与丝丁万下丞三与丗.<>c.__il2cppRuntimeField_static_fields, method:  System.String 与丝丁万下丞三与丗.<>c::丏丅世上丝丆万丒东(int 七丞丙丒三丕且丌丟));
                与丝丁万下丞三与丗.<>c.<>9__5_0 = val_40;
            }
            
                val_41 = null;
                val_41 = null;
                val_43 = 与丝丁万下丞三与丗.<>c.<>9__5_1;
                if(val_43 == null)
            {
                    System.Func<System.String, System.String, System.String> val_25 = null;
                val_43 = val_25;
                val_25 = new System.Func<System.String, System.String, System.String>(object:  与丝丁万下丞三与丗.<>c.__il2cppRuntimeField_static_fields, method:  System.String 与丝丁万下丞三与丗.<>c::丏东丙丈丒世丌世丈(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                与丝丁万下丞三与丗.<>c.<>9__5_1 = val_43;
            }
            
                val_37 = " exists in Expression and AttrAction together!";
                val_44 = "attributes " + System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  val_13, selector:  val_23), func:  val_25)(System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  val_13, selector:  val_23), func:  val_25)) + val_37;
            }
            else
            {
                    val_44 = 0;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_28 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            mem2[0] = 0;
            var val_29 = (val_44 == 0) ? 1 : 0;
            mem2[0] = 0;
            mem2[0] = 0;
            return (PGCompany.丁丑丘下丒丟丆丝三<System.Byte>)X8;
            label_63:
            if( != 0)
            {
                goto label_85;
            }
            
            goto label_86;
        }
        private static 与丝丁万下丞三与丗()
        {
            PGCompany.AttributeSystem.与丝丁万下丞三与丗.丆丘七丒丁丐丛东丐 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>>();
        }
    
    }

}

using UnityEngine;

namespace TagSystem
{
    internal static class 专与丈上丅上丘东万
    {
        // Fields
        internal const char 一丛丕丙丐丛丝丌七 = '\x2e';
        private static readonly System.Text.StringBuilder 丅丅三丑丆东丈丅丑;
        
        // Methods
        internal static bool 下业下上丞且业上不(string 丆万一不丌且东丐丐, ref System.Collections.Generic.List<string> 专丂丕丗丗东世丞下)
        {
            var val_12;
            var val_13;
            System.Collections.Generic.List<System.String> val_14;
            var val_15;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) != false)
            {
                    return false;
            }
            
            val_12 = 0;
            val_13 = 0;
            goto label_4;
            label_11:
            if(137105408 >= 0.Length)
            {
                goto label_5;
            }
            
            label_12:
            if((137105408 >= 1) && ((丆万一不丌且东丐丐.Chars[137105408] & 65535) == '.'))
            {
                    专丂丕丗丗东世丞下.Add(item:  丆万一不丌且东丐丐.Substring(startIndex:  1, length:  0));
            }
            
            val_12 = 1;
            val_13 = val_13;
            label_4:
            val_14 = val_12 + 1;
            if(丆万一不丌且东丐丐 == null)
            {
                goto label_11;
            }
            
            if(val_14 < 丆万一不丌且东丐丐.Length)
            {
                goto label_12;
            }
            
            label_5:
            if(丆万一不丌且东丐丐.Length <= val_13)
            {
                    return System.Linq.Enumerable.Any<System.String>(source:  专丂丕丗丗东世丞下);
            }
            
            if(丆万一不丌且东丐丐 != null)
            {
                    val_15 = 丆万一不丌且东丐丐.Length;
            }
            else
            {
                    val_15 = 0.Length;
            }
            
            val_14 = 专丂丕丗丗东世丞下;
            val_14.Add(item:  丆万一不丌且东丐丐.Substring(startIndex:  val_13 + 1, length:  val_15 + val_13));
            return System.Linq.Enumerable.Any<System.String>(source:  专丂丕丗丗东世丞下);
        }
        internal static bool 丟丘丌丄丘丐世且丁(string 丆万一不丌且东丐丐, ref System.Collections.Generic.List<string> 东且丁丆丛丁丏丘且)
        {
            var val_9;
            System.Collections.Generic.List<System.String> val_10;
            if(丆万一不丌且东丐丐 == null)
            {
                    return false;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) == true)
            {
                    return false;
            }
            
            if(东且丁丆丛丁丏丘且 == null)
            {
                    return false;
            }
            
            东且丁丆丛丁丏丘且.Add(item:  丆万一不丌且东丐丐);
            if((丆万一不丌且东丐丐.IndexOf(value:  '.')) < 1)
            {
                    return System.Linq.Enumerable.Any<System.String>(source:  东且丁丆丛丁丏丘且);
            }
            
            if(丆万一不丌且东丐丐.Length < 1)
            {
                    return System.Linq.Enumerable.Any<System.String>(source:  东且丁丆丛丁丏丘且);
            }
            
            do
            {
                if((0 >= 1) && ((丆万一不丌且东丐丐.Chars[0] & 65535) == '.'))
            {
                    string val_6 = 丆万一不丌且东丐丐.Substring(startIndex:  0, length:  0);
                val_10 = 东且丁丆丛丁丏丘且;
                if((val_10.Contains(item:  val_6)) != true)
            {
                    val_10 = 东且丁丆丛丁丏丘且;
                val_10.Add(item:  val_6);
            }
            
            }
            
                val_9 = 0 + 1;
            }
            while(val_9 < 丆万一不丌且东丐丐.Length);
            
            return System.Linq.Enumerable.Any<System.String>(source:  东且丁丆丛丁丏丘且);
        }
        internal static int 丞丁专下丆丒上业丝(string 丆万一不丌且东丐丐)
        {
            var val_6;
            var val_7;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) != false)
            {
                    val_6 = 0;
                return (int)((丆万一不丌且东丐丐.Chars[0] & 65535) == '.') ? (val_6 + 1) : (val_6);
            }
            
            val_7 = 0;
            val_6 = 1;
            goto label_5;
            label_8:
            val_7 = 1;
            label_5:
            if(val_7 < 丆万一不丌且东丐丐.Length)
            {
                goto label_8;
            }
            
            return (int)((丆万一不丌且东丐丐.Chars[0] & 65535) == '.') ? (val_6 + 1) : (val_6);
        }
        internal static bool 专丒丅丒丘三上丙丂(string 丆万一不丌且东丐丐, string 一丂丄丌丈丄丏丒专)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  一丂丄丌丈丄丏丒专)) == true)
            {
                    return false;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) == true)
            {
                    return false;
            }
            
            if(丆万一不丌且东丐丐.Length < 一丂丄丌丈丄丏丒专.Length)
            {
                    return false;
            }
            
            var val_6 = ((丆万一不丌且东丐丐.IndexOf(value:  一丂丄丌丈丄丏丒专, comparisonType:  4)) == 0) ? 1 : 0;
            return false;
        }
        internal static string 丅丌丕三丞且世且丗(string[] 三万丟丁万丄一三丛)
        {
            string val_16;
            var val_17;
            string val_18;
            System.Text.StringBuilder val_19;
            var val_20;
            string val_21;
            var val_22;
            var val_23;
            var val_24;
            if((三万丟丁万丄一三丛 == null) || (三万丟丁万丄一三丛.Length < 1))
            {
                goto label_2;
            }
            
            if(三万丟丁万丄一三丛.Length != 1)
            {
                goto label_3;
            }
            
            val_16 = 三万丟丁万丄一三丛[0];
            return (string)val_16;
            label_2:
            val_16 = 0;
            return (string)val_16;
            label_3:
            val_17 = null;
            val_17 = null;
            val_18 = 0;
            System.Text.StringBuilder val_1 = TagSystem.专与丈上丅上丘东万.丅丅三丑丆东丈丅丑.Clear();
            if(三万丟丁万丄一三丛.Length < 1)
            {
                goto label_8;
            }
            
            goto label_27;
            label_14:
            val_19 = 0.Length;
            val_20 = 1;
            goto label_10;
            label_27:
            if(0 >= 三万丟丁万丄一三丛.Length)
            {
                    val_18 = 0;
            }
            
            val_21 = 三万丟丁万丄一三丛[0];
            if(val_21 == null)
            {
                goto label_19;
            }
            
            三万丟丁万丄一三丛[0] = val_21.Chars[0] & 65535;
            if(三万丟丁万丄一三丛[0] != '.')
            {
                goto label_13;
            }
            
            val_21 = val_21.Substring(startIndex:  1);
            if(val_21 == null)
            {
                goto label_14;
            }
            
            label_13:
            val_19 = val_21.Length;
            val_20 = 0;
            label_10:
            if(((val_21.Chars[val_19 - 1]) & 65535) == '.')
            {
                    if((val_20 & 1) != 0)
            {
                    val_19 = 0.Length;
            }
            else
            {
                    val_19 = val_21.Length;
            }
            
                val_21 = val_21.Substring(startIndex:  0, length:  val_19 - 1);
            }
            
            val_18 = 0;
            if(val_21.Length >= 1)
            {
                    if(0 >= 1)
            {
                    val_22 = null;
                val_22 = null;
                System.Text.StringBuilder val_14 = TagSystem.专与丈上丅上丘东万.丅丅三丑丆东丈丅丑.Append(value:  '.');
            }
            
                val_23 = null;
                val_23 = null;
                val_19 = TagSystem.专与丈上丅上丘东万.丅丅三丑丆东丈丅丑;
                val_18 = val_21;
                System.Text.StringBuilder val_15 = val_19.Append(value:  val_18);
            }
            
            label_19:
            if((0 + 1) < 三万丟丁万丄一三丛.Length)
            {
                goto label_27;
            }
            
            label_8:
            val_24 = null;
            val_24 = null;
            if(TagSystem.专与丈上丅上丘东万.丅丅三丑丆东丈丅丑 == null)
            {
                
            }
        
        }
        internal static string 世一丂丌丛且丝一丘(string 丆万一不丌且东丐丐, string[] 三万丟丁万丄一三丛)
        {
            string val_3 = 丆万一不丌且东丐丐;
            int val_1 = 三万丟丁万丄一三丛.Length + 1;
            string[] val_2 = new string[0];
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(val_3 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_3 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_2[0] = val_3;
            if(三万丟丁万丄一三丛.Length < 1)
            {
                    return TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_2);
            }
            
            do
            {
                long val_3 = 0;
                val_3 = 三万丟丁万丄一三丛[val_3];
                val_3 = val_3 + 1;
                val_2[(long)val_3] = val_3;
            }
            while(val_3 < 三万丟丁万丄一三丛.Length);
            
            return TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_2);
        }
        internal static string 丙业不丝丗丌丗世下(TagSystem.三与下丘七丘丌丏丄 丆万一不丌且东丐丐)
        {
            PGCompany.东丑丒丗一丞下丙丙<T> val_9;
            int val_10;
            var val_11;
            System.Func<System.String, System.String, System.String> val_13;
            val_10 = 丆万一不丌且东丐丐;
            if(val_10 == null)
            {
                    return (string)val_10;
            }
            
            val_9 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            bool val_3 = val_10.丞丈丑丗下丗三三三(东且丁丆丛丁丏丘且: ref  val_9);
            if((System.Linq.Enumerable.Any<System.String>(source:  val_9)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_13 = 专与丈上丅上丘东万.<>c.<>9__8_0;
                if(val_13 == null)
            {
                    System.Func<System.String, System.String, System.String> val_5 = null;
                val_13 = val_5;
                val_5 = new System.Func<System.String, System.String, System.String>(object:  专与丈上丅上丘东万.<>c.__il2cppRuntimeField_static_fields, method:  System.String 专与丈上丅上丘东万.<>c::下丌万不丑专三丂丝(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                专与丈上丅上丘东万.<>c.<>9__8_0 = val_13;
            }
            
                val_10 = System.Linq.Enumerable.Aggregate<System.String>(source:  val_9, func:  val_5);
                if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) != null)
            {
                    return (string)val_10;
            }
            
                return (string)val_10;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_8 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            val_10 = System.String.alignConst;
            return (string)val_10;
        }
        internal static TagSystem.三与下丘七丘丌丏丄 与丛丆专东丐一且丅(string 丞丕丒专一下丙业上)
        {
            string val_10;
            var val_11;
            System.Char[] val_12;
            var val_13;
            val_10 = 丞丕丒专一下丙业上;
            val_11 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) == true)
            {
                    return (TagSystem.三与下丘七丘丌丏丄)val_11;
            }
            
            if(((val_10.IndexOf(value:  " ", comparisonType:  4)) & 2147483648) == 0)
            {
                    val_10 = val_10.Trim();
            }
            
            TagSystem.三与下丘七丘丌丏丄 val_4 = null;
            val_11 = val_4;
            val_4 = new TagSystem.三与下丘七丘丌丏丄();
            if((val_10.IndexOf(value:  ',')) < 1)
            {
                goto label_8;
            }
            
            char[] val_6 = new char[1];
            val_12 = val_6;
            val_12[0] = ',';
            val_10 = val_10.Split(separator:  val_6);
            val_13 = 0;
            goto label_12;
            label_16:
            val_12 = val_10[0];
            bool val_8 = val_4.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  val_12);
            val_13 = 1;
            label_12:
            if(val_13 < val_7.Length)
            {
                goto label_16;
            }
            
            return (TagSystem.三与下丘七丘丌丏丄)val_11;
            label_8:
            bool val_9 = val_4.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  val_10);
            return (TagSystem.三与下丘七丘丌丏丄)val_11;
        }
        private static 专与丈上丅上丘东万()
        {
            TagSystem.专与丈上丅上丘东万.丅丅三丑丆东丈丅丑 = new System.Text.StringBuilder();
        }
    
    }

}

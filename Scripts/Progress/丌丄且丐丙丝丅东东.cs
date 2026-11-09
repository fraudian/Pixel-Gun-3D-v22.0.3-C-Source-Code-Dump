using UnityEngine;

namespace Progress
{
    internal class 丌丄且丐丙丝丅东东 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.上丅丙丟不业不丆东 丄丐不丏丁丘不丒丈;
        
        // Properties
        internal PGCompany.上丅丙丟不业不丆东 业一丁丄丌且上丈丘 { get; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal PGCompany.上丅丙丟不业不丆东 不丕丒丁丈丅丏三丌()
        {
            return (PGCompany.上丅丙丟不业不丆东)this.丄丐不丏丁丘不丒丈;
        }
        internal int 丄七丛东与丆丌专丝(string 丆万一不丌且东丐丐)
        {
            string val_8;
            string val_9;
            val_8 = 丆万一不丌且东丐丐;
            丛且专丞丗丆丙丒万 val_5 = 0;
            三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_8);
            if(val_1 != null)
            {
                    int val_2 = val_1.业东丅东丌上丗丑不();
                return (int)val_9;
            }
            
            val_9 = val_8;
            if((丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  val_9)) > 0)
            {
                    return (int)val_9;
            }
            
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().TryGetValue(key:  val_8, value: out  val_5)) != false)
            {
                    val_8 = val_5;
                val_9 = val_8;
                int val_7 = val_9.业东丅东丌上丗丑不();
                return (int)val_9;
            }
            
            val_9 = 0;
            return (int)val_9;
        }
        internal bool 专万丝且丌丄丆丐万(string 丆万一不丌且东丐丐)
        {
            return this.且且丒丁万七丞上丅(丞世不丒下上上丝丑:  this.丄七丛东与丆丌专丝(丆万一不丌且东丐丐:  丆万一不丌且东丐丐));
        }
        internal int 世丛丗且不丏丟下丝(string 丆万一不丌且东丐丐)
        {
            return this.丕专万丈上东东丛丑(丞世不丒下上上丝丑:  this.丄七丛东与丆丌专丝(丆万一不丌且东丐丐:  丆万一不丌且东丐丐));
        }
        internal System.Collections.Generic.Dictionary<int, int> 七丆三丌丅丐丕七丏()
        {
            var val_3;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_5;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_7;
            val_3 = null;
            val_3 = null;
            val_5 = 丌丄且丐丙丝丅东东.<>c.<>9__8_0;
            if(val_5 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::丆世丞丅丘丝与丅丟(System.Collections.Generic.KeyValuePair<int, int> 丟三下万一丄七一丗));
                val_3 = null;
                丌丄且丐丙丝丅东东.<>c.<>9__8_0 = val_5;
            }
            
            val_3 = null;
            val_7 = 丌丄且丐丙丝丅东东.<>c.<>9__8_1;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  this.丄丐不丏丁丘不丒丈, keySelector:  val_1, elementSelector:  System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_2 = null);
            }
            
            val_7 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::与丅业丟业丛丂下丏(System.Collections.Generic.KeyValuePair<int, int> 丟三下万一丄七一丗));
            丌丄且丐丙丝丅东东.<>c.<>9__8_1 = val_7;
            return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  this.丄丐不丏丁丘不丒丈, keySelector:  val_1, elementSelector:  val_2);
        }
        internal void 丂丑丂专七专丐丆万(System.Collections.Generic.Dictionary<int, int> 丌专丗万万丒七丆业)
        {
            var val_3;
            PGCompany.上丅丙丟不业不丆东 val_7;
            if(丌专丗万万丒七丆业 == null)
            {
                    return;
            }
            
            val_7 = this.丄丐不丏丁丘不丒丈;
            val_7.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = 丌专丗万万丒七丆业.GetEnumerator();
            label_5:
            if(((-2044177264) & 1) == 0)
            {
                goto label_3;
            }
            
            this.丄丐不丏丁丘不丒丈.Add(下上丐丆丝丟丝丒不:  val_3.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂(), 丙业与丙丗丝不丈东:  -2044177272);
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal bool 且且丒丁万七丞上丅(int 丞世不丒下上上丝丑)
        {
            if(this.丄丐不丏丁丘不丒丈 != null)
            {
                    return this.丄丐不丏丁丘不丒丈.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
            }
            
            return this.丄丐不丏丁丘不丒丈.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
        }
        internal int 丕专万丈上东东丛丑(int 丞世不丒下上上丝丑)
        {
            int val_1 = 0;
            return (int)((this.丄丐不丏丁丘不丒丈.TryGetValue(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑, 丙业与丙丗丝不丈东: out  val_1)) != true) ? (val_1) : 0;
        }
        internal void 丆东上且丟丌业丗与(int 丞世不丒下上上丝丑, int 丛丝与万丑不丛丛不)
        {
            int val_1 = 0;
            bool val_2 = this.丄丐不丏丁丘不丒丈.TryGetValue(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑, 丙业与丙丗丝不丈东: out  val_1);
            this.丄丐不丏丁丘不丒丈.set_Item(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑, 丙业与丙丗丝不丈东:  System.Math.Max(val1:  0, val2:  val_1 + 丛丝与万丑不丛丛不));
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            System.Collections.Generic.IEnumerable<TSource> val_11;
            var val_12;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32> val_14;
            if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "IS_DETAILS_MIGRATION_30_NOV_2018_OCCURS_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
            {
                    val_11 = Progress.丌丄且丐丙丝丅东东.丘丑万与丘丝丒丒丈();
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_3 = Progress.丌丄且丐丙丝丅东东.丅丌丐丄丈丄丐丒与();
                val_11 = val_3;
            }
            
            val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean>(object:  this, method:  System.Boolean Progress.丌丄且丐丙丝丅东东::上专丏东下丑丈东丑(System.Collections.Generic.KeyValuePair<string, int> 丟三下万一丄七一丗));
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32> val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(object:  this, method:  System.Int32 Progress.丌丄且丐丙丝丅东东::丟丝丙一不丘丝丙丝(System.Collections.Generic.KeyValuePair<string, int> 丟三下万一丄七一丗));
            val_12 = null;
            val_12 = null;
            val_14 = 丌丄且丐丙丝丅东东.<>c.<>9__13_2;
            if(val_14 == null)
            {
                    val_14 = null;
                val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::丝丞万丂上丕万下丘(System.Collections.Generic.KeyValuePair<string, int> 丟三下万一丄七一丗));
                丌丄且丐丙丝丅东东.<>c.<>9__13_2 = val_14;
            }
            
            this.丄丐不丏丁丘不丒丈 = PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32, System.Int32>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>(source:  val_11, predicate:  val_3), keySelector:  null, elementSelector:  null));
        }
        private static System.Collections.Generic.Dictionary<string, int> 丅丌丐丄丈丄丐丒与()
        {
            var val_9;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_11;
            var val_12;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_14;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_v3_101017")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_v3_101017", 下下丏一丙不丘丌丞:  "{}");
            }
            
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_v3_101017"));
            val_9 = null;
            val_9 = null;
            val_11 = 丌丄且丐丙丝丅东东.<>c.<>9__14_0;
            val_12 = 0;
            if(val_11 != null)
            {
                    val_12 = 0;
            }
            else
            {
                    val_11 = null;
                val_11 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丄且丐丙丝丅东东.<>c::丑丌一上丗东丝丑万(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
                val_9 = null;
                丌丄且丐丙丝丅东东.<>c.<>9__14_0 = val_11;
            }
            
            val_9 = null;
            val_14 = 丌丄且丐丙丝丅东东.<>c.<>9__14_1;
            if(val_14 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Int32>)System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Int32>(source:  null, keySelector:  val_11, elementSelector:  null);
            }
            
            val_14 = null;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::丕丂万丛万丕且丏丂(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            丌丄且丐丙丝丅东东.<>c.<>9__14_1 = val_14;
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Int32>(source:  null, keySelector:  val_11, elementSelector:  null);
        }
        private static System.Collections.Generic.Dictionary<string, int> 丘丑万与丘丝丒丒丈()
        {
            new 丌丄且丐丙丝丅东东.丕丛业丁丏下一七丘() = new System.Object();
            if(new 丌丄且丐丙丝丅东东.丕丛业丁丏下一七丘() != null)
            {
                    .丄东丙不世丄丛专且 = "POSITIVE_DETAILS";
            }
            else
            {
                    mem[16] = "POSITIVE_DETAILS";
            }
            
            .七丆专下东丞丁三上 = "NEGATIVE_DETAILS";
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_301118")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_301118", 下下丏一丙不丘丌丞:  "{}");
            }
            
            string val_3 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "DetailsShopCraftInfo.OUR_DETAILS_KEY_301118");
            object[] val_5 = new object[1];
            val_5[0] = (val_3 == null) ? "null" : (val_3);
            UnityEngine.Debug.LogErrorFormat(format:  "LoadOurDetails deserialized = null, {0}", args:  val_5);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)null;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 24;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            PGCompany.上丅丙丟不业不丆东 val_6;
            var val_7;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_10;
            val_6 = this.丄丐不丏丁丘不丒丈;
            val_6.Clear();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = 丌丄且丐丙丝丅东东.<>c.<>9__19_0;
            if(val_6 == null)
            {
                    val_6 = null;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::丆东丈东丞丆丌业丟(System.Collections.Generic.KeyValuePair<string, object> 三丟东丕丄丄下下丑));
                val_7 = null;
                丌丄且丐丙丝丅东东.<>c.<>9__19_0 = val_6;
            }
            
            val_7 = null;
            val_10 = 丌丄且丐丙丝丅东东.<>c.<>9__19_1;
            if(val_10 == null)
            {
                    val_10 = null;
                val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  丌丄且丐丙丝丅东东.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丌丄且丐丙丝丅东东.<>c::丗丕七丙丟与丈丅丒(System.Collections.Generic.KeyValuePair<string, object> 三丟东丕丄丄下下丑));
                丌丄且丐丙丝丅东东.<>c.<>9__19_1 = val_10;
            }
            
            this.丄丐不丏丁丘不丒丈 = PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32, System.Int32>(source:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0, keySelector:  null, elementSelector:  null));
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            if(this.丄丐不丏丁丘不丒丈 != null)
            {
                    return this.丄丐不丏丁丘不丒丈.丁丕上三丕丌丟丗丙();
            }
            
            return this.丄丐不丏丁丘不丒丈.丁丕上三丕丌丟丗丙();
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丌丄且丐丙丝丅东东.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丌丄且丐丙丝丅东东.丐丌丞上世丛丐丏丛;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丄丐不丏丁丘不丒丈.Clear();
        }
        internal System.Collections.Generic.List<int> 一丆丞丆上丘万丐不()
        {
            return 0;
        }
        public 丌丄且丐丙丝丅东东()
        {
            this.丄丐不丏丁丘不丒丈 = new PGCompany.上丅丙丟不业不丆东();
        }
        private static 丌丄且丐丙丝丅东东()
        {
            Progress.丌丄且丐丙丝丅东东.丕丟一七丑丙丂丆丙 = "DetSl";
            Progress.丌丄且丐丙丝丅东东.丐丌丞上世丛丐丏丛 = "DetSl_2019";
        }
        private bool 上专丏东下丑丈东丑(System.Collections.Generic.KeyValuePair<string, int> 丟三下万一丄七一丗)
        {
            string val_1 = 丟三下万一丄七一丗.Value.丐丏七丌丕丗业且上();
            return (bool)((val_1.丄七丛东与丆丌专丝(丆万一不丌且东丐丐:  val_1)) != 1) ? 1 : 0;
        }
        private int 丟丝丙一不丘丝丙丝(System.Collections.Generic.KeyValuePair<string, int> 丟三下万一丄七一丗)
        {
            string val_1 = 丟三下万一丄七一丗.Value.丐丏七丌丕丗业且上();
            return (int)val_1.丄七丛东与丆丌专丝(丆万一不丌且东丐丐:  val_1);
        }
    
    }

}

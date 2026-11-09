using UnityEngine;

namespace Progress
{
    internal class 丕与丛三丗丒丈丕七 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕七丘一丑不丒丈丒;
        internal static readonly string 丐丁丟三丌丏东丐丗;
        internal static readonly string 一万下三万业与丅丗;
        internal static readonly string 东专丞丕丅丆三丗下;
        internal static string 七丌专丌业业丆丅丂;
        private System.Collections.Generic.Dictionary<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 丛丙丟丗世丞丒且且;
        private System.Collections.Generic.List<Progress.丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈> 丘与丄专不不专丁上;
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private static readonly System.Text.UTF8Encoding 丑丝丂丈丌丗丅丂丗;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 丟丑丂专不丝与万丑()
        {
            if(this.丛丙丟丗世丞丒且且 != null)
            {
                    return val_2;
            }
            
            UnityEngine.Debug.LogErrorFormat(format:  "_storag_eSkins == null", args:  System.Array.Empty<System.Object>());
            System.Collections.Generic.Dictionary<System.Int64, 丟丆丒丅三丁丑七与> val_2 = Progress.丕与丛三丗丒丈丕七.专丑丙丛世丈下丞丟();
            this.丛丙丟丗世丞丒且且 = val_2;
            return val_2;
        }
        private static System.Collections.Generic.Dictionary<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 专丑丙丛世丈下丞丟()
        {
            var val_3;
            System.Collections.Generic.Dictionary<System.Int64, 丟丆丒丅三丁丑七与> val_1 = new System.Collections.Generic.Dictionary<System.Int64, 丟丆丒丅三丁丑七与>();
            丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与 val_2 = new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与();
            val_3 = null;
            val_3 = null;
            if(val_2 != null)
            {
                    .三丌专世丑丒丙丁世 = Progress.丕与丛三丗丒丈丕七.七丌专丌业业丆丅丂;
            }
            else
            {
                    mem[16] = Progress.丕与丛三丗丒丈丕七.七丌专丌业业丆丅丂;
            }
            
            .丟万与与不东丁业丌 = "56fb534c11562c67";
            val_1.Add(key:  0, value:  val_2);
            return val_1;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丕与丛三丗丒丈丕七.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丕与丛三丗丒丈丕七.丐丌丞上世丛丐丏丛;
        }
        internal void 丙丘丙不丟东且丌丏(long 丞丅上丏丂且下丅与, string 丒丘丏上丙丟丑丕丈, string 丑丞丈丗丄丙丟万丄, string 丝不丄业丛三上丕丄)
        {
            string val_8 = 丑丞丈丗丄丙丟万丄;
            if((this.丛丙丟丗世丞丒且且.ContainsKey(key:  丞丅上丏丂且下丅与)) != true)
            {
                    this.丛丙丟丗世丞丒且且.Add(key:  丞丅上丏丂且下丅与, value:  new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与());
            }
            
            丟丆丒丅三丁丑七与 val_3 = this.丛丙丟丗世丞丒且且.Item[丞丅上丏丂且下丅与];
            if((丝不丄业丛三上丕丄.Equals(value:  val_3.丟万与与不东丁业丌)) != true)
            {
                    丟丆丒丅三丁丑七与 val_5 = this.丛丙丟丗世丞丒且且.Item[丞丅上丏丂且下丅与];
                val_5.三丌专世丑丒丙丁世 = val_8;
                val_8 = this.丛丙丟丗世丞丒且且.Item[丞丅上丏丂且下丅与];
                val_6.丟万与与不东丁业丌 = 丝不丄业丛三上丕丄;
            }
            
            丟丆丒丅三丁丑七与 val_7 = this.丛丙丟丗世丞丒且且.Item[丞丅上丏丂且下丅与];
            val_7.丝丘丅与丌丗丅丈下 = 丒丘丏上丙丟丑丕丈;
        }
        internal void 专丕丘丘丌上丞专丁(long 丞丅上丏丂且下丅与)
        {
            bool val_1 = this.丛丙丟丗世丞丒且且.Remove(key:  丞丅上丏丂且下丅与);
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 12;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            var val_13;
            string val_14;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64> val_16;
            var val_17;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64> val_19;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, 丟丆丒丅三丁丑七与> val_21;
            val_13 = null;
            val_14 = "";
            val_13 = null;
            val_16 = 丕与丛三丗丒丈丕七.<>c.<>9__21_0;
            if(val_16 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64> val_1 = null;
                val_16 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64>(object:  丕与丛三丗丒丈丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 丕与丛三丗丒丈丕七.<>c::丅丁丁丈丞丄三丐丅(System.Collections.Generic.KeyValuePair<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 三丟东丕丄丄下下丑));
                丕与丛三丗丒丈丕七.<>c.<>9__21_0 = val_16;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = 丕与丛三丗丒丈丕七.<>c.<>9__21_1;
            if(val_19 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64> val_3 = null;
                val_19 = val_3;
                val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64>(object:  丕与丛三丗丒丈丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 丕与丛三丗丒丈丕七.<>c::丁世丆与一下丗丑丙(System.Collections.Generic.KeyValuePair<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 三丟东丕丄丄下下丑));
                val_17 = null;
                丕与丛三丗丒丈丕七.<>c.<>9__21_1 = val_19;
            }
            
            val_17 = null;
            val_21 = 丕与丛三丗丒丈丕七.<>c.<>9__21_2;
            if(val_21 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, 丟丆丒丅三丁丑七与> val_4 = null;
                val_21 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, 丟丆丒丅三丁丑七与>(object:  丕与丛三丗丒丈丕七.<>c.__il2cppRuntimeField_static_fields, method:  丟丆丒丅三丁丑七与 丕与丛三丗丒丈丕七.<>c::且丗丟丂下丗丟不丑(System.Collections.Generic.KeyValuePair<long, Progress.丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与> 丒丒丄丁且丄丆丂丌));
                丕与丛三丗丒丈丕七.<>c.<>9__21_2 = val_21;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_6 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64, 丟丆丒丅三丁丑七与>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int64, 丟丆丒丅三丁丑七与>, System.Int64>(source:  this.丛丙丟丗世丞丒且且, keySelector:  val_1), keySelector:  val_3, elementSelector:  val_4).GetEnumerator();
            label_20:
            if(((-2048397064) & 1) == 0)
            {
                goto label_17;
            }
            
            ConfiguredValueTaskAwaiter val_7 = 0.GetAwaiter();
            string val_12 = val_14 + val_7._value._obj.丐丏七丌丕丗业且上().ToString()(val_14 + val_7._value._obj.丐丏七丌丕丗业且上().ToString()) + 0(val_14 + val_7._value._obj.丐丏七丌丕丗业且上().ToString()(val_14 + val_7._value._obj.丐丏七丌丕丗业且上().ToString()) + 0) + 0;
            goto label_20;
            label_17:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string);
        }
        internal override void 不一丘丅且丆不七上(object 丁丘丄丕下专东七不)
        {
            object val_5;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            object val_27;
            this.丛丙丟丗世丞丒且且.Clear();
            this.丛丙丟丗世丞丒且且 = Progress.丕与丛三丗丒丈丕七.专丑丙丛世丈下丞丟();
            Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_42:
            if(((-2048197008) & 1) == 0)
            {
                goto label_10;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
            val_19 = 0;
            new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与() = new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与();
            val_20 = null;
            val_20 = null;
            if((ContainsKey(key:  Progress.丕与丛三丗丒丈丕七.丕七丘一丑不丒丈丒)) != false)
            {
                    val_21 = null;
                val_21 = null;
                .三丌专世丑丒丙丁世 = Item[Progress.丕与丛三丗丒丈丕七.丕七丘一丑不丒丈丒];
            }
            
            val_22 = null;
            val_22 = null;
            if((ContainsKey(key:  Progress.丕与丛三丗丒丈丕七.丐丁丟三丌丏东丐丗)) != false)
            {
                    val_23 = null;
                val_23 = null;
                .丝丘丅与丌丗丅丈下 = Item[Progress.丕与丛三丗丒丈丕七.丐丁丟三丌丏东丐丗];
            }
            
            val_24 = null;
            val_24 = null;
            if((ContainsKey(key:  Progress.丕与丛三丗丒丈丕七.一万下三万业与丅丗)) != false)
            {
                    val_25 = null;
                val_25 = null;
                .丟万与与不东丁业丌 = Item[Progress.丕与丛三丗丒丈丕七.一万下三万业与丅丗];
            }
            
            this.丛丙丟丗世丞丒且且.set_Item(key:  System.Int64.Parse(s:  val_7._value._obj.丐丏七丌丕丗业且上()), value:  new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与());
            goto label_42;
            label_10:
            val_26 = 0;
            val_27 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(223 != 223)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            object val_4;
            object val_5;
            var val_10;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丛丙丟丗世丞丒且且.GetEnumerator();
            label_12:
            if(((-2048023552) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_4.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_10 = null;
            val_10 = null;
            null.Add(key:  Progress.丕与丛三丗丒丈丕七.丕七丘一丑不丒丈丒, value:  val_4);
            null.Add(key:  Progress.丕与丛三丗丒丈丕七.一万下三万业与丅丗, value:  val_5);
            null.Add(key:  Progress.丕与丛三丗丒丈丕七.丐丁丟三丌丏东丐丗, value:  val_4);
            val_1.Add(key:  val_6._value._obj.丐丏七丌丕丗业且上().ToString(), value:  null);
            goto label_12;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            string val_12;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            System.Func<且丞丕丐丞一下世丈, System.Int64> val_54;
            var val_55;
            var val_56;
            System.Collections.Generic.List<且丞丕丐丞一下世丈> val_1 = new System.Collections.Generic.List<且丞丕丐丞一下世丈>();
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "User Skins", defaultValue:  System.String.alignConst));
            val_49 = 0;
            object val_6 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "User Name Skins", defaultValue:  System.String.alignConst));
            val_50 = 0;
            Dictionary.Enumerator<TKey, TValue> val_9 = GetEnumerator();
            val_51 = 1152921516595685792;
            label_28:
            if(((-2047735392) & 1) == 0)
            {
                goto label_9;
            }
            
            ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
            if((System.String.op_Equality(a:  val_13._value._obj.丐丏七丌丕丗业且上(), b:  UnityEngine.PlayerPrefs.GetString(key:  "Name Current Skin", defaultValue:  "0"))) == false)
            {
                goto label_10;
            }
            
            new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与() = new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与();
            .三丌专世丑丒丙丁世 = ;
            .丟万与与不东丁业丌 = Progress.丕与丛三丗丒丈丕七.丌丘丝丂丕丛丘丐丕(丑与丂丌世丕丆一丗:  val_13._value._obj);
            if((ContainsKey(key:  val_13._value._obj.丐丏七丌丕丗业且上())) != false)
            {
                    .丝丘丅与丌丗丅丈下 = Item[val_13._value._obj.丐丏七丌丕丗业且上()];
            }
            
            mem[1152921541213829408].Add(key:  System.Int64.Parse(s:  val_13._value._obj.丐丏七丌丕丗业且上()), value:  new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与());
            goto label_28;
            label_10:
            if((ContainsKey(key:  val_13._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_28;
            }
            
            new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈() = new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈();
            .丞丅上丏丂且下丅与 = System.Int64.Parse(s:  val_13._value._obj.丐丏七丌丕丗业且上());
            .三丌专世丑丒丙丁世 = ;
            .丝丘丅与丌丗丅丈下 = Item[val_13._value._obj.丐丏七丌丕丗业且上()];
            .丝不丄业丛三上丕丄 = Progress.丕与丛三丗丒丈丕七.丌丘丝丂丕丛丘丐丕(丑与丂丌世丕丆一丗:  val_13._value._obj);
            val_1.Add(item:  new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈());
            goto label_28;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_52 = null;
            val_52 = null;
            val_54 = 丕与丛三丗丒丈丕七.<>c.<>9__24_0;
            if(val_54 == null)
            {
                    System.Func<且丞丕丐丞一下世丈, System.Int64> val_32 = null;
                val_54 = val_32;
                val_32 = new System.Func<且丞丕丐丞一下世丈, System.Int64>(object:  丕与丛三丗丒丈丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 丕与丛三丗丒丈丕七.<>c::上东东七丏上丙且丞(Progress.丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈 三丟东丕丄丄下下丑));
                丕与丛三丗丒丈丕七.<>c.<>9__24_0 = val_54;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_33 = System.Linq.Enumerable.OrderByDescending<且丞丕丐丞一下世丈, System.Int64>(source:  val_1, keySelector:  val_32);
            val_55 = null;
            val_55 = null;
            if(SkinsController.丂且丛且且丕专丘丏 < 1)
            {
                goto label_74;
            }
            
            val_51 = 1152921541212157968;
            val_54 = 0;
            label_87:
            if(val_54 >= val_1.Count)
            {
                goto label_74;
            }
            
            且丞丕丐丞一下世丈 val_36 = val_1.Item[0];
            .三丌专世丑丒丙丁世 = val_36.三丌专世丑丒丙丁世;
            且丞丕丐丞一下世丈 val_37 = val_1.Item[0];
            .丝丘丅与丌丗丅丈下 = val_37.丝丘丅与丌丗丅丈下;
            且丞丕丐丞一下世丈 val_38 = val_1.Item[0];
            .丟万与与不东丁业丌 = Progress.丕与丛三丗丒丈丕七.丌丘丝丂丕丛丘丐丕(丑与丂丌世丕丆一丗:  val_38.丝丘丅与丌丗丅丈下);
            val_49 = mem[1152921541213829408];
            且丞丕丐丞一下世丈 val_40 = val_1.Item[0];
            val_49.Add(key:  val_40.丞丅上丏丂且下丅与, value:  new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与());
            val_54 = val_54 + 1;
            if(val_54 < SkinsController.丂且丛且且丕专丘丏)
            {
                goto label_87;
            }
            
            label_74:
            val_56 = "NewUserCape";
            if((UnityEngine.PlayerPrefs.HasKey(key:  "NewUserCape")) == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  UnityEngine.PlayerPrefs.GetString(key:  "NewUserCape"))) == true)
            {
                    return;
            }
            
            Rilisoft.CapeMemento val_46 = Rilisoft.与丄丁丄丙丞下下丙.丌丙与丘下丘与三专<Rilisoft.CapeMemento>(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "NewUserCape"));
            .三丌专世丑丒丙丁世 = ;
            val_54;
            .丟万与与不东丁业丌 = Progress.丕与丛三丗丒丈丕七.丌丘丝丂丕丛丘丐丕(丑与丂丌世丕丆一丗:  val_12);
            val_56 = mem[1152921541213829408];
            val_56.set_Item(key:  0, value:  new 丕与丛三丗丒丈丕七.丟丆丒丅三丁丑七与());
        }
        internal bool 丂丌与丙丞三万丛丘(string 丞丅上丏丂且下丅与)
        {
            System.Collections.Generic.Dictionary<System.Int64, 丟丆丒丅三丁丑七与> val_4;
            var val_5;
            val_4 = this;
            if((System.Int64.TryParse(s:  丞丅上丏丂且下丅与, result: out  0)) != false)
            {
                    val_4 = this.丛丙丟丗世丞丒且且;
                val_5 = val_4;
                bool val_3 = val_5.ContainsKey(key:  0);
            }
            else
            {
                    val_5 = 0;
            }
            
            val_5 = val_5 & 1;
            return (bool)val_5;
        }
        internal string 丌与丗丛业丝东丏丙(long 丞丅上丏丂且下丅与)
        {
            long val_3;
            string val_4;
            val_3 = 丞丅上丏丂且下丅与;
            if((this.丛丙丟丗世丞丒且且.ContainsKey(key:  val_3)) != false)
            {
                    val_3 = this.丛丙丟丗世丞丒且且.Item[val_3];
                val_4 = val_2.三丌专世丑丒丙丁世;
                return (string)val_4;
            }
            
            val_4 = "";
            return (string)val_4;
        }
        internal string 丗丅丁丁下丟世一丐(long 丞丅上丏丂且下丅与)
        {
            long val_3;
            string val_4;
            val_3 = 丞丅上丏丂且下丅与;
            if((this.丛丙丟丗世丞丒且且.ContainsKey(key:  val_3)) != false)
            {
                    val_3 = this.丛丙丟丗世丞丒且且.Item[val_3];
                val_4 = val_2.丝丘丅与丌丗丅丈下;
                return (string)val_4;
            }
            
            val_4 = "";
            return (string)val_4;
        }
        internal string 丆丞丆专万七且丟丙(long 丞丅上丏丂且下丅与)
        {
            long val_3;
            string val_4;
            val_3 = 丞丅上丏丂且下丅与;
            if((this.丛丙丟丗世丞丒且且.ContainsKey(key:  val_3)) != false)
            {
                    val_3 = this.丛丙丟丗世丞丒且且.Item[val_3];
                val_4 = val_2.丟万与与不东丁业丌;
                return (string)val_4;
            }
            
            val_4 = "";
            return (string)val_4;
        }
        internal int 丒专下与丑丁丆丟业()
        {
            bool val_2 = this.丛丙丟丗世丞丒且且.ContainsKey(key:  0);
            val_2 = this.丛丙丟丗世丞丒且且.Count - val_2;
            return (int)val_2;
        }
        internal System.Collections.Generic.List<Progress.丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈> 一丒一丏丂丁丄丕丒()
        {
            string val_4;
            var val_11;
            System.Func<且丞丕丐丞一下世丈, System.Int64> val_13;
            this.丘与丄专不不专丁上.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丛丙丟丗世丞丒且且.GetEnumerator();
            label_9:
            if(((-2046764448) & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(val_5._value._obj.丐丏七丌丕丗业且上() == 1)
            {
                goto label_9;
            }
            
            new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈() = new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈();
            .丞丅上丏丂且下丅与 = val_5._value._obj.丐丏七丌丕丗业且上();
            .三丌专世丑丒丙丁世 = val_4;
            .丝丘丅与丌丗丅丈下 = val_4;
            this.丘与丄专不不专丁上.Add(item:  new 丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈());
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_11 = null;
            val_11 = null;
            val_13 = 丕与丛三丗丒丈丕七.<>c.<>9__30_0;
            if(val_13 == null)
            {
                    System.Func<且丞丕丐丞一下世丈, System.Int64> val_9 = null;
                val_13 = val_9;
                val_9 = new System.Func<且丞丕丐丞一下世丈, System.Int64>(object:  丕与丛三丗丒丈丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 丕与丛三丗丒丈丕七.<>c::丄丝丆七丁丑业丒丞(Progress.丕与丛三丗丒丈丕七.且丞丕丐丞一下世丈 三丟东丕丄丄下下丑));
                丕与丛三丗丒丈丕七.<>c.<>9__30_0 = val_13;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_10 = System.Linq.Enumerable.OrderBy<且丞丕丐丞一下世丈, System.Int64>(source:  this.丘与丄专不不专丁上, keySelector:  val_9);
            return (System.Collections.Generic.List<且丞丕丐丞一下世丈>)this.丘与丄专不不专丁上;
        }
        internal string 丛丝丕丄七丄七万不()
        {
            var val_3;
            string val_4;
            val_3 = this;
            if((this.丛丙丟丗世丞丒且且.ContainsKey(key:  0)) != false)
            {
                    val_3 = this.丛丙丟丗世丞丒且且.Item[0];
                val_4 = val_2.三丌专世丑丒丙丁世;
                return (string)val_4;
            }
            
            val_4 = "";
            return (string)val_4;
        }
        internal static string 丌丘丝丂丕丛丘丐丕(string 丑与丂丌世丕丆一丗)
        {
            var val_7 = null;
            int val_2 = 丑与丂丌世丕丆一丗.Length;
            System.Security.Cryptography.SHA256Managed val_3 = new System.Security.Cryptography.SHA256Managed();
            if(val_3 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_3.Dispose();
            }
            
            if(0 != 1)
            {
                    return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  Progress.丕与丛三丗丒丈丕七.丑丝丂丈丌丗丅丂丗), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
            }
            
            if(0 == 0)
            {
                    return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  Progress.丕与丛三丗丒丈丕七.丑丝丂丈丌丗丅丂丗), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
            }
            
            return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  Progress.丕与丛三丗丒丈丕七.丑丝丂丈丌丗丅丂丗), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丛丙丟丗世丞丒且且 = Progress.丕与丛三丗丒丈丕七.专丑丙丛世丈下丞丟();
            this.丘与丄专不不专丁上.Clear();
        }
        public 丕与丛三丗丒丈丕七()
        {
            this.丛丙丟丗世丞丒且且 = Progress.丕与丛三丗丒丈丕七.专丑丙丛世丈下丞丟();
            this.丘与丄专不不专丁上 = new System.Collections.Generic.List<且丞丕丐丞一下世丈>();
        }
        private static 丕与丛三丗丒丈丕七()
        {
            Progress.丕与丛三丗丒丈丕七.丕七丘一丑不丒丈丒 = "c";
            Progress.丕与丛三丗丒丈丕七.丐丁丟三丌丏东丐丗 = "n";
            Progress.丕与丛三丗丒丈丕七.一万下三万业与丅丗 = "h";
            Progress.丕与丛三丗丒丈丕七.东专丞丕丅丆三丗下 = "-1";
            Progress.丕与丛三丗丒丈丕七.七丌专丌业业丆丅丂 = "iVBORw0KGgoAAAANSUhEUgAAAAwAAAAQCAIAAACtAwlQAAAAyElEQVQoFY2RsQ3CQAxFfxANBVswBrQp2IAV2IGKnjVYAUEJGyHRhmc7vjuChLBOOfv72//sSH9YF5xdUs/uTMI5INBeWksPaeWkPkMiyqzT3RMbaXAeEQUkCj5zgn2ARu2GEVmTa40e32adngkjRzMOTlikjLRNyOSGl65D0Y1UfdPIvC10yaK8jVS2ciDoO506c9wiZY1jVBy2EOnjJ1jlYi7WyMHaMSuJnkUFp7ydAtsTcy6dEX/D+qTFCsaC9lkQJmGW/LzfpnEh0eOFSr4AAAAASUVORK5CYII=";
            Progress.丕与丛三丗丒丈丕七.丕丟一七丑丙丂丆丙 = "Custom_Skin_Slot";
            Progress.丕与丛三丗丒丈丕七.丐丌丞上世丛丐丏丛 = "CustomSkin_Slot_Nov2018";
            Progress.丕与丛三丗丒丈丕七.丑丝丂丈丌丗丅丂丗 = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false, throwOnInvalidBytes:  false);
        }
    
    }

}

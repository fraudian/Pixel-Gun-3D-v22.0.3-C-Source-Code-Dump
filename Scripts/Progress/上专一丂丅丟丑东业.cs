using UnityEngine;

namespace Progress
{
    internal class 上专一丂丅丟丑东业 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.上丅丙丟不业不丆东 万丑丏东三丑丞与丏;
        
        // Properties
        internal System.Collections.Generic.Dictionary<int, int> 丅一丙下下下业下丑 { get; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<int, int> 三东丈丑丆丆丅东且()
        {
            return (System.Collections.Generic.Dictionary<System.Int32, System.Int32>)new System.Collections.Generic.Dictionary<System.Int32, System.Int32>(dictionary:  this.万丑丏东三丑丞与丏);
        }
        internal System.Nullable<int> 丄丏且丆丈一东丟丙(int 丞世不丒下上上丝丑)
        {
            var val_3;
            if((this.万丑丏东三丑丞与丏.TryGetValue(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑, 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_3 = 0;
                return (System.Nullable<System.Int32>)val_3;
            }
            
            val_3 = 0;
            return (System.Nullable<System.Int32>)val_3;
        }
        internal void 丝丗丆丘东万不世丄(int 丞世不丒下上上丝丑)
        {
            if((this.万丑丏东三丑丞与丏.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) == false)
            {
                    return;
            }
            
            bool val_2 = this.万丑丏东三丑丞与丏.Remove(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
        }
        internal System.Collections.Generic.Dictionary<int, int> 东丗且丂与丐七与丒()
        {
            object val_23;
            var val_24;
            var val_25;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_27;
            var val_29;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_31;
            var val_32;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>, System.Int32> val_34;
            var val_35;
            System.Func<System.Int32, System.Boolean> val_37;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_38;
            上专一丂丅丟丑东业.丒丑万一丁丕东一丗 val_1 = null;
            val_23 = val_1;
            val_1 = new 上专一丂丅丟丑东业.丒丑万一丁丕东一丗();
            .丝且与丝丒丟万丁专 = this;
            val_24 = null;
            val_24 = null;
            val_25 = null;
            val_25 = null;
            val_27 = 上专一丂丅丟丑东业.<>c.<>9__7_0;
            if(val_27 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_2 = null;
                val_27 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上专一丂丅丟丑东业.<>c::七丌专丑丈丅丛丑丌(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                上专一丂丅丟丑东业.<>c.<>9__7_0 = val_27;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = 上专一丂丅丟丑东业.<>c.<>9__7_1;
            if(val_31 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_4 = null;
                val_31 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> 上专一丂丅丟丑东业.<>c::丐丛与丂下且与业丂(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                上专一丂丅丟丑东业.<>c.<>9__7_1 = val_31;
            }
            
            .世丂丏丘丟丈业七丈 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  val_2), selector:  val_4));
            .丂业东丕与与丂丗专 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().业东丙丗世万丈丘东();
            val_32 = null;
            val_32 = null;
            val_34 = 上专一丂丅丟丑东业.<>c.<>9__7_3;
            if(val_34 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>, System.Int32> val_12 = null;
                val_34 = val_12;
                val_12 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>, System.Int32>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 上专一丂丅丟丑东业.<>c::与且丒丆世丞丑丅丛(System.Collections.Generic.KeyValuePair<int, 三丅丁丗丗丝丂万且> 丈丏万丄丒业丅丒一));
                上专一丂丅丟丑东业.<>c.<>9__7_3 = val_34;
            }
            
            val_35 = null;
            val_35 = null;
            val_37 = 上专一丂丅丟丑东业.<>c.<>9__7_4;
            if(val_37 == null)
            {
                    System.Func<System.Int32, System.Boolean> val_16 = null;
                val_37 = val_16;
                val_16 = new System.Func<System.Int32, System.Boolean>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上专一丂丅丟丑东业.<>c::上下世三丘丄丗丞三(int 丈丏万丄丒业丅丒一));
                上专一丂丅丟丑东业.<>c.<>9__7_4 = val_37;
            }
            
            System.Collections.Generic.List<TSource> val_18 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Where<System.Int32>(source:  System.Linq.Enumerable.Except<System.Int32>(first:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>, System.Int32>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>>(source:  丏丄丑上丛不丈且万.丈丒丅万丝丆与东专(), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 三丅丁丗丗丝丂万且>, System.Boolean>(object:  val_1, method:  System.Boolean 上专一丂丅丟丑东业.丒丑万一丁丕东一丗::七丒丏丙丑一丄丅且(System.Collections.Generic.KeyValuePair<int, 三丅丁丗丗丝丂万且> 丈丏万丄丒业丅丒一))), selector:  val_12), second:  this.万丑丏东三丑丞与丏.Keys), predicate:  val_16));
            if(val_18.Count >= 1)
            {
                    上专一丂丅丟丑东业.丒东不万丞丑七丕丘 val_20 = null;
                val_37 = val_20;
                val_20 = new 上专一丂丅丟丑东业.丒东不万丞丑七丕丘();
                .东丟且丗且三专丙丁 = val_23;
                .东且丁丆丛丁丏丘且 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
                System.Action<System.Int32> val_22 = null;
                val_23 = val_22;
                val_22 = new System.Action<System.Int32>(object:  val_20, method:  System.Void 上专一丂丅丟丑东业.丒东不万丞丑七丕丘::丏专丆七一一东丁丙(int 七丞丙丒三丕且丌丟));
                val_18.ForEach(action:  val_22);
                val_38 = (上专一丂丅丟丑东业.丒东不万丞丑七丕丘)[1152921541228773088].东且丁丆丛丁丏丘且;
                return (System.Collections.Generic.Dictionary<System.Int32, System.Int32>)val_38;
            }
            
            val_38 = 0;
            return (System.Collections.Generic.Dictionary<System.Int32, System.Int32>)val_38;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 29;
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
            object val_5;
            object val_14;
            var val_15;
            val_14 = this;
            new PGCompany.上丅丙丟不业不丆东() = new PGCompany.上丅丙丟不业不丆东();
            this.万丑丏东三丑丞与丏 = new PGCompany.上丅丙丟不业不丆东();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_10:
            if(((-2032330624) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            this.万丑丏东三丑丞与丏.Add(下上丐丆丝丟丝丒不:  System.Convert.ToInt32(value:  val_6._value._obj.丐丏七丌丕丗业且上(), provider:  System.Globalization.CultureInfo.InvariantCulture), 丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_6._value._obj, provider:  System.Globalization.CultureInfo.InvariantCulture));
            goto label_10;
            label_4:
            val_15 = 0;
            val_14 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(108 != 108)
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
            if(this.万丑丏东三丑丞与丏 != null)
            {
                    return this.万丑丏东三丑丞与丏.丁丕上三丕丌丟丗丙();
            }
            
            return this.万丑丏东三丑丞与丏.丁丕上三丕丌丟丗丙();
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 与世丄万丈丈上丆下()
        {
            var val_7;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_9;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_11;
            val_7 = null;
            val_7 = null;
            val_9 = 上专一丂丅丟丑东业.<>c.<>9__14_0;
            if(val_9 == null)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 上专一丂丅丟丑东业.<>c::丄丅丟七丈万丞丏丒(System.Collections.Generic.KeyValuePair<int, int> 丈丏万丄丒业丅丒一));
                val_7 = null;
                上专一丂丅丟丑东业.<>c.<>9__14_0 = val_9;
            }
            
            val_7 = null;
            val_11 = 上专一丂丅丟丑东业.<>c.<>9__14_1;
            if(val_11 == null)
            {
                    val_11 = null;
                val_11 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  上专一丂丅丟丑东业.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 上专一丂丅丟丑东业.<>c::丏丝丅三业丙丄万丂(System.Collections.Generic.KeyValuePair<int, int> 丈丏万丄丒业丅丒一));
                上专一丂丅丟丑东业.<>c.<>9__14_1 = val_11;
            }
            
            this.万丑丏东三丑丞与丏 = PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  Progress.七七世万专丕丁上业.专且丙一与丐业丙丄().三东丈丑丆丆丅东且(), keySelector:  null, elementSelector:  null));
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.上专一丂丅丟丑东业.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.上专一丂丅丟丑东业.丐丌丞上世丛丐丏丛;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.万丑丏东三丑丞与丏.Clear();
        }
        public 上专一丂丅丟丑东业()
        {
        
        }
        private static 上专一丂丅丟丑东业()
        {
            Progress.上专一丂丅丟丑东业.丕丟一七丑丙丂丆丙 = "FiuSl_V17";
            Progress.上专一丂丅丟丑东业.丐丌丞上世丛丐丏丛 = "FiuSl_2019_V17";
        }
    
    }

}

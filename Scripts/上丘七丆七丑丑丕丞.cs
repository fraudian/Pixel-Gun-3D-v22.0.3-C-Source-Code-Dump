using UnityEngine;
public sealed class 上丘七丆七丑丑丕丞
{
    // Fields
    private static readonly 上丘七丆七丑丑丕丞 世丒丞七专三与万丕;
    private string <丛下世丑万丞丄丙丑>k__BackingField;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 一丗丗不丞丟丌丂丘;
    
    // Properties
    internal static 上丘七丆七丑丑丕丞 丆丕丝丒不丙且丐丗 { get; }
    private string 丛业丐丈三丏丘世丆 { get; }
    public string 丄丞世东专且丞且丘 { get; set; }
    
    // Methods
    internal static 上丘七丆七丑丑丕丞 丑七不且上丗丁一世()
    {
        null = null;
        return (上丘七丆七丑丑丕丞)上丘七丆七丑丑丕丞.世丒丞七专三与万丕;
    }
    private string 三丄丈丞一专丝丛丛()
    {
        return "Statistics.CategoriesKillRate";
    }
    public string 且三丛丟上丕丘丌丝()
    {
        return (string)this.<丛下世丑万丞丄丙丑>k__BackingField;
    }
    public void 丁上三东丝丞万专丟(string 丙业与丙丗丝不丈东)
    {
        this.<丛下世丑万丞丄丙丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private 上丘七丆七丑丑丕丞()
    {
    
    }
    internal void 丑与七丑丒不丏下专(string 丝三丛且丘不丌丙下)
    {
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丝三丛且丘不丌丙下);
        if(val_1 == null)
        {
                return;
        }
        
        this.丑与七丑丒不丏下专(七丆丒与丗丌丄且丂:  val_1.万上丄下业丛丌不丈() - 1);
    }
    internal void 丑与七丑丒不丏下专(CategoryNames 七丆丒与丗丌丄且丂)
    {
        var val_11;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_1 = this.丈丑三丏东丅丐且丙();
        if((val_1.ContainsKey(key:  this.<丛下世丑万丞丄丙丑>k__BackingField)) != true)
        {
                val_1.Add(key:  this.<丛下世丑万丞丄丙丑>k__BackingField, value:  new System.Collections.Generic.Dictionary<System.Int32, System.Int32>());
        }
        
        if((val_1.Item[this.<丛下世丑万丞丄丙丑>k__BackingField].ContainsKey(key:  七丆丒与丗丌丄且丂)) != true)
        {
                val_1.Item[this.<丛下世丑万丞丄丙丑>k__BackingField].Add(key:  七丆丒与丗丌丄且丂, value:  0);
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_7 = val_1.Item[this.<丛下世丑万丞丄丙丑>k__BackingField];
        if(val_7 != null)
        {
                val_11 = val_7.Item[七丆丒与丗丌丄且丂];
        }
        else
        {
                val_11 = val_7.Item[七丆丒与丗丌丄且丂];
        }
        
        val_7.set_Item(key:  七丆丒与丗丌丄且丂, value:  val_11 + 1);
    }
    internal System.Collections.Generic.List<CategoryNames> 与丘东七丑丒七丗东(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
    {
        var val_19;
        var val_30;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_32;
        var val_34;
        var val_35;
        var val_38;
        var val_40;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_42;
        var val_43;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, CategoryNames> val_45;
        上丘七丆七丑丑丕丞.世东丒与丞七不不东 val_1 = new 上丘七丆七丑丑丕丞.世东丒与丞七不不东();
        .丁丂专业丁丅丅丈丙 = System.StringComparer.Ordinal;
        .万万丞不丝丛不丝丐 = ;
        .丙丆丁丗丗业万一丄 = ;
        val_30 = null;
        val_30 = null;
        val_32 = 上丘七丆七丑丑丕丞.<>c.<>9__13_2;
        if(val_32 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_8 = null;
            val_32 = val_8;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.Int32, System.Int32> 上丘七丆七丑丑丕丞.<>c::丘一丅丙丗丘丘丞丐(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 三丟东丕丄丄下下丑));
            上丘七丆七丑丑丕丞.<>c.<>9__13_2 = val_32;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_10 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        var val_33 = 0;
        val_33 = val_33 + 1;
        System.Collections.Generic.IEnumerator<T> val_12 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>>(source:  this.丈丑三丏东丅丐且丙(), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Boolean>(object:  val_1, method:  System.Boolean 上丘七丆七丑丑丕丞.世东丒与丞七不不东::下丄丌丝三专丕丆上(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 七丏丄丅丌业与且丙))), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Boolean>(object:  val_1, method:  System.Boolean 上丘七丆七丑丑丕丞.世东丒与丞七不不东::不丐丄丑万万且下且(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 七丏丄丅丌业与且丙))), selector:  val_8).GetEnumerator();
        val_34 = 0;
        val_35 = 0;
        var val_36 = 0;
        label_50:
        if(val_12 != null)
        {
            goto label_47;
        }
        
        label_48:
        label_47:
        var val_34 = 0;
        val_34 = val_34 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_21;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        Dictionary.Enumerator<TKey, TValue> val_17 = val_12.Current.GetEnumerator();
        label_34:
        if(((-494542016) & 1) == 0)
        {
            goto label_28;
        }
        
        string val_20 = val_19.丐丏七丌丕丗业且上();
        if((val_10.ContainsKey(key:  val_20.丙东专丂世丈丏丁丂())) != true)
        {
                val_10.set_Item(key:  val_20.丙东专丂世丈丏丁丂(), value:  0);
        }
        
        int val_24 = val_20.丙东专丂世丈丏丁丂();
        val_10.set_Item(key:  val_24, value:   + val_10.Item[val_24]);
        goto label_34;
        label_28:
        val_36 = val_36 + 1;
        val_38 = val_35;
        mem2[0] = 258;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_36 == 1) || ((-494542080 + ((0 + 1)) << 2) != 258))
        {
            goto label_46;
        }
        
        var val_37 = 0;
        val_37 = val_37 ^ (val_36 >> 31);
        val_36 = val_36 + val_37;
        if(val_12 != null)
        {
            goto label_47;
        }
        
        goto label_48;
        label_46:
        if( == 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_21:
        val_36 = val_36 + 1;
        mem2[0] = 278;
        if(val_12 == null)
        {
            
        }
        else
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_12.Dispose();
        }
        
        if(val_36 == 1)
        {
            goto label_63;
        }
        
        if(( == 0) || ((-494542080 + ((0 + 1)) << 2) == 278))
        {
            goto label_77;
        }
        
        label_76:
        label_77:
        val_40 = null;
        val_40 = null;
        val_42 = 上丘七丆七丑丑丕丞.<>c.<>9__13_3;
        if(val_42 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_28 = null;
            val_42 = val_28;
            val_28 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 上丘七丆七丑丑丕丞.<>c::丅且业三一丞丈丒丁(System.Collections.Generic.KeyValuePair<int, int> 三丟东丕丄丄下下丑));
            上丘七丆七丑丑丕丞.<>c.<>9__13_3 = val_42;
        }
        
        val_43 = null;
        val_43 = null;
        val_45 = 上丘七丆七丑丑丕丞.<>c.<>9__13_4;
        if(val_45 != null)
        {
                return (System.Collections.Generic.List<CategoryNames>)System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, CategoryNames>(source:  System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(source:  val_10, keySelector:  val_28), selector:  System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, CategoryNames> val_30 = null));
        }
        
        val_45 = val_30;
        val_30 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, CategoryNames>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 上丘七丆七丑丑丕丞.<>c::丈丞丈丆丒丙丄下上(System.Collections.Generic.KeyValuePair<int, int> 三丟东丕丄丄下下丑));
        上丘七丆七丑丑丕丞.<>c.<>9__13_4 = val_45;
        return (System.Collections.Generic.List<CategoryNames>)System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, CategoryNames>(source:  System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(source:  val_10, keySelector:  val_28), selector:  val_30));
        label_63:
        if( != 0)
        {
            goto label_76;
        }
        
        goto label_77;
    }
    internal void 丂且不业丂专丛丆东()
    {
        System.Collections.Generic.IEnumerable<TSource> val_11;
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String> val_14;
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String> val_17;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_19;
        val_11 = this.丈丑三丏东丅丐且丙();
        if(val_11.Count >= 101)
        {
                val_12 = null;
            val_12 = null;
            val_14 = 上丘七丆七丑丑丕丞.<>c.<>9__14_0;
            if(val_14 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String> val_4 = null;
            val_14 = val_4;
            val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  System.String 上丘七丆七丑丑丕丞.<>c::丑下万丂专丆且丛丅(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 三丟东丕丄丄下下丑));
            上丘七丆七丑丑丕丞.<>c.<>9__14_0 = val_14;
        }
        
            val_15 = null;
            val_15 = null;
            val_17 = 上丘七丆七丑丑丕丞.<>c.<>9__14_1;
            if(val_17 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String> val_7 = null;
            val_17 = val_7;
            val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  System.String 上丘七丆七丑丑丕丞.<>c::丕丘丁丞七丙丄与三(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 丟三下万一丄七一丗));
            val_15 = null;
            上丘七丆七丑丑丕丞.<>c.<>9__14_1 = val_17;
        }
        
            val_15 = null;
            val_19 = 上丘七丆七丑丑丕丞.<>c.<>9__14_2;
            if(val_19 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_8 = null;
            val_19 = val_8;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(object:  上丘七丆七丑丑丕丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.Int32, System.Int32> 上丘七丆七丑丑丕丞.<>c::丕与不丐丛丝丒丘上(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<int, int>> 业下丌下三丕丙丌下));
            上丘七丆七丑丑丕丞.<>c.<>9__14_2 = val_19;
        }
        
            val_11 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(source:  System.Linq.Enumerable.Take<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>>(source:  System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>, System.String>(source:  val_11, keySelector:  val_4, comparer:  System.StringComparer.Ordinal), count:  50), keySelector:  val_7, elementSelector:  val_8);
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Statistics.CategoriesKillRate", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_11));
    }
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丈丑三丏东丅丐且丙()
    {
        var val_8;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(this.一丗丗不丞丟丌丂丘 != null)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
        }
        
        val_20 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Statistics.CategoriesKillRate"));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
        val_20 = val_3;
        val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        this.一丗丗不丞丟丌丂丘 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>();
        Dictionary.Enumerator<TKey, TValue> val_5 = val_3.GetEnumerator();
        val_21 = 0;
        val_22 = 0;
        var val_18 = 0;
        label_34:
        if(((-494120336) & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_10 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_9._value._obj != 0)
        {
                val_23 = null;
        }
        
        if(val_9._value._obj != 0)
        {
                val_23 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        label_20:
        if(((-494120400) & 1) == 0)
        {
            goto label_16;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_8.GetAwaiter();
        null.Add(key:  System.Convert.ToInt32(value:  val_13._value._obj.丐丏七丌丕丗业且上()), value:  System.Convert.ToInt32(value:  -494120416));
        goto label_20;
        label_16:
        val_18 = val_18 + 1;
        mem2[0] = 162;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_18 != 1) && ((-494120480 + ((0 + 1)) << 2) == 162))
        {
                var val_19 = 0;
            val_19 = val_19 ^ (val_18 >> 31);
            val_18 = val_18 + val_19;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        this.一丗丗不丞丟丌丂丘.Add(key:  val_9._value._obj.丐丏七丌丕丗业且上(), value:  null);
        goto label_34;
        label_9:
        val_18 = val_18 + 1;
        mem2[0] = 206;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_18 != 1)
        {
                if( == 0)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
        }
        
            if((-494120480 + ((0 + 1)) << 2) == 206)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
        }
        
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
        }
        
        if( != 0)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
        }
        
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)this.一丗丗不丞丟丌丂丘;
    }
    private static 上丘七丆七丑丑丕丞()
    {
        上丘七丆七丑丑丕丞.世丒丞七专三与万丕 = new 上丘七丆七丑丑丕丞();
    }

}

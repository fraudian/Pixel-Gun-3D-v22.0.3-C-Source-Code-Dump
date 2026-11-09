using UnityEngine;
internal static class 丅丄丕不丏丛三丑一
{
    // Fields
    private static System.Collections.Generic.List<string> 万一万丌与一世丌与;
    
    // Methods
    internal static bool 与丕三七上专丄丗与(string 丐世下不一丁丟丅专)
    {
        var val_6;
        var val_9;
        var val_12;
        System.Collections.Generic.Dictionary<System.String, SetsSettings> val_19;
        CategoryNames val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        SetsConfig val_1 = SetsConfig.Instance;
        val_19 = val_1.dictionarySetSettings;
        if((val_19.ContainsKey(key:  丐世下不一丁丟丅专)) == false)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<ItemSetsInfo> val_3 = null;
        val_19 = val_3;
        val_3 = new System.Collections.Generic.List<ItemSetsInfo>();
        SetsConfig val_4 = SetsConfig.Instance;
        SetsSettings val_5 = val_4.dictionarySetSettings.Item[丐世下不一丁丟丅专];
        List.Enumerator<T> val_7 = val_6.GetEnumerator();
        val_20 = 0;
        val_21 = 0;
        var val_18 = 0;
        label_19:
        if((1268656192 & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
        List.Enumerator<T> val_11 = val_10._value._token.GetEnumerator();
        label_11:
        if((1268656160 & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_14 = val_12.GetAwaiter();
        val_3.Add(item:  new ItemSetsInfo() {idItem = val_14._value._obj, categoryNames = val_14._value._token});
        goto label_11;
        label_9:
        val_18 = val_18 + 1;
        mem2[0] = 116;
        val_22 = val_21;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_18 == 1) || ((1152921540235241376 + ((0 + 1)) << 2) != 116))
        {
            goto label_16;
        }
        
        var val_19 = 0;
        val_19 = val_19 ^ (val_18 >> 31);
        val_18 = val_18 + val_19;
        goto label_19;
        label_16:
        if( == 0)
        {
            goto label_19;
        }
        
        goto label_19;
        label_7:
        val_23 = val_18 + 1;
        mem2[0] = 141;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_18 == 1) || ((1152921540235241376 + ((0 + 1)) << 2) != 141))
        {
            goto label_25;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ (val_18 >> 31);
        val_23 = val_18 + val_20;
        if(val_19 != null)
        {
            goto label_29;
        }
        
        goto label_27;
        label_25:
        if( != 0)
        {
                val_21 = 0;
        }
        
        if(val_19 != null)
        {
            goto label_29;
        }
        
        label_27:
        label_29:
        List.Enumerator<T> val_15 = val_3.GetEnumerator();
        label_34:
        if((1268656160 & 1) == 0)
        {
            goto label_30;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_9.GetAwaiter();
        val_19 = val_16._value._obj;
        val_20 = val_16._value._token;
        if((val_20 == 7) || ((丅丄丕不丏丛三丑一.丟丛丝业丄丄业丘业(丈丁丐丌三丟与一丕:  val_20, 下丅丙一丂丗丅丝七:  val_19)) == true))
        {
            goto label_34;
        }
        
        val_24 = val_18 + 1;
        val_25 = 224;
        goto label_35;
        label_30:
        val_24 = val_18 + 1;
        val_25 = 220;
        label_35:
        mem2[0] = 220;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_24 == 1)
        {
            goto label_39;
        }
        
        if((1152921540235241376 + (((0 + 1) + 1)) << 2) != 224)
        {
            goto label_40;
        }
        
        label_3:
        val_26 = 0;
        return (bool)val_26;
        label_39:
        if( != 0)
        {
            goto label_42;
        }
        
        goto label_43;
        label_40:
        val_26 = 1;
        if( == 0)
        {
                return (bool)val_26;
        }
        
        if((1152921540235241376 + (((0 + 1) + 1)) << 2) == 220)
        {
                return (bool)val_26;
        }
        
        label_42:
        label_43:
        val_26 = 1;
        return (bool)val_26;
    }
    internal static System.Collections.Generic.List<string> 丏专丄专丙丑丈丗丕()
    {
        System.Collections.Generic.IEnumerable<T> val_5;
        var val_7;
        System.Collections.Generic.Dictionary<System.String, SetsSettings> val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        丅丄丕不丏丛三丑一.万一万丌与一世丌与.Clear();
        SetsConfig val_1 = SetsConfig.Instance;
        val_8 = val_1.dictionarySetSettings;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_8.GetEnumerator();
        label_13:
        if((1268852096 & 1) == 0)
        {
            goto label_6;
        }
        
        if((丅丄丕不丏丛三丑一.与丕三七上专丄丗与(丐世下不一丁丟丅专:  丐丏七丌丕丗业且上())) == false)
        {
            goto label_13;
        }
        
        val_9 = null;
        val_9 = null;
        丅丄丕不丏丛三丑一.万一万丌与一世丌与.AddRange(collection:  val_5);
        goto label_13;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_10 = null;
        val_10 = null;
        return (System.Collections.Generic.List<System.String>)丅丄丕不丏丛三丑一.万一万丌与一世丌与;
    }
    private static bool 丟丛丝业丄丄业丘业(CategoryNames 丈丁丐丌三丟与一丕, string 下丅丙一丂丗丅丝七)
    {
        string val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七)) == true)
        {
            goto label_32;
        }
        
        val_19 = 1152921505259880448;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  丈丁丐丌三丟与一丕)) == false)
        {
            goto label_6;
        }
        
        val_20 = 1152921505286238208;
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_32;
        }
        
        val_22 = null;
        val_22 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与() == null)
        {
                return (bool)val_23;
        }
        
        val_24 = null;
        val_24 = null;
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        int val_6 = val_23.Count;
        if(val_6 == 0)
        {
                return (bool)val_23;
        }
        
        do
        {
            val_25 = null;
            val_25 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0] != null)
        {
                if((System.String.op_Equality(a:  下丅丙一丂丗丅丝七, b:  val_8.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛())) == true)
        {
                return (bool)val_23;
        }
        
        }
        
            val_19 = 0 + 1;
            val_23 = 0;
        }
        while(val_6 != val_19);
        
        return (bool)val_23;
        label_6:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  丈丁丐丌三丟与一丕)) == false)
        {
            goto label_32;
        }
        
        val_19 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  丈丁丐丌三丟与一丕);
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_14 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().Item[丈丁丐丌三丟与一丕];
        int val_15 = val_14.Count;
        if(val_15 == 0)
        {
            goto label_45;
        }
        
        label_43:
        System.Collections.Generic.List<System.String> val_16 = val_14.Item[0];
        if((val_16.Contains(item:  下丅丙一丂丗丅丝七)) == true)
        {
            goto label_42;
        }
        
        val_20 = 0 + 1;
        if(val_15 != val_20)
        {
            goto label_43;
        }
        
        goto label_45;
        label_42:
        if(val_16 != null)
        {
                return val_16.Contains(item:  val_19);
        }
        
        label_45:
        object[] val_18 = new object[1];
        val_18[0] = 下丅丙一丂丗丅丝七;
        UnityEngine.Debug.LogErrorFormat(format:  "wear not found: {0}", args:  val_18);
        label_32:
        val_23 = 0;
        return (bool)val_23;
    }
    private static 丅丄丕不丏丛三丑一()
    {
        丅丄丕不丏丛三丑一.万一万丌与一世丌与 = new System.Collections.Generic.List<System.String>();
    }

}

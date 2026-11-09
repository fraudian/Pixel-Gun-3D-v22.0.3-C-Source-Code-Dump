using UnityEngine;
internal static class 不丑世不专上专专丝
{
    // Fields
    private static System.Collections.Generic.HashSet<string> 与丁丏专世丑与一丑;
    private static System.Collections.Generic.List<CategoryNames> 丙丅专不丌丛丕丌丗;
    private static System.Collections.Generic.List<ItemRarity> 且丗万一上丈丅丄丆;
    private static System.Collections.Generic.List<int> 丝丏万不三不丝丘丄;
    
    // Properties
    private static System.Collections.Generic.HashSet<string> 不上丅丁七丒丕与七 { get; }
    
    // Methods
    internal static string 七三下丝与世世下上(string 丆万一不丌且东丐丐)
    {
        System.Object[] val_8;
        var val_9;
        var val_10;
        string val_1 = 不丑世不专上专专丝.丒丕东丐丅丙与丗且(丆万一不丌且东丐丐:  丆万一不丌且东丐丐);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
        {
                object[] val_3 = new object[1];
            val_8 = val_3;
            val_8[0] = (丆万一不丌且东丐丐 == null) ? "null" : 丆万一不丌且东丐丐;
            UnityEngine.Debug.LogErrorFormat(format:  "GetInappPriceForTryGun idInapp.IsNullOrEmpty , tag = {0}", args:  val_3);
            val_9 = 0;
            return (string)val_9;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_1);
        if(val_8 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = val_8;
            return (string)val_9;
        }
        
        val_9 = 0;
        return (string)val_9;
    }
    internal static string 丒丕东丐丅丙与丗且(string 丆万一不丌且东丐丐)
    {
        System.Object[] val_9;
        var val_10;
        var val_11;
        System.Int32[] val_12;
        var val_13;
        object val_14;
        var val_15;
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丆万一不丌且东丐丐);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_9 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().丗丁丛丂一一一不世(丈丘丝一丗下丈丐不:  val_1.七丙丛与万且专三三(), 丈下丑丆上丏丗丈专:  val_1.丆丙专丆丅丟丙与丈());
        val_10 = 0;
        goto label_5;
        label_14:
        val_11 = null;
        val_11 = null;
        val_12 = 0;
        if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_9)
        {
            goto label_10;
        }
        
        val_10 = 1;
        label_5:
        val_13 = null;
        val_13 = null;
        val_12 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
        if(val_10 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        object[] val_6 = new object[1];
        val_9 = val_6;
        val_9[0] = (丆万一不丌且东丐丐 == null) ? "null" : 丆万一不丌且东丐丐;
        UnityEngine.Debug.LogErrorFormat(format:  "GetInappOff_erIdForTryGun rec == null , tag = {0}", args:  val_6);
        val_14 = 0;
        return (string)val_14;
        label_10:
        val_15 = null;
        val_15 = null;
        val_9 = StoreKitEventListener.业万专三一丟且丘业;
        val_14 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
        val_14 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
        return (string)val_14;
        label_15:
        val_14 = 0;
        return (string)val_14;
    }
    internal static void 东一专丅下丌丟上东(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业, UnityEngine.Transform 丅专与丒丈丗丒丘丌, string 丘不七东下丌丑丁丂, System.Action 丏丄下东丁丝与丌不, System.Action 且上丌丏三丏丑七丌, bool 业丑丒丅丝丆丝丕丑 = False)
    {
        string val_14;
        var val_15;
        var val_16;
        TryGunScreenController val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  (业丑丒丅丝丆丝丕丑 != true) ? "NguiWindows/BuyTryGunWindow" : "TryGunScreen")).GetComponent<TryGunScreenController>();
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  丘不七东下丌丑丁丂));
        val_14 = val_4.transform;
        val_14.parent = 丅专与丒丈丗丒丘丌;
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(业丑丒丅丝丆丝丕丑 != false)
        {
                val_15 = null;
            val_15 = null;
            val_14 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
            if((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  val_14)) != true)
        {
                val_16 = null;
            val_16 = null;
            WeaponManager.丟丗丄业丘丗业丗七.丁丁丌丘万下丕七丆(丆丐七世世且丏丐业:  丆丐七世世且丏丐业);
        }
        
        }
        
        val_4.业三丌世丕丆三丈丙(丒东业不丐丑丕丄丆:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 丗三专万丌且丂世七:  业丑丒丅丝丆丝丕丑);
        if(val_4 != null)
        {
                val_4.一丝东下不丛丟世三 = 丏丄下东丁丝与丌不;
        }
        else
        {
                mem[160] = 丏丄下东丁丝与丌不;
        }
        
        val_4.丝与丑三三不丄三丏 = 且上丌丏三丏丑七丌;
    }
    private static 三丅丁丗丗丝丂万且 专丐丟不丈丑东丝不()
    {
        object val_145;
        var val_146;
        var val_147;
        var val_148;
        var val_149;
        var val_150;
        object val_151;
        var val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_158;
        var val_159;
        丕丑丙丑丙东丌丘丕 val_160;
        var val_161;
        var val_162;
        var val_163;
        System.Comparison<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>> val_165;
        var val_166;
        var val_167;
        var val_168;
        var val_169;
        var val_170;
        var val_171;
        var val_172;
        var val_173;
        var val_174;
        var val_176;
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_177;
        System.Comparison<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>> val_178;
        var val_179;
        var val_180;
        System.Predicate<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>> val_182;
        var val_183;
        int val_184;
        var val_185;
        var val_187;
        var val_188;
        System.Comparison<三丅丁丗丗丝丂万且> val_189;
        val_145 = new 不丑世不专上专专丝.上丌专丄丘丂东且丒();
        val_145 = new System.Object();
        .下丈下业丝上丟上丅 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().万七一丛三丟三丞不();
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>> val_9 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>>();
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_10 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_11 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_12 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_13 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_14 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_15 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>());
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>> val_17 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>>(capacity:  null.Count);
        System.Collections.Generic.List<System.Int32> val_19 = new System.Collections.Generic.List<System.Int32>(capacity:  null.Count);
        .丆丅丟丞上丈丂上上 = null;
        val_146 = 0;
        goto label_16;
        label_19:
        (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].丆丅丟丞上丈丂上上.Add(item:  0);
        val_146 = 1;
        label_16:
        if(val_146 < null.Count)
        {
            goto label_19;
        }
        
        val_147 = null;
        val_147 = null;
        List.Enumerator<T> val_22 = WeaponManager.丟丗丄业丘丗业丗七.丘一丄丕不专上三丅().GetEnumerator();
        label_43:
        if((180852992 & 1) == 0)
        {
            goto label_24;
        }
        
        string val_24 = 0.丐丏七丌丕丗业且上();
        if((((((val_24 == null) || (val_24.东七与与不丅丙上上() == true)) || (val_24.与丕丒世七丁万丂丛() == false)) || ((WeaponManager.丞上一丘丆三下丐丑().Contains(item:  val_24.三与丛丑且丐丈业丌())) == true)) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_24.业东丅东丌上丗丑不())) == null)) || ((不丑世不专上专专丝.丁下一丆丙不世七三().Contains(item:  val_24.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_43;
        }
        
        CategoryNames val_36 = val_24.丒万丕七专不丏丞丌();
        (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].丆丅丟丞上丈丂上上.set_Item(index:  val_36, value:  (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].丆丅丟丞上丈丂上上.Item[val_36] + 1);
        goto label_43;
        label_24:
        val_148 = 180852672;
        val_149 = 0;
        val_150 = 1152921505264140288;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(( != 1) && ( == 386))
        {
                val_149 = 0;
        }
        else
        {
                if(0 != 0)
        {
            
        }
        
        }
        
        val_153 = null;
        不丑世不专上专专丝.丙丅专不丌丛丕丌丗.Clear();
        if(不丑世不专上专专丝.且丗万一上丈丅丄丆.Count == 0)
        {
            goto label_101;
        }
        
        label_114:
        var val_145 = 0;
        do
        {
            val_154 = null;
            val_154 = null;
            int val_40 = val_145 + 1;
            不丑世不专上专专丝.且丗万一上丈丅丄丆.set_Item(index:  val_40, value:  0);
            不丑世不专上专专丝.丝丏万不三不丝丘丄.set_Item(index:  val_40, value:  0);
            val_145 = val_145 + 1;
        }
        while(val_145 <= 4);
        
        val_155 = null;
        val_156 = ;
        goto label_115;
        label_101:
        var val_146 = 0;
        do
        {
            val_157 = null;
            val_157 = null;
            不丑世不专上专专丝.且丗万一上丈丅丄丆.Add(item:  0);
            不丑世不专上专专丝.丝丏万不三不丝丘丄.Add(item:  0);
            val_146 = val_146 + 1;
        }
        while(val_146 <= 4);
        
        goto label_114;
        label_115:
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_41 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        var val_147 = 0;
        if(val_41 != null)
        {
            goto label_158;
        }
        
        label_159:
        label_158:
        if(val_147 >= val_41.Count)
        {
            goto label_118;
        }
        
        if(val_41.Item[0] != null)
        {
                三丈丟与丏丘丈丐万 val_44 = val_41.Item[0];
            if(val_44.三丐三丞丘丕不丒专 != null)
        {
                三丈丟与丏丘丈丐万 val_45 = val_41.Item[0];
            if(val_45.三丐三丞丘丕不丒专 == 5)
        {
                val_158 = null;
            val_158 = null;
            三丈丟与丏丘丈丐万 val_46 = val_41.Item[0];
            不丑世不专上专专丝.丙丅专不丌丛丕丌丗.Add(item:  val_46.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌());
        }
        
            val_159 = null;
            val_159 = null;
            三丈丟与丏丘丈丐万 val_48 = val_41.Item[0];
            三丈丟与丏丘丈丐万 val_50 = val_41.Item[0];
            不丑世不专上专专丝.且丗万一上丈丅丄丆.set_Item(index:  val_48.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌(), value:  val_50.三丐三丞丘丕不丒专);
            三丈丟与丏丘丈丐万 val_51 = val_41.Item[0];
            val_160 = val_51.三丐三丞丘丕不丒专.七丑丌专丒上丒丙七();
            if(val_160 == null)
        {
                三丈丟与丏丘丈丐万 val_53 = val_41.Item[0];
            val_160 = val_53.三丐三丞丘丕不丒专.丐七丐丝与丒七丈丐();
        }
        
            val_161 = null;
            val_161 = null;
            三丈丟与丏丘丈丐万 val_55 = val_41.Item[0];
            不丑世不专上专专丝.丝丏万不三不丝丘丄.set_Item(index:  val_55.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌(), value:  BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_160));
        }
        
        }
        
        val_147 = val_147 + 1;
        if(val_41 != null)
        {
            goto label_158;
        }
        
        goto label_159;
        label_118:
        int val_60 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  74);
        val_162 = 1152921505264246784;
        label_389:
        val_163 = null;
        val_163 = null;
        val_165 = 不丑世不专上专专丝.<>c.<>9__3_0;
        if(val_165 == null)
        {
                val_162 = 1152921505264246784;
            val_165 = null;
            val_165 = new System.Comparison<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>>(object:  不丑世不专上专专丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 不丑世不专上专专丝.<>c::丗万丏丗东世专丙丘(System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 东丄且丁丑丈丆与万, System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丟丂丞世丈丈丑世东));
            不丑世不专上专专丝.<>c.<>9__3_0 = val_165;
        }
        
        null.Sort(comparison:  null);
        val_166 = 0;
        goto label_196;
        label_200:
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_62 = null.Item[0];
        val_62.Value.Clear();
        val_166 = 1;
        label_196:
        if(val_166 < null.Count)
        {
            goto label_200;
        }
        
        null.Clear();
        Dictionary.Enumerator<TKey, TValue> val_64 = (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].下丈下业丝上丟上丅.GetEnumerator();
        label_273:
        if((180852928 & 1) == 0)
        {
            goto label_204;
        }
        
        ConfiguredValueTaskAwaiter val_67 = 0.GetAwaiter();
        三丅丁丗丗丝丂万且 val_69 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_67._value._obj.丐丏七丌丕丗业且上());
        if(((val_69 == null) || (val_69.东七与与不丅丙上上() == true)) || (val_69.与丕丒世七丁万丂丛() == false))
        {
            goto label_273;
        }
        
        val_167 = null;
        val_167 = null;
        if((((((((System.String.op_Equality(a:  val_69.与不丞丑七丘丁丂丛(), b:  WeaponManager.丑与一世丛丄业丐丒)) == true) || (val_69.七丙丛与万且专三三() < (UnityEngine.Mathf.Max(a:  1, b:  ExperienceController.丞丞丘业东丙丏七丌() - PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().专丏与丈丙专丐且丗())))) || (val_69.七丙丛与万且专三三() > ExperienceController.丞丞丘业东丙丏七丌())) || (val_69.丆丙专丆丅丟丙与丈() != 4)) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_69.业东丅东丌上丗丑不())) != null)) || ((WeaponManager.丞上一丘丆三下丐丑().Contains(item:  val_69.三与丛丑且丐丈业丌())) == true)) || ((WeaponManager.丐上业丐丏丐万世丑().Contains(item:  val_69.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_273;
        }
        
        val_168 = null;
        val_168 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_69.与不丞丑七丘丁丂丛())) == true)
        {
            goto label_273;
        }
        
        val_169 = null;
        val_169 = null;
        if(((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  val_69.与不丞丑七丘丁丂丛())) == true) || ((不丑世不专上专专丝.丁下一丆丙不世七三().Contains(item:  val_69.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_273;
        }
        
        val_170 = null;
        val_170 = null;
        if(4 < 不丑世不专上专专丝.且丗万一上丈丅丄丆.Item[val_69.丒万丕七专不丏丞丌()])
        {
            goto label_273;
        }
        
        new 丕丑丙丑丙东丌丘丕() = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  4);
        val_171 = null;
        val_171 = null;
        if((不丑世不专上专专丝.丝丏万不三不丝丘丄.Item[val_69.丒万丕七专不丏丞丌()] >= (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕()))) || ((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  val_69.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_273;
        }
        
        val_172 = null;
        val_172 = null;
        if((System.String.op_Inequality(a:  val_69.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_273;
        }
        
        val_173 = null;
        val_173 = null;
        if((((不丑世不专上专专丝.丙丅专不丌丛丕丌丗.Contains(item:  val_69.丒万丕七专不丏丞丌())) == true) || ((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且七东专世丝丒丟一(丞一丁业丄一一业且:  val_69.与不丞丑七丘丁丂丛(), 专丏世丑与丐丝丝七:  (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1, 丗与丟上上丑专世丗:  new System.Nullable<OfferModule>() {HasValue = false})) == true)) || (val_69.业东丅东丌上丗丑不() == val_60))
        {
            goto label_273;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_117 = null.Item[val_69.丒万丕七专不丏丞丌()];
        val_117.Value.Add(item:  val_69);
        goto label_273;
        label_204:
        val_174 = 180852672;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_176 = 1;
        if((val_176 != 1) && (1461 == 1461))
        {
                val_176 = 1;
            val_177 = ;
        }
        else
        {
                if( != 0)
        {
                val_177 = 0;
        }
        else
        {
                val_177 = 0;
        }
        
        }
        
        if(val_145 == null)
        {
                val_177 = val_177;
        }
        
        val_178 = (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].丂丌丑一丏丌丌世丆;
        if(val_178 == null)
        {
                val_178 = null;
            val_178 = new System.Comparison<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>>(object:  new 不丑世不专上专专丝.上丌专丄丘丂东且丒(), method:  System.Int32 不丑世不专上专专丝.上丌专丄丘丂东且丒::专丝丏不不丆丌丅丆(System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 东丄且丁丑丈丆与万, System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丟丂丞世丈丈丑世东));
            .丂丌丑一丏丌丌世丆 = val_178;
        }
        
        null.Sort(comparison:  null);
        val_179 = 1152921505264246784;
        val_180 = null;
        val_180 = null;
        val_182 = 不丑世不专上专专丝.<>c.<>9__3_2;
        if(val_182 == null)
        {
                val_179 = 1152921505264246784;
            val_182 = null;
            val_182 = new System.Predicate<System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>>(object:  不丑世不专上专专丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 不丑世不专上专专丝.<>c::专丈丅专丑丕丗丌世(System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丈丏万丄丒业丅丒一));
            不丑世不专上专专丝.<>c.<>9__3_2 = val_182;
        }
        
        int val_122 = null.FindIndex(match:  null);
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_123 = null.Item[val_122];
        val_151 = val_123.Value;
        null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_151});
        null.RemoveAt(index:  val_122);
        val_183 = 0;
        goto label_366;
        label_373:
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_124 = null.Item[0];
        val_151;
        if(val_124.Value.Count >= 1)
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_126 = null.Item[0];
            val_151 = val_126.Value;
            null.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_151});
        }
        
        val_183 = 1;
        label_366:
        if(val_183 < (null.Count - 1))
        {
            goto label_373;
        }
        
        if(null.Count < 1)
        {
            goto label_375;
        }
        
        if(null.Count != 4)
        {
            goto label_377;
        }
        
        val_184 = 1;
        goto label_378;
        label_375:
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_133 = null.Item[null.Count - 1];
        if(val_133.Value.Count < 1)
        {
            goto label_382;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_137 = null.Item[null.Count - 1];
        val_185;
        goto label_385;
        label_377:
        int val_138 = null.Count;
        val_184 = ((val_138 < 0) ? (val_138 + 1) : (val_138)) >> 1;
        label_378:
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_140 = null.Item[val_184];
        val_185;
        label_385:
        if(val_140.Value != 0)
        {
            goto label_388;
        }
        
        label_382:
        val_187 = 1152921505264246784;
        if(4 > 3)
        {
            goto label_389;
        }
        
        if((0 & 1) == 0)
        {
            goto label_390;
        }
        
        三丅丁丗丗丝丂万且 val_141 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_60);
        return (三丅丁丗丗丝丂万且)val_188;
        label_388:
        val_189 = (不丑世不专上专专丝.上丌专丄丘丂东且丒)[1152921539147482464].世丆丅专丂丗丛丕丂;
        if(val_189 == null)
        {
                val_189 = null;
            val_189 = new System.Comparison<三丅丁丗丗丝丂万且>(object:  new 不丑世不专上专专丝.上丌专丄丘丂东且丒(), method:  System.Int32 不丑世不专上专专丝.上丌专丄丘丂东且丒::且丂七丏一三且丗专(三丅丁丗丗丝丂万且 与丄丑丗且丗东丗一, 三丅丁丗丗丝丂万且 丕丏丌丕下丁丂丁丆));
            .世丆丅专丂丗丛丕丂 = val_189;
        }
        
        val_140.Value.Sort(comparison:  null);
        三丅丁丗丗丝丂万且 val_143 = val_140.Value.Item[0];
        return (三丅丁丗丗丝丂万且)val_188;
        label_390:
        val_188 = 0;
        return (三丅丁丗丗丝丂万且)val_188;
    }
    private static System.Collections.Generic.HashSet<string> 丁下一丆丙不世七三()
    {
        var val_4;
        var val_5;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_22;
        val_14 = null;
        val_14 = null;
        if(不丑世不专上专专丝.与丁丏专世丑与一丑 != null)
        {
            goto label_43;
        }
        
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        val_15 = null;
        val_15 = null;
        不丑世不专上专专丝.与丁丏专世丑与一丑 = val_1;
        val_16 = null;
        val_16 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = WeaponManager.且专专丁丌丗丛且丙.GetEnumerator();
        val_13 = 0;
        val_17 = 0;
        var val_12 = 0;
        label_28:
        if((181333680 & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(val_4 == 0)
        {
            goto label_28;
        }
        
        HashSet.Enumerator<T> val_9 = WeaponManager.不丗丒丏丄丐丁丑下(专丆丌丛东一不丑丙:  val_6._value._obj.丙东专丂世丈丏丁丂()).GetEnumerator();
        label_19:
        if((181333632 & 1) == 0)
        {
            goto label_15;
        }
        
        val_18 = null;
        val_18 = null;
        bool val_11 = val_1.Add(item:  val_5.丐丏七丌丕丗业且上());
        goto label_19;
        label_15:
        val_12 = val_12 + 1;
        mem2[0] = 120;
        val_19 = val_17;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_12 == 1) || ((1152921539147918912 + ((0 + 1)) << 2) != 120))
        {
            goto label_25;
        }
        
        var val_13 = 0;
        val_13 = val_13 ^ (val_12 >> 31);
        val_12 = val_12 + val_13;
        goto label_28;
        label_25:
        if( == 0)
        {
            goto label_28;
        }
        
        goto label_28;
        label_9:
        val_12 = val_12 + 1;
        mem2[0] = 145;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_12 == 1)
        {
            goto label_37;
        }
        
        if(( == 0) || ((1152921539147918912 + ((0 + 1)) << 2) == 145))
        {
            goto label_43;
        }
        
        label_42:
        label_43:
        val_22 = null;
        val_22 = null;
        return (System.Collections.Generic.HashSet<System.String>)不丑世不专上专专丝.与丁丏专世丑与一丑;
        label_37:
        if( != 0)
        {
            goto label_42;
        }
        
        goto label_43;
    }
    internal static void 丐丗丅丆丘丐丆丏丞(bool 丛丕下丕丞世丂东与, UnityEngine.Transform 丅专与丒丈丗丒丘丌, string 且丅丟丛丛万丝下上)
    {
        WeaponManager val_53;
        object val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        val_53 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈丝下一丗业丛下不();
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                val_54 = 1152921505066536960;
            if((GameConnect.东且三丆丑世世丘丟() != true) && (GameConnect.业丛丛丂一丆丕丗丟() != true))
        {
                if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
        }
        
        label_157:
        val_55 = null;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_53 = 1152921505066536960;
        if(GameConnect.业丛丛丂一丆丕丗丟() == true)
        {
                return;
        }
        
        if(GameConnect.不专专丂万丝上东丐() == true)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        val_56 = null;
        val_56 = null;
        val_53 = WeaponManager.丟丗丄业丘丗业丗七;
        if( != 0)
        {
                return;
        }
        
        if(WeaponManager.丘丘丑上丁丑丁丟七() == false)
        {
                return;
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丛不丆丕且丗丏丑丒() == false)
        {
                return;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
                return;
        }
        
        val_53 = 不丑世不专上专专丝.专丐丟不丈丑东丝不();
        if(val_53 == null)
        {
            goto label_52;
        }
        
        int val_19 = val_53.业东丅东丌上丗丑不();
        val_54 = val_19;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  74, 丙业与丙丗丝不丈东:  val_19);
        不丑世不专上专专丝.东一专丅下丌丟上东(丆丐七世世且丏丐业:  val_53, 丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丘不七东下丌丑丁丂:  且丅丟丛丛万丝下上, 丏丄下东丁丝与丌不:  0, 且上丌丏三丏丑七丌:  0, 业丑丒丅丝丆丝丕丑:  false);
        return;
        label_18:
        if((GameConnect.万不丒丌丙万丗东不() == true) || (丛丕下丕丞世丂东与 == true))
        {
            goto label_157;
        }
        
        val_57 = null;
        val_57 = null;
        if(((WeaponManager.丟丗丄业丘丗业丗七 == 0) || (丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)) || (val_53.Count < 1))
        {
            goto label_157;
        }
        
        List.Enumerator<T> val_24 = val_53.GetEnumerator();
        label_133:
        if((181556624 & 1) == 0)
        {
            goto label_104;
        }
        
        new 不丑世不专上专专丝.下丌丛三下专丘丐丕() = new System.Object();
        ConfiguredValueTaskAwaiter val_27 = val_19.GetAwaiter();
        .丈丏万丄丒业丅丒一 = val_27._value._obj;
        mem[1152921539148214792] = val_27._value._token;
        mem[1152921539148214794] = val_27._value._continueOnCapturedContext;
        val_58 = null;
        val_58 = null;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_29 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new 不丑世不专上专专丝.下丌丛三下专丘丐丕(), method:  System.Boolean 不丑世不专上专专丝.下丌丛三下专丘丐丕::丝丆丅丟丝丘丞丘专(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        if((System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  WeaponManager.丟丗丄业丘丗业丗七.丘一丄丕不专上三丅(), predicate:  null)) == null)
        {
            goto label_133;
        }
        
        三丅丁丗丗丝丂万且 val_32 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂());
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_33 = WeaponManager.万一丛七丙丑丄丆丑();
        if(((System.String.op_Equality(a:  val_33.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_32.与不丞丑七丘丁丂丛())) == true) || ((WeaponManager.七世丂丁丆丙丐丆丌().Contains(item:  val_32.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_97;
        }
        
        val_54 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_32.与不丞丑七丘丁丂丛());
        if(val_54 >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_32.三与丛丑且丐丈业丌())))
        {
            goto label_97;
        }
        
        val_53 = val_32.与不丞丑七丘丁丂丛();
        if((WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  val_53)) != null)
        {
            goto label_133;
        }
        
        不丑世不专上专专丝.东一专丅下丌丟上东(丆丐七世世且丏丐业:  val_32, 丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丘不七东下丌丑丁丂:  且丅丟丛丛万丝下上, 丏丄下东丁丝与丌不:  0, 且上丌丏三丏丑七丌:  0, 业丑丒丅丝丆丝丕丑:  true);
        goto label_104;
        label_97:
        int val_47 = .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂();
        goto label_133;
        label_104:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_52:
        WeaponManager.丌丟上丕一丙丟丌丄();
        WeaponManager.万下丟丁丘丂一与丛(上丑丕上丕丁丂丏专:  true);
    }
    internal static void 丝丄丗丑丌且丄上与(PropertiesArmoryItemContainer 七万丄七丅丅丕丝丑, string 丞一丁业丄一一业且)
    {
        UnityEngine.Object val_8;
        UILabel val_9;
        val_8 = 七万丄七丅丅丕丝丑;
        val_9 = 1152921504848912384;
        if(val_8 == 0)
        {
                return;
        }
        
        val_9 = 七万丄七丅丅丕丝丑.tryGunDiscountTime;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = WeaponManager.业丗丌下丙丗丛丝万();
        long val_4 = WeaponManager.丟丗丄业丘丗业丗七.东丑丗专丗万世丙丒(丒东业不丐丑丕丄丆:  丞一丁业丄一一业且);
        val_8 = 七万丄七丅丅丕丝丑.tryGunDiscountTime;
        if((val_4 != 1) && (FriendsController.丝丗专上三不丄丑丑() != 1))
        {
                var val_8 = val_9;
            val_8 = val_4 + val_8;
            val_9 = val_8 - FriendsController.丝丗专上三不丄丑丑();
        }
        
        val_8.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_9, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
    }
    private static 不丑世不专上专专丝()
    {
        不丑世不专上专专丝.与丁丏专世丑与一丑 = 0;
        不丑世不专上专专丝.丙丅专不丌丛丕丌丗 = new System.Collections.Generic.List<CategoryNames>();
        不丑世不专上专专丝.且丗万一上丈丅丄丆 = new System.Collections.Generic.List<ItemRarity>(capacity:  6);
        不丑世不专上专专丝.丝丏万不三不丝丘丄 = new System.Collections.Generic.List<System.Int32>(capacity:  6);
    }

}

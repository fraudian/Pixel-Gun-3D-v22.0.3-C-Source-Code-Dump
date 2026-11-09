using UnityEngine;
internal sealed class 丂丏丈不丗丆下丈且
{
    // Fields
    private static 丂丏丈不丗丆下丈且 丝业丆丁业三丈丟东;
    private System.Collections.Generic.Dictionary<string, 丂丏丈不丗丆下丈且.东丄丟一丞丟业丅上> 三三丒业丂丗专专且;
    private System.Collections.Generic.Dictionary<CategoryNames, Rilisoft.OfferItemType> 三丕三丒丈专丝丑七;
    
    // Properties
    internal static 丂丏丈不丗丆下丈且 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static 丂丏丈不丗丆下丈且 丑七不且上丗丁一世()
    {
        丂丏丈不丗丆下丈且 val_1 = 丂丏丈不丗丆下丈且.丝业丆丁业三丈丟东;
        if(val_1 != null)
        {
                return val_1;
        }
        
        丂丏丈不丗丆下丈且.上丛丌丆丑上七世三();
        val_1 = 丂丏丈不丗丆下丈且.丝业丆丁业三丈丟东;
        return val_1;
    }
    internal static void 上丛丌丆丑上七世三()
    {
        丂丏丈不丗丆下丈且 val_1 = new 丂丏丈不丗丆下丈且();
        丂丏丈不丗丆下丈且.丝业丆丁业三丈丟东 = val_1;
        val_1.丞丌丁丐丏丗七丌丛();
        FriendsController.业丒丛一丌丟业世丝(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void 丂丏丈不丗丆下丈且::丞丌丁丐丏丗七丌丛()));
        FriendsController.三丁丅世丙一东上世(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void 丂丏丈不丗丆下丈且::丞丌丁丐丏丗七丌丛()));
    }
    internal void 丘上丐世丆丑且丞丒()
    {
        this.丞丌丁丐丏丗七丌丛();
    }
    internal System.Collections.Generic.List<string> 业三三丟业专东丐丘()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.三三丒业丂丗专专且.Keys.GetEnumerator();
        label_5:
        if((1037644936 & 1) == 0)
        {
            goto label_3;
        }
        
        val_1.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal void 丛丙三丕且东丛丑业(string 丄万世不丟丒丏东丁)
    {
        string val_7;
        System.Collections.Generic.Dictionary<System.String, 东丄丟一丞丟业丅上> val_8;
        val_7 = 丄万世不丟丒丏东丁;
        val_8 = this.三三丒业丂丗专专且;
        if((val_8.ContainsKey(key:  val_7)) == false)
        {
                return;
        }
        
        if(this.三三丒业丂丗专专且.Item[val_7] == null)
        {
                return;
        }
        
        val_7 = val_2.丅万丂世不丘丕下一;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_7.GetEnumerator();
        val_8 = 1152921538883434896;
        label_7:
        if((1037800952 & 1) == 0)
        {
            goto label_6;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        Rilisoft.OfferItemType val_6 = val_4._value._obj.不丌七丅丆丝丗丌东(七丆丒与丗丌丄且丂:  val_4._value._obj.丙东专丂世丈丏丁丂());
        val_6.三丈丅丂丌丟丙丁丁(与丙丆世丘丑丒丌丄:  val_6, 下丑下七万丒丌丗丆:  val_4._value._obj);
        goto label_7;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 三丈丅丂丌丟丙丁丁(CategoryNames 七丆丒与丗丌丄且丂, System.Collections.Generic.List<string> 下丑下七万丒丌丗丆)
    {
        Rilisoft.OfferItemType val_1 = this.不丌七丅丆丝丗丌东(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        val_1.三丈丅丂丌丟丙丁丁(与丙丆世丘丑丒丌丄:  val_1, 下丑下七万丒丌丗丆:  下丑下七万丒丌丗丆);
    }
    private void 三丈丅丂丌丟丙丁丁(Rilisoft.OfferItemType 与丙丆世丘丑丒丌丄, System.Collections.Generic.List<string> 下丑下七万丒丌丗丆)
    {
        var val_2;
        var val_3;
        string val_22;
        PGCompany.三东丏不丗世丅丌丄 val_23;
        string val_24;
        List.Enumerator<T> val_1 = 下丑下七万丒丌丗丆.GetEnumerator();
        label_5:
        if((1038119088 & 1) == 0)
        {
            goto label_2;
        }
        
        val_22 = val_3.丐丏七丌丕丗业且上();
        if((System.String.IsNullOrEmpty(value:  val_22)) == true)
        {
            goto label_3;
        }
        
        val_23 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  与丙丆世丘丑丒丌丄, 丞丅上丏丂且下丅与:  val_22);
        if(val_23.丕丐一丙专丛丒丑万() == false)
        {
            goto label_5;
        }
        
        goto label_7;
        label_2:
        val_23 = 0;
        val_22 = "";
        goto label_7;
        label_3:
        val_23 = 0;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_24 = val_22;
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        if(val_23 == 0)
        {
                return;
        }
        
        if(val_23.丕丐一丙专丛丒丑万() == false)
        {
                return;
        }
        
        val_2 = 0;
        val_3 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_23, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_23, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        val_2 = 0;
        val_3 = 0;
        PGCompany.丗丟丄丈东丝丕丄世 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  val_23, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        val_24 = val_15;
        if(val_24 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            if(ExperienceController.丞丞丘业东丙丏七丌() > val_24.丁丕丁三丁丗不三丟())
        {
                val_24 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            bool val_20 = val_24.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_15, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = true});
        }
        
        }
        
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  val_23);
    }
    private void 丂丞不丘一丙丞东丙(CategoryNames 七丆丒与丗丌丄且丂, System.Collections.Generic.List<string> 下丑下七万丒丌丗丆)
    {
        var val_3;
        string val_9;
        string val_10;
        val_9 = 下丑下七万丒丌丗丆;
        val_10 = "";
        List.Enumerator<T> val_1 = val_9.GetEnumerator();
        goto label_2;
        label_7:
        val_9 = val_3.丐丏七丌丕丗业且上();
        if(((System.String.IsNullOrEmpty(value:  val_9)) == true) || ((七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_9)) != 七丌丞万七万丁丐丙.丑丒丆与丘下丛上业))
        {
            goto label_6;
        }
        
        val_10 = "";
        label_2:
        if((1038288528 & 1) != 0)
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        val_10 = val_9;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        if((七丌丞万七万丁丐丙.一丐丂丁丏丕丒不丗(丞丅上丏丂且下丅与:  null, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) != true)
        {
                七丌丞万七万丁丐丙.一七上丞丟丗丛丑丕(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 丞丅上丏丂且下丅与:  null);
        }
        
        丆丟七丌丞东丆丕丌.丄东世丌专下丈丑丙(丒东业不丐丑丕丄丆:  null, 丙丑丕丂下丏一丁专:  七丆丒与丗丌丄且丂, 丆万丐丗丅丘丆丁丌:  false);
    }
    private Rilisoft.OfferItemType 不丌七丅丆丝丗丌东(CategoryNames 七丆丒与丗丌丄且丂)
    {
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) != false)
        {
                return 10;
        }
        
        if((七丆丒与丗丌丄且丂 - 6) <= 6)
        {
                var val_5 = 106018336 + ((七丆丒与丗丌丄且丂 - 6)) << 2;
            val_5 = val_5 + 106018336;
        }
        else
        {
                if(七丆丒与丗丌丄且丂 == 170000)
        {
                return 10;
        }
        
            if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) != false)
        {
                return 10;
        }
        
            var val_4 = (七丆丒与丗丌丄且丂 == 25000) ? 80 : 0;
            return 10;
        }
    
    }
    private void 丕丄且丅丝万丌不世(CategoryNames 七丆丒与丗丌丄且丂, System.Collections.Generic.List<string> 下丑下七万丒丌丗丆)
    {
        var val_4;
        var val_5;
        var val_24;
        string val_26;
        PGCompany.三东丏不丗世丅丌丄 val_27;
        string val_28;
        CategoryNames val_25 = 七丆丒与丗丌丄且丂;
        val_25 = (val_25 == 7) ? 20 : (((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_25)) != true) ? 10 : 0);
        List.Enumerator<T> val_3 = 下丑下七万丒丌丗丆.GetEnumerator();
        label_7:
        if((1038578000 & 1) == 0)
        {
            goto label_4;
        }
        
        val_26 = val_5.丐丏七丌丕丗业且上();
        if((System.String.IsNullOrEmpty(value:  val_26)) == true)
        {
            goto label_5;
        }
        
        val_27 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  val_25, 丞丅上丏丂且下丅与:  val_26);
        if(val_27.丕丐一丙专丛丒丑万() == false)
        {
            goto label_7;
        }
        
        goto label_9;
        label_4:
        val_27 = 0;
        val_26 = "";
        goto label_9;
        label_5:
        val_27 = 0;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_28 = val_26;
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        if(val_27 == 0)
        {
                return;
        }
        
        if(val_27.丕丐一丙专丛丒丑万() == false)
        {
                return;
        }
        
        val_4 = 0;
        val_5 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_27, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_27, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        val_4 = 0;
        val_5 = 0;
        PGCompany.丗丟丄丈东丝丕丄世 val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  val_27, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if(val_17 != null)
        {
                val_27 = 1152921505616695296;
            val_24 = val_17;
            if(val_24 != null)
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            if(ExperienceController.丞丞丘业东丙丏七丌() > val_24.丁丕丁三丁丗不三丟())
        {
                val_24 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            bool val_22 = val_24.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_17, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = true});
        }
        
        }
        
        }
        
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  val_27);
    }
    private void 丞丌丁丐丏丗七丌丛()
    {
        var val_6;
        var val_23;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        this.三三丒业丂丗专专且.Clear();
        if(FriendsController.丄丐丗丒丒三丕万丞() == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = FriendsController.丄丐丗丒丒三丕万丞().GetEnumerator();
        val_26 = 0;
        val_27 = 0;
        val_28 = 0;
        val_29 = 0;
        label_50:
        if((1038785376 & 1) == 0)
        {
            goto label_8;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((System.String.IsNullOrEmpty(value:  val_7._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_50;
        }
        
        if((val_7._value._obj == 0) || (val_7._value._obj.Count == 0))
        {
            goto label_50;
        }
        
        List.Enumerator<T> val_11 = val_7._value._obj.GetEnumerator();
        label_28:
        if((1038785328 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_12 = val_6.丐丏七丌丕丗业且上();
        if(((val_12 == null) || ((val_12.ContainsKey(key:  "cat")) == false)) || ((val_12.ContainsKey(key:  "item")) == false))
        {
            goto label_28;
        }
        
        object val_18 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  System.Convert.ToString(value:  val_12.Item["cat"]));
        val_30 = null;
        if(val_18 == null)
        {
                val_30 = val_30;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_18);
        this.一上下丁丁下丈丕世(世业丙丌东丁三下丘:  val_7._value._obj.丐丏七丌丕丗业且上(), 七丆丒与丗丌丄且丂:  1152921504628731904, 丞丅上丏丂且下丅与:  System.Convert.ToString(value:  val_12.Item["item"]));
        goto label_28;
        label_14:
        val_29 = val_29 + 1;
        mem2[0] = 248;
        val_31 = val_27;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_29 == 1) || (val_23 != 248))
        {
            goto label_47;
        }
        
        val_29 = val_29 + val_18 ^ 0;
        goto label_50;
        label_47:
        if( == false)
        {
            goto label_50;
        }
        
        goto label_50;
        label_8:
        val_29 = val_29 + 1;
        mem2[0] = 276;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_29 != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(val_23 == 276)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    private void 一上下丁丁下丈丕世(string 世业丙丌东丁三下丘, CategoryNames 七丆丒与丗丌丄且丂, string 丞丅上丏丂且下丅与)
    {
        System.Collections.Generic.Dictionary<System.String, 东丄丟一丞丟业丅上> val_9;
        System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>> val_10;
        val_9 = this.三三丒业丂丗专专且;
        if((this.三三丒业丂丗专专且.ContainsKey(key:  世业丙丌东丁三下丘)) == false)
        {
            goto label_2;
        }
        
        东丄丟一丞丟业丅上 val_2 = val_9.Item[世业丙丌东丁三下丘];
        val_9 = this.三三丒业丂丗专专且;
        东丄丟一丞丟业丅上 val_4 = val_9.Item[世业丙丌东丁三下丘];
        val_10 = val_4.丅万丂世不丘丕下一;
        if((val_2.丅万丂世不丘丕下一.ContainsKey(key:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_8;
        }
        
        val_10.Item[七丆丒与丗丌丄且丂].Insert(index:  0, item:  丞丅上丏丂且下丅与);
        return;
        label_2:
        val_9.set_Item(key:  世业丙丌东丁三下丘, value:  new 丂丏丈不丗丆下丈且.东丄丟一丞丟业丅上());
        东丄丟一丞丟业丅上 val_7 = this.三三丒业丂丗专专且.Item[世业丙丌东丁三下丘];
        val_10 = val_7.丅万丂世不丘丕下一;
        label_8:
        System.Collections.Generic.List<System.String> val_8 = new System.Collections.Generic.List<System.String>();
        val_8.Add(item:  丞丅上丏丂且下丅与);
        val_10.set_Item(key:  七丆丒与丗丌丄且丂, value:  val_8);
    }
    public 丂丏丈不丗丆下丈且()
    {
        this.三三丒业丂丗专专且 = new System.Collections.Generic.Dictionary<System.String, 东丄丟一丞丟业丅上>();
        System.Collections.Generic.Dictionary<CategoryNames, Rilisoft.OfferItemType> val_2 = new System.Collections.Generic.Dictionary<CategoryNames, Rilisoft.OfferItemType>();
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  10);
            val_2.Add(key:  1, value:  10);
            val_2.Add(key:  2, value:  10);
            val_2.Add(key:  3, value:  10);
            val_2.Add(key:  4, value:  10);
            val_2.Add(key:  5, value:  10);
            val_2.Add(key:  0, value:  56);
            val_2.Add(key:  16, value:  56);
            val_2.Add(key:  64, value:  56);
            val_2.Add(key:  80, value:  56);
        }
        else
        {
                val_2.Add(key:  0, value:  10);
            val_2.Add(key:  1, value:  10);
            val_2.Add(key:  2, value:  10);
            val_2.Add(key:  3, value:  10);
            val_2.Add(key:  4, value:  10);
            val_2.Add(key:  5, value:  10);
            val_2.Add(key:  0, value:  56);
            val_2.Add(key:  16, value:  56);
            val_2.Add(key:  64, value:  56);
            val_2.Add(key:  80, value:  56);
        }
        
        val_2.Add(key:  168, value:  80);
        this.三丕三丒丈专丝丑七 = val_2;
    }

}

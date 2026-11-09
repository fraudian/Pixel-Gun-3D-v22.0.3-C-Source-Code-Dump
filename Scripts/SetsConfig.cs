using UnityEngine;
internal sealed class SetsConfig : ScriptableObject
{
    // Fields
    private static SetsConfig _instance;
    internal System.Collections.Generic.List<SetsSettings> listSetSettings;
    internal System.Collections.Generic.Dictionary<string, SetsSettings> dictionarySetSettings;
    
    // Properties
    internal static SetsConfig Instance { get; }
    
    // Methods
    internal static SetsConfig get_Instance()
    {
        SetsConfig val_3 = SetsConfig._instance;
        if(val_3 != 0)
        {
                return (SetsConfig)SetsConfig._instance;
        }
        
        SetsConfig._instance = UnityEngine.Resources.Load<SetsConfig>(path:  "SetsAndEffectConfig/SetsConfig");
        val_3 = SetsConfig._instance;
        val_3.丘上丐世丆丑且丞丒();
        return (SetsConfig)SetsConfig._instance;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        string val_2;
        var val_4 = this;
        List.Enumerator<T> val_1 = this.listSetSettings.GetEnumerator();
        label_4:
        if((1269445680 & 1) == 0)
        {
            goto label_2;
        }
        
        this.dictionarySetSettings.set_Item(key:  val_2, value:  new SetsSettings() {Id = val_2});
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void 丘丙丄丆丑丗下丁丒()
    {
        string val_3;
        float val_4;
        string val_5;
        System.Collections.Generic.List<System.String> val_8;
        var val_14;
        System.Collections.Generic.List<T> val_17;
        var val_20;
        var val_26;
        var val_27;
        var val_28;
        this.listSetSettings.Clear();
        Dictionary.Enumerator<TKey, TValue> val_2 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().GetEnumerator();
        val_26 = 1152921524478588416;
        val_27 = 0;
        val_28 = 0;
        goto label_5;
        label_61:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        System.Collections.Generic.List<SetsItemSettingSettings> val_9 = new System.Collections.Generic.List<SetsItemSettingSettings>();
        if(val_3 == 0)
        {
            goto label_26;
        }
        
        System.Collections.Generic.List<ItemSetsInfo> val_10 = new System.Collections.Generic.List<ItemSetsInfo>();
        Dictionary.Enumerator<TKey, TValue> val_11 = val_3 + 72.GetEnumerator();
        label_25:
        if((1269590352 & 1) == 0)
        {
            goto label_23;
        }
        
        ConfiguredValueTaskAwaiter val_15 = val_14.GetAwaiter();
        null.Add(item:  new ItemSetsInfo() {idItem = val_15._value._obj, categoryNames = val_15._value._obj.丙东专丂世丈丏丁丂()});
        goto label_25;
        label_23:
        var val_25 = 0;
        val_25 = val_25 + 1;
        mem2[0] = 398;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_27 = val_25;
        if((val_27 != 1) && ((1269590128 + ((0 + 1)) << 2) == 398))
        {
                var val_26 = 0;
            val_26 = val_26 ^ (val_27 >> 31);
            val_27 = val_27 + val_26;
        }
        else
        {
                if( != 0)
        {
                val_27 = 0;
            val_28 = 0;
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
        null.Add(item:  new ItemSetsInfo() {idItem = val_3 + 56, categoryNames = 7});
        null.Add(item:  new SetsItemSettingSettings() {isAvatar = true});
        label_26:
        Dictionary.Enumerator<TKey, TValue> val_18 = val_17.GetEnumerator();
        label_46:
        if((1269590352 & 1) == 0)
        {
            goto label_43;
        }
        
        ConfiguredValueTaskAwaiter val_22 = val_20.GetAwaiter();
        System.Collections.Generic.List<ItemSetsInfo> val_23 = new System.Collections.Generic.List<ItemSetsInfo>();
        null.Add(item:  new ItemSetsInfo() {idItem = val_22._value._obj, categoryNames = val_22._value._obj.丙东专丂世丈丏丁丂()});
        null.Add(item:  new SetsItemSettingSettings() {isAvatar = false});
        goto label_46;
        label_43:
        var val_28 = val_27;
        val_28 = val_28 + 1;
        mem2[0] = 611;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_30 = val_28;
        if((val_30 != 1) && ((1269590128 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 611))
        {
                var val_29 = 0;
            val_29 = val_29 ^ (val_30 >> 31);
            val_30 = val_30 + val_29;
        }
        else
        {
                if( != 0)
        {
                val_27 = 0;
            val_28 = 0;
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
        var val_31 = 1;
        val_31 = val_31 * 100;
        val_4 = (float)val_31;
        val_8 = 0;
        val_3 = 0;
        val_5 = val_5;
        val_17 = null;
        this.listSetSettings.Add(item:  new SetsSettings() {Id = val_5, weight = val_4, index = val_6._value._obj.业东丅东丌上丗丑不(), listPlayerEffect = val_8, ArmorPropertyLkey = val_3, SetPropertyLkey = val_8, SpriteNameForProperties = val_3, LkeySet = val_4});
        val_26 = X28;
        label_5:
        if((1269590416 & 1) != 0)
        {
            goto label_61;
        }
        
        var val_32 = val_30;
        val_32 = val_32 + 1;
        mem2[0] = 667;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_32 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1269590128 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 667)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    public void 丌丄丙丞丌丞业丈七()
    {
        var val_4;
        System.Func<SetsSettings, System.Single> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = SetsConfig.<>c.<>9__7_0;
        if(val_6 == null)
        {
                System.Func<SetsSettings, System.Single> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<SetsSettings, System.Single>(object:  SetsConfig.<>c.__il2cppRuntimeField_static_fields, method:  System.Single SetsConfig.<>c::下丗丕丝丁丆丑丅丞(SetsSettings 三丟东丕丄丄下下丑));
            SetsConfig.<>c.<>9__7_0 = val_6;
        }
        
        this.listSetSettings = System.Linq.Enumerable.ToList<SetsSettings>(source:  System.Linq.Enumerable.OrderByDescending<SetsSettings, System.Single>(source:  this.listSetSettings, keySelector:  val_1));
    }
    public SetsConfig()
    {
        this.listSetSettings = new System.Collections.Generic.List<SetsSettings>();
        this.dictionarySetSettings = new System.Collections.Generic.Dictionary<System.String, SetsSettings>();
    }

}

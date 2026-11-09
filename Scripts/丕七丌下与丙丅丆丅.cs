using UnityEngine;
public sealed class 丕七丌下与丙丅丆丅
{
    // Fields
    internal const string 东丏业丘丂七丂专丟 = "CampaignProgress";
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 与丒丅丙丕丏东丐丈;
    
    // Methods
    private static 丕七丌下与丙丅丆丅()
    {
        丕七丌下与丙丅丆丅.与丒丅丙丕丏东丐丈 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        bool val_2 = 丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "CampaignProgress");
    }
    internal static void 东丒丒业丛东与丝业()
    {
    
    }
    internal static void 丗丛丅丕丘且丅丈丟()
    {
    
    }
    internal static void 东万与业一上丄丑东()
    {
    
    }
    internal static string 丟丘丐丑丐上丐三丟(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 上丕丈丞丌丘丅不与)
    {
        return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  上丕丈丞丌丘丅不与);
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 丏业丄万丛且且上丗(string 丐丗丂丌丞丁世丁丛)
    {
        var val_11;
        string val_26;
        var val_27;
        System.Collections.Generic.Dictionary<TKey, TValue> val_28;
        var val_29;
        var val_30;
        var val_37;
        val_26 = 丐丗丂丌丞丁世丁丛;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        val_27 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_26);
        if((val_27 != null) && (UnityEngine.Debug.isDebugBuild != false))
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                UnityEngine.Debug.Log(message:  "Deserialized progress type: "("Deserialized progress type: ") + val_27.GetType());
            UnityEngine.Debug.Log(message:  "##### Serialized campaign progress:\n"("##### Serialized campaign progress:\n") + val_26);
        }
        
        }
        
        if(val_27 == null)
        {
            goto label_79;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_8 = val_27.GetEnumerator();
        val_28 = 0;
        val_29 = 0;
        label_66:
        if((1795925120 & 1) == 0)
        {
            goto label_11;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        if(val_12._value._obj == 0)
        {
            goto label_59;
        }
        
        object val_29 = val_12._value._obj;
        if((val_12._value._obj + 286) == 0)
        {
            goto label_16;
        }
        
        var val_27 = val_12._value._obj + 176;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_15:
        if(((val_12._value._obj + 176 + 8) + -8) == null)
        {
            goto label_14;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < (val_12._value._obj + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_14:
        val_29 = val_29 + (((val_12._value._obj + 176 + 8)) << 4);
        val_30 = val_29 + 296;
        label_16:
        System.Collections.Generic.IEnumerator<T> val_14 = val_12._value._obj.GetEnumerator();
        label_39:
        var val_30 = 0;
        val_30 = val_30 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_31 = 0;
        val_31 = val_31 + 1;
        T val_18 = val_14.Current;
        null.Add(key:  val_18.丐丏七丌丕丗业且上(), value:  System.Convert.ToInt32(value:  val_18));
        goto label_39;
        label_22:
        var val_32 = 0;
        val_32 = val_32 + 1;
        mem2[0] = 253;
        if(val_14 == null)
        {
            
        }
        else
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            val_14.Dispose();
        }
        
        var val_35 = val_32;
        if((val_35 == 1) || ((1152921536467543072 + ((0 + 1)) << 2) != 253))
        {
            goto label_56;
        }
        
        var val_34 = 0;
        val_34 = val_34 ^ (val_35 >> 31);
        val_35 = val_35 + val_34;
        goto label_62;
        label_56:
        if( != 0)
        {
            
        }
        
        label_59:
        if(UnityEngine.Debug.isDebugBuild != false)
        {
                UnityEngine.Debug.LogWarning(message:  "boxProgressDictionary == null");
        }
        
        label_62:
        val_1.Add(key:  val_12._value._obj.丐丏七丌丕丗业且上(), value:  null);
        goto label_66;
        label_11:
        val_37 = val_35 + 1;
        mem2[0] = 319;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if((1152921536467543072 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) == 319)
        {
                return val_1;
        }
        
        }
        
        label_79:
        if(UnityEngine.Debug.isDebugBuild == false)
        {
                return val_1;
        }
        
        val_26 = "campaignProgressDictionary == null,    serializedProgress == "("campaignProgressDictionary == null,    serializedProgress == ") + val_26;
        UnityEngine.Debug.LogWarning(message:  val_26);
        return val_1;
    }
    private static void 丈丅万丐丁丐下丞丛(string 下上丐丆丝丟丝丒不, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 万丝且丘不丑丝下丑)
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  丕七丌下与丙丅丆丅.丟丘丐丑丐上丐三丟(上丕丈丞丌丘丅不与:  万丝且丘不丑丝下丑));
        if(UnityEngine.Application.platform == 8)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.Save();
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 丞与丗与丛七丙丂丐(string 下上丐丆丝丟丝丒不)
    {
        return 丕七丌下与丙丅丆丅.丏业丄万丛且且上丗(丐丗丂丌丞丁世丁丛:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
    }
    public 丕七丌下与丙丅丆丅()
    {
    
    }

}

using UnityEngine;
public class 丐丛丏丞丁丙不与丂
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 专业一不丐丛专丞丑;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丆丙业世业丐丐世七;
    private static bool 丙丐丄丛东七丑万丙;
    internal const string 丄丄丅丛丅丘丞丗万 = "wekill";
    internal const string 丛丁且丐专丁专万专 = "wewerekilled";
    
    // Properties
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丁与与下丅丅丈且丄 { get; }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丕丝丁东世万东丅丅 { get; }
    
    // Methods
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 万丌与丁丞丐丂丞丒()
    {
        var val_1 = null;
        if(丐丛丏丞丁丙不与丂.丙丐丄丛东七丑万丙 != true)
        {
                丐丛丏丞丁丙不与丂.上丛丌丆丑上七世三();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)丐丛丏丞丁丙不与丂.丛丁且丐专丁专万专;
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丂与丄丑丒且专丑丐()
    {
        var val_1 = null;
        if(丐丛丏丞丁丙不与丂.丙丐丄丛东七丑万丙 != true)
        {
                丐丛丏丞丁丙不与丂.上丛丌丆丑上七世三();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>)丐丛丏丞丁丙不与丂.丆丙业世业丐丐世七;
    }
    private static void 上丛丌丆丑上七世三()
    {
        null = null;
        丐丛丏丞丁丙不与丂.不丕世东丕且世丆丂(东丑丁丂丑丄一专上: ref  void* val_1 = 丐丛丏丞丁丙不与丂.__il2cppRuntimeField_static_fields, 丞丌丐且三丕不上丝: ref  1152921505077616648);
        丐丛丏丞丁丙不与丂.丙丐丄丛东七丑万丙 = true;
    }
    private static void 不丕世东丕且世丆丂(ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 东丑丁丂丑丄一专上, ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丞丌丐且三丕不上丝)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_23;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_24;
        var val_25;
        System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>> val_27;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_28;
        丐丛丏丞丁丙不与丂.丂与东丄丛丗专业丛();
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "KillRateKeyStatistics"));
        val_18 = 0;
        if((val_18.ContainsKey(key:  "version")) == false)
        {
            goto label_8;
        }
        
        val_19 = val_18.Item["version"];
        val_20 = null;
        val_20 = null;
        if(val_19 == null)
        {
            goto label_12;
        }
        
        if(null == null)
        {
            goto label_15;
        }
        
        val_19 = 0;
        goto label_15;
        label_8:
        UnityEngine.Debug.LogError(message:  "ParseKillRate: no version key. Please clear your PlayerPrefs");
        goto label_19;
        label_12:
        label_15:
        if((val_19.Equals(value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒)) == false)
        {
            goto label_19;
        }
        
        if(val_18 != 0)
        {
            goto label_28;
        }
        
        goto label_27;
        label_19:
        丐丛丏丞丁丙不与丂.与丐业不丙丗专丈丛();
        val_18 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "KillRateKeyStatistics"));
        label_27:
        val_18 = 0;
        val_21 = 1;
        goto label_29;
        label_28:
        val_21 = 0;
        label_29:
        if((val_18.ContainsKey(key:  "wekill")) == false)
        {
            goto label_30;
        }
        
        object val_10 = val_18.Item["wekill"];
        val_22 = 0;
        if(val_21 != 0)
        {
            goto label_51;
        }
        
        goto label_52;
        label_30:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = null;
        val_22 = val_11;
        val_11 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_21 == 0)
        {
            goto label_52;
        }
        
        label_51:
        label_52:
        if((val_18.ContainsKey(key:  "wewerekilled")) == false)
        {
            goto label_37;
        }
        
        if(val_18.Item["wewerekilled"] == null)
        {
            goto label_39;
        }
        
        val_23 = 1152921530787778480;
        val_24 = 0;
        goto label_53;
        label_37:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = null;
        val_24 = val_14;
        val_14 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        goto label_42;
        label_39:
        val_24 = 0;
        label_42:
        val_23 = 1152921530787778480;
        label_53:
        val_25 = null;
        val_25 = null;
        val_27 = 丐丛丏丞丁丙不与丂.<>c.<>9__10_0;
        if(val_27 != null)
        {
                val_28 = mem[东丑丁丂丑丄一专上];
            val_28 = 东丑丁丂丑丄一专上;
        }
        else
        {
                System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>> val_15 = null;
            val_27 = val_15;
            val_15 = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>>(object:  丐丛丏丞丁丙不与丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丐丛丏丞丁丙不与丂.<>c::三丏丂丄丟丁上且丗(System.Collections.Generic.Dictionary<string, object> 丑与丘丛业丕丟丝不, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, int>> 丏丂万业丙专丏丒丒));
            丐丛丏丞丁丙不与丂.<>c.<>9__10_0 = val_27;
            val_28 = mem[东丑丁丂丑丄一专上];
            val_28 = 东丑丁丂丑丄一专上;
            if(val_27 == null)
        {
            goto label_54;
        }
        
        }
        
        label_54:
        val_15.Invoke(arg1:  val_11, arg2:  val_28);
        val_15.Invoke(arg1:  val_24, arg2:  val_23);
    }
    private static void 与丐业不丙丗专丈丛()
    {
        var val_3;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_3 = null;
        val_3 = null;
        val_1.Add(key:  "version", value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "KillRateKeyStatistics", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
    }
    private static void 丂与东丄丛丗专业丛()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "KillRateKeyStatistics")) != false)
        {
                return;
        }
        
        丐丛丏丞丁丙不与丂.与丐业不丙丗专丈丛();
    }
    public 丐丛丏丞丁丙不与丂()
    {
    
    }
    private static 丐丛丏丞丁丙不与丂()
    {
        丐丛丏丞丁丙不与丂.丛丁且丐专丁专万专 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>();
        丐丛丏丞丁丙不与丂.丆丙业世业丐丐世七 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>();
        丐丛丏丞丁丙不与丂.丙丐丄丛东七丑万丙 = false;
    }

}

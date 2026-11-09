using UnityEngine;
internal sealed class 上七丄丆一与东丅丝
{
    // Fields
    private const string 丗丗丂丏一丏丑丌丝 = "Ads.DailyInterstitialCount";
    private static readonly 上七丄丆一与东丅丝 <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static 上七丄丆一与东丅丝 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    private 上七丄丆一与东丅丝()
    {
    
    }
    internal static 上七丄丆一与东丅丝 丑七不且上丗丁一世()
    {
        null = null;
        return (上七丄丆一与东丅丝)上七丄丆一与东丅丝.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    internal int 一丝万丏丌丂上丂丞(System.DateTime 丅丏丅丂丝一丆丙丅)
    {
        string val_8;
        object val_9;
        object val_5 = 0;
        System.DateTime val_1 = 丅丏丅丂丝一丆丙丅.dateData.Date;
        val_8;
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "Ads.DailyInterstitialCount", defaultValue:  System.String.alignConst));
        if(val_3 == null)
        {
                return (int)val_9;
        }
        
        if(((((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0.TryGetValue(key:  val_1.dateData, value: out  val_5)) != false)
        {
                val_8 = val_5;
            val_9 = val_8;
            int val_7 = System.Convert.ToInt32(value:  val_9);
            return (int)val_9;
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    public int 世一丒与万丐丄万丑(System.DateTime 丅丏丅丂丝一丆丙丅)
    {
        var val_10;
        int val_11;
        object val_6 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  1);
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "Ads.DailyInterstitialCount", defaultValue:  System.String.alignConst));
        val_10 = 0;
        System.DateTime val_5 = 丅丏丅丂丝一丆丙丅.dateData.Date;
        if((TryGetValue(key:  val_5.dateData, value: out  val_6)) != false)
        {
                val_11 = (System.Convert.ToInt32(value:  val_6)) + 1;
            val_1.Add(key:  val_5.dateData, value:  val_11);
        }
        else
        {
                val_11 = 1;
            val_1.Add(key:  val_5.dateData, value:  1);
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "Ads.DailyInterstitialCount", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
        return (int)val_11;
    }
    private static 上七丄丆一与东丅丝()
    {
        上七丄丆一与东丅丝.<不丁丄七丛不丆丁丕>k__BackingField = new 上七丄丆一与东丅丝();
    }

}

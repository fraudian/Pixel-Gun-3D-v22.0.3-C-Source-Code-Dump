using UnityEngine;
internal class 丟下七丘下下丙丗丅
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, PetInfo> 丟丟万一不业上丐丗;
    private static System.Collections.Generic.Dictionary<int, string> 万东与一丝丆万丆丗;
    private static System.Collections.Generic.Dictionary<string, int> 丂丑丅世丐丞丕万东;
    
    // Properties
    internal static System.Collections.Generic.Dictionary<string, PetInfo> 东一丁世丑丞业丄丐 { get; }
    internal static System.Collections.Generic.Dictionary<int, string> 专一丁丑三丌下丙丕 { get; }
    internal static System.Collections.Generic.Dictionary<string, int> 丁丕万丆丏与丌丒丐 { get; }
    
    // Methods
    internal static System.Collections.Generic.Dictionary<string, PetInfo> 一三专丞丒丅上业上()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.String, PetInfo>)丟下七丘下下丙丗丅.丟丟万一不业上丐丗;
    }
    internal static System.Collections.Generic.Dictionary<int, string> 与丐专丒丆业丏上丗()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.Int32, System.String>)丟下七丘下下丙丗丅.万东与一丝丆万丆丗;
    }
    internal static int 与与丁丟丐丈丗丐丐(string 世丐丗专丅三丝丑丆)
    {
        if((丟下七丘下下丙丗丅.一三专丞丒丅上业上().ContainsKey(key:  世丐丗专丅三丝丑丆)) == false)
        {
                return 0;
        }
        
        PetInfo val_4 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上().Item[世丐丗专丅三丝丑丆];
        if(val_4 != null)
        {
                return val_4.Index;
        }
        
        return val_4.Index;
    }
    internal static System.Collections.Generic.Dictionary<string, int> 丗丁七东丂丌丙与丕()
    {
        var val_6;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        val_7 = 丟下七丘下下丙丗丅.丂丑丅世丐丞丕万东;
        if(val_7.Count != 0)
        {
            goto label_19;
        }
        
        val_7 = 丟下七丘下下丙丗丅.与丐专丒丆业丏上丗();
        Dictionary.Enumerator<TKey, TValue> val_3 = val_7.GetEnumerator();
        label_12:
        if(((-435167560) & 1) == 0)
        {
            goto label_8;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        val_8 = null;
        val_8 = null;
        丟下七丘下下丙丗丅.丂丑丅世丐丞丕万东.set_Item(key:  val_4._value._obj, value:  val_4._value._obj.丙东专丂世丈丏丁丂());
        goto label_12;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_19:
        val_9 = null;
        val_9 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Int32>)丟下七丘下下丙丗丅.丂丑丅世丐丞丕万东;
    }
    private static 丟下七丘下下丙丗丅()
    {
        丟下七丘下下丙丗丅.丟丟万一不业上丐丗 = new System.Collections.Generic.Dictionary<System.String, PetInfo>();
        丟下七丘下下丙丗丅.万东与一丝丆万丆丗 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
        丟下七丘下下丙丗丅.丂丑丅世丐丞丕万东 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        System.Collections.Generic.Dictionary<System.String, PetInfo> val_4 = new System.Collections.Generic.Dictionary<System.String, PetInfo>();
    }
    public 丟下七丘下下丙丗丅()
    {
    
    }

}

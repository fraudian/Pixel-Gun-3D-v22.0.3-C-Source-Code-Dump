using UnityEngine;
internal class 丌丈丟丂上丟丘丞丕
{
    // Fields
    internal static readonly string 丑丌丙丁丒丏且世丄;
    private static readonly string 丗七丁七丙丂丕万与;
    private static readonly string 丙丘万一丈丛丌丞一;
    
    // Methods
    internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.与丅下丅上专万不丄.丗丘丑丝丒丞丞丞丘 专丞丙一丟专丞与丗)
    {
        var val_10;
        string val_11;
        var val_12;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(专丞丙一丟专丞与丗.丛丗丙不万且东世丅().Count != 0)
        {
                val_10 = null;
            val_10 = null;
            val_1.set_Item(key:  丌丈丟丂上丟丘丞丕.丗七丁七丙丂丕万与, value:  专且丝丄丙丗丈不丞.丛丌下万七丞丝丝丞(丑丝丟丕丒不万万万:  专丞丙一丟专丞与丗.丛丗丙不万且东世丅()));
        }
        
        val_11 = 专丞丙一丟专丞与丗.丐万东丞万丝丘丄一();
        if(val_11.Count == 0)
        {
                return val_1;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = 丌丈丟丂上丟丘丞丕.丙丘万一丈丛丌丞一;
        val_1.set_Item(key:  val_11, value:  专丞丙一丟专丞与丗.丐万东丞万丝丘丄一().丁丕上三丕丌丟丗丙());
        return val_1;
    }
    internal Progress.与丅下丅上专万不丄.丗丘丑丝丒丞丞丞丘 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_8;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        与丅下丅上专万不丄.丗丘丑丝丒丞丞丞丘 val_1 = new 与丅下丅上专万不丄.丗丘丑丝丒丞丞丞丘();
        val_24 = null;
        val_24 = null;
        val_25 = 1152921516630043280;
        if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  丌丈丟丂上丟丘丞丕.丗七丁七丙丂丕万与)) == false)
        {
            goto label_31;
        }
        
        val_26 = null;
        val_26 = null;
        if(一丐丗丁丞丆丅丟丄.Item[丌丈丟丂上丟丘丞丕.丗七丁七丙丂丕万与] == null)
        {
            goto label_31;
        }
        
        val_27 = null;
        val_27 = null;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_28 = 1152921516789141600;
        val_29 = 1152921524472061664;
        label_23:
        if((1738773440 & 1) == 0)
        {
            goto label_18;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_12 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_8.丐丏七丌丕丗业且上()));
        val_1.丛丗丙不万且东世丅().Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_12.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_12.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_12.上万三丆专丏丒丗业});
        goto label_23;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_25 = 1152921516630043280;
        label_31:
        val_30 = null;
        val_30 = null;
        val_31 = 丌丈丟丂上丟丘丞丕.丙丘万一丈丛丌丞一;
        if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_31)) == false)
        {
                return (丗丘丑丝丒丞丞丞丘)val_1;
        }
        
        val_32 = null;
        val_32 = null;
        val_31 = 丌丈丟丂上丟丘丞丕.丙丘万一丈丛丌丞一;
        if(一丐丗丁丞丆丅丟丄.Item[val_31] == null)
        {
                return (丗丘丑丝丒丞丞丞丘)val_1;
        }
        
        val_33 = null;
        val_33 = null;
        Dictionary.Enumerator<TKey, TValue> val_17 = GetEnumerator();
        val_25 = 1152921516595683744;
        val_29 = 1152921516595686816;
        val_28 = 1152921516595685792;
        label_54:
        if((1738773392 & 1) == 0)
        {
            goto label_49;
        }
        
        ConfiguredValueTaskAwaiter val_19 = val_8.GetAwaiter();
        val_1.丐万东丞万丝丘丄一().set_Item(下上丐丆丝丟丝丒不:  System.Convert.ToInt32(value:  val_19._value._obj.丐丏七丌丕丗业且上()), 丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_19._value._obj));
        goto label_54;
        label_49:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丗丘丑丝丒丞丞丞丘)val_1;
    }
    public 丌丈丟丂上丟丘丞丕()
    {
    
    }
    private static 丌丈丟丂上丟丘丞丕()
    {
        丌丈丟丂上丟丘丞丕.丑丌丙丁丒丏且世丄 = "s";
        丌丈丟丂上丟丘丞丕.丗七丁七丙丂丕万与 = "l";
        丌丈丟丂上丟丘丞丕.丙丘万一丈丛丌丞一 = "d";
    }

}

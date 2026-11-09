using UnityEngine;
internal static class 丌丝世丞世丛丆丅丟
{
    // Fields
    private const string 不丂三万丙丄丆三万 = "Storager.STORED_ITEMS_12_1_0_KEY";
    private static System.Collections.Generic.HashSet<string> 丈业丁丒不业丛丐七;
    private static readonly System.Collections.Generic.Dictionary<string, System.Action> 丞丞丛丄一丕丆丛三;
    private static readonly System.Collections.Generic.Dictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 丗丌业丟业上一丑丄;
    private static readonly System.Collections.Generic.Dictionary<string, string> 丟丗丞丑七且一与一;
    private const bool 且丆丏丄丂丝不专丂 = True;
    private static System.Collections.Generic.HashSet<string> 与三丛丌丙丄三丕丂;
    private static readonly System.Collections.Generic.IDictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 丘且丕丏丄三丝七且;
    private static readonly string[] 七丑不丈丌丑专下世;
    
    // Methods
    internal static string 丁丝丘丞丑丂丙丈丄(string 下上丐丆丝丟丝丒不, string 丞丌丑丛上丕丙丕下)
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) != false)
        {
                return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  丞丌丑丛上丕丙丕下);
        return (string)丞丌丑丛上丕丙丕下;
    }
    internal static int 丗三丝业丅丁丁丑下(string 下上丐丆丝丟丝丒不, int 丞丌丑丛上丕丙丕下)
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) != false)
        {
                return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  丞丌丑丛上丕丙丕下, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        return (int)丞丌丑丛上丕丙丕下;
    }
    internal static bool 丑丞丞东丟丒丂上不(string 丌丘不丆丈丈世万上, bool 丝丒上丑一三丑丐丛 = True)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丘不丆丈丈世万上)) == false)
        {
            goto label_3;
        }
        
        label_20:
        UnityEngine.Debug.LogErrorFormat(format:  "HasItem storageId.IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        return false;
        label_3:
        if((Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false) || (丝丒上丑一三丑丐丛 == false))
        {
                return 丌丝世丞世丛丆丅丟.丑丆丙丌三丁丑专丄(丌丘不丆丈丈世万上:  丌丘不丆丈丈世万上);
        }
        
        if((丏丄丑上丛不丈且万.丈东丗与丑丄丆一丘().Contains(item:  丌丘不丆丈丈世万上)) != false)
        {
                return 丌丝世丞世丛丆丅丟.丑丆丙丌三丁丑专丄(丌丘不丆丈丈世万上:  丌丘不丆丈丈世万上);
        }
        
        new object[1][0] = 丌丘不丆丈丈世万上;
        goto label_20;
    }
    internal static bool 丑丆丙丌三丁丑专丄(string 丌丘不丆丈丈世万上)
    {
        丌丝世丞世丛丆丅丟.丛丂丌不丞丕七世业();
        if(丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂 == true)
        {
                return 丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.Contains(item:  丌丘不丆丈丈世万上);
        }
        
        return 丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.Contains(item:  丌丘不丆丈丈世万上);
    }
    internal static void 东丌丟三丞世一一丑(string 丌丘不丆丈丈世万上, bool 丕万不丌世丟三丛丈 = False)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丘不丆丈丈世万上)) == false)
        {
            goto label_3;
        }
        
        label_26:
        UnityEngine.Debug.LogErrorFormat(format:  "SetItem storageId.IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
        return;
        label_3:
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                if((丏丄丑上丛不丈且万.丈东丗与丑丄丆一丘().Contains(item:  丌丘不丆丈丈世万上)) == false)
        {
            goto label_10;
        }
        
        }
        
        丌丝世丞世丛丆丅丟.丛丂丌不丞丕七世业();
        if((丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.Add(item:  丌丘不丆丈丈世万上)) != true)
        {
                if(丕万不丌世丟三丛丈 == false)
        {
            goto label_15;
        }
        
        }
        
        丌丝世丞世丛丆丅丟.丟丛三丑丆且不丐丛();
        label_15:
        丌丝世丞世丛丆丅丟.下与丂丝丒丘与七业(下上丐丆丝丟丝丒不:  丌丘不丆丈丈世万上);
        return;
        label_10:
        new object[1][0] = 丌丘不丆丈丈世万上;
        goto label_26;
    }
    internal static void 丂丄丗丝丌丌丝世丘(System.Collections.Generic.List<string> 丗丙东七下东丗丕且)
    {
        var val_7;
        var val_8;
        System.Action<System.String> val_10;
        System.Object[] val_11;
        string val_12;
        丌丝世丞世丛丆丅丟.丞丂万丅不丒丘丟丗 val_1 = new 丌丝世丞世丛丆丅丟.丞丂万丅不丒丘丟丗();
        if(丗丙东七下东丗丕且 == null)
        {
            goto label_1;
        }
        
        if(丗丙东七下东丗丕且.Count == 0)
        {
            goto label_2;
        }
        
        丌丝世丞世丛丆丅丟.丛丂丌不丞丕七世业();
        val_7 = val_1;
        .东且丁丆丛丁丏丘且 = 0;
        丗丙东七下东丗丕且.ForEach(action:  new System.Action<System.String>(object:  val_1, method:  System.Void 丌丝世丞世丛丆丅丟.丞丂万丅不丒丘丟丗::丈丒丙专丈专丐丏丛(string 下丅丙一丂丗丅丝七)));
        if(((1152921539207389472 & 1) != 0) && ((1152921539207389472 & 1) != 0))
        {
                丌丝世丞世丛丆丅丟.丟丛三丑丆且不丐丛();
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = 丌丝世丞世丛丆丅丟.<>c.<>9__5_1;
        if(val_10 == null)
        {
                System.Action<System.String> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Action<System.String>(object:  丌丝世丞世丛丆丅丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丌丝世丞世丛丆丅丟.<>c::丒丌丒东丂丘丕丑业(string 下丅丙一丂丗丅丝七));
            丌丝世丞世丛丆丅丟.<>c.<>9__5_1 = val_10;
        }
        
        丗丙东七下东丗丕且.ForEach(action:  val_4);
        return;
        label_1:
        val_11 = System.Array.Empty<System.Object>();
        val_12 = "SetItems storageIds == null";
        goto label_17;
        label_2:
        val_11 = System.Array.Empty<System.Object>();
        val_12 = "SetItems storageIds.Count == 0";
        label_17:
        UnityEngine.Debug.LogErrorFormat(format:  val_12, args:  val_11);
    }
    internal static void 三业世丅丄丗万丈丏(string 丌丘不丆丈丈世万上)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丘不丆丈丈世万上)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "MigrateItem storageId.IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        丌丝世丞世丛丆丅丟.丛丂丌不丞丕七世业();
        bool val_3 = 丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.Add(item:  丌丘不丆丈丈世万上);
    }
    internal static void 丐丒丒丏丈丄丘丑丘(string 丌丘不丆丈丈世万上)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丘不丆丈丈世万上)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "RemoveItem storageId.IsNullOrEmpty", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        丌丝世丞世丛丆丅丟.丛丂丌不丞丕七世业();
        if((丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.Remove(item:  丌丘不丆丈丈世万上)) == false)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.丟丛三丑丆且不丐丛();
    }
    internal static void 丟丛三丑丆且不丐丛()
    {
        var val_5;
        bool val_6;
        string val_7;
        val_5 = null;
        val_5 = null;
        val_6 = 丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂;
        if(val_6 == false)
        {
            goto label_3;
        }
        
        val_6 = 丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂;
        val_7 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  val_6));
        if(val_7 == null)
        {
            goto label_6;
        }
        
        丌丝世丞世丛丆丅丟.丅东丑七丄一七不丈(一丐丗丁丞丆丅丟丄:  val_7);
        return;
        label_3:
        UnityEngine.Debug.LogErrorFormat(format:  "SaveStoredItems _storedItems == null", args:  System.Array.Empty<System.Object>());
        return;
        label_6:
        val_7 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "serialized == null", args:  val_7);
    }
    internal static bool 与一万丆且与专丐三()
    {
        bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丝世丞世丛丆丅丟.丑丑七东万丐丒丞丈());
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    internal static string 丁丑业一东东且三东()
    {
        return 丌丝世丞世丛丆丅丟.丑丑七东万丐丒丞丈();
    }
    private static string 丑丑七东万丐丒丞丈()
    {
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
                return Rilisoft.三丄丄与且与丂万与.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  "Storager.STORED_ITEMS_12_1_0_KEY");
        }
        
        return UnityEngine.PlayerPrefs.GetString(key:  "Storager.STORED_ITEMS_12_1_0_KEY", defaultValue:  System.String.alignConst);
    }
    private static void 丅东丑七丄一七不丈(string 一丐丗丁丞丆丅丟丄)
    {
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                UnityEngine.PlayerPrefs.SetString(key:  "Storager.STORED_ITEMS_12_1_0_KEY", value:  一丐丗丁丞丆丅丟丄);
            return;
        }
        
        Rilisoft.三丄丄与且与丂万与.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  "Storager.STORED_ITEMS_12_1_0_KEY", 下下丏一丙不丘丌丞:  一丐丗丁丞丆丅丟丄);
    }
    private static void 丛丂丌不丞丕七世业()
    {
        System.Collections.Generic.HashSet<System.String> val_9;
        var val_10;
        var val_11;
        val_10 = null;
        val_10 = null;
        if(丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂 == true)
        {
                return;
        }
        
        string val_1 = 丌丝世丞世丛丆丅丟.丑丑七东万丐丒丞丈();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
        {
                System.Collections.Generic.HashSet<System.String> val_3 = null;
            val_9 = val_3;
            val_3 = new System.Collections.Generic.HashSet<System.String>();
        }
        else
        {
                if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_1)) != null)
        {
                val_11 = 0;
        }
        
            val_9 = null;
            val_9 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null)));
        }
        
        丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂 = val_9;
    }
    internal static void 丂丌丑丑丞专不专丞(string 下上丐丆丝丟丝丒不, System.Action 丌专业且丛丏丞丝且)
    {
        System.Collections.Generic.Dictionary<System.String, System.Action> val_6;
        var val_7;
        var val_8;
        var val_9;
        System.Action val_10;
        var val_11;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = null;
        if((丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
        {
            goto label_7;
        }
        
        val_9 = null;
        val_6 = 丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三;
        val_10 = System.Delegate.Combine(a:  val_6.Item[下上丐丆丝丟丝丒不], b:  丌专业且丛丏丞丝且);
        if(val_6 == null)
        {
            goto label_11;
        }
        
        if(val_10 != null)
        {
            goto label_12;
        }
        
        goto label_18;
        label_7:
        val_11 = null;
        丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三.Add(key:  下上丐丆丝丟丝丒不, value:  丌专业且丛丏丞丝且);
        return;
        label_11:
        if(val_10 == null)
        {
            goto label_18;
        }
        
        label_12:
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_18:
        val_6.set_Item(key:  下上丐丆丝丟丝丒不, value:  val_10);
    }
    internal static void 丟三丅丂丞与一丒上(string 下上丐丆丝丟丝丒不, System.Action 丌专业且丛丏丞丝且)
    {
        System.Collections.Generic.Dictionary<System.String, System.Action> val_7;
        var val_8;
        var val_9;
        var val_10;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = 丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三;
        if((val_7.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = 丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三.Item[下上丐丆丝丟丝丒不];
        val_10 = 0;
        goto label_15;
        label_20:
        if((System.Linq.Enumerable.ToArray<System.Delegate>(source:  val_7)[0]) == 丌专业且丛丏丞丝且)
        {
            goto label_14;
        }
        
        label_18:
        val_10 = 1;
        goto label_15;
        label_14:
        if(((System.Delegate.Remove(source:  val_7, value:  丌专业且丛丏丞丝且)) == null) || (null == null))
        {
            goto label_18;
        }
        
        goto label_18;
        label_15:
        if(val_10 < val_4.Length)
        {
            goto label_20;
        }
    
    }
    private static void 下与丂丝丒丘与七业(string 下上丐丆丝丟丝丒不)
    {
        var val_4;
        var val_5;
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if((丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        System.Action val_3 = 丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三.Item[下上丐丆丝丟丝丒不];
        if(val_3 == null)
        {
                return;
        }
        
        val_3.Invoke();
    }
    internal static bool 丝丛丑丁丞七不丒业(string 下上丐丆丝丟丝丒不)
    {
        string val_4;
        var val_5;
        var val_6;
        val_4 = 下上丐丆丝丟丝丒不;
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  val_4, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true)
        {
                val_6 = null;
            val_6 = null;
            if((System.String.op_Equality(a:  val_4, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
                return Rilisoft.三丄丄与且与丂万与.丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  val_4 = 丌丝世丞世丛丆丅丟.丒丞丅丕世丏丝一丄(上丞丞丅与不丞世业:  val_4));
        }
        
        }
        
        return Rilisoft.三丄丄与且与丂万与.丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  val_4);
    }
    internal static void 万丈丛丞丕业丙东丄(string 下上丐丆丝丟丝丒不, bool 下下丏一丙不丘丌丞, bool 丕丒万丄世丆丑丟丙 = False, bool 丌丂丑业下丞丝丈世 = False)
    {
        丕丒万丄世丆丑丟丙 = 丕丒万丄世丆丑丟丙;
        丌丂丑业下丞丝丈世 = 丌丂丑业下丞丝丈世;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  下下丏一丙不丘丌丞), 丕丒万丄世丆丑丟丙:  丕丒万丄世丆丑丟丙, 丌丂丑业下丞丝丈世:  丌丂丑业下丞丝丈世);
    }
    internal static void 且专丒一丅万与丁丞(string 下上丐丆丝丟丝丒不, int 下下丏一丙不丘丌丞, bool 丕丒万丄世丆丑丟丙 = False, bool 丌丂丑业下丞丝丈世 = False)
    {
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                if((丏丄丑上丛不丈且万.丈东丗与丑丄丆一丘().Contains(item:  下上丐丆丝丟丝丒不)) != false)
        {
                object[] val_4 = new object[1];
            val_4[0] = 下上丐丆丝丟丝丒不;
            UnityEngine.Debug.LogErrorFormat(format:  "setInt incorrect key:  {0}, use SetItem instead of setInt", args:  val_4);
            return;
        }
        
        }
        
        val_15 = 下上丐丆丝丟丝丒不;
        if(丕丒万丄世丆丑丟丙 == true)
        {
            goto label_19;
        }
        
        val_15 = 下上丐丆丝丟丝丒不;
        if(丌丂丑业下丞丝丈世 == true)
        {
            goto label_19;
        }
        
        val_16 = null;
        val_16 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_15 = 下上丐丆丝丟丝丒不;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_19;
        }
        
        label_16:
        val_15 = 丌丝世丞世丛丆丅丟.丒丞丅丕世丏丝一丄(上丞丞丅与不丞世业:  下上丐丆丝丟丝丒不);
        label_19:
        if(丌丂丑业下丞丝丈世 == false)
        {
            goto label_28;
        }
        
        val_18 = null;
        val_18 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_25;
        }
        
        val_19 = null;
        val_19 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_28;
        }
        
        label_25:
        val_15 = 丌丝世丞世丛丆丅丟.丕七丒业丟下丁丄七(上丞丞丅与不丞世业:  下上丐丆丝丟丝丒不);
        label_28:
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  val_15, value:  下下丏一丙不丘丌丞);
        }
        else
        {
                Rilisoft.三丄丄与且与丂万与.丂丟丝与上丌丆丅东(下上丐丆丝丟丝丒不:  val_15, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
            val_20 = null;
            val_20 = null;
            int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            var val_15 = 0;
            val_15 = val_15 + 1;
            丌丝世丞世丛丆丅丟.丘且丕丏丄三丝七且.set_Item(key:  0, value:  0);
        }
        
        val_22 = null;
        val_22 = null;
        bool val_14 = System.Linq.Enumerable.Contains<System.String>(source:  丌丝世丞世丛丆丅丟.七丑不丈丌丑专下世, value:  下上丐丆丝丟丝丒不);
        丌丝世丞世丛丆丅丟.下与丂丝丒丘与七业(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
    }
    internal static bool 丙不下丝与丏世世三(string 下上丐丆丝丟丝丒不, bool 且丌丌丟丙丐丛丅下 = False, bool 专不万丝丂三万丝丕 = False, bool 丅丝丆且丘丟丗丅丄 = False)
    {
        且丌丌丟丙丐丛丅下 = 且丌丌丟丙丐丛丅下;
        专不万丝丂三万丝丕 = 专不万丝丂三万丝丕;
        丅丝丆且丘丟丗丅丄 = 丅丝丆且丘丟丗丅丄;
        return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 且丌丌丟丙丐丛丅下:  且丌丌丟丙丐丛丅下, 专不万丝丂三万丝丕:  专不万丝丂三万丝丕, 丅丝丆且丘丟丗丅丄:  丅丝丆且丘丟丗丅丄));
    }
    internal static int 丑下丏丑丛丝下丟丈(string 下上丐丆丝丟丝丒不, bool 且丌丌丟丙丐丛丅下 = False, bool 专不万丝丂三万丝丕 = False, bool 丅丝丆且丘丟丗丅丄 = False)
    {
        System.Collections.Generic.IDictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且> val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        val_17 = 丅丝丆且丘丟丗丅丄;
        if((Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false) && (且丌丌丟丙丐丛丅下 != true))
        {
                if((丏丄丑上丛不丈且万.丈东丗与丑丄丆一丘().Contains(item:  下上丐丆丝丟丝丒不)) != false)
        {
                object[] val_4 = new object[1];
            val_4[0] = 下上丐丆丝丟丝丒不;
            UnityEngine.Debug.LogErrorFormat(format:  "getInt incorrect key:  {0}, use HasItem instead of getInt", args:  val_4);
        }
        
        }
        
        val_18 = 下上丐丆丝丟丝丒不;
        if(专不万丝丂三万丝丕 == true)
        {
            goto label_20;
        }
        
        val_18 = 下上丐丆丝丟丝丒不;
        if(val_17 == true)
        {
            goto label_20;
        }
        
        val_19 = null;
        val_19 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_17;
        }
        
        val_20 = null;
        val_20 = null;
        val_18 = 下上丐丆丝丟丝丒不;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_20;
        }
        
        label_17:
        val_18 = 丌丝世丞世丛丆丅丟.丒丞丅丕世丏丝一丄(上丞丞丅与不丞世业:  下上丐丆丝丟丝丒不);
        label_20:
        if(val_17 == false)
        {
            goto label_29;
        }
        
        val_17 = 1152921505171275776;
        val_21 = null;
        val_21 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_26;
        }
        
        val_22 = null;
        val_22 = null;
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_29;
        }
        
        label_26:
        val_18 = 丌丝世丞世丛丆丅丟.丕七丒业丟下丁丄七(上丞丞丅与不丞世业:  下上丐丆丝丟丝丒不);
        label_29:
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                val_23 = UnityEngine.PlayerPrefs.GetInt(key:  val_18);
            return (int)val_23;
        }
        
        val_17 = 1152921505266909184;
        val_24 = null;
        val_24 = null;
        var val_19 = 0;
        val_19 = val_19 + 1;
        if((丌丝世丞世丛丆丅丟.丘且丕丏丄三丝七且.TryGetValue(key:  null, value: out  TValue val_14 = null)) != false)
        {
                val_23;
            return (int)val_23;
        }
        
        val_26 = null;
        val_23 = Rilisoft.三丄丄与且与丂万与.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  val_18);
        val_26 = null;
        val_17 = 丌丝世丞世丛丆丅丟.丘且丕丏丄三丝七且;
        int val_17 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_17.Add(key:  0, value:  0);
        return (int)val_23;
    }
    private static string 丕七丒业丟下丁丄七(string 上丞丞丅与不丞世业)
    {
        return System.String.Format(format:  "new_{0}_Jule2017", arg0:  上丞丞丅与不丞世业);
    }
    private static string 丒丞丅丕世丏丝一丄(string 上丞丞丅与不丞世业)
    {
        return System.String.Format(format:  "new_{0}_V3", arg0:  上丞丞丅与不丞世业);
    }
    internal static void 专丟专且业丅丛下丂(string 下上丐丆丝丟丝丒不, string 下下丏一丙不丘丌丞)
    {
        null = null;
        丌丝世丞世丛丆丅丟.丟丗丞丑七且一与一.set_Item(key:  下上丐丆丝丟丝丒不, value:  下下丏一丙不丘丌丞);
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                UnityEngine.PlayerPrefs.SetString(key:  下上丐丆丝丟丝丒不, value:  下下丏一丙不丘丌丞);
        }
        else
        {
                Rilisoft.三丄丄与且与丂万与.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
        }
        
        丌丝世丞世丛丆丅丟.下与丂丝丒丘与七业(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
    }
    internal static string 下世丙上丈丏东与丙(string 下上丐丆丝丟丝丒不)
    {
        var val_6;
        string val_7;
        var val_8;
        string val_1 = 0;
        val_6 = null;
        val_6 = null;
        if((丌丝世丞世丛丆丅丟.丟丗丞丑七且一与一.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1)) != false)
        {
                val_7 = val_1;
            return val_7;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                val_7 = UnityEngine.PlayerPrefs.GetString(key:  下上丐丆丝丟丝丒不);
            return val_7;
        }
        
        val_8 = null;
        val_7 = Rilisoft.三丄丄与且与丂万与.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        val_8 = null;
        丌丝世丞世丛丆丅丟.丟丗丞丑七且一与一.Add(key:  下上丐丆丝丟丝丒不, value:  val_7);
        return val_7;
    }
    internal static bool 丐丘丐且业三丑丅丈(string 世丐与丞丕三丂专与)
    {
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
                return 丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  世丐与丞丕三丂专与);
        }
        
        return UnityEngine.PlayerPrefs.HasKey(key:  世丐与丞丕三丂专与);
    }
    internal static void 丏七丂万不东丘丄丂(string 世丐与丞丕三丂专与)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  世丐与丞丕三丂专与, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private static void 丌丟丙丕与丝丘丌万()
    {
    
    }
    private static 丌丝世丞世丛丆丅丟()
    {
        var val_7;
        丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂 = false;
        丌丝世丞世丛丆丅丟.且丆丏丄丂丝不专丂.__il2cppRuntimeField_0 = 0;
        丌丝世丞世丛丆丅丟.丞丞丛丄一丕丆丛三 = new System.Collections.Generic.Dictionary<System.String, System.Action>();
        丌丝世丞世丛丆丅丟.丗丌业丟业上一丑丄 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且>();
        丌丝世丞世丛丆丅丟.丟丗丞丑七且一与一 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        丌丝世丞世丛丆丅丟.与三丛丌丙丄三丕丂 = new System.Collections.Generic.HashSet<System.String>();
        丌丝世丞世丛丆丅丟.丘且丕丏丄三丝七且 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且>();
        string[] val_6 = new string[4];
        val_7 = null;
        val_7 = null;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        if(下专世丏丈丞三丗不.丁七丌丞丞万丈三丆 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(下专世丏丈丞三丗不.丁七丌丞丞万丈三丆 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_6[0] = 下专世丏丈丞三丗不.丁七丌丞丞万丈三丆;
        val_6[1] = 下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗;
        val_6[2] = 下专世丏丈丞三丗不.东且丄一丕专丌丆丐;
        val_6[3] = 下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆;
        丌丝世丞世丛丆丅丟.七丑不丈丌丑专下世 = val_6;
    }

}

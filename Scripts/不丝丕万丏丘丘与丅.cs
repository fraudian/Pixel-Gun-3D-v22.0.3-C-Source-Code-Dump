using UnityEngine;
public class 不丝丕万丏丘丘与丅
{
    // Fields
    private static 不丝丕万丏丘丘与丅 世丒丞七专三与万丕;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> 丂万丅丏万世丗世丏;
    
    // Properties
    internal static 不丝丕万丏丘丘与丅 丆丕丝丒不丙且丐丗 { get; }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> 丛丝丝丈丝丞丒业丝 { get; }
    
    // Methods
    private 不丝丕万丏丘丘与丅()
    {
        this.丂万丅丏万世丗世丏 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
        this.Load();
    }
    internal static 不丝丕万丏丘丘与丅 丑七不且上丗丁一世()
    {
        不丝丕万丏丘丘与丅 val_2;
        不丝丕万丏丘丘与丅 val_3 = 不丝丕万丏丘丘与丅.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        不丝丕万丏丘丘与丅 val_1 = null;
        val_2 = val_1;
        val_1 = new 不丝丕万丏丘丘与丅();
        不丝丕万丏丘丘与丅.世丒丞七专三与万丕 = val_2;
        val_3 = 不丝丕万丏丘丘与丅.世丒丞七专三与万丕;
        return val_3;
    }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> 丘下世丛且丄丝与丕()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>)this.丂万丅丏万世丗世丏;
    }
    internal System.Collections.Generic.List<string> 丐下下丅与上东丙丑(PGCompany.BattlePass.BPChallengeType 万丒丑且丈丂丘东丑)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7;
        var val_8;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_2 = 万丒丑且丈丂丘东丑.ToString().ToLowerInvariant();
        val_7 = this.丂万丅丏万世丗世丏;
        if((val_7.ContainsKey(key:  val_2)) != false)
        {
                val_7 = this.丂万丅丏万世丗世丏;
            if(val_7.Item[val_2] != null)
        {
                val_8 = this.丂万丅丏万世丗世丏.Item[val_2];
            return (System.Collections.Generic.List<System.String>)val_8;
        }
        
        }
        
        System.Collections.Generic.List<System.String> val_6 = null;
        val_8 = val_6;
        val_6 = new System.Collections.Generic.List<System.String>();
        return (System.Collections.Generic.List<System.String>)val_8;
    }
    private void Load()
    {
        this.丅专下万丕丑丆丅丝(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "BPChalengeLocalization.Keys"));
    }
    private void 丂且不业丂专丛丆东()
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "BPChalengeLocalization.Keys", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂万丅丏万世丗世丏));
    }
    internal void 丅专下万丕丑丆丅丝(System.Collections.Generic.Dictionary<string, object> 不丒丗且丝一不业一)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_15;
        var val_16;
        string val_17;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_1 = null;
        val_15 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
        this.丂万丅丏万世丗世丏 = val_15;
        Dictionary.Enumerator<TKey, TValue> val_2 = 不丒丗且丝一不业一.GetEnumerator();
        goto label_2;
        label_18:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        string val_7 = val_6._value._obj.丐丏七丌丕丗业且上();
        System.Collections.Generic.List<System.String> val_8 = new System.Collections.Generic.List<System.String>();
        this.丂万丅丏万世丗世丏.set_Item(key:  val_7, value:  null);
        val_15;
        val_15 = null;
        val_15 = new System.Collections.Generic.List<System.Object>();
        val_16 = 0;
        goto label_7;
        label_17:
        object val_10 = null.Item[0];
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_17)) != false)
        {
                this.丂万丅丏万世丗世丏.Item[val_7].Add(item:  val_17);
        }
        
        val_16 = 1;
        label_7:
        if(val_16 < null.Count)
        {
            goto label_17;
        }
        
        label_2:
        if((1723897520 & 1) != 0)
        {
            goto label_18;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丂且不业丂专丛丆东();
    }
    internal void 丅专下万丕丑丆丅丝(string 丌且专不丙丕专丅万)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
        Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万) = val_2;
        val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        this.丅专下万丕丑丆丅丝(不丒丗且丝一不业一:  val_2);
    }

}

using UnityEngine;
internal static class 且丙丈万世丛且丅丗
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, object> 一丅与不丆专上业丌;
    private static string 专不三专三丕七丛丗;
    
    // Properties
    internal static string 丟与丏丈丝且业世丒 { get; set; }
    
    // Methods
    private static void 丘丟丌丒丗专丝丑下()
    {
        且丙丈万世丛且丅丗.丘东丞世丝丟世丗丅(丙业与丙丗丝不丈东:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  65));
    }
    internal static void 丘东丞世丝丟世丗丅(string 丙业与丙丗丝不丈东)
    {
        null = null;
        且丙丈万世丛且丅丗.专不三专三丕七丛丗 = 丙业与丙丗丝不丈东;
        且丙丈万世丛且丅丗.东丝且丏丟东丂丗丅();
    }
    internal static string 业三丞丄丗世三上专()
    {
        null = null;
        return (string)且丙丈万世丛且丅丗.专不三专三丕七丛丗;
    }
    private static void 东丝且丏丟东丂丗丅()
    {
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  且丙丈万世丛且丅丗.业三丞丄丗世三上专());
        if(val_2 == null)
        {
                return;
        }
        
        System.Collections.Generic.IDictionary<System.String, System.Object> val_3 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
    }
    internal static object 丆丁下下七下不专丝(int 丅丅下丟丑专下与一)
    {
        var val_4;
        int val_15;
        var val_16;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = 丅丅下丟丑专下与一;
        PGCompany.与丐业一丂丗与七丟 val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.与丐业一丂丗与七丟>(且下丕七丙丗丄不七:  1);
        且丙丈万世丛且丅丗.丘丟丌丒丗专丝丑下();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        PGCompany.ClanWarEventConfig val_3 = val_2.世丈丁业丛上丘丗丐();
        if(val_4.Count <= val_15)
        {
                PGCompany.ClanWarEventConfig val_6 = val_2.世丈丁业丛上丘丗丐();
            val_15 = val_4.Count - 1;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = 且丙丈万世丛且丅丗.一丅与不丆专上业丌;
        PGCompany.ClanWarEventConfig val_8 = val_2.世丈丁业丛上丘丗丐();
        if((val_17.ContainsKey(key:  val_4.Item[val_15])) == false)
        {
            goto label_12;
        }
        
        val_18 = null;
        val_18 = null;
        val_17 = 且丙丈万世丛且丅丗.一丅与不丆专上业丌;
        PGCompany.ClanWarEventConfig val_11 = val_2.世丈丁业丛上丘丗丐();
        val_15 = val_4.Item[val_15];
        object val_13 = val_17.Item[val_15];
        return (object)val_19;
        label_4:
        val_20 = null;
        val_20 = null;
        System.Collections.Generic.KeyValuePair<System.String, System.Object> val_14 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  且丙丈万世丛且丅丗.一丅与不丆专上业丌);
        return (object)val_19;
        label_12:
        val_19 = 0;
        return (object)val_19;
    }
    private static 且丙丈万世丛且丅丗()
    {
        且丙丈万世丛且丅丗.一丅与不丆专上业丌 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
    }

}

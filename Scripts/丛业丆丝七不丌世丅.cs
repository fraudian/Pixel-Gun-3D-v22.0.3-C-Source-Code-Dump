using UnityEngine;
public class 丛业丆丝七不丌世丅
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, int> 丗七万丗丂丘丝丛丑;
    private static Rilisoft.丅丟丒丟丑丈丒三丆 丏七下丒上东业丆丒;
    private static Rilisoft.且丈丞一丞丟与上七 丑丐三丏世七三丌丟;
    internal static int 与丑丂专丁世不丑世;
    
    // Properties
    internal static System.Collections.Generic.Dictionary<string, int> 丘丏丁丂丌一丝丛丝 { get; }
    
    // Methods
    internal static System.Collections.Generic.Dictionary<string, int> 丝世丌丟丑丐丘丐丏()
    {
        var val_1 = null;
        if(丛业丆丝七不丌世丅.丗七万丗丂丘丝丛丑 == null)
        {
                丛业丆丝七不丌世丅.Load();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Int32>)丛业丆丝七不丌世丅.丗七万丗丂丘丝丛丑;
    }
    internal static void 丑东丙丙世七丑丅且(string 丆万一不丌且东丐丐, int 且丙丙丁丅丐七丌丐, string 上且丗一丏丏万丅丌, string 丈下丑丆上丏丗丈专, int 丙丂丏丛丌丏下丝不)
    {
        var val_10;
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丆万一不丌且东丐丐 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丆万一不丌且东丐丐 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丆万一不丌且东丐丐;
        val_1[1] = 且丙丙丁丅丐七丌丐;
        val_1[2] = 上且丗一丏丏万丅丌;
        val_1[3] = 丈下丑丆上丏丗丈专;
        val_1[4] = 丙丂丏丛丌丏下丝不;
        string val_2 = System.String.Format(format:  "{0}_{1}_{2}_{3}_{4}_k", args:  val_1);
        val_10 = 1152921505129582592;
        if((丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏().ContainsKey(key:  val_2)) == false)
        {
            goto label_22;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = 丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏();
        if(val_5 == null)
        {
            goto label_25;
        }
        
        val_10 = val_5.Item[val_2];
        goto label_26;
        label_22:
        丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏().Add(key:  val_2, value:  1);
        return;
        label_25:
        val_10 = 0.Item[val_2];
        label_26:
        val_5.set_Item(key:  val_2, value:  val_10 + 1);
    }
    internal static void 丙一丝专丟丟与丟丛(string 丆万一不丌且东丐丐, int 且丙丙丁丅丐七丌丐, string 上且丗一丏丏万丅丌, string 丈下丑丆上丏丗丈专, int 丙丂丏丛丌丏下丝不)
    {
        var val_10;
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丆万一不丌且东丐丐 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丆万一不丌且东丐丐 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丆万一不丌且东丐丐;
        val_1[1] = 且丙丙丁丅丐七丌丐;
        val_1[2] = 上且丗一丏丏万丅丌;
        val_1[3] = 丈下丑丆上丏丗丈专;
        val_1[4] = 丙丂丏丛丌丏下丝不;
        string val_2 = System.String.Format(format:  "{0}_{1}_{2}_{3}_{4}_d", args:  val_1);
        val_10 = 1152921505129582592;
        if((丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏().ContainsKey(key:  val_2)) == false)
        {
            goto label_22;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = 丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏();
        if(val_5 == null)
        {
            goto label_25;
        }
        
        val_10 = val_5.Item[val_2];
        goto label_26;
        label_22:
        丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏().Add(key:  val_2, value:  1);
        return;
        label_25:
        val_10 = 0.Item[val_2];
        label_26:
        val_5.set_Item(key:  val_2, value:  val_10 + 1);
    }
    internal static string 丂丆丑世一不丘丏七()
    {
        return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏());
    }
    internal static void 且七丙丄丘一丄上不()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        丛业丆丝七不丌世丅.与丑丂专丁世不丑世 = 与丂丏丛丞丞丒丟丄.世丆丞丂一不万丛丟;
        丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏().Clear();
        丛业丆丝七不丌世丅.丏七下丒上东业丆丒.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  "{}");
        丛业丆丝七不丌世丅.丑丐三丏世七三丌丟.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丛业丆丝七不丌世丅.与丑丂专丁世不丑世);
    }
    internal static void 丂且不业丂专丛丆东()
    {
        null = null;
        丛业丆丝七不丌世丅.丏七下丒上东业丆丒.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丛业丆丝七不丌世丅.丝世丌丟丑丐丘丐丏()));
        丛业丆丝七不丌世丅.丑丐三丏世七三丌丟.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丛业丆丝七不丌世丅.与丑丂专丁世不丑世);
    }
    private static void Load()
    {
        var val_9;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        Rilisoft.且丈丞一丞丟与上七 val_20;
        var val_21;
        var val_22;
        val_15 = null;
        val_15 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛业丆丝七不丌世丅.丏七下丒上东业丆丒.世三丞丅丑丌丈丈一())) != false)
        {
                val_16 = null;
            val_16 = null;
            丛业丆丝七不丌世丅.丏七下丒上东业丆丒.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  "{}");
        }
        
        val_17 = null;
        val_17 = null;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        丛业丆丝七不丌世丅.丗七万丗丂丘丝丛丑 = val_5;
        Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        label_25:
        if((1524366416 & 1) == 0)
        {
            goto label_19;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_9.GetAwaiter();
        val_18 = null;
        val_18 = null;
        val_5.Add(key:  val_11._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToInt32(value:  val_11._value._obj));
        goto label_25;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_19 = null;
        val_19 = null;
        val_20 = 丛业丆丝七不丌世丅.丑丐三丏世七三丌丟;
        val_21 = null;
        丛业丆丝七不丌世丅.与丑丂专丁世不丑世 = val_20.世三丞丅丑丌丈丈一();
        if(丛业丆丝七不丌世丅.与丑丂专丁世不丑世 != 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_21 = null;
        val_20 = 与丂丏丛丞丞丒丟丄.世丆丞丂一不万丛丟;
        val_21 = null;
        丛业丆丝七不丌世丅.与丑丂专丁世不丑世 = val_20;
    }
    public 丛业丆丝七不丌世丅()
    {
    
    }
    private static 丛业丆丝七不丌世丅()
    {
        丛业丆丝七不丌世丅.丏七下丒上东业丆丒 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  "WeaponsStats.KillsAndDeaths_Ups_v3");
        丛业丆丝七不丌世丅.丑丐三丏世七三丌丟 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "WeaponsStats.MatchesToSend");
        丛业丆丝七不丌世丅.与丑丂专丁世不丑世 = 0;
    }

}

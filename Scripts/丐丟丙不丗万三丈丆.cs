using UnityEngine;
public class 丐丟丙不丗万三丈丆
{
    // Fields
    private static 丐丟丙不丗万三丈丆 丝业丆丁业三丈丟东;
    private bool 丗丐丑七丙丛专丅丌;
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> 下业丙丈丝万丂丐东;
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> 与丈七丕丙三丆上上;
    private bool <丙三丟与东万丆一丗>k__BackingField;
    
    // Properties
    internal static 丐丟丙不丗万三丈丆 丄丘七三上丕世丞业 { get; }
    internal bool 丛丘丕且丈丂万丝丒 { get; set; }
    
    // Methods
    internal static 丐丟丙不丗万三丈丆 与一丅丝不丈业与丙()
    {
        丐丟丙不丗万三丈丆 val_2;
        丐丟丙不丗万三丈丆 val_3 = 丐丟丙不丗万三丈丆.丝业丆丁业三丈丟东;
        if(val_3 != null)
        {
                return val_3;
        }
        
        丐丟丙不丗万三丈丆 val_1 = new 丐丟丙不丗万三丈丆();
        丐丟丙不丗万三丈丆.丝业丆丁业三丈丟东 = val_1;
        val_2 = 丐丟丙不丗万三丈丆.丝业丆丁业三丈丟东;
        val_1.丗专丟丂东丝七丈丝();
        val_3 = 丐丟丙不丗万三丈丆.丝业丆丁业三丈丟东;
        return val_3;
    }
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> 丘丘七丑丙丈世丌丗(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_3;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_4;
        val_3 = this;
        val_4 = this.与丈七丕丙三丆上上;
        if((val_4.ContainsKey(key:  上且丗一丏丏万丅丌)) != false)
        {
                val_4 = val_4;
            与与丌丑丑丞丗丐丂 val_2 = val_4.Item[上且丗一丏丏万丅丌];
            if(val_2.万万三上一丞丕丙丁 == true)
        {
                return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>)this.下业丙丈丝万丂丐东.SyncRoot;
        }
        
        }
        
        val_3 = this.下业丙丈丝万丂丐东;
        return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>)this.下业丙丈丝万丂丐东.SyncRoot;
    }
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> 丌丛不丈丘丆且丘东(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 丞丁丑丏丄丏七丂不)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_3;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_4;
        丅三丒丒上丑丐上业[] val_5;
        var val_6;
        val_3 = 上且丗一丏丏万丅丌;
        val_4 = this;
        if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_3)) == false)
        {
            goto label_2;
        }
        
        val_3 = this.与丈七丕丙三丆上上.Item[val_3];
        val_5 = val_2.七丂专丞专丝万丒上;
        if(val_5 == null)
        {
            goto label_5;
        }
        
        val_6 = 0;
        goto label_6;
        label_20:
        var val_6 = 0;
        label_17:
        丅三丒丒上丑丐上业 val_3 = val_2.七丂专丞专丝万丒上[0];
        if(val_6 >= val_2.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上.Length)
        {
            goto label_11;
        }
        
        丅三丒丒上丑丐上业 val_4 = val_2.七丂专丞专丝万丒上[0];
        val_6 = val_6 + 1;
        if(val_2.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上[0] != 丞丁丑丏丄丏七丂不)
        {
            goto label_17;
        }
        
        return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>)this.下业丙丈丝万丂丐东.SyncRoot;
        label_11:
        val_5 = val_2.七丂专丞专丝万丒上;
        val_6 = 1;
        label_6:
        if(val_6 < val_2.七丂专丞专丝万丒上.Length)
        {
            goto label_20;
        }
        
        label_5:
        if(val_2.万万三上一丞丕丙丁 == true)
        {
                return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>)this.下业丙丈丝万丂丐东.SyncRoot;
        }
        
        label_2:
        val_4 = this.下业丙丈丝万丂丐东;
        return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>)this.下业丙丈丝万丂丐东.SyncRoot;
    }
    internal int 丁与丞丅世与丘丆丆(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 丞丁丑丏丄丏七丂不)
    {
        丅三丒丒上丑丐上业 val_3;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_4;
        丅三丒丒上丑丐上业[] val_5;
        var val_6;
        int val_7;
        var val_8;
        val_3 = 丞丁丑丏丄丏七丂不;
        val_4 = this;
        if((this.与丈七丕丙三丆上上.ContainsKey(key:  上且丗一丏丏万丅丌)) == false)
        {
            goto label_2;
        }
        
        val_4 = this.与丈七丕丙三丆上上;
        与与丌丑丑丞丗丐丂 val_2 = val_4.Item[上且丗一丏丏万丅丌];
        val_5 = val_2.七丂专丞专丝万丒上;
        if(val_5 == null)
        {
            goto label_5;
        }
        
        val_4 = 0;
        goto label_6;
        label_20:
        val_6 = 0;
        label_17:
        丅三丒丒上丑丐上业 val_3 = val_2.七丂专丞专丝万丒上[0];
        if(val_6 >= val_2.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上.Length)
        {
            goto label_11;
        }
        
        丅三丒丒上丑丐上业 val_4 = val_2.七丂专丞专丝万丒上[0];
        val_6 = val_6 + 1;
        if(val_2.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上[0] != val_3)
        {
            goto label_17;
        }
        
        goto label_18;
        label_11:
        val_5 = val_2.七丂专丞专丝万丒上;
        val_4 = 1;
        label_6:
        if(val_4 < val_2.七丂专丞专丝万丒上.Length)
        {
            goto label_20;
        }
        
        label_5:
        val_7 = val_2.丕万与丐丙且丗且丛;
        goto label_21;
        label_2:
        val_8 = 0;
        return (int)val_8;
        label_18:
        val_3 = val_2.七丂专丞专丝万丒上[0];
        val_7 = val_2.七丂专丞专丝万丒上[0x0][0].丕万与丐丙且丗且丛;
        label_21:
        val_8 = mem[val_2.七丂专丞专丝万丒上[0x0][0].丕万与丐丙且丗且丛];
        val_8 = val_7;
        return (int)val_8;
    }
    private void 丏丌丝丗业丘丏下丌(bool 丙业与丙丗丝不丈东)
    {
        this.<丙三丟与东万丆一丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 上丑丙丂丆一丞下上()
    {
        return (bool)this.<丙三丟与东万丆一丗>k__BackingField;
    }
    internal static bool 东丁不业丟世丂三世(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        丂丛丑东不丅丈一东 = ((丂丛丑东不丅丈一东 == 17) ? 1 : 0) | ((丂丛丑东不丅丈一东 == 20) ? 1 : 0);
        return (bool)丂丛丑东不丅丈一东;
    }
    private void 上丛丌丆丑上七世三()
    {
        this.丗专丟丂东丝七丈丝();
    }
    private void 丂丒七丞且世世丐丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丗专丟丂东丝七丈丝();
    }
    private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 64)
        {
                return;
        }
        
        this.丐丏丅三丕下丒且万();
    }
    private void 丐丞上丌丄丕丙丗丛()
    {
        if(this.丗丐丑七丙丛专丅丌 == true)
        {
                return;
        }
        
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丙丗丂丙七丁丈万丗(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void 丐丟丙不丗万三丈丆::丂丒七丞且世世丐丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.丗丐丑七丙丛专丅丌 = true;
    }
    private void 丗专丟丂东丝七丈丝()
    {
        this.丐丞上丌丄丕丙丗丛();
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void 丐丟丙不丗万三丈丆::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        if(PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丟东丒三一丐业且专() == 2)
        {
                PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void 丐丟丙不丗万三丈丆::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            this.丐丏丅三丕下丒且万();
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "TierMatchmakingController: load config for old system is not implemented");
    }
    private void 丐丏丅三丕下丒且万()
    {
        this.丟丈上丛丙丕业丁丐(丛七丅东丒丅丘不业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  64));
    }
    private void 丟丈上丛丙丕业丁丐(string 丛七丅东丒丅丘不业)
    {
        this.<丙三丟与东万丆一丗>k__BackingField = false;
        this.下业丙丈丝万丂丐东.Clear();
        this.与丈七丕丙三丆上上.Clear();
        if((System.String.IsNullOrEmpty(value:  丛七丅东丒丅丘不业)) == true)
        {
                return;
        }
        
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丛七丅东丒丅丘不业);
        if(val_2 == null)
        {
                return;
        }
        
        this.丌丒丒丐丂上丙丘丐(一丐丗丁丞丆丅丟丄:  val_2);
        this.<丙三丟与东万丆一丗>k__BackingField = true;
    }
    private void 丌丒丒丐丂上丙丘丐(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_4;
        object val_34;
        var val_35;
        var val_36;
        string val_37;
        var val_38;
        var val_39;
        丅三丒丒上丑丐上业[] val_40;
        var val_41;
        var val_42;
        var val_43;
        val_34 = 一丐丗丁丞丆丅丟丄;
        Dictionary.Enumerator<TKey, TValue> val_1 = val_34.GetEnumerator();
        goto label_2;
        label_47:
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        val_35 = 0;
        new 与七丙丌丈丅上丝不() = new 与七丙丌丈丅上丝不();
        val_36 = 0;
        goto label_34;
        label_46:
        object val_10 = Item[0];
        if(val_10 == null)
        {
            goto label_43;
        }
        
        object val_11 = val_10.Item["mode"];
        if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_37 = 0;
        }
        
        System.Nullable<T> val_13 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_37, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
        if(((-637682856) & 1) == 0)
        {
            goto label_15;
        }
        
        if((val_10.ContainsKey(key:  "maps")) == false)
        {
            goto label_16;
        }
        
        object val_16 = val_10.Item["maps"];
        val_38 = 0;
        val_39 = 1;
        int val_17 = val_38.Count;
        val_40 = new 丅三丒丒上丑丐上业[0];
        val_41 = 0;
        goto label_20;
        label_30:
        System.Int32[] val_24 = 0;
        val_42 = 0;
        val_38.Item[0].不丐丗上丝下不上且(丘东不三丏丛丅丟丞:  val_10, 丂丛丑东不丅丈一东:  new System.Nullable<Rilisoft.七丕丟丏三丈一丄世>() {HasValue = val_13.HasValue}, 丒丐丈下丛丛丒丈丏: ref  null, 丞丅上丏丂且下丅与: ref  0, 丕万与丐丙且丗且丛: ref  0, 丂丄丝丘丌丅丈三不: ref  val_24);
        new 丗丑一一丛丁上丏丆() = new 丗丑一一丛丁上丏丆(丒丐丈下丛丛丒丈丏:  null, 丈丞丏三丒丁丗丘东:  new 与七丙丌丈丅上丝不());
        new 丅三丒丒上丑丐上业() = new 丅三丒丒上丑丐上业(丞丅上丏丂且下丅与:  0, 七丂专丞专丝万丒上:  val_24, 丕万与丐丙且丗且丛:  0, 一丐丗丁丞丆丅丟丄:  new 丗丑一一丛丁上丏丆());
        val_40 = val_40;
        val_40[0] = new 丅三丒丒上丑丐上业();
        val_38 = val_38;
        val_39 = val_39;
        val_41 = 1;
        label_20:
        if(val_41 < val_38.Count)
        {
            goto label_30;
        }
        
        goto label_31;
        label_15:
        val_34 = "TierMatchmakingController config: Unknow mode: "("TierMatchmakingController config: Unknow mode: ") + val_37;
        UnityEngine.Debug.LogError(message:  val_34);
        label_43:
        val_36 = 1;
        goto label_34;
        label_16:
        val_40 = 0;
        label_31:
        if((val_10.ContainsKey(key:  "R")) != false)
        {
                val_43 = System.Convert.ToInt32(value:  val_10.Item["R"]);
        }
        else
        {
                val_43 = 0;
        }
        
        new 与与丌丑丑丞丗丐丂() = new 与与丌丑丑丞丗丐丂(丂丛丑东不丅丈一东:  new 丗丑一一丛丁上丏丆(丒丐丈下丛丛丒丈丏:  val_10, 丈丞丏三丒丁丗丘东:  new 与七丙丌丈丅上丝不()), 七丂专丞专丝万丒上:  val_40, 丕万与丐丙且丗且丛:  0);
        if((System.String.op_Equality(a:  val_5._value._obj.丐丏七丌丕丗业且上(), b:  "server")) == false)
        {
            goto label_39;
        }
        
        this.与丈七丕丙三丆上上.Add(key:  val_13.HasValue, value:  new 与与丌丑丑丞丗丐丂());
        goto label_43;
        label_39:
        this.下业丙丈丝万丂丐东.Add(key:  val_13.HasValue, value:  new 与与丌丑丑丞丗丐丂());
        goto label_43;
        label_34:
        if(val_36 < Count)
        {
            goto label_46;
        }
        
        label_2:
        if(((-637682832) & 1) != 0)
        {
            goto label_47;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 不丐丗上丝下不上且(System.Collections.Generic.Dictionary<string, object> 丘东不三丏丛丅丟丞, System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丂丛丑东不丅丈一东, ref System.Collections.Generic.Dictionary<string, object> 丒丐丈下丛丛丒丈丏, ref int 丞丅上丏丂且下丅与, ref int 丕万与丐丙且丗且丛, ref int[] 丂丄丝丘丌丅丈三不)
    {
        System.Int32[] val_20;
        System.Int32[] val_21;
        var val_22;
        string val_23;
        int val_24;
        var val_25;
        if((丘东不三丏丛丅丟丞.ContainsKey(key:  "boiler")) != false)
        {
                丒丐丈下丛丛丒丈丏.Add(key:  "boiler", value:  丘东不三丏丛丅丟丞.Item["boiler"]);
        }
        
        if((丒丐丈下丛丛丒丈丏.ContainsKey(key:  "R")) != false)
        {
                丕万与丐丙且丗且丛 = System.Convert.ToInt32(value:  丒丐丈下丛丛丒丈丏.Item["R"]);
        }
        
        val_20 = 1152921516622706448;
        丞丅上丏丂且下丅与 = System.Convert.ToInt32(value:  丒丐丈下丛丛丒丈丏.Item["id"]);
        object val_8 = 丒丐丈下丛丛丒丈丏.Item["map"];
        int val_9 = 0.Count;
        val_21 = new int[0];
        丂丄丝丘丌丅丈三不 = val_21;
        val_22 = 0;
        goto label_17;
        label_35:
        object val_11 = 0.Item[0];
        if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        if(((-637452024) != 20) || ((val_23.EndsWith(value:  "_solo")) == false))
        {
            goto label_23;
        }
        
        if(val_23 == 0)
        {
            goto label_24;
        }
        
        val_24 = val_23.LastIndexOf(value:  "_solo");
        goto label_25;
        label_23:
        val_20 = 0;
        goto label_26;
        label_24:
        val_24 = val_23.LastIndexOf(value:  "_solo");
        label_25:
        val_23 = val_23.Substring(startIndex:  0, length:  val_24);
        val_20 = 1;
        label_26:
        int val_17 = 0;
        if((System.Int32.TryParse(s:  val_23, result: out  val_17)) != false)
        {
                val_25 = val_17;
            if(val_20 != 0)
        {
                val_25 = 10000;
        }
        
            val_20 = 丂丄丝丘丌丅丈三不;
            mem2[0] = val_25;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "TierMatchmakingController config: map not found: "("TierMatchmakingController config: map not found: ") + val_23);
        }
        
        val_21 = 丂丄丝丘丌丅丈三不;
        val_22 = 1;
        label_17:
        if(val_22 < mem[1152921538329214120])
        {
            goto label_35;
        }
    
    }
    internal float 丒丈与丟与上世丕一(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_17;
        var val_18;
        丄世丕丈一丈东丆丐 val_19;
        var val_20;
        var val_21;
        val_17 = 丂丛丑东不丅丈一东;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  val_17)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_17)) == false)
        {
                return 0f;
        }
        
        }
        
        if((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_17, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞)) != null)
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_17, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞);
            val_18 = 1152921505230008320;
            val_19 = val_4.丝三业丒万丛丝丁丅;
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  val_17).Item[val_17];
            val_18 = 1152921505230008320;
            val_19 = val_6.丂丛丑东不丅丈一东;
        }
        
        丁一业专丈三丄丘专 val_7 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        val_17 = 0.丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  val_17);
        if(val_19 == null)
        {
                return 0f;
        }
        
        val_20 = val_19.且丘丝丈业丞七丄丟();
        if((val_9.Length == 0) || (val_19 == null))
        {
            goto label_16;
        }
        
        不七且丌丄丑世七丙[] val_11 = val_19.且丘丝丈业丞七丄丟();
        不七且丌丄丑世七丙[] val_15 = val_19.且丘丝丈业丞七丄丟();
        if(val_15.Length == 0)
        {
            goto label_22;
        }
        
        val_20 = (long)UnityEngine.Mathf.Clamp(value:  val_17.丏专丆丞七东且丕丘(), min:  0, max:  UnityEngine.Mathf.Max(a:  0, b:  val_11.Length - 1));
        var val_17 = 12;
        val_17 = val_19.且丘丝丈业丞七丄丟() + (val_20 * val_17);
        if(val_17 != null)
        {
            goto label_28;
        }
        
        label_29:
        label_28:
        val_21 = ((long)(int)(val_14) * 12) + val_16 + 32;
        return val_17.丐专丞丂丟丂丟万丅(万不世丒与丏业丌丆:  100);
        label_16:
        val_21 = 100;
        return val_17.丐专丞丂丟丂丟万丅(万不世丒与丏业丌丆:  100);
        label_22:
        if(val_17 != null)
        {
            goto label_28;
        }
        
        goto label_29;
    }
    internal bool 丄丐丅七不丕丙一丘(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        var val_16;
        var val_17;
        丄世丕丈一丈东丆丐 val_18;
        var val_19;
        val_16 = this;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return false;
        }
        
        }
        
        if((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞)) != null)
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞);
            val_17 = 1152921505230008320;
            val_18 = val_4.丝三业丒万丛丝丁丅;
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东).Item[丂丛丑东不丅丈一东];
            val_17 = 1152921505230008320;
            val_18 = val_6.丂丛丑东不丅丈一东;
        }
        
        丁一业专丈三丄丘专 val_7 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        丑丄一丐丁丕世下丕 val_8 = 0.丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        if(val_8 == null)
        {
            goto label_13;
        }
        
        if(val_18 == null)
        {
            goto label_14;
        }
        
        label_24:
        不七且丌丄丑世七丙[] val_10 = val_18.且丘丝丈业丞七丄丟();
        val_16 = UnityEngine.Mathf.Clamp(value:  val_8.丏专丆丞七东且丕丘(), min:  0, max:  UnityEngine.Mathf.Max(a:  0, b:  val_10.Length - 1));
        不七且丌丄丑世七丙[] val_14 = val_18.且丘丝丈业丞七丄丟();
        if(val_14.Length == 0)
        {
            goto label_19;
        }
        
        val_16 = (long)val_16;
        var val_16 = 12;
        val_16 = val_18.且丘丝丈业丞七丄丟() + (val_16 * val_16);
        val_19 = mem[((long)(int)(val_13) * 12) + val_15 + 32];
        val_19 = ((long)(int)(val_13) * 12) + val_15 + 32;
        if(val_8 != null)
        {
                return val_8.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  100);
        }
        
        return val_8.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  100);
        label_13:
        if(val_18 != null)
        {
            goto label_24;
        }
        
        label_14:
        val_19 = 100;
        return val_8.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  100);
        label_19:
        val_19 = 100;
        if(val_8 != null)
        {
                return val_8.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  100);
        }
        
        return val_8.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  100);
    }
    internal int 丟下业丁万丗三丅丄(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return 0;
        }
        
        }
        
        丑丄一丐丁丕世下丕 val_4 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙().丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        if(val_4.丆丐万丑上丄上丂三 != null)
        {
                return val_4.丆丐万丑上丄上丂三.Count;
        }
        
        return val_4.丆丐万丑上丄上丂三.Count;
    }
    private int 丑上丒丑丟三上丙丄(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_8;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_9;
        if(丂丛丑东不丅丈一东 == 17)
        {
                return 0;
        }
        
        if(丂丛丑东不丅丈一东 == 20)
        {
                return 0;
        }
        
        val_8 = this.下业丙丈丝万丂丐东;
        if((val_8.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                val_9 = this.与丈七丕丙三丆上上;
            if((val_9.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return 0;
        }
        
        }
        
        与与丌丑丑丞丗丐丂 val_4 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东).Item[丂丛丑东不丅丈一东];
        if(val_4.丂丛丑东不丅丈一东 != null)
        {
                return val_4.丂丛丑东不丅丈一东.业三丕丏不丅七丁三(丈丘丝一丗下丈丐不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂());
        }
        
        return val_4.丂丛丑东不丅丈一东.业三丕丏不丅七丁三(丈丘丝一丗下丈丐不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂());
    }
    internal int 丒丐下丙上丂丐一丑(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丙丂丏丛丌丏下丝不)
    {
        if(丂丛丑东不丅丈一东 == 17)
        {
                return 0;
        }
        
        if(丂丛丑东不丅丈一东 == 20)
        {
                return 0;
        }
        
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return 0;
        }
        
        }
        
        与与丌丑丑丞丗丐丂 val_4 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东).Item[丂丛丑东不丅丈一东];
        if(val_4.丂丛丑东不丅丈一东 != null)
        {
                return val_4.丂丛丑东不丅丈一东.丛丕丐丏丒一业专世(丈丘丝一丗下丈丐不:  丙丂丏丛丌丏下丝不);
        }
        
        return val_4.丂丛丑东不丅丈一东.丛丕丐丏丒一业专世(丈丘丝一丗下丈丐不:  丙丂丏丛丌丏下丝不);
    }
    internal int 丒丐下丙上丂丐一丑(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        return this.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丙丂丏丛丌丏下丝不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂());
    }
    private int 丝丕丒丛丅丙丅下丄(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        if(丂丛丑东不丅丈一东 == 17)
        {
                return 1;
        }
        
        if(丂丛丑东不丅丈一东 != 20)
        {
                return GameConnect.丅下世万业业丘专丄();
        }
        
        return 1;
    }
    internal int 丏专丆丞七东且丕丘(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        int val_10;
        var val_11;
        val_10 = 丛且丞与丕业下丏丞;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return this.丑上丒丑丟三上丙丄(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        }
        
        if((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  val_10)) != null)
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  val_10);
            val_11 = 1152921505230008320;
            val_10 = val_4.丝三业丒万丛丝丁丅;
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东).Item[丂丛丑东不丅丈一东];
            val_11 = 1152921505230008320;
            val_10 = val_6.丂丛丑东不丅丈一东;
        }
        
        丁一业专丈三丄丘专 val_7 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        丑丄一丐丁丕世下丕 val_8 = 0.丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        if(val_8 == null)
        {
                return this.丑上丒丑丟三上丙丄(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        if(val_10 == null)
        {
                return this.丑上丒丑丟三上丙丄(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        不七且丌丄丑世七丙[] val_9 = val_10.且丘丝丈业丞七丄丟();
        if(val_9.Length == 0)
        {
                return this.丑上丒丑丟三上丙丄(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        if(val_10 == null)
        {
                return this.丑上丒丑丟三上丙丄(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        return val_8.丏专丆丞七东且丕丘();
    }
    internal int 业丛东丕丘丁丗万世(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_19;
        var val_20;
        var val_21;
        丄世丕丈一丈东丆丐 val_22;
        val_19 = 丂丛丑东不丅丈一东;
        val_20 = this;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  val_19)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_19)) == false)
        {
                return val_22.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_19 = ???);
        }
        
        }
        
        if((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_19, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞)) != null)
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_19, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞);
            val_21 = 1152921505230008320;
            val_22 = val_4.丝三业丒万丛丝丁丅;
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  val_19).Item[val_19];
            val_21 = 1152921505230008320;
            val_22 = val_6.丂丛丑东不丅丈一东;
        }
        
        丁一业专丈三丄丘专 val_7 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        val_20 = 0.丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  val_19);
        if(val_20 == null)
        {
                return val_22.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_19);
        }
        
        if(val_22 == null)
        {
                return val_22.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_19);
        }
        
        不七且丌丄丑世七丙[] val_9 = val_22.且丘丝丈业丞七丄丟();
        if(val_9.Length == 0)
        {
                return val_22.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_19);
        }
        
        if(val_22 == null)
        {
                return val_22.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_19);
        }
        
        int val_10 = ExperienceController.丞丞丘业东丙丏七丌();
        int val_11 = val_20.丏专丆丞七东且丕丘();
        val_20 = ???;
        goto typeof(丄世丕丈一丈东丆丐).__il2cppRuntimeField_168;
    }
    internal int 丏业世丄丒一丙专丟(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_31;
        丄世丕丈一丈东丆丐 val_32;
        object val_33;
        int val_34;
        val_31 = 丂丛丑东不丅丈一东;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  val_31)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_31)) == false)
        {
                return 0;
        }
        
        }
        
        if((丛且丞与丕业下丏丞 != 1) && ((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_31, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞)) != null))
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_31, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞);
            val_32 = val_4.丝三业丒万丛丝丁丅;
            val_31 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙().丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  val_31);
            val_33 = "Tier Map matchmaking";
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_8 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  val_31).Item[val_31];
            val_32 = val_8.丂丛丑东不丅丈一东;
            val_31 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙().丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  val_31);
            val_33 = "Tier Mode matchmaking";
        }
        
        UnityEngine.Debug.Log(message:  val_33);
        if(val_32 == null)
        {
                return 0;
        }
        
        不七且丌丄丑世七丙[] val_11 = val_32.且丘丝丈业丞七丄丟();
        if((val_11.Length == 0) || (val_32 == null))
        {
                return 0;
        }
        
        if(val_31 != null)
        {
                val_31.万万丐丟丏丘丞丞丆();
        }
        else
        {
                0.万万丐丟丏丘丞丞丆();
        }
        
        不七且丌丄丑世七丙[] val_13 = val_32.且丘丝丈业丞七丄丟();
        int val_16 = UnityEngine.Mathf.Clamp(value:  val_31.丏专丆丞七东且丕丘(), min:  0, max:  UnityEngine.Mathf.Max(a:  0, b:  val_13.Length - 1));
        var val_29 = 12;
        val_29 = val_32.且丘丝丈业丞七丄丟() + ((long)val_16 * val_29);
        if((val_31.丄丐丅七不丕丙一丘(万不世丒与丏业丌丆:  ((long)(int)(val_16) * 12) + val_17 + 32)) == false)
        {
            goto label_33;
        }
        
        var val_30 = 12;
        val_30 = val_32.且丘丝丈业丞七丄丟() + ((long)val_16 * val_30);
        float val_20 = val_31.丐专丞丂丟丂丟万丅(万不世丒与丏业丌丆:  ((long)(int)(val_16) * 12) + val_19 + 32);
        UnityEngine.Debug.Log(message:  "My tier matchmaking killrate " + val_20);
        if((val_16 & 2147483648) == 0)
        {
                不七且丌丄丑世七丙[] val_22 = val_32.且丘丝丈业丞七丄丟();
            if(val_16 < val_22.Length)
        {
                var val_31 = 12;
            val_31 = val_32.且丘丝丈业丞七丄丟() + ((long)val_16 * val_31);
            if(val_20 >= (((long)(int)(val_16) * 12) + val_23 + 36))
        {
                var val_32 = 12;
            val_32 = val_32.且丘丝丈业丞七丄丟() + ((long)val_16 * val_32);
            if(val_20 <= (((long)(int)(val_16) * 12) + val_24 + 40))
        {
                return 0;
        }
        
        }
        
        }
        
        }
        
        val_34 = val_16 + 1;
        if((val_34 & 2147483648) != 0)
        {
            goto label_50;
        }
        
        不七且丌丄丑世七丙[] val_25 = val_32.且丘丝丈业丞七丄丟();
        if(val_34 >= val_25.Length)
        {
            goto label_50;
        }
        
        var val_33 = 12;
        val_33 = val_32.且丘丝丈业丞七丄丟() + ((long)val_34 * val_33);
        if(val_20 >= (((long)(int)((val_16 + 1)) * 12) + val_26 + 36))
        {
            goto label_53;
        }
        
        label_50:
        val_34 = val_16 - 1;
        if((val_34 & 2147483648) != 0)
        {
                return 0;
        }
        
        不七且丌丄丑世七丙[] val_27 = val_32.且丘丝丈业丞七丄丟();
        if(val_34 >= val_27.Length)
        {
                return 0;
        }
        
        var val_34 = 12;
        val_34 = val_32.且丘丝丈业丞七丄丟() + ((long)val_34 * val_34);
        if(val_20 > (((long)(int)((val_16 - 1)) * 12) + val_28 + 40))
        {
                return 0;
        }
        
        label_53:
        if(val_31 == null)
        {
            goto label_60;
        }
        
        val_31.丒丒丆丅业不下丞丄(专世专丟丝丌与丘上:  val_34);
        goto label_61;
        label_33:
        UnityEngine.Debug.Log(message:  "Not enough interactions to check rank");
        return 0;
        label_60:
        0.丒丒丆丅业不下丞丄(专世专丟丝丌与丘上:  val_34);
        label_61:
        val_31.下与丗七东丒丞丙丘();
        return 0;
    }
    internal int 丝上一七丝下丅丑丈(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_18;
        var val_19;
        丄世丕丈一丈东丆丐 val_20;
        object val_21;
        val_18 = 丂丛丑东不丅丈一东;
        val_19 = this;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  val_18)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_18)) == false)
        {
                return val_20.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_18 = ???);
        }
        
        }
        
        if((丛且丞与丕业下丏丞 != 1) && ((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_18, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞)) != null))
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  val_18, 丞丁丑丏丄丏七丂不:  丛且丞与丕业下丏丞);
            val_20 = val_4.丝三业丒万丛丝丁丅;
            val_21 = "Tier Map matchmaking";
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  val_18).Item[val_18];
            val_20 = val_6.丂丛丑东不丅丈一东;
            val_21 = "Tier Mode matchmaking";
        }
        
        UnityEngine.Debug.Log(message:  val_21);
        if(val_20 == null)
        {
                return val_20.丝丕丒丛丅丙丅下丄(丂丛丑东不丅丈一东:  val_18);
        }
        
        不七且丌丄丑世七丙[] val_7 = val_20.且丘丝丈业丞七丄丟();
        if((val_7.Length == 0) || (val_20 == null))
        {
                return val_20.丛丕丐丏丒一业专世(丈丘丝一丗下丈丐不:  ExperienceController.丞丞丘业东丙丏七丌());
        }
        
        int val_8 = ExperienceController.丞丞丘业东丙丏七丌();
        int val_9 = this.丏业世丄丒一丙专丟(丂丛丑东不丅丈一东:  val_18, 丛且丞与丕业下丏丞:  丛且丞与丕业下丏丞);
        val_19 = ???;
        goto typeof(丄世丕丈一丈东丆丐).__il2cppRuntimeField_168;
    }
    internal void 丟三丈一丟丙东不东(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丛且丞与丕业下丏丞, bool 三丑丘丟上丅下与一)
    {
        int val_21;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_22;
        var val_23;
        val_21 = 丛且丞与丕业下丏丞;
        val_22 = this.下业丙丈丝万丂丐东;
        if((val_22.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                val_22 = this.与丈七丕丙三丆上上;
            if((val_22.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return;
        }
        
        }
        
        if((val_21 != 1) && ((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  val_21)) != null))
        {
                丅三丒丒上丑丐上业 val_4 = this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  val_21);
            val_23 = 1152921505230008320;
            val_21 = val_4.丝三业丒万丛丝丁丅;
        }
        else
        {
                与与丌丑丑丞丗丐丂 val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东).Item[丂丛丑东不丅丈一东];
            val_23 = 1152921505230008320;
            val_21 = val_6.丂丛丑东不丅丈一东;
        }
        
        丁一业专丈三丄丘专 val_7 = 丁一业专丈三丄丘专.与一丅丝不丈业与丙();
        丑丄一丐丁丕世下丕 val_8 = 0.丁且丝丈下丄丒丛丞(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        if(val_21 == null)
        {
                return;
        }
        
        不七且丌丄丑世七丙[] val_9 = val_21.且丘丝丈业丞七丄丟();
        if(val_9.Length == 0)
        {
                return;
        }
        
        if(val_21 == null)
        {
                return;
        }
        
        不七且丌丄丑世七丙[] val_11 = val_21.且丘丝丈业丞七丄丟();
        不七且丌丄丑世七丙[] val_16 = val_21.且丘丝丈业丞七丄丟();
        val_8.丒丒丆丅业不下丞丄(专世专丟丝丌与丘上:  UnityEngine.Mathf.Clamp(value:  (UnityEngine.Mathf.Clamp(value:  val_8.丏专丆丞七东且丕丘(), min:  0, max:  UnityEngine.Mathf.Max(a:  0, b:  val_11.Length - 1))) + (((三丑丘丟上丅下与一 & true) != 0) ? (-1) : 1), min:  0, max:  UnityEngine.Mathf.Max(a:  0, b:  val_16.Length - 1)));
    }
    internal bool 丝专丙与丈丒丟丁丘(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_7;
        var val_8;
        val_6 = 丂丛丑东不丅丈一东;
        val_7 = this.下业丙丈丝万丂丐东;
        if((val_7.ContainsKey(key:  val_6)) == true)
        {
            goto label_2;
        }
        
        val_7 = this.与丈七丕丙三丆上上;
        if((val_7.ContainsKey(key:  val_6)) == false)
        {
            goto label_4;
        }
        
        label_2:
        val_6 = this.丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  val_6).Item[val_6];
        var val_5 = (val_4.万万三上一丞丕丙丁 == true) ? 1 : 0;
        return (bool)val_8;
        label_4:
        val_8 = 0;
        return (bool)val_8;
    }
    internal bool 专丒东万业业丈丝东(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_3;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 1;
        return (bool)val_3;
        label_4:
        val_3 = 0;
        return (bool)val_3;
    }
    internal bool 一专丁丁丁丁丗下丗(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丞丁丑丏丄丏七丂不)
    {
        return (bool)((this.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不)) != 0) ? 1 : 0;
    }
    internal bool 丕丕丙丐七丅丑丒万(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_3;
        var val_4;
        val_3 = 丂丛丑东不丅丈一东;
        if((this.与丈七丕丙三丆上上.ContainsKey(key:  val_3)) != false)
        {
                val_3 = this.与丈七丕丙三丆上上.Item[val_3];
            if(val_2.万万三上一丞丕丙丁 != false)
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal int 丞上上三丞东丁丝世(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丞丁丑丏丄丏七丂不)
    {
        if((this.丕丕丙丐七丅丑丒万(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.丟东专丅丑一丑丄丂(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不)) == false)
        {
            goto label_1;
        }
        
        }
        
        丐丟丙不丗万三丈丆 val_3 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(val_3 != null)
        {
                return val_3.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        }
        
        return val_3.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        label_1:
        丐丟丙不丗万三丈丆 val_4 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(val_4 != null)
        {
                return val_4.业丛东丕丘丁丗万世(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丛且丞与丕业下丏丞:  丞丁丑丏丄丏七丂不);
        }
        
        return val_4.业丛东丕丘丁丗万世(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丛且丞与丕业下丏丞:  丞丁丑丏丄丏七丂不);
    }
    internal bool 丟东专丅丑一丑丄丂(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丞丁丑丏丄丏七丂不)
    {
        var val_4;
        丅三丒丒上丑丐上业[] val_5;
        var val_6;
        val_4 = this;
        if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
            goto label_5;
        }
        
        val_4 = this.丌丛不丈丘丆且丘东(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
        与与丌丑丑丞丗丐丂 val_3 = val_4.Item[丂丛丑东不丅丈一东];
        val_5 = val_3.七丂专丞专丝万丒上;
        if(val_5 == null)
        {
            goto label_5;
        }
        
        val_4 = 0;
        goto label_6;
        label_20:
        var val_7 = 0;
        label_17:
        丅三丒丒上丑丐上业 val_4 = val_3.七丂专丞专丝万丒上[0];
        if(val_7 >= val_3.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上.Length)
        {
            goto label_11;
        }
        
        丅三丒丒上丑丐上业 val_5 = val_3.七丂专丞专丝万丒上[0];
        val_7 = val_7 + 1;
        if(val_3.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上[0] != 丞丁丑丏丄丏七丂不)
        {
            goto label_17;
        }
        
        goto label_18;
        label_11:
        val_5 = val_3.七丂专丞专丝万丒上;
        val_4 = 1;
        label_6:
        if(val_4 < val_3.七丂专丞专丝万丒上.Length)
        {
            goto label_20;
        }
        
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_18:
        val_6 = 1;
        return (bool)val_6;
    }
    internal 丅三丒丒上丑丐上业 丙丏三业万丕丕丅业(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 丞丁丑丏丄丏七丂不)
    {
        int val_5;
        var val_6;
        var val_7;
        丅三丒丒上丑丐上业[] val_8;
        丅三丒丒上丑丐上业 val_9;
        val_5 = 丞丁丑丏丄丏七丂不;
        val_6 = this;
        val_7 = 1152921538315715440;
        if((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
            goto label_7;
        }
        
        }
        
        val_6 = this.丌丛不丈丘丆且丘东(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  val_5);
        与与丌丑丑丞丗丐丂 val_4 = val_6.Item[丂丛丑东不丅丈一东];
        val_8 = val_4.七丂专丞专丝万丒上;
        if(val_8 == null)
        {
            goto label_7;
        }
        
        val_6 = 0;
        goto label_8;
        label_22:
        val_7 = 0;
        label_19:
        丅三丒丒上丑丐上业 val_5 = val_4.七丂专丞专丝万丒上[0];
        if(val_7 >= val_4.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上.Length)
        {
            goto label_13;
        }
        
        丅三丒丒上丑丐上业 val_6 = val_4.七丂专丞专丝万丒上[0];
        val_7 = val_7 + 1;
        if(val_4.七丂专丞专丝万丒上[0x0][0].七丂专丞专丝万丒上[0] != val_5)
        {
            goto label_19;
        }
        
        goto label_20;
        label_13:
        val_8 = val_4.七丂专丞专丝万丒上;
        val_6 = 1;
        label_8:
        if(val_6 < val_4.七丂专丞专丝万丒上.Length)
        {
            goto label_22;
        }
        
        label_7:
        val_9 = 0;
        return val_9;
        label_20:
        val_5 = val_4.七丂专丞专丝万丒上;
        val_9 = val_5[0];
        return val_9;
    }
    internal bool 专丂专且丁丈世丕世(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 与丐上丈与丑一丌丏)
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂> val_5;
        var val_6;
        丅三丒丒上丑丐上业[] val_7;
        var val_8;
        var val_9;
        丅三丒丒上丑丐上业[] val_10;
        val_5 = this;
        val_6 = 1152921538315715440;
        if(((this.下业丙丈丝万丂丐东.ContainsKey(key:  丂丛丑东不丅丈一东)) == false) || (this.下业丙丈丝万丂丐东.Item[丂丛丑东不丅丈一东] == null))
        {
            goto label_8;
        }
        
        val_7 = val_2.七丂专丞专丝万丒上;
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_8 = 0;
        goto label_6;
        label_12:
        val_7 = val_2.七丂专丞专丝万丒上;
        val_8 = 1;
        label_6:
        if(val_8 >= val_2.七丂专丞专丝万丒上.Length)
        {
            goto label_8;
        }
        
        val_7 = val_2.七丂专丞专丝万丒上[1];
        if(val_2.七丂专丞专丝万丒上[0x1][0].丞丅上丏丂且下丅与 != 与丐上丈与丑一丌丏)
        {
            goto label_12;
        }
        
        goto label_23;
        label_8:
        if((this.与丈七丕丙三丆上上.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
            goto label_18;
        }
        
        val_5 = this.与丈七丕丙三丆上上;
        if(val_5.Item[丂丛丑东不丅丈一东] == null)
        {
                return (bool)val_9;
        }
        
        val_10 = val_4.七丂专丞专丝万丒上;
        if(val_10 == null)
        {
            goto label_18;
        }
        
        val_5 = 0;
        goto label_19;
        label_25:
        val_6 = 0;
        丅三丒丒上丑丐上业 val_5 = val_4.七丂专丞专丝万丒上[val_6];
        if(val_4.七丂专丞专丝万丒上[0x0][0].丞丅上丏丂且下丅与 == 与丐上丈与丑一丌丏)
        {
            goto label_23;
        }
        
        val_10 = val_4.七丂专丞专丝万丒上;
        val_5 = 1;
        label_19:
        if(val_5 < val_4.七丂专丞专丝万丒上.Length)
        {
            goto label_25;
        }
        
        label_18:
        val_9 = 0;
        return (bool)val_9;
        label_23:
        val_9 = 1;
        return (bool)val_9;
    }
    public 丐丟丙不丗万三丈丆()
    {
        this.下业丙丈丝万丂丐东 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>();
        this.与丈七丕丙三丆上上 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 与与丌丑丑丞丗丐丂>();
    }

}

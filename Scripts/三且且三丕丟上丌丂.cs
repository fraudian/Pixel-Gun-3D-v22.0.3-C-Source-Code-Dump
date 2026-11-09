using UnityEngine;
internal class 三且且三丕丟上丌丂
{
    // Fields
    private float 丐丈丑东丛丐且世丅;
    private string 丞丅上丏丂且下丅与;
    private string 三丞业三丞世上丄丞;
    public int 与丕丌且丕丏丝丑专;
    private int 丙万丘丗丅万丐一世;
    
    // Properties
    public int 万万丘丙丗丈丘丙丁 { get; }
    public string 丘丞丆上万与丂丞丝 { get; }
    
    // Methods
    public 三且且三丕丟上丌丂(string 丏世丑万世一七丟丞, string 三丞业三丞世上丄丞, float 丐丈丑东丛丐且世丅, int 丙万丘丗丅万丐一世)
    {
        this.丞丅上丏丂且下丅与 = "";
        this.三丞业三丞世上丄丞 = "";
        val_1 = new System.Object();
        this.丞丅上丏丂且下丅与 = 丏世丑万世一七丟丞;
        this.三丞业三丞世上丄丞 = val_1;
        this.丐丈丑东丛丐且世丅 = 丐丈丑东丛丐且世丅;
        this.丙万丘丗丅万丐一世 = 丙万丘丗丅万丐一世;
    }
    public 三且且三丕丟上丌丂()
    {
        this.丞丅上丏丂且下丅与 = "";
        this.三丞业三丞世上丄丞 = "";
    }
    public int 丟丅丟丌丅丅下专丛()
    {
        return (int)this.丙万丘丗丅万丐一世;
    }
    public string 不东丏丕丐丗七七丈()
    {
        return (string)this.丞丅上丏丂且下丅与;
    }
    public float 万丕丘丌丐丆与丄丑()
    {
        return (float)this.丐丈丑东丛丐且世丅;
    }
    public Rilisoft.GameEventItemData 丒丅丙丄丞丟下丏业()
    {
        int val_24;
        var val_25;
        string val_26;
        string val_27;
        int val_28;
        var val_29;
        val_24 = this;
        val_25 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.三丞业三丞世上丄丞)) == true)
        {
                return (Rilisoft.GameEventItemData)val_25;
        }
        
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  this.三丞业三丞世上丄丞);
        if((0.ContainsKey(key:  "ItemId")) == false)
        {
            goto label_7;
        }
        
        object val_4 = 0.Item["ItemId"];
        if(val_4 == null)
        {
            goto label_9;
        }
        
        var val_5 = (null == null) ? (val_4) : 0;
        if(1 != 0)
        {
            goto label_45;
        }
        
        goto label_46;
        label_7:
        val_26 = "";
        if(1 == 0)
        {
            goto label_46;
        }
        
        label_45:
        label_46:
        if((0.ContainsKey(key:  "ItemType")) == false)
        {
            goto label_13;
        }
        
        object val_7 = 0.Item["ItemType"];
        if(val_7 == null)
        {
            goto label_15;
        }
        
        var val_8 = (null == null) ? (val_7) : 0;
        if(1 != 0)
        {
            goto label_47;
        }
        
        goto label_48;
        label_13:
        val_27 = "";
        if(1 == 0)
        {
            goto label_48;
        }
        
        label_47:
        label_48:
        if((0.ContainsKey(key:  "ItemSubType")) != false)
        {
                val_28 = System.Convert.ToInt32(value:  0.Item["ItemSubType"]);
        }
        else
        {
                val_28 = 0;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_27));
        if((0.ContainsKey(key:  "Count")) == false)
        {
            goto label_31;
        }
        
        val_29 = System.Convert.ToInt32(value:  0.Item["Count"]);
        if(1 != 0)
        {
            goto label_35;
        }
        
        goto label_37;
        label_31:
        val_29 = 0;
        if(1 == 0)
        {
            goto label_37;
        }
        
        label_35:
        label_37:
        if((0.ContainsKey(key:  "Sort")) != false)
        {
                val_24 = System.Convert.ToInt32(value:  0.Item["Sort"]);
        }
        else
        {
                val_24 = 0;
        }
        
        Rilisoft.GameEventItemData val_20 = null;
        val_25 = val_20;
        val_20 = new Rilisoft.GameEventItemData();
        PGCompany.三东丏不丗世丅丌丄 val_22 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  PGCompany.专丏丐丄丛丈丄丂丂.丈丏丆丛一丂丐丕丈(丁世万丟不丘不且丏:  1152921504628731904), 丞丅上丏丂且下丅与:  val_26, 丂丕丂丏专丂丄丕且:  0);
        if(val_25 != null)
        {
                .ItemParams = val_22;
            .SubType = val_28;
        }
        else
        {
                mem[40] = val_22;
            .SubType = val_28;
        }
        
        .ExtSort = val_24;
        return (Rilisoft.GameEventItemData)val_25;
        label_9:
        if(1 != 0)
        {
            goto label_45;
        }
        
        goto label_46;
        label_15:
        if(1 != 0)
        {
            goto label_47;
        }
        
        goto label_48;
    }
    public int 世丅丈丘丂与与丝专(三且且三丕丟上丌丂 丆上上业丌丒三丑丏)
    {
        if(丆上上业丌丒三丑丏 == null)
        {
                return 1;
        }
        
        return 1;
    }
    public bool 万一丅上东七七丆下(三且且三丕丟上丌丂 丘丛丏丘丝七世七丅)
    {
        if(丘丛丏丘丝七世七丅 == null)
        {
                return false;
        }
        
        if(this.丞丅上丏丂且下丅与 != null)
        {
                return this.丞丅上丏丂且下丅与.Equals(value:  丘丛丏丘丝七世七丅.丞丅上丏丂且下丅与);
        }
        
        return this.丞丅上丏丂且下丅与.Equals(value:  丘丛丏丘丝七世七丅.丞丅上丏丂且下丅与);
    }

}

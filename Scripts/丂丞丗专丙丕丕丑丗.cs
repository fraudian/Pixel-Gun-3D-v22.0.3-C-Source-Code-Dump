using UnityEngine;
public class 丂丞丗专丙丕丕丑丗
{
    // Fields
    private byte[] 与丕丟丑丂丟东丅东;
    private int 下丟丅丏丏丞东丁丆;
    private static 丒丞丕丕七丁丗丟丛<string> 丑下丅三万下丌丈丒;
    
    // Properties
    public bool 不丏丑世丏丆丒业丕 { get; }
    
    // Methods
    public 丂丞丗专丙丕丕丑丗(byte[] 丝丆丁丞丛三丁丑丙)
    {
        this.与丕丟丑丂丟东丅东 = 丝丆丁丞丛三丁丑丙;
    }
    public 丂丞丗专丙丕丕丑丗(UnityEngine.TextAsset 丄专丄丟七丅万不丅)
    {
        this.与丕丟丑丂丟东丅东 = 丄专丄丟七丅万不丅.bytes;
    }
    public static 丂丞丗专丙丕丕丑丗 丌万丗与七丄丕不丁(string 丛丄业丕且丗下一万)
    {
        System.IO.FileStream val_5 = System.IO.File.OpenRead(path:  丛丄业丕且丗下一万);
        if(val_5 == null)
        {
                return (丂丞丗专丙丕丕丑丗)val_5;
        }
        
        System.IO.FileStream val_2 = val_5 & 4294967295;
        val_5.Close();
        丂丞丗专丙丕丕丑丗 val_4 = null;
        val_5 = val_4;
        val_4 = new 丂丞丗专丙丕丕丑丗();
        .与丕丟丑丂丟东丅东 = new byte[0];
        return (丂丞丗专丙丕丕丑丗)val_5;
    }
    public bool 上且一丌丝丕上丞丒()
    {
        if(this.与丕丟丑丂丟东丅东 == null)
        {
                return false;
        }
        
        return (bool)(this.下丟丅丏丏丞东丁丆 < this.与丕丟丑丂丟东丅东.Length) ? 1 : 0;
    }
    private static string 业与不上丂丕万丙丘(byte[] 不不丒丝丌东与专丆, int 丄且一丄丏丆丐丗与, int 丌丒丝东丌下丕丁丅)
    {
        if(System.Text.Encoding.UTF8 == null)
        {
            
        }
    
    }
    public string 业与不上丂丕万丙丘()
    {
        return this.业与不上丂丕万丙丘(丐丌丐丌东三丝七丏:  true);
    }
    public string 业与不上丂丕万丙丘(bool 丐丌丐丌东三丝七丏)
    {
        System.Byte[] val_6;
        int val_7;
        int val_8;
        var val_9;
        val_6 = this.与丕丟丑丂丟东丅东;
        val_7 = this.与丕丟丑丂丟东丅东.Length;
        if((丐丌丐丌东三丝七丏 == false) || (this.下丟丅丏丏丞东丁丆 >= val_7))
        {
            goto label_6;
        }
        
        label_7:
        val_6 = this.与丕丟丑丂丟东丅东;
        if(val_6[(long)this.下丟丅丏丏丞东丁丆] >= 32)
        {
            goto label_6;
        }
        
        int val_1 = this.下丟丅丏丏丞东丁丆 + 1;
        this.下丟丅丏丏丞东丁丆 = val_1;
        if(val_1 < val_7)
        {
            goto label_7;
        }
        
        label_6:
        val_8 = this.下丟丅丏丏丞东丁丆;
        if(val_8 >= val_7)
        {
            goto label_8;
        }
        
        var val_6 = (long)val_8;
        var val_2 = val_6 + 32;
        label_13:
        val_6 = val_2 - 32;
        if(val_6 >= (long)val_7)
        {
            goto label_9;
        }
        
        val_8 = val_8 + 1;
        if(null == 13)
        {
            goto label_12;
        }
        
        val_2 = val_2 + 1;
        if(null != 10)
        {
            goto label_13;
        }
        
        label_12:
        val_8 = val_8 - 1;
        label_9:
        val_6 = this.与丕丟丑丂丟东丅东;
        val_7 = val_8 + 1;
        string val_4 = 丂丞丗专丙丕丕丑丗.业与不上丂丕万丙丘(不不丒丝丌东与专丆:  val_6, 丄且一丄丏丆丐丗与:  this.下丟丅丏丏丞东丁丆, 丌丒丝东丌下丕丁丅:  val_8 - this.下丟丅丏丏丞东丁丆);
        goto label_16;
        label_8:
        val_9 = 0;
        label_16:
        this.下丟丅丏丏丞东丁丆 = val_7;
        return (string)val_9;
    }
    public System.Collections.Generic.Dictionary<string, string> 丌不丛东丂丒与专丟()
    {
        string val_9;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        char[] val_2 = new char[1];
        val_2[0] = '=';
        if(this.与丕丟丑丂丟东丅东 == null)
        {
                return val_1;
        }
        
        do
        {
            if(this.下丟丅丏丏丞东丁丆 >= this.与丕丟丑丂丟东丅东.Length)
        {
                return val_1;
        }
        
            string val_3 = this.业与不上丂丕万丙丘(丐丌丐丌东三丝七丏:  true);
            if(val_3 == null)
        {
                return val_1;
        }
        
            if((val_3.StartsWith(value:  "//")) != true)
        {
                val_9 = val_3.Split(separator:  val_2, count:  2, options:  1);
            if(val_5.Length == 2)
        {
                val_9 = val_9[1].Trim().Replace(oldValue:  "\\n", newValue:  "\n");
            val_1.set_Item(key:  val_9[0].Trim(), value:  val_9);
        }
        
        }
        
        }
        while(this.与丕丟丑丂丟东丅东 != null);
        
        return val_1;
    }
    public 丒丞丕丕七丁丗丟丛<string> 丛一世丒下业且丞丟()
    {
        var val_25;
        var val_26;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_38;
        val_25 = null;
        val_25 = null;
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒.世业丒万丘丆专丘丐();
        val_26 = 0;
        val_27 = "";
        label_37:
        if((this.与丕丟丑丂丟东丅东 == null) || (this.下丟丅丏丏丞东丁丆 >= this.与丕丟丑丂丟东丅东.Length))
        {
            goto label_5;
        }
        
        if((0 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_1 = this.业与不上丂丕万丙丘(丐丌丐丌东三丝七丏:  false);
        if(val_1 == null)
        {
                return (丒丞丕丕七丁丗丟丛<System.String>)丂丞丗专丙丕丕丑丗.__il2cppRuntimeField_static_fields;
        }
        
        val_27 = val_27 + "\n" + val_1.Replace(oldValue:  "\\n", newValue:  "\n")(val_1.Replace(oldValue:  "\\n", newValue:  "\n"));
        val_29 = val_26;
        if(val_27 != null)
        {
            goto label_11;
        }
        
        goto label_9;
        label_6:
        string val_4 = this.业与不上丂丕万丙丘(丐丌丐丌东三丝七丏:  true);
        if(val_4 == null)
        {
                return (丒丞丕丕七丁丗丟丛<System.String>)丂丞丗专丙丕丕丑丗.__il2cppRuntimeField_static_fields;
        }
        
        val_27 = val_4.Replace(oldValue:  "\\n", newValue:  "\n");
        val_29 = 0;
        if(val_27 != null)
        {
            goto label_11;
        }
        
        label_9:
        label_11:
        int val_6 = val_27.Length;
        val_26 = val_29;
        val_30 = 0;
        goto label_12;
        label_35:
        char val_8 = val_6.Chars[0] & 65535;
        if(val_8 == '"')
        {
            goto label_13;
        }
        
        if(val_8 != ',')
        {
            goto label_27;
        }
        
        if((val_30 & 1) == 0)
        {
            goto label_15;
        }
        
        val_30 = 1;
        goto label_27;
        label_13:
        if((val_30 & 1) == 0)
        {
            goto label_17;
        }
        
        if(1 >= val_6)
        {
            goto label_18;
        }
        
        if((val_27.Chars[1] & 65535) != '"')
        {
            goto label_20;
        }
        
        val_30 = 1;
        val_31 = 1;
        goto label_27;
        label_15:
        val_32 = null;
        val_32 = null;
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_27.Substring(startIndex:  0, length:  0));
        val_30 = 0;
        val_26 = 1;
        goto label_27;
        label_17:
        val_30 = 1;
        val_26 = 1;
        goto label_27;
        label_20:
        val_33 = null;
        val_33 = null;
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_27.Substring(startIndex:  0, length:  0).Replace(oldValue:  "\"\"", newValue:  "\""));
        char val_15 = val_27.Chars[1] & 65535;
        val_30 = 0;
        int val_17 = (val_15 == ',') ? 2 : (val_26);
        label_27:
        val_29 = ((val_15 == ',') ? 1 : (val_29)) + 1;
        label_12:
        if(val_29 < val_6)
        {
            goto label_35;
        }
        
        if(val_17 >= val_27.Length)
        {
            goto label_36;
        }
        
        if((val_30 & 1) != 0)
        {
            goto label_37;
        }
        
        val_34 = null;
        val_34 = null;
        if(val_27 == null)
        {
            goto label_40;
        }
        
        val_35 = val_27.Length;
        goto label_41;
        label_18:
        val_36 = null;
        val_36 = null;
        val_27 = val_27.Substring(startIndex:  0, length:  0).Replace(oldValue:  "\"\"", newValue:  "\"");
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_27);
        return (丒丞丕丕七丁丗丟丛<System.String>)丂丞丗专丙丕丕丑丗.__il2cppRuntimeField_static_fields;
        label_5:
        val_28 = 0;
        return (丒丞丕丕七丁丗丟丛<System.String>)丂丞丗专丙丕丕丑丗.__il2cppRuntimeField_static_fields;
        label_40:
        val_35 = 0.Length;
        label_41:
        val_27 = val_27.Substring(startIndex:  val_17, length:  val_35 - val_17);
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_27);
        label_36:
        val_38 = null;
        val_38 = null;
        return (丒丞丕丕七丁丗丟丛<System.String>)丂丞丗专丙丕丕丑丗.__il2cppRuntimeField_static_fields;
    }
    private static 丂丞丗专丙丕丕丑丗()
    {
        丂丞丗专丙丕丕丑丗.丑下丅三万下丌丈丒 = new 丒丞丕丕七丁丗丟丛<System.String>();
    }

}

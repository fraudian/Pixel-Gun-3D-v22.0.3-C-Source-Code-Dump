using UnityEngine;
internal abstract class 三且丛下丛丝丐专世
{
    // Fields
    private 丟丏丕丝不丗且三三 七东下丅丙世与丐丒;
    private bool 东上下与与丅专上下;
    private 丟丏丕丝不丗且三三 <丂万丌丏上七丞丒丄>k__BackingField;
    private string <三丈七万丟三世丅不>k__BackingField;
    
    // Properties
    internal abstract string 丂丛丗世丈上丑丟丄 { get; }
    private string 丂丘且世丙丈丛三丁 { get; }
    internal 丟丏丕丝不丗且三三 七与东丙专丕丏丅丛 { get; set; }
    internal string 丒丈丒七七七丛丅世 { get; set; }
    internal string 丞与业丝丟丒与丞专 { get; }
    
    // Methods
    internal abstract string 丂丗丐丗丝七丙丐丛(); // 0
    private string 万丕且丅丕丑丄丟专()
    {
        return System.String.Format(format:  "{0}_{1}_key", arg0:  this, arg1:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().业一丆万丂且不上世());
    }
    internal 丟丏丕丝不丗且三三 与丄丞业不下世丄上()
    {
        return (丟丏丕丝不丗且三三)this.<丂万丌丏上七丞丒丄>k__BackingField;
    }
    internal void 专丅丟专且丘丏与七(丟丏丕丝不丗且三三 丙业与丙丗丝不丈东)
    {
        this.<丂万丌丏上七丞丒丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丆丈不业丂与丕丝且()
    {
        return (string)this.<三丈七万丟三世丅不>k__BackingField;
    }
    internal void 丁万丐丗丈丞七丑专(string 丙业与丙丗丝不丈东)
    {
        this.<三丈七万丟三世丅不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 东丌业丕丙丕七丆丁()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)this.<三丈七万丟三世丅不>k__BackingField(this.<三丈七万丟三世丅不>k__BackingField) + "_" + this.<丂万丌丏上七丞丒丄>k__BackingField.ToString()(this.<丂万丌丏上七丞丒丄>k__BackingField.ToString());
    }
    internal void 丛不丄与丅丘丙丁与(System.Collections.Generic.Dictionary<string, object> 丞东丈丐丛丏丕丗丅)
    {
        var val_7;
        string val_53;
        丟丏丕丝不丗且三三 val_54;
        object val_55;
        var val_56;
        object val_57;
        string val_58;
        object val_59;
        var val_60;
        var val_61;
        var val_62;
        string val_63;
        string val_64;
        var val_65;
        string val_67;
        var val_68;
        var val_69;
        object val_13 = 0;
        object val_18 = 0;
        object val_35 = 0;
        if(丞东丈丐丛丏丕丗丅 == null)
        {
                return;
        }
        
        object val_1 = 0;
        val_53 = this;
        bool val_2 = 丞东丈丐丛丏丕丗丅.TryGetValue(key:  this, value: out  val_1);
        if(val_1 == 0)
        {
                return;
        }
        
        var val_3 = (((mem[282584257676871] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
        return;
        label_40:
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        if(((System.String.op_Equality(a:  val_8._value._obj.丐丏七丌丕丗业且上(), b:  "currentStateIsB")) == true) || ((System.String.op_Equality(a:  val_8._value._obj.丐丏七丌丕丗业且上(), b:  "SettingsB")) == true))
        {
            goto label_37;
        }
        
        if((0.TryGetValue(key:  "minLevelPlayers", value: out  val_13)) != false)
        {
                val_55 = val_13;
            val_55 = val_55;
            val_56 = (~(System.Int32.TryParse(s:  System.Convert.ToString(value:  val_55), result: out  0))) & 1;
        }
        else
        {
                val_56 = 1;
        }
        
        if((0.TryGetValue(key:  "maxLevelPlayers", value: out  val_18)) != false)
        {
                val_57 = val_18;
            val_57 = val_57;
            bool val_22 = System.Int32.TryParse(s:  System.Convert.ToString(value:  val_57), result: out  65);
        }
        
        if(val_56 == 0)
        {
            goto label_23;
        }
        
        if((this.<丂万丌丏上七丞丒丄>k__BackingField) != 0)
        {
            goto label_37;
        }
        
        val_58 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_58 = val_58;
        bool val_24 = 丑丝丞丒丅丄万丒三.世丐世丂丗丆丙下丟(丞丅上丏丂且下丅与:  val_58, 不上下丂丙丙丅丏丟:  false);
        if((this.<丂万丌丏上七丞丒丄>k__BackingField) != 0)
        {
            goto label_37;
        }
        
        label_23:
        if(ExperienceController.丞丞丘业东丙丏七丌() < 0)
        {
            goto label_37;
        }
        
        var val_27 = (ExperienceController.丞丞丘业东丙丏七丌() > 65) ? 1 : 0;
        val_27 = 1 | val_27;
        if((val_27 & 1) != 0)
        {
            goto label_37;
        }
        
        val_59 = 0.Item["enableABTest"];
        val_59 = val_59;
        if((System.Convert.ToInt32(value:  val_59)) != 1)
        {
            goto label_37;
        }
        
        goto label_38;
        label_37:
        if((1515557728 & 1) != 0)
        {
            goto label_40;
        }
        
        val_60 = 0;
        label_71:
        val_53 = public System.Void Dictionary.Enumerator<System.String, System.Object>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_60 != 0)
        {
            goto label_41;
        }
        
        val_54 = this.<丂万丌丏上七丞丒丄>k__BackingField;
        if(val_54 != 0)
        {
            goto label_42;
        }
        
        goto label_43;
        label_42:
         =  - 1;
        if( > 1)
        {
            goto label_55;
        }
        
        label_43:
        if((this.<三丈七万丟三世丅不>k__BackingField) == null)
        {
            goto label_47;
        }
        
        val_53 = this.<三丈七万丟三世丅不>k__BackingField;
        if((val_3.TryGetValue(key:  val_53, value: out  null)) == false)
        {
            goto label_47;
        }
        
        if( != 0)
        {
                val_61 = null;
            val_61 = null;
            var val_32 = (((mem[282584257676871] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_61) ? () : 0;
        }
        
        val_53 = 0;
        if((System.Convert.ToInt32(value:  0.Item["enableABTest"])) != 0)
        {
            goto label_55;
        }
        
        label_47:
        label_55:
        if(((this.<丂万丌丏上七丞丒丄>k__BackingField) != 2) || ( == 0))
        {
            goto label_57;
        }
        
        val_62 = null;
        val_62 = null;
        goto label_61;
        label_57:
        val_63 = "currentStateIsB";
        if((val_3.TryGetValue(key:  val_63, value: out  val_35)) == false)
        {
                return;
        }
        
        val_63 = 0;
        if((System.Convert.ToBoolean(value:  val_35)) == false)
        {
                return;
        }
        
        val_64 = "SettingsB";
        val_65 = public System.Boolean System.Collections.Generic.Dictionary<System.String, System.Object>::TryGetValue(System.String key, out System.Object value);
        goto label_68;
        label_61:
        val_64 = "SettingsB";
        val_65 = public System.Boolean System.Collections.Generic.Dictionary<System.String, System.Object>::TryGetValue(System.String key, out System.Object value);
        label_68:
        bool val_40 = TryGetValue(key:  val_64, value: out  0);
        return;
        label_38:
        string val_41 = val_8._value._obj.丐丏七丌丕丗业且上();
        goto label_71;
        label_41:
        if((val_60.ContainsKey(key:  "probabilityB")) != false)
        {
                val_67 = val_41;
            val_68 = System.Convert.ToInt32(value:  val_60.Item["probabilityB"]);
        }
        else
        {
                val_67 = val_41;
            val_68 = 50;
        }
        
        int val_45 = UnityEngine.Random.Range(min:  1, max:  101);
        this.<三丈七万丟三世丅不>k__BackingField = val_67;
        this.<丂万丌丏上七丞丒丄>k__BackingField = (val_45 <= 50) ? (1 + 1) : 1;
        object val_47 = 0;
        if(val_45 > 50)
        {
            
        }
        else
        {
                bool val_48 = val_60.TryGetValue(key:  "SettingsB", value: out  val_47);
            val_69 = val_47;
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丌丙丛丛丆东丙丁丛(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七与东丙专丕丏丅丛:  this.<丂万丌丏上七丞丒丄>k__BackingField, 丏世丐丄东丂丛下世:  this, 丞与业丝丟丒与丞专:  this.东丌业丕丙丕七丆丁(), 丗万不丁且上与丏万:  this.<三丈七万丟三世丅不>k__BackingField);
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
    }
    protected virtual void 下世丙丐上专业下丒(object 万丆丕丁丆丒丂七下)
    {
    
    }
    protected virtual void 丂与丗专上业丏丗万()
    {
    
    }
    internal virtual void 不丌一专下丈世丒下()
    {
        if((this.<丂万丌丏上七丞丒丄>k__BackingField) != 3)
        {
                this.<丂万丌丏上七丞丒丄>k__BackingField = 3;
        }
    
    }
    protected 三且丛下丛丝丐专世()
    {
    
    }

}

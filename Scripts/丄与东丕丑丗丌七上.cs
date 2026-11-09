using UnityEngine;
internal sealed class 丄与东丕丑丗丌七上
{
    // Fields
    private static 丄与东丕丑丗丌七上 丝业丆丁业三丈丟东;
    private System.Collections.Generic.Dictionary<string, 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅> 丒丄丅丟丞丅丄七丕;
    private System.EventHandler 丅上丞丆万丑不丒丌;
    
    // Properties
    internal static 丄与东丕丑丗丌七上 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static 丄与东丕丑丗丌七上 丑七不且上丗丁一世()
    {
        丄与东丕丑丗丌七上 val_2 = 丄与东丕丑丗丌七上.丝业丆丁业三丈丟东;
        if(val_2 != null)
        {
                return val_2;
        }
        
        丄与东丕丑丗丌七上 val_1 = null;
        val_2 = val_1;
        val_1 = new 丄与东丕丑丗丌七上();
        丄与东丕丑丗丌七上.丝业丆丁业三丈丟东 = val_2;
        return val_2;
    }
    internal void 三丂一且下丝丏上丆(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅上丞丆万丑不丒丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅上丞丆万丑不丒丌 != 1152921540106707336);
    
    }
    internal void 万丆丈东万业丗下丁(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅上丞丆万丑不丒丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅上丞丆万丑不丒丌 != 1152921540106843912);
    
    }
    internal 丄与东丕丑丗丌七上()
    {
        this.丒丄丅丟丞丅丄七丕 = new System.Collections.Generic.Dictionary<System.String, 丗一丂丈丅三丌东丅>();
        this.且丛一三业丈丝丞丅();
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void 丄与东丕丑丗丌七上::丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
    }
    internal 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅 丐下下丅与上东丙丑(string 丈丟且丐上不世专丁)
    {
        丗一丂丈丅三丌东丅 val_1 = 0;
        return (丗一丂丈丅三丌东丅)((this.丒丄丅丟丞丅丄七丕.TryGetValue(key:  丈丟且丐上不世专丁, value: out  val_1)) != true) ? (val_1) : 0;
    }
    private void 丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 65)
        {
                return;
        }
        
        this.且丛一三业丈丝丞丅();
    }
    private void 且丛一三业丈丝丞丅()
    {
        var val_9;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        int val_80;
        var val_81;
        var val_82;
        val_74 = this;
        string val_57 = 0;
        this.丒丄丅丟丞丅丄七丕.Clear();
        PGCompany.丒丒丛丙不万专三丆 val_73 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_73.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  65));
        if(val_3 == null)
        {
                return;
        }
        
        val_73 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_73, 下上丐丆丝丟丝丒不:  "building_settings", 丙业与丙丗丝不丈东: out  0)) == false)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_6 = val_4.GetEnumerator();
        label_104:
        if((1140884976 & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
        val_75 = 0;
        new 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅() = new System.Object();
        .<上七东下丏不丕丐丑>k__BackingField = val_10._value._obj.丐丏七丌丕丗业且上();
        System.Collections.Generic.List<System.Single> val_14 = new System.Collections.Generic.List<System.Single>();
        .<丅七丏东业上丐丑丒>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "hl", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_17;
        }
        
        val_76 = 0;
        goto label_18;
        label_24:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<丅七丏东业上丐丑丒>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_15.Item[0]));
        val_76 = 1;
        label_18:
        if(val_76 < val_15.Count)
        {
            goto label_24;
        }
        
        label_17:
        System.Collections.Generic.List<System.Single> val_20 = new System.Collections.Generic.List<System.Single>();
        .<丄丏与与业丆丟丑下>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "dl", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_27;
        }
        
        val_77 = 0;
        goto label_28;
        label_34:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<丄丏与与业丆丟丑下>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_21.Item[0]));
        val_77 = 1;
        label_28:
        if(val_77 < val_21.Count)
        {
            goto label_34;
        }
        
        label_27:
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "rd", 丙业与丙丗丝不丈东: out  float val_26 = 514.0906f)) != false)
        {
                .<丌专下丝丈丐丁东与>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "ds", 丙业与丙丗丝不丈东: out  float val_28 = 514.0903f)) != false)
        {
                .<丒丐丌丄丙业丟丕三>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  float val_30 = 514.0901f)) != false)
        {
                .<下且东丙业丑与丕丆>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  float val_32 = 514.0898f)) != false)
        {
                .<丛丝丛丕万丒一丏丄>k__BackingField = 0f;
        }
        
        System.Collections.Generic.List<System.Single> val_34 = new System.Collections.Generic.List<System.Single>();
        .<七七丗一丙上丛丐丗>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "trhl", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_49;
        }
        
        val_78 = 0;
        goto label_50;
        label_56:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<七七丗一丙上丛丐丗>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_35.Item[0]));
        val_78 = 1;
        label_50:
        if(val_78 < val_35.Count)
        {
            goto label_56;
        }
        
        label_49:
        System.Collections.Generic.List<System.Single> val_40 = new System.Collections.Generic.List<System.Single>();
        .<丁丅丕丄丘七丈丏不>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "trdal", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_59;
        }
        
        val_79 = 0;
        goto label_60;
        label_66:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<丁丅丕丄丘七丈丏不>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_41.Item[0]));
        val_79 = 1;
        label_60:
        if(val_79 < val_41.Count)
        {
            goto label_66;
        }
        
        label_59:
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "trde", 丙业与丙丗丝不丈东: out  float val_46 = 514.0886f)) != false)
        {
                .<东三丒不专上一丘丘>k__BackingField = 0f;
        }
        
        .<丙丁丁丙丂世丐七业>k__BackingField = ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "sr", 丙业与丙丗丝不丈东: out  float val_48 = 514.0884f)) != true) ? 0f : -1f;
        .<万丟且三丏丒丁业丏>k__BackingField = ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "et", 丙业与丙丗丝不丈东: out  float val_51 = 514.0881f)) != true) ? 0f : -1f;
        .<丑丁丆与三万丙与丕>k__BackingField = ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "ir", 丙业与丙丗丝不丈东: out  float val_54 = 514.0879f)) != true) ? 0f : -1f;
        bool val_58 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "etp", 丙业与丙丗丝不丈东: out  val_57);
        val_80 = val_57;
        if(val_80 == 0)
        {
                val_80 = System.String.alignConst;
        }
        
        .<丕丒世三丞丈丏丒丝>k__BackingField = val_80;
        System.Collections.Generic.List<System.Single> val_59 = new System.Collections.Generic.List<System.Single>();
        .<丐七一丐丅丄丙丁丅>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "edbl", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_81;
        }
        
        val_81 = 0;
        goto label_82;
        label_88:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<丐七一丐丅丄丙丁丅>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_60.Item[0]));
        val_81 = 1;
        label_82:
        if(val_81 < val_60.Count)
        {
            goto label_88;
        }
        
        label_81:
        System.Collections.Generic.List<System.Single> val_65 = new System.Collections.Generic.List<System.Single>();
        .<丝丘丂丒上丄丌丙丙>k__BackingField = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "dps", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_91;
        }
        
        val_82 = 0;
        goto label_92;
        label_98:
        (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<丝丘丂丒上丄丌丙丙>k__BackingField.Add(item:  System.Convert.ToSingle(value:  val_66.Item[0]));
        val_82 = 1;
        label_92:
        if(val_82 < val_66.Count)
        {
            goto label_98;
        }
        
        label_91:
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "an", 丙业与丙丗丝不丈东: out  0)) != false)
        {
            
        }
        
        .<专丛丅七丐丟万且专>k__BackingField = System.String.__il2cppRuntimeField_static_fields;
        this.丒丄丅丟丞丅丄七丕.set_Item(key:  (丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅)[1152921540107530864].<上七东下丏不丕丐丑>k__BackingField, value:  new 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅());
        goto label_104;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}

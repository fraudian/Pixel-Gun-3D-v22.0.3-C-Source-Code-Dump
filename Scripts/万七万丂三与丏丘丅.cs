using UnityEngine;
internal sealed class 万七万丂三与丏丘丅
{
    // Fields
    private static 万七万丂三与丏丘丅 丝业丆丁业三丈丟东;
    private System.Collections.Generic.Dictionary<string, 万七万丂三与丏丘丅.丈丝丞下丙七与丙丟> 丒丄丅丟丞丅丄七丕;
    private System.EventHandler 丅上丞丆万丑不丒丌;
    
    // Properties
    internal static 万七万丂三与丏丘丅 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static 万七万丂三与丏丘丅 丑七不且上丗丁一世()
    {
        万七万丂三与丏丘丅 val_2 = 万七万丂三与丏丘丅.丝业丆丁业三丈丟东;
        if(val_2 != null)
        {
                return val_2;
        }
        
        万七万丂三与丏丘丅 val_1 = null;
        val_2 = val_1;
        val_1 = new 万七万丂三与丏丘丅();
        万七万丂三与丏丘丅.丝业丆丁业三丈丟东 = val_2;
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
        while(this.丅上丞丆万丑不丒丌 != 1152921540111900936);
    
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
        while(this.丅上丞丆万丑不丒丌 != 1152921540112037512);
    
    }
    internal 万七万丂三与丏丘丅()
    {
        this.丒丄丅丟丞丅丄七丕 = new System.Collections.Generic.Dictionary<System.String, 丈丝丞下丙七与丙丟>();
        this.且丛一三业丈丝丞丅();
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void 万七万丂三与丏丘丅::丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
    }
    internal 万七万丂三与丏丘丅.丈丝丞下丙七与丙丟 丐下下丅与上东丙丑(string 三丒丈七东下丌丝丗)
    {
        丈丝丞下丙七与丙丟 val_2 = 0;
        return (丈丝丞下丙七与丙丟)((this.丒丄丅丟丞丅丄七丕.TryGetValue(key:  三丒丈七东下丌丝丗.ToLower(), value: out  val_2)) != true) ? (val_2) : 0;
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
        var val_34;
        var val_35;
        val_34 = this;
        this.丒丄丅丟丞丅丄七丕.Clear();
        PGCompany.丒丒丛丙不万专三丆 val_33 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_33.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  65));
        if(val_3 == null)
        {
                return;
        }
        
        val_33 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_33, 下上丐丆丝丟丝丒不:  "mob_settings", 丙业与丙丗丝不丈东: out  0)) == false)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_6 = val_4.GetEnumerator();
        label_40:
        if((1146020576 & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
        val_35;
        new 万七万丂三与丏丘丅.丈丝丞下丙七与丙丟() = new System.Object();
        .<上七东下丏不丕丐丑>k__BackingField = "Enemy" + val_10._value._obj.丐丏七丌丕丗业且上() + "_go";
        if(val_10._value._obj != 0)
        {
                val_35 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "hp", 丙业与丙丗丝不丈东: out  float val_15 = 827.5437f)) != false)
        {
                .<不丌丞下丞丝业丙专>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "dpsP", 丙业与丙丗丝不丈东: out  float val_17 = 827.5435f)) != false)
        {
                .<丘丈丕丈丆丕丌与且>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "dpsT", 丙业与丙丗丝不丈东: out  float val_19 = 827.5432f)) != false)
        {
                .<上一业一不下丆且丟>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "rs", 丙业与丙丗丝不丈东: out  float val_21 = 827.543f)) != false)
        {
                .<丁下丕一丅丝三丏业>k__BackingField = 0f;
        }
        
        .<丗丈世七七丗丙万丒>k__BackingField = ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "sc", 丙业与丙丗丝不丈东: out  float val_23 = 827.5427f)) != true) ? 0f : 1f;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "tz", 丙业与丙丗丝不丈东: out  float val_26 = 827.5425f)) != false)
        {
                .<丄丌丕业业专丞三丘>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "ntd", 丙业与丙丗丝不丈东: out  float val_28 = 827.5422f)) != false)
        {
                .<丘丂丄不丑丘丕丄丁>k__BackingField = 0f;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Single>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "sr", 丙业与丙丗丝不丈东: out  float val_30 = 827.542f)) != false)
        {
                .<丙丁丁丙丂世丐七业>k__BackingField = 0f;
        }
        
        this.丒丄丅丟丞丅丄七丕.set_Item(key:  (万七万丂三与丏丘丅.丈丝丞下丙七与丙丟)[1152921540112666464].<上七东下丏不丕丐丑>k__BackingField.ToLower(), value:  new 万七万丂三与丏丘丅.丈丝丞下丙七与丙丟());
        goto label_40;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}

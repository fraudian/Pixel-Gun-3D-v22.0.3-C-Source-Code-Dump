using UnityEngine;
internal class 丙下且专一丒丂专七
{
    // Fields
    internal int 丆万一不丌且东丐丐;
    internal Rilisoft.丝丑丂丛万丐丈丘且 丕丗专且丆丂丌丕丒;
    internal System.Collections.Generic.Dictionary<int, Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject> 丑一丈丅丆丂丙丙丐;
    
    // Methods
    internal System.Collections.Generic.Dictionary<string, object> 丗丟丝丗丟专且丂业()
    {
        System.Collections.Generic.Dictionary<System.Int32, ChestProgressDataObject> val_8;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "s", value:  this.丕丗专且丆丂丌丕丒);
        val_1.Add(key:  "t", value:  this.丆万一不丌且东丐丐);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_8 = this.丑一丈丅丆丂丙丙丐;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_8.GetEnumerator();
        label_7:
        if(((-44911176) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        val_2.Add(key:  val_4._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  val_4._value._obj.七丕且七丙丌丄七丘());
        goto label_7;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_1.Add(key:  "p", value:  val_2);
        return val_1;
    }
    internal static 丙下且专一丒丂专七 丌七丒七丕上丐三七(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_16;
        var val_17;
        var val_18;
        丙下且专一丒丂专七 val_1 = new 丙下且专一丒丂专七();
        bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  0);
        int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        if(val_1 != null)
        {
                val_16 = 0;
        }
        else
        {
                val_16 = 1;
        }
        
        .丕丗专且丆丂丌丕丒 = 0;
        mem[1152921538921888704] = 0;
        bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  (丙下且专一丒丂专七)[1152921538921888672].丆万一不丌且东丐丐);
        if((丏丂万业丙专丏丒丒.ContainsKey(key:  "p")) == false)
        {
                return val_1;
        }
        
        object val_8 = 丏丂万业丙专丏丒丒.Item["p"];
        if(val_8 != null)
        {
                val_17 = null;
            val_17 = null;
            var val_9 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_17) ? (val_8) : 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_10 = 0.GetEnumerator();
        label_19:
        if(((-44744912) & 1) == 0)
        {
            goto label_14;
        }
        
        ConfiguredValueTaskAwaiter val_11 = 0.GetAwaiter();
        if(val_11._value._obj != 0)
        {
                val_18 = 0;
        }
        
        (丙下且专一丒丂专七)[1152921538921888672].丑一丈丅丆丂丙丙丐.Add(key:  System.Int32.Parse(s:  val_11._value._obj.丐丏七丌丕丗业且上()), value:  上专业三丟丁丞专下.ChestProgressDataObject.丌七丒七丕上丐三七(丏丂万业丙专丏丒丒:  null));
        goto label_19;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal static System.Collections.Generic.Dictionary<string, object> 东丈一丙一下丗下与(System.Collections.Generic.Dictionary<int, 丙下且专一丒丂专七> 上丏丗东丆丏丛丞丅)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        Dictionary.Enumerator<TKey, TValue> val_2 = 上丏丗东丆丏丛丞丅.GetEnumerator();
        label_5:
        if(((-44585784) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        val_1.Add(key:  val_3._value._obj.丙东专丂世丈丏丁丂().ToString(), value:  val_3._value._obj.丗丟丝丗丟专且丂业());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal static System.Collections.Generic.Dictionary<int, 丙下且专一丒丂专七> 丅丏下丛世七上丑丏(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_8;
        System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_1 = new System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七>();
        if(丏丂万业丙专丏丒丒 == null)
        {
                return val_1;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = 丏丂万业丙专丏丒丒.GetEnumerator();
        label_7:
        if(((-44438984) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        if(val_3._value._obj != 0)
        {
                val_8 = 0;
        }
        
        val_1.Add(key:  System.Int32.Parse(s:  val_3._value._obj.丐丏七丌丕丗业且上()), value:  丙下且专一丒丂专七.丌七丒七丕上丐三七(丏丂万业丙专丏丒丒:  null));
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public 丙下且专一丒丂专七()
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丕丗专且丆丂丌丕丒 = 0;
        mem[1152921538922292032] = 0;
        this.丑一丈丅丆丂丙丙丐 = new System.Collections.Generic.Dictionary<System.Int32, ChestProgressDataObject>();
    }

}

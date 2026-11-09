using UnityEngine;
[Serializable]
private class 三一丈七且丄与丝东.KnownChestsContainer : ISerializationCallbackReceiver
{
    // Fields
    private System.Collections.Generic.List<int> _keys;
    private System.Collections.Generic.List<string> _values;
    public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> Events;
    
    // Methods
    public void OnAfterDeserialize()
    {
        System.Collections.Generic.List<System.Int32> val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Func<System.String, System.Int32> val_15;
        val_10 = this._keys;
        this.Events = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32>>();
        if(val_10 == null)
        {
                return;
        }
        
        if(this._values == null)
        {
                return;
        }
        
        val_11 = 1152921516995557280;
        val_12 = 0;
        goto label_3;
        label_16:
        char[] val_4 = new char[1];
        val_4[0] = ':';
        val_13 = null;
        val_13 = null;
        val_15 = 三一丈七且丄与丝东.KnownChestsContainer.<>c.<>9__3_0;
        if(val_15 == null)
        {
                System.Func<System.String, System.Int32> val_6 = null;
            val_15 = val_6;
            val_6 = new System.Func<System.String, System.Int32>(object:  三一丈七且丄与丝东.KnownChestsContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 三一丈七且丄与丝东.KnownChestsContainer.<>c::丛不与丛东业丏一三(string 东七上世万下丗丄丛));
            三一丈七且丄与丝东.KnownChestsContainer.<>c.<>9__3_0 = val_15;
            val_11 = 1152921516995557280;
        }
        
        this.Events.Add(key:  this._keys.Item[0], value:  System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.String, System.Int32>(source:  this._values.Item[0].Split(separator:  val_4), selector:  val_6)));
        val_10 = this._keys;
        val_12 = 1;
        label_3:
        if(val_12 < val_10.Count)
        {
            goto label_16;
        }
    
    }
    public void OnBeforeSerialize()
    {
        var val_6;
        var val_14;
        var val_15;
        var val_16;
        System.Func<System.Int32, System.String> val_18;
        val_14 = this;
        this._keys = new System.Collections.Generic.List<System.Int32>();
        this._values = new System.Collections.Generic.List<System.String>();
        if(this.Events == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = this.Events.GetEnumerator();
        val_15 = 1152921525678534064;
        label_10:
        if(((-321893248) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        this._keys.Add(item:  val_7._value._obj.丙东专丂世丈丏丁丂());
        val_16 = null;
        val_16 = null;
        val_18 = 三一丈七且丄与丝东.KnownChestsContainer.<>c.<>9__4_0;
        if(val_18 == null)
        {
                val_18 = null;
            val_18 = new System.Func<System.Int32, System.String>(object:  三一丈七且丄与丝东.KnownChestsContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.String 三一丈七且丄与丝东.KnownChestsContainer.<>c::丄丅丙丘丌丏东丏丗(int 七丞丙丒三丕且丌丟));
            val_15 = val_15;
            三一丈七且丄与丝东.KnownChestsContainer.<>c.<>9__4_0 = val_18;
        }
        
        this._values.Add(item:  System.String.Join(separator:  ":", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  val_7._value._obj, selector:  null))));
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public 三一丈七且丄与丝东.KnownChestsContainer()
    {
    
    }

}

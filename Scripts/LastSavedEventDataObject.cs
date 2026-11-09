using UnityEngine;
[Serializable]
private class 三一丈七且丄与丝东.LastSavedEventDataObject : ISerializationCallbackReceiver
{
    // Fields
    private System.Collections.Generic.List<int> _keys;
    private System.Collections.Generic.List<string> _values;
    public System.Collections.Generic.Dictionary<int, string> Events;
    
    // Methods
    public void OnAfterDeserialize()
    {
        System.Collections.Generic.List<System.Int32> val_5;
        var val_6;
        val_5 = this._keys;
        this.Events = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
        if((val_5 == null) || (this._values == null))
        {
            goto label_2;
        }
        
        val_6 = 0;
        goto label_3;
        label_8:
        this.Events.Add(key:  this._keys.Item[0], value:  this._values.Item[0]);
        val_5 = this._keys;
        val_6 = 1;
        label_3:
        if(val_6 < val_5.Count)
        {
            goto label_8;
        }
        
        label_2:
        this._keys = 0;
        this._values = 0;
    }
    public void OnBeforeSerialize()
    {
        if(this.Events == null)
        {
                return;
        }
        
        this._keys = new System.Collections.Generic.List<System.Int32>();
        this._values = new System.Collections.Generic.List<System.String>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.Events.GetEnumerator();
        label_6:
        if(((-320924920) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        this._keys.Add(item:  val_4._value._obj.丙东专丂世丈丏丁丂());
        this._values.Add(item:  val_4._value._obj);
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public 三一丈七且丄与丝东.LastSavedEventDataObject()
    {
    
    }

}

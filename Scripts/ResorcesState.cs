using UnityEngine;
[Serializable]
internal class 东丂七丁上世丈丁丏.ResorcesState : ISerializationCallbackReceiver
{
    // Fields
    internal System.Collections.Generic.Dictionary<string, string> Resources;
    private System.Collections.Generic.List<string> _keys;
    private System.Collections.Generic.List<string> _values;
    
    // Methods
    internal 东丂七丁上世丈丁丏.ResorcesState()
    {
        this.Resources = new System.Collections.Generic.Dictionary<System.String, System.String>();
    }
    public void OnBeforeSerialize()
    {
        var val_7;
        System.Collections.Generic.Dictionary<System.String, System.String> val_8;
        val_7 = this;
        if(this._keys != null)
        {
                this._keys.Clear();
        }
        else
        {
                this._keys = new System.Collections.Generic.List<System.String>();
        }
        
        if(this._values != null)
        {
                this._values.Clear();
        }
        else
        {
                this._values = new System.Collections.Generic.List<System.String>();
        }
        
        val_8 = this.Resources;
        if(val_8 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.Resources = val_8;
            if(val_8 == null)
        {
                return;
        }
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = val_3.GetEnumerator();
        label_10:
        if(((-809269416) & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        this._keys.Add(item:  val_5._value._obj.丐丏七丌丕丗业且上());
        this._values.Add(item:  val_5._value._obj);
        goto label_10;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void OnAfterDeserialize()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_5;
        System.Collections.Generic.List<System.String> val_6;
        var val_7;
        val_5 = this.Resources;
        if(val_5 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.Resources = val_5;
        }
        
        val_1.Clear();
        val_6 = this._keys;
        if(val_6 == null)
        {
                return;
        }
        
        val_7 = 0;
        goto label_4;
        label_9:
        this.Resources.Add(key:  val_6.Item[0], value:  this._values.Item[0]);
        val_6 = this._keys;
        val_7 = 1;
        label_4:
        if(val_7 < val_6.Count)
        {
            goto label_9;
        }
        
        this._keys.Clear();
        this._values.Clear();
    }

}

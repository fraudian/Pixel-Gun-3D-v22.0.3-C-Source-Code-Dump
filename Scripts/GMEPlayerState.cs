using UnityEngine;
[Serializable]
internal class 丈专丂丁丁东丌丁丅.GMEPlayerState : ISerializationCallbackReceiver
{
    // Fields
    private System.Collections.Generic.List<int> _keys;
    private System.Collections.Generic.List<PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState> _values;
    private System.Collections.Generic.Dictionary<int, PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState> <EventsState>k__BackingField;
    
    // Properties
    internal System.Collections.Generic.Dictionary<int, PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState> EventsState { get; set; }
    
    // Methods
    internal System.Collections.Generic.Dictionary<int, PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState> get_EventsState()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState>)this.<EventsState>k__BackingField;
    }
    private void set_EventsState(System.Collections.Generic.Dictionary<int, PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState> 丙业与丙丗丝不丈东)
    {
        this.<EventsState>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丈专丂丁丁东丌丁丅.GMEPlayerState()
    {
        this.<EventsState>k__BackingField = new System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState>();
    }
    public void OnBeforeSerialize()
    {
        var val_7;
        System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState> val_8;
        val_7 = this;
        if(this._keys != null)
        {
                this._keys.Clear();
        }
        else
        {
                this._keys = new System.Collections.Generic.List<System.Int32>();
        }
        
        if(this._values != null)
        {
                this._values.Clear();
        }
        else
        {
                this._values = new System.Collections.Generic.List<GMEEventPlayerState>();
        }
        
        val_8 = this.<EventsState>k__BackingField;
        if(val_8 == null)
        {
                System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState>();
            this.<EventsState>k__BackingField = val_8;
            if(val_8 == null)
        {
                return;
        }
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = val_3.GetEnumerator();
        label_10:
        if(((-761929064) & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        this._keys.Add(item:  val_5._value._obj.丙东专丂世丈丏丁丂());
        this._values.Add(item:  val_5._value._obj);
        goto label_10;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void OnAfterDeserialize()
    {
        System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState> val_5;
        System.Collections.Generic.List<System.Int32> val_6;
        var val_7;
        val_5 = this.<EventsState>k__BackingField;
        if(val_5 == null)
        {
                System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.Int32, GMEEventPlayerState>();
            this.<EventsState>k__BackingField = val_5;
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
        this.<EventsState>k__BackingField.Add(key:  val_6.Item[0], value:  this._values.Item[0]);
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
    internal void 业丏丗丐丂业东丂丗(int 丛下丙三丆丏万东丅, PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState 丞东丏三丌万丝丆丄)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }

}

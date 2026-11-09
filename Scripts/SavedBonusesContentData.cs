using UnityEngine;
[Serializable]
public class BalanceController.SavedBonusesContentData : ISerializationCallbackReceiver
{
    // Fields
    public System.Collections.Generic.Dictionary<string, BalanceController.SavedBonusesContentData.ValueObject> Bonuses;
    private System.Collections.Generic.List<string> _keys;
    private System.Collections.Generic.List<BalanceController.SavedBonusesContentData.ValueObject> _values;
    
    // Methods
    public void OnAfterDeserialize()
    {
        var val_7;
        System.Collections.Generic.Dictionary<System.String, ValueObject> val_1 = new System.Collections.Generic.Dictionary<System.String, ValueObject>();
        this.Bonuses = val_1;
        val_7 = 0;
        goto label_1;
        label_9:
        if(this._values.Count > val_7)
        {
                ValueObject val_4 = this._values.Item[0];
            this.Bonuses.Add(key:  val_1.Item[0], value:  this._values.Item[0]);
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < this._keys.Count)
        {
            goto label_9;
        }
        
        this._keys.Clear();
        this._values.Clear();
    }
    public void OnBeforeSerialize()
    {
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
                this._values = new System.Collections.Generic.List<ValueObject>();
        }
        
        if(this.Bonuses == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = this.Bonuses.GetEnumerator();
        label_9:
        if(((-1575203384) & 1) == 0)
        {
            goto label_6;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        this._keys.Add(item:  val_4._value._obj.丐丏七丌丕丗业且上());
        this._values.Add(item:  val_4._value._obj);
        goto label_9;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public BalanceController.SavedBonusesContentData()
    {
    
    }

}

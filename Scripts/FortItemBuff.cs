using UnityEngine;
[Serializable]
public class 丞东丌丟与丅丅万丝.FortItemBuff
{
    // Fields
    private string _lkey;
    public 丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 BuffType;
    public float Value;
    
    // Properties
    public string LKey { get; }
    
    // Methods
    public string get_LKey()
    {
        if(this._lkey != null)
        {
                return (string);
        }
        
        丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 val_1 = this.BuffType;
        val_1 = val_1 - 7;
        if(val_1 <= 5)
        {
                var val_2 = 106019456;
            val_2 = (106019456 + ((this.BuffType - 7)) << 2) + val_2;
        }
        else
        {
                this._lkey = ;
            return (string);
        }
    
    }
    public 丞东丌丟与丅丅万丝.FortItemBuff()
    {
    
    }

}

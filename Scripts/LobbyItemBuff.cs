using UnityEngine;
[Serializable]
public class 丕专丟上与丄丈三丏.LobbyItemBuff
{
    // Fields
    private string _lkey;
    public 丕专丟上与丄丈三丏.万东丙丛丅业丝世三 BuffType;
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
        
        丕专丟上与丄丈三丏.万东丙丛丅业丝世三 val_1 = this.BuffType;
        val_1 = val_1 - 7;
        if(val_1 <= 5)
        {
                var val_2 = 106014484;
            val_2 = (106014484 + ((this.BuffType - 7)) << 2) + val_2;
        }
        else
        {
                this._lkey = ;
            return (string);
        }
    
    }
    public 丕专丟上与丄丈三丏.LobbyItemBuff()
    {
    
    }

}

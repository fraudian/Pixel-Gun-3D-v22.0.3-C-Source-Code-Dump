using UnityEngine;
public class KeybordHolder : MonoBehaviour
{
    // Fields
    public KeybordShow _tk;
    
    // Methods
    private void OnClick()
    {
        if(this._tk != null)
        {
            goto label_0;
        }
        
        this._tk = this._tk;
        if(this._tk == null)
        {
            goto label_1;
        }
        
        label_0:
        bool val_1 = this._tk.mKeybordHold;
        val_1 = val_1 ^ 1;
        this._tk.mKeybordHold = val_1;
        return;
        label_1:
    }
    public KeybordHolder()
    {
    
    }

}

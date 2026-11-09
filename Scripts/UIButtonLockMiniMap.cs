using UnityEngine;
public class UIButtonLockMiniMap : MonoBehaviour
{
    // Fields
    public bool toggle;
    
    // Methods
    private void OnClick()
    {
        if((UnityEngine.Object.op_Implicit(exists:  UIMiniMap.instance)) == false)
        {
                return;
        }
        
        bool val_4 = this.toggle;
        val_4 = val_4 ^ 1;
        this.toggle = val_4;
        this = UIMiniMap.instance;
        mem2[0] = this.toggle;
    }
    public UIButtonLockMiniMap()
    {
    
    }

}

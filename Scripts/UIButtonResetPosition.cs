using UnityEngine;
public class UIButtonResetPosition : MonoBehaviour
{
    // Fields
    public bool isMinimap;
    
    // Methods
    private void OnClick()
    {
        UnityEngine.Object val_7;
        if(this.isMinimap != false)
        {
                val_7 = UIMiniMap.instance;
            if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
        {
                return;
        }
        
            UIMiniMap val_3 = UIMiniMap.instance;
        }
        else
        {
                val_7 = UIWorldMap.instance;
            if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
        {
                return;
        }
        
        }
        
        UIWorldMap.instance.ResetPanning();
    }
    public UIButtonResetPosition()
    {
        this.isMinimap = true;
    }

}

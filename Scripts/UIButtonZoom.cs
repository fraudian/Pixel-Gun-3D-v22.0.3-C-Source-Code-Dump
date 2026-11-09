using UnityEngine;
public class UIButtonZoom : MonoBehaviour
{
    // Fields
    public bool zoomIn;
    public bool isMinimap;
    public float amount;
    
    // Methods
    private void OnClick()
    {
        bool val_7;
        float val_8;
        var val_9;
        if(this.isMinimap == false)
        {
            goto label_1;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  UIMiniMap.instance)) == false)
        {
                return;
        }
        
        val_7 = this.zoomIn;
        val_8 = this.amount;
        val_9 = UIMiniMap.instance;
        if(val_9 == null)
        {
            goto label_10;
        }
        
        if(val_7 == false)
        {
            goto label_13;
        }
        
        label_12:
        val_9.ZoomIn(丛丁三世世丆七不业:  val_8);
        return;
        label_1:
        if((UnityEngine.Object.op_Implicit(exists:  UIWorldMap.instance)) == false)
        {
                return;
        }
        
        val_7 = this.zoomIn;
        val_8 = this.amount;
        val_9 = UIWorldMap.instance;
        if(val_9 == null)
        {
            goto label_10;
        }
        
        if(val_7 == true)
        {
            goto label_12;
        }
        
        label_13:
        val_9.ZoomOut(丛丁三世世丆七不业:  val_8);
        return;
        label_10:
        if(val_7 == true)
        {
            goto label_12;
        }
        
        goto label_13;
    }
    public UIButtonZoom()
    {
        this.isMinimap = true;
        this.amount = 0.5f;
    }

}

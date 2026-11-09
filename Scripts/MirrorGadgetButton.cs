using UnityEngine;
public class MirrorGadgetButton : MonoBehaviour
{
    // Fields
    public UIAnchor targetUiAnchor;
    
    // Methods
    private void Update()
    {
        float val_3;
        float val_4;
        float val_5;
        UnityEngine.Transform val_1 = this.transform;
        if(this.targetUiAnchor.side != 6)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        val_3 = val_2.x;
        val_4 = val_2.y;
        val_5 = val_2.z;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_2:
        val_3 = 0f;
        val_4 = 0f;
        val_5 = 0f;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_1.localScale = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5};
    }
    public MirrorGadgetButton()
    {
    
    }

}

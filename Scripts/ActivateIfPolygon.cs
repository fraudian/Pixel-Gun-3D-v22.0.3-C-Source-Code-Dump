using UnityEngine;
internal class ActivateIfPolygon : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        var val_4;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
            goto label_3;
        }
        
        val_4 = mem[PolygonController.一下一万丄丅丘且丑 + 24];
        val_4 = PolygonController.一下一万丄丅丘且丑 + 24;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        val_4 = 0;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_1.SetActive(value:  (val_4 != 0) ? 1 : 0);
    }
    public ActivateIfPolygon()
    {
    
    }

}

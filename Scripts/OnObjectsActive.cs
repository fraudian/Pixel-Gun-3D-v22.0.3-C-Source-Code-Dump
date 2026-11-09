using UnityEngine;
public class OnObjectsActive : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] objects;
    private int 三不七丝业丌丆丕丈;
    public UnityEngine.MonoBehaviour objectToEnable;
    
    // Methods
    private void Update()
    {
        this.三不七丝业丌丆丕丈 = this.objects.Length;
        goto label_1;
        label_6:
        int val_2 = ((this.objects[0].activeInHierarchy & true) != 0) ? (-1) : 1;
        val_2 = val_2 + this.三不七丝业丌丆丕丈;
        0 = 1;
        this.三不七丝业丌丆丕丈 = val_2;
        label_1:
        if(0 < this.objects.Length)
        {
            goto label_6;
        }
        
        this.objectToEnable.enabled = (this.三不七丝业丌丆丕丈 > 0) ? 1 : 0;
    }
    public OnObjectsActive()
    {
    
    }

}

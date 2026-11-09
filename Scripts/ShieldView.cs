using UnityEngine;
public class ShieldView : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform shieldPoint;
    
    // Methods
    private void Awake()
    {
        goto label_1;
        label_5:
        this.GetComponentsInChildren<UnityEngine.TrailRenderer>()[0].Clear();
        0 = 1;
        label_1:
        if(0 < val_1.Length)
        {
            goto label_5;
        }
    
    }
    public ShieldView()
    {
    
    }

}

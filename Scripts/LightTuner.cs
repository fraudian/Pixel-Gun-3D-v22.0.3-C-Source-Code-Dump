using UnityEngine;
public class LightTuner : MonoBehaviour
{
    // Fields
    public UnityEngine.Light[] lighters;
    public float value;
    public bool apply;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        var val_3;
        float val_5;
        float val_6;
        if(this.apply == false)
        {
                return;
        }
        
        val_3 = 0;
        goto label_1;
        label_6:
        UnityEngine.Light val_3 = this.lighters[0];
        if(val_3 != null)
        {
                val_5 = this.value;
            val_6 = val_3.intensity;
        }
        else
        {
                float val_2 = 0.intensity;
            val_5 = this.value;
            val_6 = val_2;
        }
        
        val_2 = val_5 * val_6;
        val_3.intensity = val_2;
        val_3 = 1;
        label_1:
        if(val_3 < this.lighters.Length)
        {
            goto label_6;
        }
        
        this.apply = false;
    }
    public LightTuner()
    {
    
    }

}
